using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontPropValue.UpdateCommand
{
    public class UpdateFrontPropValueCommand : IRequest<Unit>
    {
        public Guid PropValueID { get; set; }
        public string Value { get; set; }
    }
}
