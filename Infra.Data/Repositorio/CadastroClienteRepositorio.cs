using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using Infra.Data.Contexto;
using Infra.Data.Repositorio.BaseRepositorio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Data.Repositorio
{
    public class CadastroClienteRepositorio : BaseRepositorio<DadosCliente>, ICadastroClienteRepositorio
    {
        public CadastroClienteRepositorio(ContextoSQL context) : base(context)
        {
        }

        public DadosCliente RetornaClientId(int id)
        {
            return _context.Cliente.AsNoTracking()
                .Include(x => x.Pagamentos)
                .Include(x => x.Endereco)
                .FirstOrDefault(n => n.Id == id);
        }
        public DadosCliente ConsultaId(int id)
        {
            return _context.Cliente.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }
    }
}
