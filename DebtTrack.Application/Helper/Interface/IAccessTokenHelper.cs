using DebtTrack.Domain.Entities;
using System.Security.Claims;

namespace DebtTrack.Application.Helper.Interface
{
    public interface IAccessTokenHelper
    {
        public string GenerateAccessToken(string username , string roleName);
        public ClaimsPrincipal ValidateAccessToken(string token);
    }
}
