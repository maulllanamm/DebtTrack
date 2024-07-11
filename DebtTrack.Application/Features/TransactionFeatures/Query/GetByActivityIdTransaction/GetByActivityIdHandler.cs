using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ActivityFeatures.Command;

public class GetByActivityIdHandler : IRequestHandler<GetByActivityIdRequest,List<GetByActivityIdResponse>>
{
    private readonly IMapper _mapper;
    private readonly ITransactionRepository _transactionRepository;
    
    public GetByActivityIdHandler(ITransactionRepository transactionRepository, IMapper mapper)
    {
        _transactionRepository = transactionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetByActivityIdResponse>> Handle(GetByActivityIdRequest request, CancellationToken cancellationToken)
    {
        var res = await _transactionRepository.GetByActivityId(request.ActivityId);
        if (res is null)
        {
            throw new NotFoundException($"Activity id {request.ActivityId} not found");
        }
        return _mapper.Map<List<GetByActivityIdResponse>>(res);
    }
}