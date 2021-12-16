using Infra.Data.Contexto;
using Infra.Data.Repositorio;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCuting.IoC
{
    public static class ConfigureServicesInjection
    {
        public static void ConexaoBanco(this IServiceCollection services)
        {
            services.AddScoped<ContextoSQL>();
        }
    }
}
