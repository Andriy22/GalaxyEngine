using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontPage.CreateCommand
{
    public class CreateFrontPageCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public string Route { get; set; }
    }
}
