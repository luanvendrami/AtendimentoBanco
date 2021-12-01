using Dominio.Interfaces.Aplicações;
using Dominio.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtendimentoBanco.Controllers
{
    [ApiController, Route("[controller]")]
    [Consumes("application/json")]
    public class CadastroClientesControllers : Controller
    {
        private readonly ICadastroClienteService _cadastroClienteService;

        public CadastroClientesControllers(ICadastroClienteService cadastroClienteService)
        {
            _cadastroClienteService = cadastroClienteService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroCliente(ClienteDto dto)
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
    }
}
