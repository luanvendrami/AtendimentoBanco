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
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private readonly IPagamentoService _pagamentoService;

        public PagamentoController(IPagamentoService pagamentoService)
        {
            _pagamentoService = pagamentoService;
        }

        [HttpPost("CadastrarTaxa")]
        public ActionResult SalvarTaxa(EncargosDto dto)
        {
            try
            {
                var retorno = _pagamentoService.SalvaTaxas(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao salvar a taxa informada!");
            }
        }
    }
}
