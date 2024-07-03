﻿using AutoMapper;
using DebtTrack.Application.Common.Exceptions;
using DebtTrack.Application.Helper.Interface;
using DebtTrack.Application.Repositories;
using MediatR;

namespace DebtTrack.Application.Features.AuthFeatures.LoginFeatures
{
    public sealed class LoginHandler : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPasswordHelper _passwordHelper;
        private readonly string _papper = "eKPgmATs1EjohoBDMe1b3iPD64geBINmcSJhqkX1DB0MbhUpFKgDk4AyMvXJ8bjs";
        private readonly int _iteration = 5;
        public LoginHandler(IUserRepository userRepository, IMapper mapper, IPasswordHelper passwordHelper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _passwordHelper = passwordHelper;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByUsername(request.Username);
            if(user == null)
            {
                throw new NotFoundException($"User with username {request.Username} Not Found");
            }

            var passwordHash = _passwordHelper.ComputeHash(request.Password, user.password_salt, _papper, _iteration);
            if (passwordHash != user.password_hash)
            {
                throw new NotFoundException("Incorrect password");
            }

            if (user.verify_date is null)
            {
                var errors = new string[] { "User is not verified" };
                throw new BadRequestException(errors);
            }

            return _mapper.Map<LoginResponse>(user);
        }
    }
}
