using System.Security.Claims;
using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace DebtTrack.Application.Features.DebtFeatures.Command.CreateDebt;

public class CreateTransactionHandler : IRequestHandler<CreateTransactionRequest, CreateTransactionResponse>
{
    private readonly IMapper _mapper;
    private readonly ITransactionRepository _transactionRepository;
    private readonly IParticipantRepository _participantRepository;
    private readonly IActivityRepository _activityRepository;

    public CreateTransactionHandler(IMapper mapper,  ITransactionRepository transactionRepository, IParticipantRepository participantRepository, IActivityRepository activityRepository)
    {
        _mapper = mapper;
        _transactionRepository = transactionRepository;
        _participantRepository = participantRepository;
        _activityRepository = activityRepository;
    }

    public async Task<CreateTransactionResponse> Handle(CreateTransactionRequest request,
        CancellationToken cancellationToken)
    {
        var transaction = _mapper.Map<Transaction>(request);

        var activity = await _activityRepository.GetById(request.ActivityId);
        if (activity is null)
        {
            throw new NotFoundException($"Activity {request.ActivityId} not found");
        }
        var participant = await _participantRepository.GetById(request.ParticipantId);

        if (participant == null)
        {
            throw new NotFoundException($"Participant Not Found");
        }

        var res = await _transactionRepository.Create(transaction);

        return _mapper.Map<CreateTransactionResponse>(res);
    }
}