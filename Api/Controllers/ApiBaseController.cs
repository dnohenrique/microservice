using Application.ViewModels.Response;
using Domain.Interfaces.Bus;
using Domain.Notifications;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{

    public abstract class ApiBaseController : ControllerBase
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IMediatorHandler _mediator;


        public ApiBaseController(INotificationHandler<DomainNotification> notifications,
                                IMediatorHandler mediator)
        {
            _notifications = (DomainNotificationHandler)notifications;
            _mediator = mediator;
        }
        protected IEnumerable<DomainNotification> Notifications => _notifications.GetNotifications();

        protected bool IsValidOperation()
        {
            return (!_notifications.HasNotifications());
        }

        protected new IActionResult Response(dynamic result = null)
        {
            if (IsValidOperation())
            {
                return result == null ? Ok() : Ok(result);
            }

            var notifications = from n
                                in _notifications.GetNotifications()
                                select new
                                {
                                    type = "validation-error",
                                    field = n.Key,
                                    message = n.Value
                                };

            return BadRequest(new
            {
                metadata = new { resultset = new { type = ReturnType.List.ToString() } },
                result = notifications
            });
        }

        protected void NotifyModelStateErrors()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var erro in erros)
            {
                var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotifyError(string.Empty, erroMsg);
            }
        }

        protected void NotifyError(string code, string message)
        {
            _mediator.PublishEvent(new DomainNotification(code, message));
        }

    }
}
