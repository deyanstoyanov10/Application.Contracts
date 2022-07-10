namespace Application.Contracts.Autentication.Login.Request
{
    using MediatR;
    using Response;

    public class LoginRequest : IRequest<LoginResponse>
    {
        public string? Username { get; set; }

        public string? Password { get; set; }
    }
}
