using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontComponent.CreateCommand
{
    public class CreateFrontComponentCommand : IRequest<Guid>
    {
        public Guid BaseComponentId { get; set; }
        public Guid PageId { get; set; }
        public int DispayIndex { get; set; }
    }
}
