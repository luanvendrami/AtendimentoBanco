using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public abstract class Inscricao
    {
        protected Inscricao(DateTime? dataExpiracao)
        {
            DataInicial = DateTime.Now;
            UltimaAtualizacaoData = DateTime.Now;
            DataExpiracao = dataExpiracao;
            Ativo = true;
            Pagamentos = new List<Pagamento>();
        }

        public DateTime DataInicial { get; private set; }
        public DateTime UltimaAtualizacaoData { get; private set; }
        public DateTime? DataExpiracao { get; private set; }
        public bool Ativo { get; private set; }

        public IReadOnlyCollection<Pagamento> Pagamentos { get; set; }

        public void AddPagamento(Pagamento pagamento)
        {

        }

        public void Ativado()
        {
            Ativo = true;
            UltimaAtualizacaoData = DateTime.Now;
        }

        public void Desativado()
        {
            Ativo = false;
            UltimaAtualizacaoData = DateTime.Now;
        }
    }
}
