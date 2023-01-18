namespace BancoMaster.RotasCRUD.Domain.Notifications;

public interface INotificador
{
    bool HasNotificacao();
    List<Notificacao> GetNotificacoes();
    void Handle(Notificacao notificacao);
}
