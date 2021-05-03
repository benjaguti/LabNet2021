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
        
        //Genera una lista de todo lo que contiene la tabla y la pasa a Lista
        public List<Categories> GetAll() 
        {
            return context.Categories.ToList();
        }
        //El siguiente metodo realiza un insert a la base de datos, se pasa por parametro la nueva categoria
        public void Insert(Categories newCategories)
        {
            context.Categories.Add(newCategories);
            
            context.SaveChanges();
        }

        //El sisguiente metodo elimina un elemento a traves de un id
        public void Delete(int id) 
        {
            var categoryDelete = context.Categories.Find(id);

            context.Categories.Remove(categoryDelete);
            
            context.SaveChanges();

        }


        //El siguiente metodo actualiza una fila ya creada
        public void Update(Categories cat) 
        {
            var catUpdate = context.Categories.Find(cat.CategoryID);
            
            catUpdate.Description = cat.Description;
            
            context.SaveChanges();
        }

    }



}
