using MediatR;
using System;

namespace Application.Commands.FrontBaseComponent.CreateCommand
{
    public class CreateFrontBaseComponentCommand : IRequest<string>
    {
        public string Name { get; set; }
    }
}
