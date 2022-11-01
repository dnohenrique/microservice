using System.Threading.Tasks;

namespace Domain.Interfaces.Bus
{
    public interface IMediatorHandler
    {
        Task PublishEvent(IMediatorEventBase evt);
        Task<T> SendCommand<T>(IMediatorCommandBase<T> cmd);
    }
}
