using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HelloControllerDen : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public ActionResult ButtonClick(User user)
        {
            return View("HelloUserPage", user);
        }

    }
}
