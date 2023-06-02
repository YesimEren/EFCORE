using Microsoft.AspNetCore.Mvc;

namespace EFCORE.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index() // blokların listelendğği sayfa
        {
            return View();
        }
    }
}
