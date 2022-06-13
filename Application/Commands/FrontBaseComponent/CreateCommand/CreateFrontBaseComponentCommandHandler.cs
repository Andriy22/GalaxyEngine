using Application.Common.Exceptions;
using Application.Interfaces;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.FrontBaseComponent.CreateCommand
{
    public class CreateFrontBaseComponentCommandHandler : IRequestHandler<CreateFrontBaseComponentCommand, string>
    {

        private readonly IDBContext _dbContext;

        public CreateFrontBaseComponentCommandHandler(IDBContext dbContext) =>
                _dbContext = dbContext;

        public async Task<string> Handle(CreateFrontBaseComponentCommand request,
            CancellationToken cancellationToken)
        {
            if (_dbContext.FrontBaseComponents.FirstOrDefault(x => x.Name.ToLower() ==
                                                              request.Name.ToLower()) != null)
            {
                throw new AlreadyExistsException("FrontBaseComponent", request.Name);
            }

            var entity = new Domain.FrontBaseComponent
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                NormalizedName = request.Name.ToString()
            };

            _dbContext.FrontBaseComponents.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}