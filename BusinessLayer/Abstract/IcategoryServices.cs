using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IcategoryServices
    {
        void CategoryAdd(Category category);
       void CategoryRemove(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetList();
        Category GetById(int id);   

    }
}
