using MediatR;

namespace Domain.Interfaces.Bus
{
    public interface IMediatorCommandBase<T> : IRequest<T>
    {
    }
}
