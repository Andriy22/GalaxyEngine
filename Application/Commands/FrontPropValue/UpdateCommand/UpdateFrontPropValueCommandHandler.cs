using Application.Common.Exceptions;
using Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.FrontPropValue.UpdateCommand
{
    public class UpdateFrontPropValueCommandHandler : IRequestHandler<UpdateFrontPropValueCommand, Unit>
    {
        private readonly IDBContext _dbContext;

        public UpdateFrontPropValueCommandHandler(IDBContext dbContext) =>
            _dbContext = dbContext;

        public async Task<Unit> Handle(UpdateFrontPropValueCommand request,
            CancellationToken cancellationToken)
        {

            var entity = await _dbContext.FrontPropValues.FirstOrDefaultAsync(x => x.Id == request.PropValueID, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException("FrontPropValue", entity.Id);
            }

            entity.Value = request.Value;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }

}
