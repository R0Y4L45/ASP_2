using ASP_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace ASP_2.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ViewResult ViewResult(FileViewModel fm)
        {
            return View(fm);
        }
        public PartialViewResult Name()
        {
            return PartialView("_SecondView");
        }
        public ContentResult Content()
        {
            return Content("<script> alert('Hi! I am Dev') </script>", "text/html");
        }
        public FileResult FileResult()
        {
            return File("~/New Text Document.txt", "text/plain");
        }
        public JsonResult JsonResult()
        {
            string s = "{Id: 1, Name: test1, Surname: test2, Age: 12}";
            var json = JsonSerializer.Serialize(s);
            return Json(json);   
        }
    }
}