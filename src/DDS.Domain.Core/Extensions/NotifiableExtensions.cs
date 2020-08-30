using Flunt.Notifications;

namespace DDS.Domain.Core.Extensions
{
    public static class NotifiableExtensions
    {

        /// <summary>
        /// Adiciona as notificações dos itens passados por parâmetros apenas se nenhum deles for nulo
        /// </summary>
        /// <param name="source"></param>
        /// <param name="items"></param>
        public static void AddNotificationsIfNotNull(this Notifiable source, params Notifiable[] items)
        {
            foreach (var item in items)
            {
                if (item != null)
                    source.AddNotifications(item);
            }
        }
    }
}
