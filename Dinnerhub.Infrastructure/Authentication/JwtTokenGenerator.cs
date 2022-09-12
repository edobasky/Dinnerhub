
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Dinnerhub.Application.Common.Interfaces.Authentication;

namespace Dinnerhub.Infrastructure.Authentication;
public class JwtTokenGenerator : IJwtTokenGenerator
{
    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, firstName + " " + lastName),
            new Claim(JwtRegisteredClaimNames.Jti, firstName + " " + lastName),
            new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
        };

        
    }
}