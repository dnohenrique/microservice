using Domain.Interfaces.Bus;
using FluentValidation.Results;

namespace Domain.Command
{
    public abstract class CommandBase<T> : IMediatorCommandBase<T>
    {
        public string MessageType { get; protected set; }
        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();

        public CommandBase()
        {
            MessageType = GetType().Name;
        }
    }
}
