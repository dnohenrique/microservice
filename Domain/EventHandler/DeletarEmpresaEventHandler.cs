using Domain.Entities;
using Domain.Event;
using Domain.EventHandlers;
using Domain.Interfaces.Bus;
using Domain.Notifications;
using Domain.Interfaces.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.EventHandler
{
    public class DeletarEmpresaEventHandler : EventHandlerBase, INotificationHandler<DeletarEmpresaEvent>
    {
        private readonly IEmpresaRepository<Empresa> _empresaRepository;
        private readonly IMediatorHandler _bus;

        public DeletarEmpresaEventHandler(IEmpresaRepository<Empresa> empresaRepository, IMediatorHandler bus): base(bus)
        {
            _empresaRepository = empresaRepository;
            _bus = bus;
        }

        public async Task Handle(DeletarEmpresaEvent evt, CancellationToken cancellationToken)
        {
            if (!evt.IsValid())
            {
                NotifyValidationErrors(evt);
                return;
            }

            var empresa = await _empresaRepository.ObterPorIdAsync(evt.Id);

            if (empresa == null)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"O Empresa {evt.Id} não existe."));
                return;
            }

            var isOk = await _empresaRepository.DeletarAsync(evt.Id);

            if (!isOk)
            {
                await _bus.PublishEvent(new DomainNotification(evt.MessageType, $"Não foi possível deletar o Empresa {evt.Id}."));
            }
        }
    }
}
