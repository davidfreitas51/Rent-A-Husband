using Microsoft.AspNetCore.Mvc;
using RentAHusband.Models;
using System.Diagnostics;

namespace RentAHusband.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Maridos()
		{
			return View("~/Views/MaridoDeAluguel/Index.cshtml");
		}
		public IActionResult Cadastro()
		{
			return View("~/Views/MaridoDeAluguel/Create.cshtml");
		}
		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
