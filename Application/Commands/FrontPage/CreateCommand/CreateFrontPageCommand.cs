using MediatR;
using System;

namespace Application.Commands.FrontPage.CreateCommand
{
    public class CreateFrontPageCommand : IRequest<string>
    {
        public string Name { get; set; }
        public string Route { get; set; }
        public string CategoryId { get; set; }
    }
}
