using Microsoft.AspNetCore.Mvc;

namespace ClinicManager.API.Controllers
{
    /// <summary>
    ///  Класс HomeController
    /// </summary>
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("{*catchall}")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }
    }
}