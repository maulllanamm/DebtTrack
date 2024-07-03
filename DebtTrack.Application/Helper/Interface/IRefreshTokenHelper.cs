using DebtTrack.Application.Features.AuthFeatures.LoginFeatures;
using DebtTrack.Domain.Entities;
using System.Security.Claims;

namespace DebtTrack.Application.Helper.Interface
{
    public interface IRefreshTokenHelper
    {
        public string GenerateRefreshToken(string username, string roleName);
        public void SetRefreshToken(string newRefreshToken, string username);
        public Task ValidateRefreshToken(string username, string refreshToken);
    }
}
