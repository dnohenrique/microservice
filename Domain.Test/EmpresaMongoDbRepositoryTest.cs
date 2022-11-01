using Domain.Dto;
using Domain.Entities;
using Domain.Interfaces.Bus;
using Domain.Interfaces.Repository;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Domain.Test
{
    public class EmpresaMongoDbRepositoryTest
    {
        private Empresa _empresaEntity { get; set; }

        private Mock<IEmpresaRepository<Empresa>> _empresaRepositoryMock { get; set; }
        private Mock<IMediatorHandler> _mediatorMock { get; set; }
        private CancellationToken _cancellationToken { get; set; }
    }
}
