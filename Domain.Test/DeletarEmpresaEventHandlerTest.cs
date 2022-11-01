using Domain.Entities;
using Domain.EventHandler;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Domain.Event;
using Domain.Notifications;
using Domain.Dto;

namespace Domain.Test
{
    public class DeletarEmpresaEventHandlerTest
    {
        public Mock<IMediatorHandler> _mediatorMock { get; set; }
        public CancellationToken _cancellationToken { get; set; }

        public DeletarEmpresaEventHandlerTest()
        {
            _mediatorMock = new Mock<IMediatorHandler>();
        }
    }
}
