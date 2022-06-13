using MediatR;
using System;

namespace Application.Demo.Commands.CreateCommand
{
    public class CreateDemoCommand : IRequest<string>
    {
        public string Title { get; set; }
        public string UserId { get; set; }
    }
}
