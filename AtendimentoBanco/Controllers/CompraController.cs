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
    public class CompraController : ControllerBase
    {
        private readonly ICompraService _compraService;

        public CompraController(ICompraService compraService)
        {
            _compraService = compraService;
        } 

        [HttpPost("CompraCliente")]
        public ActionResult CompraCliente([FromForm] EfetuarCompraDto dto)
        {
            try
            {
                var retorno = _compraService.EfetuarCompra(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("As informações NÃO foram salvas!");
            }
        }
    }
}
