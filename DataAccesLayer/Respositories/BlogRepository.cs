using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Respositories
{
    public class BlogRepository : IBlogDal

    {
        Context a = new Context();
        public void AddBlog(Blog blog)
        {
            a.Add(blog);
            a.SaveChanges();
        }

        public void DeleteBlog(Blog blog)
        {
            a.Remove(blog);
            a.SaveChanges();
        }

        public Blog GetById(int id)
        {
            return a.Blogs.Find(id);
        }

        public List<Blog> ListAllBlog()
        {
            return a.Blogs.ToList();
        }

        public void UpdateBlog(Blog blog)
        {
            a.Update(blog);
            a.SaveChanges();
        }
    }
}
