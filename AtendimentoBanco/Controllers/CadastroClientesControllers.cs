using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtendimentoBanco.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroClientesControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
