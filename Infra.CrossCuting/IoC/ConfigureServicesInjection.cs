using CadastroCliente.Service;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using EnderecoCliente.Service;
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

        public static void InjeçaoServices(this IServiceCollection services)
        {
            services.AddScoped<ICadastroClienteService, CadastroClienteService>();
            services.AddScoped<IEnderecoClienteService, EnderecoClienteService>();

        }

        public static void InjeçaoRepositorio(this IServiceCollection services)
        {
            services.AddScoped<ICadastroClienteRepositorio, CadastroClienteRepositorio>();
            services.AddScoped<IEnderecoClienteRepositorio, EnderecoClienteRepositorio>();
            services.AddScoped<IPagamentosRepositorio, PagamentosRepositorio>();
        }
    }
}
