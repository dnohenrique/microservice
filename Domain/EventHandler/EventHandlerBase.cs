using Domain.Event;
using Domain.Interfaces.Bus;
using Domain.Notifications;

namespace Domain.EventHandlers
{
    public class EventHandlerBase
    {
        private readonly IMediatorHandler _bus;

        public EventHandlerBase(IMediatorHandler bus)
        {
            _bus = bus;
        }

        protected void NotifyValidationErrors(EventBase message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.PublishEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }
    }
}
