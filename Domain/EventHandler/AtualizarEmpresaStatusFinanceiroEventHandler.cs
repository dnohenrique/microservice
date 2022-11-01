using Domain.Entities;
using Domain.Enums;
using Domain.Event;
using Domain.EventHandlers;
using Domain.ExtensionMethod;
using Domain.Interfaces.Aws;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Domain.Notifications;
using MediatR;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.EventHandler
{
    public class AtualizarEmpresaStatusFinanceiroEventHandler : EventHandlerBase, INotificationHandler<AtualizarEmpresaStatusFinanceiroEvent>
    {
        private readonly IEmpresaRepository<Empresa> _empresaRepository;
        private readonly IMediatorHandler _bus;
        protected readonly IPublicarEmpresaNoSns _publicarEmpresaNoSns;

        public AtualizarEmpresaStatusFinanceiroEventHandler
            (
                IMediatorHandler bus,
                IEmpresaRepository<Empresa> empresaRepository,
                IPublicarEmpresaNoSns publicarEmpresaNoSns
            ) : base(bus)

        {
            _bus = bus;
            _empresaRepository = empresaRepository;
            _publicarEmpresaNoSns = publicarEmpresaNoSns;
        }

        public async Task Handle(AtualizarEmpresaStatusFinanceiroEvent evt, CancellationToken cancellationToken)
        {
            if (!evt.IsValid())
            {
                NotifyValidationErrors(evt);
                return;
            }

            var empresa = await _empresaRepository.ObterPorCNPJAsync(evt.CNPJ);

            bool atualizado;

            var statusFinanceiro = !string.IsNullOrEmpty(evt.StatusFinanceiro) ? CultureInfo.CurrentCulture.TextInfo.ToTitleCase(evt.StatusFinanceiro.ToLower()) : "";

            if (string.IsNullOrEmpty(statusFinanceiro))
            {
                atualizado = false;
            }
            else
            {
                if (!string.IsNullOrEmpty(empresa.StatusFinanceiro) && empresa.StatusFinanceiro == statusFinanceiro)
                {
                    atualizado = true;
                }
                else
                {
                    var statusFinanceiroEnum = EnumExtension.GetEnumValueFromDescription<StatusFinanceiroEnum>(statusFinanceiro);
                    atualizado = await _empresaRepository.AtualizarStatusFinanceiro(statusFinanceiroEnum.GetEnumDescription(), evt.CNPJ);
                }
            }

            if (atualizado)
                await _publicarEmpresaNoSns.EnviarEmpresaIdAsync(evt.CNPJ);
            else
                await _bus.PublishEvent(new DomainNotification("validation-error", $"Não foi possível atualizar o status financeiro da Empresa {evt.CNPJ}."));
        }
    }
}
