using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IGenericDal<T>where T : class // dışarıdan entity almam gerek.bunun için T dedim yalnız T değeri bir classa ait bütün nitelikleri kullanacak
    {
        void insert(T t);
        void Delete(T T);
        void Update(T t);
        List<T> getListAll(); 
        T GetById(int id);
    }
}
