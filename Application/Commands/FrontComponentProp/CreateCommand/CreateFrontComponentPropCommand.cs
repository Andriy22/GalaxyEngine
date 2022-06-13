using MediatR;
using System;

namespace Application.Commands.FrontComponentProp.CreateCommand
{
    public class CreateFrontComponentPropCommand : IRequest<string>
    {
        public string Title { get; set; }
        public bool CanBeHidden { get; set; }
        public string Type { get; set; }
        public string BaseComponentId { get; set; }
    }
}
