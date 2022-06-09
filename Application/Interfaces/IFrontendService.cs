using Application.Models;
using Application.Models.FrontModels.DTOs;
using Application.Models.FrontModels.VMs;
using Application.Queries.FrontBaseComponent.GetFrontBaseComponents;
using Application.Queries.FrontComponent.GetFrontComponents;
using Application.Queries.FrontComponentProp;
using Application.Queries.FrontPage.GetFrontPages;
using Application.Queries.FrontPropValue.GetFrontPropValueByComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IFrontendService
    {
        public Task<GetFrontComponentPropListVm> GetFrontComponentPropList(GetFrontComponentPropsDto model);
        public Task<GetFrontPageListVm> GetFrontPages();
        public Task<FrontBaseComponentListVm> GetBaseComponents();
        public Task<GetFrontComponentListVm> GetComponents(Models.FrontModels.DTOs.GetFrontComponentListDto model);
        public Task<List<FrontComponentTypeWithProps>> GetComponentsTypeWithProps(Models.FrontModels.DTOs.GetFrontComponentListDto model);
        public Task<GetFrontPropValueListVm> GetComponentPropValues(GetFrontPropValuesDto model);

        public Task<Guid> CreatePage(CreateFrontPageDto model);
        public Task<Guid> CreateBaseComponent(CreateFrontBaseComponentDto model);
        public Task<Guid> AddPropToComponent(CreateFrontComponentPropDto model);
        public Task<Guid> CreateComponent(CreateFrontComponentDto model);
        public Task<Guid> AddValueToProp(CreateFrontPropValueDto model);
        public void UpdateValueToProp(UpdateFrontPropValueDto model);
    }
}
