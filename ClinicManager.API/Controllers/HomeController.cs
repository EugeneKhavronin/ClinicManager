using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ClinicManager.API.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet]
        [Route("{*catchall}")]
        public async Task<IActionResult> Index()
        {
            return  View();
        }
    }
}