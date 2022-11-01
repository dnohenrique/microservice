using Domain.Command;
using Domain.Interfaces.Bus;
using Domain.Notifications;

namespace Domain.CommandHandlers
{
    public abstract class CommandHandlerBase
    {
        private readonly IMediatorHandler _bus;

        public CommandHandlerBase(IMediatorHandler bus)
        {
            _bus = bus;
        }

        protected void NotifyValidationErrors<T>(CommandBase<T> message)
        {
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.PublishEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }
    }
}
