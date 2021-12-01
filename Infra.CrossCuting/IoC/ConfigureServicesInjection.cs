using CadastroCliente.Service;
using Dominio.Interfaces.Aplicações;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Repositorio.BaseRepositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio;
using Infra.Data.Repositorio.BaseRepositorio;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.CrossCuting.IoC
{
    public static class ConfigureServicesInjection
    {
        public static void ConexaoBanco(this IServiceCollection services)
        {
            services.AddScoped<ContextoSQL>();
        }

        public static void InjeçaoServices(this IServiceCollection services)
        {
            services.AddScoped<ICadastroClienteService, CadastroClienteService>();
        }

        public static void InjeçaoRepositorio(this IServiceCollection services)
        {
            services.AddScoped<IInformacaoClienteRepositorio, InformacaoClienteRepositorio>();
        }   
    }
}
