using Esercizio_MVC_Core_DB.Models;
using Esercizio_MVC_Core_DB.Models.DB;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Esercizio_MVC_Core_DB.Controllers
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
            return View(DataBase.GetList());
        }

		public IActionResult Create()
		{
			return View();
		}

        [HttpPost]
        public IActionResult Create(Staff s)
        {
            DataBase.AddPerson(s);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var p = DataBase.GetPerson(id);
            return View(p);
        }

        [HttpPost]
        public IActionResult Edit(Staff s)
        {
            DataBase.Modify(s);
            return RedirectToAction("Index");
        }

		public IActionResult Delete(int id)
		{
			var p = DataBase.GetPerson(id);
			return View(p);
		}

		[HttpPost]
		public IActionResult Delete(Staff s)
		{
			DataBase.Delete(s);
			return RedirectToAction("Index");
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