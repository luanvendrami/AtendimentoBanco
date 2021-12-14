using Dominio.Entidades;
using Dominio.Interfaces.Repositorio.BaseRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositorio
{
    public interface IPagamentoRepositorio : IBaseRepositorio<Pagamento>
    {
        Pagamento RetornaPagamentoId(int id);
        Pagamento BuscarPorCpf(string cpf);
    }
}
