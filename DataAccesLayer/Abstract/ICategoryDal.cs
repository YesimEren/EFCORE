using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICategoryDal :IGenericDal<Category>
        //4 temel method var 3 void olacal.ilki list oacak
    {
        //List<Category> ListAllCategory(); // categorynin tümünü getir.
        //void AddCategory(Category category);//geriye döndürmeyen değer olacağı için void olsun
        //void DeleteCategory(Category category);
        //void UpdateCategory(Category category);
        //// ıd göre de güncelleme silme yapılacak ve ıd göre veri getirlicel
        //Category GetById(int id); //---> Id ye göre getir veya al demek bu method.

    }
}
