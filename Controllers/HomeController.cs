

namespace gorillaspace.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using gorillaspace.Models;
    using Microsoft.AspNetCore.Mvc;
    public class HomeController : Controller
    {
        private readonly ToDoItemController _todoController;

        public HomeController(ToDoItemController todoController)
        {
            _todoController = todoController;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
