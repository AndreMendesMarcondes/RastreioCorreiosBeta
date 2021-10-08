using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RC.CorreioService.Interface;
using RC.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICorreioService _correioService;

        public HomeController(ILogger<HomeController> logger, ICorreioService correioService)
        {
            _logger = logger;
            _correioService = correioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string codigos)
        {
            codigos = codigos.Replace("\t", "")
                             .Replace("\n", ",")
                             .Replace("\r", "")
                             .Replace(",,", "")
                             .Replace(" ", "")
                             .Trim();

            List<RastreioCorreioDTO> lista = _correioService.Processar(codigos);

            return View(lista);
        }
    }
}
