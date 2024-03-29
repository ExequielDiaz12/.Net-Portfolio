using Microsoft.AspNetCore.Mvc;
using Portfolio.Interfaces;
using Portfolio.Models;
using Portfolio.Servicios;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyecto repositorioProyecto;

        public HomeController(ILogger<HomeController> logger, IRepositorioProyecto repositorioProyecto)
        {
            _logger = logger;
            this.repositorioProyecto = repositorioProyecto;
        }

        public IActionResult Index()
        {
            var repositorioProyecto = new RepositorioProyecto();
            var proyectos = repositorioProyecto.ObtenerPRoyectos().Take(3).ToList();
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        [HttpPost]
        public IActionResult Contacto(MensajeDTO mensajeDTO)
        {
            return RedirectToAction("Gracias");
        }
        public IActionResult Gracias()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyecto.ObtenerPRoyectos().ToList();
            
            return View(proyectos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
