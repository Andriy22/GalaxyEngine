using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.FrontComponent.CreateCommand
{
    internal class CreateFrontComponentCommandHandler : IRequestHandler<CreateFrontComponentCommand, string>
    {
        private readonly IDBContext _dbContext;

        public CreateFrontComponentCommandHandler(IDBContext dbContext) =>
            _dbContext = dbContext;

        public async Task<string> Handle(CreateFrontComponentCommand request,
            CancellationToken cancellationToken)
        {
            var entity = new Domain.FrontComponent
            {
                BaseComponentId = request.BaseComponentId,
                PageId = request.PageId,
                Id = Guid.NewGuid().ToString(),
                DisplayIndex = request.DispayIndex
            };

            _dbContext.FrontComponents.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
