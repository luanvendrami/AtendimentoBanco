using Dominio.Interfaces.Service;
using Dominio.Modelos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtendimentoBanco.Controllers
{
    [ApiController, Route("[controller]")]
    public class RecebimentoPagamentoController : ControllerBase
    {
        private readonly IRecebimentoPagamentoService _recebimentoPagamentoService;

        public RecebimentoPagamentoController(IRecebimentoPagamentoService recebimentoPagamentoService)
        {
            _recebimentoPagamentoService = recebimentoPagamentoService;
        }

        [HttpGet("ConsultaClientesNome")]
        public ActionResult BuscaClienteDebito([FromQuery]RecimentoPagamentoDto dto)
        {
            try
            {
                var retorno = _recebimentoPagamentoService.CosultarNomeClienteDebito(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao consultar a lista de clientes!");
            }
        }

        [HttpPost("Compra")]
        public ActionResult EfetuandoCompra([FromForm] RecimentoPagamentoDto dto)
        {
            try
            {
                var retorno = _recebimentoPagamentoService.Compra(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao efetuar a compra!");
            }
        }

        [HttpPost]
        public ActionResult SalvarPagamentoPorCliente([FromForm]RecimentoPagamentoDto dto)
        {
            try
            {
                var retorno = _recebimentoPagamentoService.Pagamento(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("Ocorreu um erro salvar o pagamento ao cliente!");
            }
        }
        
    }
}
