using Dominio.Interfaces.Service;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AtendimentoBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentosController : ControllerBase
    {
        private readonly IPagamentosService _pagamentos;

        public PagamentosController(IPagamentosService pagamentos)
        {
            _pagamentos = pagamentos;
        }

        [HttpGet("RetornaPagamentoId")]
        public ActionResult PagamentoId([FromQuery]int id)
        {
            try
            {
                var retorno = _pagamentos.PagamentosPorId(id);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest("Ocorreu um erro ao consultar o pagamento, verifique!");
            }
        }

        [HttpPost("CadastroPagamento")]
        public ActionResult CadastroPagamento([FromForm] PagamentoDto dto)
        {
            try
            {
                var retorno = _pagamentos.CadastroPagamentos(dto);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                return BadRequest("As informações NÃO foram salvas!");
            }
        }
    }
}
