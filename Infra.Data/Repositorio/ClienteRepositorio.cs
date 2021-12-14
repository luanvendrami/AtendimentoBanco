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

        public Cliente ValidaBancoCliente(string cpf, string rg)
        {
            return _context.Cliente.AsNoTracking()
                .Include(x => x.Pagamentos)
                .FirstOrDefault(x => x.Cpf == cpf || x.Rg == rg);
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

        public List<Cliente> RetornaClientes()
        {
            return _context.Cliente.AsNoTracking()
                .Include(x => x.Endereco)
                .Include(x => x.Pagamentos)
                .ToList();
        }

        public Cliente ConsultaPorNome(string nome, string cpf, string rg)
        {
            return _context.Cliente.AsNoTracking()
                .Include(x => x.Pagamentos)
                .FirstOrDefault(x => x.NomeCompleto == nome || x.Cpf == cpf || x.Rg == rg);
        }

        public Cliente ConsultarPorCpf(string cpf)
        {
            return _context.Cliente.AsNoTracking().FirstOrDefault(x => x.Cpf == cpf);
        }

        public List<Cliente> ConsultarPorCpfClienteCompra(string cpf)
        {
            return _context.Cliente
                .Include(x => x.Compra)
                .AsNoTracking().Where(x => x.Cpf == cpf).ToList();
        }

    }
}
