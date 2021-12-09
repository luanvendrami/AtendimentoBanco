using CadastroCliente.Service;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Infra.Data.Contexto;
using Infra.Data.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using RecebimentoPagamento.Service;

namespace Infra.CrossCuting.IoC
{
    public static class ConfigureServicesInjection
    {
        public static void ConexaoBanco(this IServiceCollection services)
        {
            services.AddScoped<ContextoSQL>();
        }

        public static void InjecaoServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IRecebimentoPagamentoService, RecebimentoPagamentoService>();
        }

        public static void InjecaoRepositorio(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IPagamentoRepositorio, PagamentoRepositorio>();
        }
    }
}
