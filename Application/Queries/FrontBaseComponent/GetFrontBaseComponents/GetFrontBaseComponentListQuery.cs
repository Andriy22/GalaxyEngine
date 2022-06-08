using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.FrontBaseComponent.GetFrontBaseComponents
{
    public class GetFrontBaseComponentListQuery : IRequest<FrontBaseComponentListVm>
    {
    }
}
