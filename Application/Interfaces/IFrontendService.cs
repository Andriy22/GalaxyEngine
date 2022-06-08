using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFrontendService
    {
        public Task<Guid> CreatePage(CreateFrontPageDto model);
        public Task<Guid> CreateBaseComponent(CreateFrontBaseComponentDto model);
    }
}
