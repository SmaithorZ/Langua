using Microsoft.AspNetCore.Mvc;

namespace Langua.Controllers
{
    public class LanguaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
