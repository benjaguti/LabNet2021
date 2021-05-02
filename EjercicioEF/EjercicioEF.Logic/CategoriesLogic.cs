using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class CategoriesLogic : BaseLogic
    {
        //El siguiente metodo realiza un insert a la base de datos
        public void AddCategory(Categories newCategories)
        {
            context.Categories.Add(newCategories);
            context.SaveChanges();
        }

        public void DeleteCategory(int id) 
        {
            var categoryDelete = context.Categories.First(r => r.CategoryID == id);

        }

    }



}
