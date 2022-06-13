using MediatR;
using System;

namespace Application.Queries.FrontComponentProp
{
    public class GetFrontComponentPropListQuery : IRequest<GetFrontComponentPropListVm>
    {
        public string BaseComponentId { get; set; }
    }
}
