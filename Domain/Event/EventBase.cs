using Domain.Interfaces.Bus;
using FluentValidation.Results;

namespace Domain.Event
{
    public abstract class EventBase : IMediatorEventBase
    {
        public string MessageType { get; protected set; }
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();

        public EventBase()
        {
            MessageType = GetType().Name;
        }
    }
}
