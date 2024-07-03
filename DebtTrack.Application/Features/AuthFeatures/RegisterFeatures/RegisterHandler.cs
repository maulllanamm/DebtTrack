﻿using AutoMapper;
using DebtTrack.Application.Helper.Interface;
using DebtTrack.Application.Repositories;
using DebtTrack.Domain.Entities;
using MediatR;

namespace DebtTrack.Application.Features.AuthFeatures.RegisterFeatures
{
    public sealed class RegisterHandler : IRequestHandler<RegisterRequest, RegisterResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IVerifyTokenHelper _verifyHelper;
        private readonly IPasswordHelper _passwordHelper;
        private readonly string _papper = "eKPgmATs1EjohoBDMe1b3iPD64geBINmcSJhqkX1DB0MbhUpFKgDk4AyMvXJ8bjs";
        private readonly int _iteration = 5;
        public RegisterHandler(IUserRepository userRepository, IMapper mapper, IPasswordHelper passwordHelper, IVerifyTokenHelper verifyHelper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _passwordHelper = passwordHelper;
            _verifyHelper = verifyHelper;
        }

        public async Task<RegisterResponse> Handle(RegisterRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var user = _mapper.Map<User>(request);

                // Generate salt and compute hash
                var passwordSalt = _passwordHelper.GenerateSalt();
                var passwordHash = _passwordHelper.ComputeHash(request.Password, passwordSalt, _papper, _iteration);

                var verifyToken = await _verifyHelper.GenerateVerifyToken(request.Email);

                // Set password hash and salt
                user.password_salt = passwordSalt;
                user.password_hash = passwordHash;
                user.role_id = 1;
                user.verify_token = verifyToken;

                var res = await _userRepository.Create(user);
                return _mapper.Map<RegisterResponse>(res);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
