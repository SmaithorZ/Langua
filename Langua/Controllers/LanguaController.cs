using Langua.Data;
using Microsoft.AspNetCore.Mvc;

namespace Langua.Controllers
{
    public class LanguaController : Controller
    {

        private readonly AppDbContext _context;

        public LanguaController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Swedish()
        {
            return View();
        }

        public IActionResult Polish()
        {
            return View();
        }

        public IActionResult Russian()
        {
            return View();
        }

    }
}
