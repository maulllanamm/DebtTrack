using DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;
using DebtTrack.Application.Helper.Interface;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        [HttpPost]
        public async Task<ActionResult<CreateTransactionResponse>> Create(CreateTransactionRequest request,
           CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

       
    }
}