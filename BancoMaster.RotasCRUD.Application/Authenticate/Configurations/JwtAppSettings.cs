namespace BancoMaster.RotasCRUD.Application.Authenticate.Configurations
{
    public class JwtAppSettings
    {
        public string? Audience { get; set; }
        public string? Issuer { get; set; }
        public int ExpiracaoDias { get; set; }
        public string? Secret { get; set; }
    }
}
