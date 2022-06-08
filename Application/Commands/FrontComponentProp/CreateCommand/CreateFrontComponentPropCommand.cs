using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontComponentProp.CreateCommand
{
    public class CreateFrontComponentPropCommand : IRequest<Guid>
    {
        public int FrontBaseComponentId { get; set; }
        public string Title { get; set; }
        public Guid BaseComponentId { get; set; }
    }
}
