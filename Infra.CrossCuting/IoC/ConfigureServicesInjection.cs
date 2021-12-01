using CadastroCliente.Service;
using Dominio.Interfaces.Aplicações;
using Infra.Data.Contexto;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCuting.IoC
{
    public static class ConfigureServicesInjection
    {
        public static void ConexaoBanco(this IServiceCollection services)
        {
            services.AddScoped<Contexto>();
        }

        public static void InjeçãoServices(this IServiceCollection services)
        {
            services.AddScoped<ICadastroClienteService, CadastroClienteService>();
        }
    }
}
