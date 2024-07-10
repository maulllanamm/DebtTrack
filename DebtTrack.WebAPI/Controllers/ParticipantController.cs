using DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;
using DebtTrack.Application.Features.ParticipantFeatures.Command;
using DebtTrack.Application.Helper.Interface;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DebtTrack.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ParticipantController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICacheHelper _cacheHelper;

        public ParticipantController(IMediator mediator, ICacheHelper cacheHelper)
        {
            _mediator = mediator;
            _cacheHelper = cacheHelper;
        }
        
        [HttpGet]
        public async Task<ActionResult<CreateParticipantResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllParticipantRequest(), cancellationToken);
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<ActionResult<CreateParticipantResponse>> GetById(int participantId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetByIdParticipantRequest(participantId), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateParticipantResponse>> Create(CreateParticipantRequest request,
           CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
        
        [HttpPut]
        public async Task<ActionResult<CreateParticipantResponse>> Update(UpdateParticipantRequest request,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

       
    }
}