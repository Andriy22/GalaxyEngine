using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontPage.UpdateCommand
{
    public class UpdateFrontPageCommand : IRequest<Unit>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string CategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
