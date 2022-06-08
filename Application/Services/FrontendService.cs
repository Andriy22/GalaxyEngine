using Application.Commands.FrontBaseComponent.CreateCommand;
using Application.Commands.FrontPage.CreateCommand;
using Application.Interfaces;
using Application.Models;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FrontendService : IFrontendService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public FrontendService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<Guid> CreateBaseComponent(CreateFrontBaseComponentDto model)
        {
            var command = _mapper.Map<CreateFrontBaseComponentCommand>(model);

            return await _mediator.Send(command);
        }

        public async Task<Guid> CreatePage(CreateFrontPageDto model)
        {
            var command = _mapper.Map<CreateFrontPageCommand>(model);

            return await _mediator.Send(command);
        }
    }
}
