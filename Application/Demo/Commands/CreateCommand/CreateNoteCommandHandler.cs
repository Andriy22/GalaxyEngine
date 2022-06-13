using Application.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Demo.Commands.CreateCommand
{
    public class CreateDemoCommandHandler
          : IRequestHandler<CreateDemoCommand, string>
    {
        private readonly IDBContext _dbContext;

        public CreateDemoCommandHandler(IDBContext dbContext) =>
            _dbContext = dbContext;

        public async Task<string> Handle(CreateDemoCommand request,
            CancellationToken cancellationToken)
        {

            var demo = new Domain.Demo
            {
                Id = Guid.NewGuid().ToString(),
                Title = request.Title,
            };

            await _dbContext.Demos.AddAsync(demo, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return demo.Id;
        }
    }
}