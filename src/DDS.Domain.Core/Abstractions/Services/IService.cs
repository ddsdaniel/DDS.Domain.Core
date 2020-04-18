using Flunt.Notifications;
using System.Collections.Generic;

namespace DDS.Domain.Core.Abstractions.Services
{
    public interface IService
    {
        IReadOnlyCollection<Notification> Notifications { get; }
        bool Invalid { get; }
        bool Valid { get; }
    }
}
