using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Respositories
{
    public class CategoryRespositories : ICategoryDal
    {
        Context c = new Context(); //veritabanıuna yansıttığımız labloalrı biz contextte tuttuk.

        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
            
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category GetById(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategory() //geri dönen değer ister
        {
            return c.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();
        }
    }
}
