using CadastroCliente.Service;
using Dominio.Interfaces.Repositorio;
using Dominio.Interfaces.Service;
using Infra.Data.Contexto;
using Infra.Data.Repositorio;
using Microsoft.Extensions.DependencyInjection;
using Pagamento.Service;

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
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IPagamentoService, PagametnoService>();
        }

        public static void InjeçaoRepositorio(this IServiceCollection services)
        {
            services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
            services.AddScoped<IEnderecoRepositorio, EnderecoRepositorio>();
            services.AddScoped<IPagamentoRepositorio, PagamentoRepositorio>();
        }
    }
}
