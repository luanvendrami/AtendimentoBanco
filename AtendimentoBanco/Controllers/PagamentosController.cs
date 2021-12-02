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
        private readonly IPagamentos _pagamentos;

        public PagamentosController(IPagamentos pagamentos)
        {
            _pagamentos = pagamentos;
        }

        [HttpPost]
        public ActionResult CadastroEndereco([FromForm] PagamentoDto dto)
        {
            try
            {
                var retorno = _pagamentos.CadastroPagamentos(dto);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                var error = ex;
                return BadRequest("As informações NÃO foram salvas!");
            }
        }
    }
}
