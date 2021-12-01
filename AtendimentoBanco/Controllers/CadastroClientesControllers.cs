using Dominio.Interfaces.Service;
using Dominio.Modelos;
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

        [HttpPost]
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
