using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class CategoriesLogic : BaseLogic, ABMLogic<Categories>
    {
        //El siguiente metodo realiza un insert a la base de datos
        
        public void Insert(Categories newCategories)
        {
            context.Categories.Add(newCategories);
            
            context.SaveChanges();
        }

        public void Delete(int id) 
        {
            var categoryDelete = context.Categories.Find(id);

            context.Categories.Remove(categoryDelete);
            
            context.SaveChanges();

        }

        public void Update(Categories cat) 
        {
            var catUpdate = context.Categories.Find(cat.CategoryID);
            
            catUpdate.Description = cat.Description;
            
            context.SaveChanges();
        }

    }



}
