using System.Security.Claims;
using TableResevationforRestaurant.Authorization;

namespace TableResevationforRestaurant.Repository.Auth
{
    public interface ITokenService
    {
        TokenResponse GetToken(IEnumerable<Claim> claim);
        string GetRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
