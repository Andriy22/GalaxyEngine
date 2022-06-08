using Application.Commands.FrontBaseComponent.CreateCommand;
using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CreateFrontBaseComponentDto : IMapWith<CreateFrontBaseComponentCommand>
    {
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateFrontBaseComponentDto, CreateFrontBaseComponentCommand>()
                   .ForMember(option => option.Name, dest => dest.MapFrom(src => src.Name));
        }
    }
}
