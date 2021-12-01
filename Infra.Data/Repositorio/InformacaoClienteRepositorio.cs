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
    public class InformacaoClienteRepositorio : BaseRepositorio<InformacaoCliente>, IInformacaoClienteRepositorio
    {
        public InformacaoClienteRepositorio(ContextoSQL context) : base(context)
        {
        }

        public IEnumerable<InformacaoCliente> RetornaClientes()
        {
            return _context.InformacaoCliente.AsNoTracking().ToList();
        }

        public IEnumerable<InformacaoCliente> RetornaNomeCliente(string nome)
        {
            return _context.InformacaoCliente.Where(n => n.NomeCompleto.Contains(nome)).ToList();
        }

        public InformacaoCliente RetornaClientId(int id)
        {
            return _context.InformacaoCliente.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }
    }
}
