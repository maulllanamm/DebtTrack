﻿namespace DebtTrack.Application.Helper.Interface
{
    public interface IVerifyTokenHelper
    {
        public Task<string> GenerateVerifyToken(string email);
    }
}
