using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.FrontComponentProp
{
    public class GetFrontComponentPropListQuery : IRequest<GetFrontComponentPropListVm>
    {
        public Guid BaseComponentId { get; set; }
    }
}
