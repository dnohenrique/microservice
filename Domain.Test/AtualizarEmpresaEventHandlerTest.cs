using Domain.Entities;
using Domain.Event;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using Moq;
using System.Threading;

namespace Domain.Test
{
    public class AtualizarEmpresaEventHandlerTest
    {
        private Mock<IMediatorHandler> _mediatorMock { get; set; }
        private CancellationToken _cancellationToken { get; set; }
        private Empresa _empresaEntity { get; set; }
        private AtualizarEmpresaEvent _atualizarEmpresaEvent { get; set; }
        private Mock<IEmpresaRepository<Empresa>> _empresaRepositoryMock { get; set; }
    }
}
