using IcatuTeste.Domain.Interfaces.Repositories;
using IcatuTeste.Domain.Interfaces.Services;
using IcatuTeste.Infra.Data.Context;
using IcatuTeste.Infra.Data.Repositories;
using IcatuTeste.Service;
using Microsoft.Extensions.DependencyInjection;

namespace IcatuTeste.Infra.IoC
{
    public static class DIContainer
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IcatuTesteContext>();

            services.AddTransient<IClienteService, ClienteService>();
            services.AddTransient<IEnderecoService, EnderecoService>();

            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IEnderecoRepository, EnderecoRepository>();
        }
    }
}
