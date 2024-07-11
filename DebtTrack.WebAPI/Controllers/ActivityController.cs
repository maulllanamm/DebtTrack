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
        
        

        [HttpPost]
        public async Task<ActionResult<CreateActivityResponse>> Create(CreateActivityRequest request,
           CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
        
        
    }
}