using Application.Commands.FrontComponentProp.CreateCommand;
using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CreateFrontComponentPropDto : IMapWith<CreateFrontComponentPropCommand>
    {
        public string Title { get; set; }
        public bool CanBeHidden { get; set; }
        public Guid BaseComponentId { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateFrontComponentPropDto, CreateFrontComponentPropCommand>()
                   .ForMember(option => option.CanBeHidden, dest => dest.MapFrom(src => src.CanBeHidden))
                   .ForMember(option => option.BaseComponentId, dest => dest.MapFrom(src => src.BaseComponentId))
                   .ForMember(option => option.Title, dest => dest.MapFrom(src => src.Title));
        }
    }
}
