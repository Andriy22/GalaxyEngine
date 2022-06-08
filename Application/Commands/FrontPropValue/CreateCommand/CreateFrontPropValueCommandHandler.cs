using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.FrontPropValue.CreateCommand
{
    internal class CreateFrontPropValueCommandHandler : IRequestHandler<CreateFrontPropValueCommand, Guid>
    {
        private readonly IDBContext _dbContext;

        public CreateFrontPropValueCommandHandler(IDBContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Guid> Handle(CreateFrontPropValueCommand request,
            CancellationToken cancellationToken)
        {
            var entity = new Domain.FrontPropValue
            {
                ComponentId = request.ComponentId,
                PropId = request.PropId,
                Value = request.Value
            };

            _dbContext.FrontPropValues.Add(entity);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }

}
