using prmToolkit.NotificationPattern;

namespace Dominio.Entidades.Base
{
    public abstract class Entidade : Notifiable
    {
        public int Id { get; protected set; }
        public DateTime DataDeCriacao { get; protected set; }
        public DateTime DataDeAlteracao { get; protected set; }
    }
}
