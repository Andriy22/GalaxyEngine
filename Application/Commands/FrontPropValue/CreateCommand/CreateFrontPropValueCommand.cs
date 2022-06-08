using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontPropValue.CreateCommand
{
    public class CreateFrontPropValueCommand : IRequest<Guid>
    {
        public Guid ComponentId { get; set; }
        public Guid PropId { get; set; }
        public string Value { get; set; }
    }
}
