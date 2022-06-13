using MediatR;
using System;

namespace Application.Commands.FrontPropValue.CreateCommand
{
    public class CreateFrontPropValueCommand : IRequest<string>
    {
        public string ComponentId { get; set; }
        public string PropId { get; set; }
        public string Value { get; set; }
    }
}
