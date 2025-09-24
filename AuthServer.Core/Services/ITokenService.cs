using AuthServer.Core.Configuration;
using AuthServer.Core.DTOs;
using AuthServer.Core.models;

namespace AuthServer.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}