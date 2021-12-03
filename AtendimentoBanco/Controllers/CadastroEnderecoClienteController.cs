using Dominio.Interfaces.Service;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AtendimentoBanco.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CadastroEnderecoClienteController : ControllerBase
    {
        private readonly IEnderecoClienteService _enderecoClienteService;

        public CadastroEnderecoClienteController(IEnderecoClienteService enderecoClienteService)
        {
            _enderecoClienteService = enderecoClienteService;
        }

        [HttpGet("RetornaEnderecoId")]
        public ActionResult EnderecoId([FromQuery]int id)
        {
            try
            {
                var retorno = _enderecoClienteService.RetornaPorId(id);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("Ocorreu um erro ao consultar o endereço, verifique!");
            }
        }

        [HttpPost("CadastroEndereco")]
        public ActionResult CadastroEndereco([FromForm] EnderecoDto dto)
        {
            try
            {
                var retorno = _enderecoClienteService.CadastroEndereco(dto);
                return Ok(retorno);
            }
            catch
            {
                return BadRequest("As informações NÃO foram salvas!");
            }
        }

        [HttpPut("AtualizarEnderecoCliente")]
        public ActionResult AtualizarEndereco(int id, [FromForm] EnderecoDto dto)
        {
            try
            {
                var retorno = _enderecoClienteService.AtualizarEndereco(id, dto);
                return Ok(retorno);
            }
            catch 
            {
                return BadRequest("As informações NÃO foram atualizadas!");
            }
        }
    }
}
