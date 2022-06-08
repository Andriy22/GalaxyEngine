using MediatR;
using System;

namespace Application.Commands.FrontComponentProp.CreateCommand
{
    public class CreateFrontComponentPropCommand : IRequest<Guid>
    {
        public int FrontBaseComponentId { get; set; }
        public string Title { get; set; }
        public Guid BaseComponentId { get; set; }
    }
}
