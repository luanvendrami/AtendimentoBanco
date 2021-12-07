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
    public class ClientesControllers : ControllerBase
    {
        private readonly IClienteService _cadastroClienteService;

        public ClientesControllers(IClienteService cadastroClienteService)
        {
            _cadastroClienteService = cadastroClienteService;
        }

        [HttpGet("RetornaClienteId")]
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
        public ActionResult CadastroCliente([FromForm]BancoDto dto)
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

        [HttpPut("AtualizarCadastroCliente")]
        public ActionResult AtualizarCliente(int id, [FromForm] BancoDto dto)
        {
            try
            {
                var retorno = _cadastroClienteService.AtualizarDados(id, dto);
                return Ok(retorno);
            }
            catch(Exception ex)
            {
                var error = ex;
                return BadRequest("As informações NÃO foram atualizadas!");
            }
        }

        [HttpDelete("DeletarCliente")]
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
