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

        //Looks up a text by language, level and slug and passes it to the ReadText view
        [Route("{language}/{level}/{slug}")]
        public IActionResult ReadText(string language, string level, string slug)
        {
            var text = _context.Texts.FirstOrDefault(t =>
            t.Language.ToLower() == language.ToLower() &&
            t.Level.ToLower() == level.ToLower() &&
            t.Slug == slug.ToLower());

            if(text == null)
            {
                return NotFound();
            }

            return View("ReadText",text);
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Swedish()
        {
            var swedishTexts = _context.Texts
                .Where(t => t.Language.ToLower() == "swedish")
                .ToList();

            return View(swedishTexts);
        }

        public IActionResult Polish()
        {
            var polishTexts = _context.Texts
                .Where(t => t.Language.ToLower() == "polish")
                .ToList();

            return View(polishTexts);
        }

        public IActionResult Russian()
        {
            var russianTexts = _context.Texts
                .Where(t => t.Language.ToLower() == "russian")
                .ToList();

            return View(russianTexts);
        }

    }
}
