using System;
using Microsoft.AspNetCore.Mvc;

namespace AdrianRossing.Ui.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            ViewData["Message"] = "Adrian's blog!";

            return View();
        }

    }
}
