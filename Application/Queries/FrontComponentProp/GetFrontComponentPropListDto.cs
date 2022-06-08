﻿using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.FrontComponentProp
{
    public class GetFrontComponentPropListDto : IMapWith<Domain.FrontComponentProp>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Domain.FrontComponentProp, GetFrontComponentPropListDto>()
                   .ForMember(option => option.Id,
                              opt => opt.MapFrom(front => front.Id))
                   .ForMember(option => option.Title,
                              opt => opt.MapFrom(front => front.Title));
        }

    }
}
