using Kuari.Blog.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kuari.BlogMvcProject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _categoryService.GetAllAsync();
            return View(data);
        }
    }
}
