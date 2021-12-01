using CadastroCliente.Service;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Repositorio.BaseRepositorio;
using Dominio.Interfaces.Service;
using EnderecoCliente.Service;
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
            services.AddScoped<ICadastroClienteService, CadastroCliente.Service.CadastroClienteService>();
            services.AddScoped<IEnderecoClienteService, EnderecoClienteService>();

        }

        public static void InjeçaoRepositorio(this IServiceCollection services)
        {
            services.AddScoped<ICadastroClienteRepositorio, Data.Repositorio.CadastroClienteRepositorio>();
        }   
    }
}
