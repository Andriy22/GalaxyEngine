using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.FrontCategory.CreateCommand
{
    public class CreateFrontCategoryCommand : IRequest<string>
    {
        public string Name { get; set; }
    }
}
