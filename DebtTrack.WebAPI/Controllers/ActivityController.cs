using DebtTrack.Application.Features.ActivityFeatures.Command;
using DebtTrack.Application.Helper.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DebtTrack.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ActivityController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICacheHelper _cacheHelper;

        public ActivityController(IMediator mediator, ICacheHelper cacheHelper)
        {
            _mediator = mediator;
            _cacheHelper = cacheHelper;
        }
        
        [HttpGet]
        public async Task<ActionResult<GetByIdActivityResponse>> GetById(int participantId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetByIdActivityRequest(participantId), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateActivityResponse>> Create(CreateActivityRequest request,
           CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
        
        
    }
}