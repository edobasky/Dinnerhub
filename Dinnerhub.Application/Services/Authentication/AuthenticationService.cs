using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dinnerhub.Application.Common.Interfaces.Authentication;

namespace Dinnerhub.Application.Services.Authentication
{
    
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IJwtTokenGenerator _jwtTokenGenerator;

        public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
        {
            _jwtTokenGenerator = jwtTokenGenerator;
        }

        public AuthenticationResult Register(string firstName, string lastname, string email, string password)
        {

            // Check if user already existss
            //Create user (geberate unique ID)

            //Create JWT token
            Guid userId = Guid.NewGuid();

            var token = _jwtTokenGenerator.GenerateToken(
                userId,
                firstName,
                lastname);

            return new AuthenticationResult(
                userId,
                firstName,
                lastname,
                email,
                token);
        }


        public AuthenticationResult Login(string email, string password)
        {
             return new AuthenticationResult(
                Guid.NewGuid(),
                "firstName",
                "lastname",
                email,
                "token");
        }
    }
}