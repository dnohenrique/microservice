using Application;
using AutoMapper;
using Domain.Aws;
using Domain.Command;
using Domain.CommandHandlers;
using Domain.Entities;
using Domain.Event;
using Domain.EventHandler;
using Domain.ExternalEntities;
using Domain.Interfaces.Aws;
using Domain.Interfaces.Bus;
using Domain.Interfaces.DataContext;
using Domain.Interfaces.Repository;
using Domain.Notifications;
using Infrastructure.AutoMapper;
using Infrastructure.Bus;
using Infrastructure.DataContext;
using Infrastructure.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace Infrastructure.IoC
{
    public class NativeInjectorBootstrapper
    {

        public static void RegisterServices(IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            // Domain Bus (Mediator)
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            // Application
            services.AddScoped<IEmpresaApplicationServices, EmpresaApplicationServices>();

            // Domain - Events
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            services.AddScoped<INotificationHandler<AtualizarEmpresaEvent>, AtualizarEmpresaEventHandler>();
            services.AddScoped<INotificationHandler<AtualizarEmpresaCobrancaEvent>, AtualizarEmpresaCobrancaEventHandler>();
            services.AddScoped<INotificationHandler<AtualizarEmpresaStatusFinanceiroEvent>, AtualizarEmpresaStatusFinanceiroEventHandler>();
            services.AddScoped<INotificationHandler<DeletarEmpresaEvent>, DeletarEmpresaEventHandler>();

            // Domain - Commands
            services.AddScoped<IRequestHandler<CriarEmpresaCommand, string>, CriarEmpresaCommandHandler>();

            // Infra - Data
            services.AddScoped<IEmpresaRepository<Empresa>, EmpresaMongoDbRepository>();
            services.AddScoped<IPlanoRepository<PlanoExternal>, PlanoMongoDbRepository>();           
            services.AddScoped<IMongoContext, MongoContext>();
            services.AddScoped<IMongoContextPlano, MongoContextPlano>();

            //Aws
            services.AddScoped<IPublicarEmpresaNoSns, PublicarEmpresaNoSns>();

            services.AddAutoMapper();

            AutoMapperConfig.RegisterMappings();
        }

    }
}
