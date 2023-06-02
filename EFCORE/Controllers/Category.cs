using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EFCORE.Controllers
{
    public class Category : Controller // Burada Kategory sınıfından değer türeteceğiz
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository()); // bütün methodlara erişim sağlayacağım
        

        public IActionResult Index() 
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
 