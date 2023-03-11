using Microsoft.AspNetCore.Mvc;

namespace Kuari.BlogMvcProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
