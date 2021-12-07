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
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(ContextoSQL context) : base(context)
        {
        }

        public Endereco RetornaEnderecoId(int id)
        {
            return _context.Endereco.AsNoTracking().FirstOrDefault(n => n.Id == id);
        }

    }
}
