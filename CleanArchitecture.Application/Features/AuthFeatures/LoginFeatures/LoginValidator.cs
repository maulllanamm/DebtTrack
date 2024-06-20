﻿using FluentValidation;

namespace CleanArchitecture.Application.Features.AuthFeatures.LoginFeatures
{
    public class LoginValidator : AbstractValidator<LoginRequest>
    {
        public LoginValidator() { 
        
            RuleFor(x => x.Username).NotEmpty();
            RuleFor(x => x.Password).NotEmpty();
        } 
    }
}
