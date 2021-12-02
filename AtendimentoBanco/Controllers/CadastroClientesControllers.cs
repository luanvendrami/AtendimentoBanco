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
    public class CadastroClientesControllers : ControllerBase
    {
        private readonly ICadastroClienteService _cadastroClienteService;

        public CadastroClientesControllers(ICadastroClienteService cadastroClienteService)
        {
            _cadastroClienteService = cadastroClienteService;
        }

        [HttpGet("RetornaCadastroClienteId")]
        public ActionResult ListaCadastrosId([FromQuery] int id)
        {
            try
            {
                var retorno = _cadastroClienteService.RetornaLista(id);
                return Ok(retorno);
            }
            catch (Exception ex)
            {
                var error = ex;
                return BadRequest("Ocorreu um erro ao consultar o id, verifique!");
            }
        }

        [HttpPost("CadastroCliente")]
        public ActionResult CadastroCliente([FromForm]ClienteDto dto)
        {
            try
            {
               var retorno = _cadastroClienteService.CadastroCliente(dto);
                return Ok(retorno);
            }
            catch(Exception ex)
            {
                var error = ex;
                return BadRequest("As informações NÃO foram salvas!");        
            }
        }
    }
}
