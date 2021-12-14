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
    public class ClientesController : ControllerBase
    {
        private readonly IClienteService _cadastroClienteService;

        public ClientesController(IClienteService cadastroClienteService)
        {
            _cadastroClienteService = cadastroClienteService;
        }

        [HttpGet("RetornaTodosClientes")]
        public ActionResult RetornaClientes()
        {
            try
            {
                var retorno = _cadastroClienteService.RetornaTodosClientes();
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao consultar a lista de clientes!");
            }
        }

        [HttpGet("ListaCompraPorCliente")]
        public ActionResult CompraPorCliente([FromQuery] ListaCompraPorClienteDto dto)
        {
            try
            {
                var retorno = _cadastroClienteService.CompraPorCliente(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("As informações NÃO foram salvas!");
            }
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
        public ActionResult CadastroCliente([FromForm] DadosDto dto)
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
        public ActionResult AtualizarCliente(int id, [FromForm] DadosDto dto)
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
