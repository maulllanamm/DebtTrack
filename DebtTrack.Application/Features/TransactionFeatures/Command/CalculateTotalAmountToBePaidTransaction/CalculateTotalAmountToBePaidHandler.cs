using System.Security.Claims;
using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public class CalculateTotalAmountToBePaidHandler : IRequestHandler<CalculateTotalAmountToBePaidRequest, List<CalculateTotalAmountToBePaidResponse>>
{
    private readonly IMapper _mapper;
    private readonly ITransactionRepository _transactionRepository;
    private readonly IParticipantRepository _participantRepository;
    private readonly IActivityRepository _activityRepository;

    public CalculateTotalAmountToBePaidHandler(IMapper mapper,  ITransactionRepository transactionRepository, IParticipantRepository participantRepository, IActivityRepository activityRepository)
    {
        _mapper = mapper;
        _transactionRepository = transactionRepository;
        _participantRepository = participantRepository;
        _activityRepository = activityRepository;
    }

    public async Task<List<CalculateTotalAmountToBePaidResponse>> Handle(CalculateTotalAmountToBePaidRequest request,
        CancellationToken cancellationToken)
    {
        var activity = await _activityRepository.GetById(request.ActivityId);
        if (activity is null)
        {
            throw new NotFoundException($"Activity {request.ActivityId} not found");
        }
        
        var transactions = await _transactionRepository.GetByActivityId(request.ActivityId);
        if (transactions == null)
        {
            throw new NotFoundException($"Transaction Not Found");
        }
        
        var tax =  (activity.total_bill - activity.bill) / transactions.Count();
        transactions.ForEach(transaction =>
        {
            transaction.total_amount_to_be_paid = transaction.amount + tax;
            transaction.modified_date = DateTime.UtcNow;
        });


        var res = await _transactionRepository.UpdateBulk(transactions);

        return _mapper.Map<List<CalculateTotalAmountToBePaidResponse>>(transactions);
    }
}