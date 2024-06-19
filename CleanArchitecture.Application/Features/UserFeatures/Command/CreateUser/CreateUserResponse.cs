﻿namespace CleanArchitecture.Application.Features.UserFeatures.Command.Create
{
    public sealed record CreateUserResponse
    {
        public string Username { get; init; }
        public string Email { get; init; }
        public string FullName { get; init; }
        public string PhoneNumber { get; init; }
        public string Address { get; init; }

    }
}