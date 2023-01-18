namespace BancoMaster.RotasCRUD.Domain.Notifications;

public class Notificacao
{
    public string Mensagem { get; }

    public Notificacao(string mensagem)
    {
        Mensagem = mensagem;
    }
}
