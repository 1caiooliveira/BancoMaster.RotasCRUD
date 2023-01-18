using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using BancoMaster.RotasCRUD.Application.Authenticate.Configurations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BancoMaster.RotasCRUD.Domain.Entities;

namespace BancoMaster.RotasCRUD.Application.Authenticate.Services;
#nullable disable
public class GeneratorToken : IGeneratorToken
{
    private readonly JwtAppSettings _jwtAppSettings;

    public GeneratorToken(IOptions<JwtAppSettings> jwtAppSettings)
    {
        _jwtAppSettings = jwtAppSettings.Value;
    }

    #region GeraJwtToken
    public LoginResponse GeraJwtToken(Usuario usuario)
    {
        ClaimsIdentity identity = new ClaimsIdentity(
            new[] {
                new Claim(JwtRegisteredClaimNames.Sub, usuario.Senha),
                new Claim(JwtRegisteredClaimNames.UniqueName, usuario.Login),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Nbf, ToUnixEpochDate(DateTime.Now).ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, ToUnixEpochDate(DateTime.Now).ToString(), ClaimValueTypes.Integer64)
            });

        var tokenHandler = new JwtSecurityTokenHandler();

        var keyByteArray = Encoding.ASCII.GetBytes(_jwtAppSettings.Secret);
        var signingKey = new SymmetricSecurityKey(keyByteArray);

        DateTime creationDate = DateTime.Now;
        DateTime expirationDate = creationDate.AddDays(_jwtAppSettings.ExpiracaoDias);

        var securityToken = tokenHandler.CreateToken(new SecurityTokenDescriptor
        {
            Issuer = _jwtAppSettings.Issuer,
            Audience = _jwtAppSettings.Audience,
            SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256),
            Subject = identity,
            NotBefore = creationDate,
            Expires = expirationDate
        });

        var tokenWrite = tokenHandler.WriteToken(securityToken);

        var response = new LoginResponse
        {
            AcessToken = tokenWrite,
            Token_type = "Bearer",
            Expires_in = 7
        };

        return response;
    }
    #endregion

    private static long ToUnixEpochDate(DateTime date)
            => (long)Math.Round((date.ToUniversalTime()
                - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
}
