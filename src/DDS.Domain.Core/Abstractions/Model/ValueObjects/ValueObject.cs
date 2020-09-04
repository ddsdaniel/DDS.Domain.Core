using Flunt.Notifications;

namespace DDS.Domain.Core.Abstractions.Models.ValueObjects
{
    public abstract class ValueObject<T> : Notifiable  where T : ValueObject<T>
    {
        
    }
}