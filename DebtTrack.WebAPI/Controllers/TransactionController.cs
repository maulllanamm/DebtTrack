using DebtTrack.Application.Features.ActivityFeatures.Command;
using DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;
using DebtTrack.Application.Features.ParticipantFeatures.Command;
using DebtTrack.Application.Helper.Interface;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DebtTrack.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TransactionController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICacheHelper _cacheHelper;

        public TransactionController(IMediator mediator, ICacheHelper cacheHelper)
        {
            _mediator = mediator;
            _cacheHelper = cacheHelper;
        }
        
        [HttpGet]
        public async Task<ActionResult<GetAllTransactionResponse>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllTransactionRequest(), cancellationToken);
            return Ok(result);
        }
        
        [HttpGet]
        public async Task<ActionResult<GetByActivityIdResponse>> GetById(int activityId, CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetByActivityIdRequest(activityId), cancellationToken);
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateTransactionResponse>> Create(CreateTransactionRequest request,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
        
        [HttpPut]
        public async Task<ActionResult<CalculateTotalAmountToBePaidResponse>> CalculateTotalAmountToBePaid(int request,
            CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new CalculateTotalAmountToBePaidRequest(request), cancellationToken);
            return Ok(result);
        }
    }
}