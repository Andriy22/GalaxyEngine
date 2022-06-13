using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.FrontComponentProp.CreateCommand
{
    public class CreateFrontComponentPropCommandHandler : IRequestHandler<CreateFrontComponentPropCommand, string>
    {
        private readonly IDBContext _dbContext;

        public CreateFrontComponentPropCommandHandler(IDBContext dbContext) =>
            _dbContext = dbContext;

        public async Task<string> Handle(CreateFrontComponentPropCommand request,
            CancellationToken cancellationToken)
        {
            var entity = new Domain.FrontComponentProp
            {
                BaseComponentId = request.BaseComponentId,
                Id = Guid.NewGuid().ToString(),
                Title = request.Title,
                CanBeHidden = request.CanBeHidden,
            };

            _dbContext.FrontComponentProps.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }

    }
}
