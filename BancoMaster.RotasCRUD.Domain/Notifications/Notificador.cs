namespace BancoMaster.RotasCRUD.Domain.Notifications;

public class Notificador : INotificador
{
    protected List<Notificacao> _notificacoes;

    public Notificador()
    {
        _notificacoes = new List<Notificacao>();
    }

    public void Handle(Notificacao notificacao)
    {
        _notificacoes.Add(notificacao);
    }

    public List<Notificacao> GetNotificacoes()
    {
        return _notificacoes;
    }

    public bool HasNotificacao()
    {
        return _notificacoes.Any();
    }
}
