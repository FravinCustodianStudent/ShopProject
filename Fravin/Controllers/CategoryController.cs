using Microsoft.AspNetCore.Mvc;

namespace Fravin.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
