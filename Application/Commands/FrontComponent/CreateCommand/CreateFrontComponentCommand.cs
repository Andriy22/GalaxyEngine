using MediatR;
using System;

namespace Application.Commands.FrontComponent.CreateCommand
{
    public class CreateFrontComponentCommand : IRequest<string>
    {
        public string BaseComponentId { get; set; }
        public string PageId { get; set; }
        public int DispayIndex { get; set; }
    }
}
