using Microsoft.AspNetCore.Mvc;

namespace WordDictionary.Controllers
{
    public class WordDictionary : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        
    }
}