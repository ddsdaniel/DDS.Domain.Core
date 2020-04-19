using Flunt.Notifications;
using System.Collections.Generic;

namespace DDS.Domain.Core.Abstractions.Model.ValueObjects.Validacoes
{
    public interface INotifiable
    {
        public IReadOnlyCollection<Notification> Notifications { get; }
        public bool Invalid { get; }
        public bool Valid { get; }

        public void AddNotification(string property, string message);
        public void AddNotification(Notification notification);
        public void AddNotifications(IReadOnlyCollection<Notification> notifications);
        public void AddNotifications(IList<Notification> notifications);
        public void AddNotifications(ICollection<Notification> notifications);
        public void AddNotifications(Notifiable item);
        public void AddNotifications(params Notifiable[] items);
    }
}
