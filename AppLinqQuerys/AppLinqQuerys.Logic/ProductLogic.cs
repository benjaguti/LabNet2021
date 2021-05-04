using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqQuerys.Logic
{
    public class ProductLogic : BaseLogic
    {

        public void ProductSinStock() 
        {
            var query = context.Products.Where(m => m.UnitsInStock == 0).ToList();

            Console.WriteLine("Consulta para mostrar lista de productos sin stock");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }

        public void ProductConStock()
        {
            var query = context.Products.Where(m => m.UnitsInStock != 0 && m.UnitPrice > 3).ToList();

            Console.WriteLine("Consulta para mostrar lista de productos con stock y precio unitario mayor a 3");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName}");
            }
        }

        public void ProductId789()
        {
            var query = context.Products
                .Where(m => m.ProductID == 789).ToList();

            Console.WriteLine("Consulta para mostrar lista de productos con Id 789");
            try
            {
                if (query.Count() != 0)
                {
                    foreach (var item in query)
                    {
                        Console.WriteLine($"{item.ProductName}");
                        break;
                    }
                }
                else 
                {
                    Console.WriteLine("No existen elementos para Id: 789");
                }
                
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
