namespace Dinnerhub.Contracts.Authentication;

public record AuthenticationRequest(
    string FirstName,
    string LastName,
    string Email,
    string Token
);