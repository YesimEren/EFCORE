using Microsoft.AspNetCore.Mvc;

namespace EFCORE.Controllers
{
    public class Category : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
