using EjercicioEF.Entities;
using EjercicioEF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoriesLogic catLogic = new CategoriesLogic();

            catLogic.AddCategory(new Categories
            {
                CategoryID = 9,
                CategoryName = "Service",
                Description = "Brinda servicios generales",
                Picture = null

            });

            Console.ReadLine();

        }
    }
}
