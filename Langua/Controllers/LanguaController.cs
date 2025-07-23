using Langua.Data;
using Langua.Models;
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

            var questions = _context.Questions.Where(q => q.TextId == text.Id).ToList();

            var viewModel = new TextWithQuestionsViewModel
            {
                Text = text,
                Questions = questions
            };

            return View(viewModel);
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Swedish()
        {
            var texts = _context.Texts
             .Where(t => t.Language.ToLower() == "swedish")
             .OrderBy(t => t.Level)
             .ThenBy(t => t.TextTitle)
             .ToList();

            return View(texts);
        }

        public IActionResult Polish()
        {
            var texts = _context.Texts
             .Where(t => t.Language.ToLower() == "polish")
             .OrderBy(t => t.Level)
             .ThenBy(t => t.TextTitle)
             .ToList();

            return View(texts);
        }

        public IActionResult Russian()
        {
            var texts = _context.Texts
            .Where(t => t.Language.ToLower() == "russian")
            .OrderBy(t => t.Level)
            .ThenBy(t => t.TextTitle)
            .ToList();

            return View(texts);
        }

    }
}
