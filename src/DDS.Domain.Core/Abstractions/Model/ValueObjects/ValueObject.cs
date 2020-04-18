using Flunt.Notifications;

namespace DDS.Domain.Core.Abstractions.Model.ValueObjects
{
    public abstract class ValueObject<T> : Notifiable  where T : ValueObject<T>
    {
        
    }
}