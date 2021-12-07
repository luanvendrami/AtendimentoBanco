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
    public class ClienteRepositorio : BaseRepositorio<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorio(ContextoSQL context) : base(context)
        {
        }

        public Cliente RetornaClientId(int id)
        {
            return _context.Cliente.AsNoTracking()
                .Include(x => x.Pagamentos)
                .Include(x => x.Endereco)
                .FirstOrDefault(n => n.Id == id);
        }
        public Cliente ConsultaId(int id)
        {
            return _context.Cliente.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }
    }
}
