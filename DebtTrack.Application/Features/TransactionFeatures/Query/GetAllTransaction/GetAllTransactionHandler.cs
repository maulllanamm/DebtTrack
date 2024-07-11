using AutoMapper;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.ParticipantFeatures.Command;

public class GetAllTransactionHandler : IRequestHandler<GetAllTransactionRequest,List<GetAllTransactionResponse>>
{
    private readonly IMapper _mapper;
    private readonly ITransactionRepository _transactionRepository;
    
    public GetAllTransactionHandler(ITransactionRepository transactionRepository, IMapper mapper)
    {
        _transactionRepository = transactionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetAllTransactionResponse>> Handle(GetAllTransactionRequest request, CancellationToken cancellationToken)
    {
        var res = await _transactionRepository.GetAll();
        return _mapper.Map<List<GetAllTransactionResponse>>(res);
    }
}