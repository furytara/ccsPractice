using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace menuapp.Controllers
{
    public class VocabularyController: Controller
    {
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult TwitterWidget()
        {
            return View();
        }

        public IActionResult ArticleNewsCard()
        {
            return View();
        }

        public IActionResult SimpleFlatMenu()
        {
            return View();
        }
    }    
}