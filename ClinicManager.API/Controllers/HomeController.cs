using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManager.API.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("{*catchall}")]
        public IActionResult Index()
        {
            return  File("index.html", "text/html");
        }
    }
}