using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index(string sendButton, string UserName)
        {
            if (sendButton!= null && UserName != null)
            {
                ViewData["Message"] = UserName;
                return View("HelloUserPage");
            }
            else if(sendButton != null && UserName == null)
            {
                return View("HelloAnonymousPage");
            }
            return View();
        }

    }
}
