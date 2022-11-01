using Domain.Interfaces.Bus;
using MediatR;
using System.Threading.Tasks;

namespace Infrastructure.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        public Task PublishEvent(IMediatorEventBase evt)
        {
            return _mediator.Publish(evt);
        }

        public async Task<T> SendCommand<T>(IMediatorCommandBase<T> cmd)
        {
            var result = await _mediator.Send(cmd);

            return result;
        }
    }
}
