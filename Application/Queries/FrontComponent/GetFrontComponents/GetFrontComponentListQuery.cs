using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.FrontComponent.GetFrontComponents
{
    public class GetFrontComponentListQuery : IRequest<GetFrontComponentListVm>
    {
        public string Route { get; set; }
    }
}
