using MediatR;
using System;

namespace Application.Demo.Queries.GetDemos
{
    public class GetDemoListQuery : IRequest<DemoListVM>
    {
        public string UserID { get; set; }
    }
}
