using Application.Common.Exceptions;
using Application.Interfaces;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.FrontPage.CreateCommand
{
    internal class CreateFrontPageCommandHandler : IRequestHandler<CreateFrontPageCommand, string>
    {
        private readonly IDBContext _dbContext;

        public CreateFrontPageCommandHandler(IDBContext dbContext) =>
            _dbContext = dbContext;

        public async Task<string> Handle(CreateFrontPageCommand request,
            CancellationToken cancellationToken)
        {
            if (_dbContext.FrontPages.FirstOrDefault(x => x.Name.ToLower() == request.Name.ToLower() || request.Route.ToLower() == x.Route.ToLower()) != null)
            {
                throw new AlreadyExistsException("FrontPage", request.Name);
            }

            var entity = new Domain.FrontPage
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                Route = request.Route,
                CategoryId = request.CategoryId,
            };

            _dbContext.FrontPages.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
