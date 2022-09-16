
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Dinnerhub.Application.Common.Interfaces.Authentication;
using Dinnerhub.Application.Common.Interfaces.Services;
using Microsoft.IdentityModel.Tokens;

namespace Dinnerhub.Infrastructure.Authentication;
public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly IDateTimeProvider _dateTimeProvider;

    public JwtTokenGenerator(IDateTimeProvider dateTimeProvider)
    {
        _dateTimeProvider = dateTimeProvider;
    }

    public string GenerateToken(Guid userId, string firstName, string lastName)
    {
        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("Secret-super-key-@*9473920")),
                SecurityAlgorithms.HmacSha256
            
        );
        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, userId.ToString()),
            new Claim(JwtRegisteredClaimNames.GivenName, firstName),
            new Claim(JwtRegisteredClaimNames.FamilyName, lastName),
            new Claim(JwtRegisteredClaimNames.UniqueName, userId.ToString()),
        };

        var securityToken = new JwtSecurityToken(
            issuer: "Dinnerhub",
            claims : claims,
            expires: _dateTimeProvider.UtcNow.AddMinutes(60),
            signingCredentials : signingCredentials
        );

       return new JwtSecurityTokenHandler().WriteToken(securityToken); 
    }
}