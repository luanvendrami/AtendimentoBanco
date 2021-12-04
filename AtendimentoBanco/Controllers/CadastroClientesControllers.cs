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
        public ActionResult CadastrosId([FromQuery] int id)
        {
            try
            {
                var retorno = _cadastroClienteService.RetornaPorId(id);
                return Ok(retorno);
            }
            catch 
            {
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
            catch
            {
                return BadRequest("As informações NÃO foram salvas!");        
            }
        }

        [HttpPut("AtualizarCadastroCliente")]
        public ActionResult AtualizarCliente(int id, [FromForm] ClienteDto dto)
        {
            try
            {
                var retorno = _cadastroClienteService.AtualizarDados(id, dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("As informações NÃO foram atualizadas!");
            }
        }

        [HttpDelete("DeletarDados")]
        public ActionResult DeletarDados(int id)
        {
            try
            {
                var retorno = _cadastroClienteService.DeletarDados(id);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("As informações NÃO foram deletadas!");
            }
        }
    }
}
