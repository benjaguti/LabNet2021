using AppLinqQuerys.Data;
using AppLinqQuerys.Entities;
using AppLinqQuerys.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqQuerys.UI
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerLogic queryCu = new CustomerLogic();

            ProductLogic queryPr = new ProductLogic();
            int op = -1;
            Console.WriteLine("1.Query para devolver objeto customer");
            Console.WriteLine("2.Query para devolver todos los productos sin stock");
            Console.WriteLine("3.Query para devolver todos los productos que tienen stock y que cuestan más de 3 por unidad");
            Console.WriteLine("4.Query para devolver todos los customers de Washington");
            Console.WriteLine("5.Query para devolver el primer elemento o nulo de una lista de productos donde el ID de producto sea igual a 789");
            Console.WriteLine("6.Query para devolver los nombre de los Customers.Mostrarlos en Mayuscula y en Minuscula.");
            Console.WriteLine("7.Query para devolver Join entre Customers y Orders donde los customers sean de Washington y la fecha de orden sea mayor a 1 / 1 / 1997.");
            Console.WriteLine("Ingrese 0 para salir");
            Console.WriteLine("Ingrese numero de consulta a realizar");
            op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        queryCu.ObjCustom();
                        break;
                    case 2:
                        queryPr.ProductSinStock();
                        break;
                    case 3:
                        queryPr.ProductConStock();
                        break;
                    case 4:
                        queryCu.CustomWhas();
                        break;
                    case 5:
                        queryPr.ProductId789();
                        break;
                    case 6:
                        queryCu.CustomMayMinus();
                        break;
                    case 7:
                        queryCu.CustomJoin();
                        break;
                    default:
                        Console.WriteLine("Digite un opción válida");
                        break;
                }
                Console.ReadKey();
                
            } while (op == 0);
            
            Console.ReadLine();


        }


    }
}
