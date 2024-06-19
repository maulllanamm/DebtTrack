﻿namespace CleanArchitecture.Application.Features.UserFeatures.Query.GetById
{
    public sealed record GetByIdUserResponse
    {
        public string Username { get; init; }
        public string Email { get; init; }
        public string FullName { get; init; }
        public string PhoneNumber { get; init; }
        public string Address { get; init; }
    }
}
