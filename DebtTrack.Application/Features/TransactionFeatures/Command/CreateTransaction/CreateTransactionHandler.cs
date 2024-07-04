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
    private readonly IUserRepository _userRepository;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CreateTransactionHandler(IMapper mapper, IUserRepository userRepository, ITransactionRepository transactionRepository, IHttpContextAccessor httpContextAccessor)
    {
        _mapper = mapper;
        _userRepository = userRepository;
        _transactionRepository = transactionRepository;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<CreateTransactionResponse> Handle(CreateTransactionRequest request,
        CancellationToken cancellationToken)
    {
        var username = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name)?.Value;
        var transaction = _mapper.Map<Transaction>(request);

        var userDebetor = await _userRepository.GetByUsername(username);
        var userReceivables = await _userRepository.GetById(request.CreditorId);

        if (userDebetor.id != request.DebtorId)
        {
            throw new NotFoundException($"Debtor Not Found");
        }
        if (userReceivables == null)
        {
            throw new NotFoundException($"Receivables Not Found");
        }

        var res = await _transactionRepository.Create(transaction);

        return _mapper.Map<CreateTransactionResponse>(res);
    }
}