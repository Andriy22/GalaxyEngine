using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.FrontPropValue
{
    public class GetFrontPropValueDto : IMapWith<Domain.FrontPropValue>
    {
        public Guid Id { get; set; }
        public string Value { get; set; }
        public string Key { get; set; }
        public bool IsHidden { get; set; }
        public string Align { get; set; }
        public string Type { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.FrontPropValue, GetFrontPropValueDto>()
              .ForMember(option => option.Id,
                  opt => opt.MapFrom(front => front.Id))
              .ForMember(option => option.Value,
                  opt => opt.MapFrom(front => front.Value))
              .ForMember(option => option.Key,
                  opt => opt.MapFrom(front => front.Prop.Title))
              .ForMember(option => option.IsHidden,
                  opt => opt.MapFrom(front => front.IsHidden))
              .ForMember(option => option.Align,
                  opt => opt.MapFrom(front => front.Align))
              .ForMember(option => option.Type,
                  opt => opt.MapFrom(front => front.Type));
        }
    }
}
