namespace BancoMaster.RotasCRUD.Application;

#nullable disable
public class UserTokenViewModel
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string Nome { get; set; }
    public bool IsAutenticado { get; set; }
    public IEnumerable<ClaimViewModel> Claims { get; set; }
}

public class LoginResponse
{
    public string AcessToken { get; set; }
    public string Token_type { get; set; }
    public int Expires_in { get; set; }
}

public class ClaimViewModel
{
    public string Value { get; set; }
    public string Type { get; set; }
}
