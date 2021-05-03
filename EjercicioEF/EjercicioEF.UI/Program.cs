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

            //Instanciacion de las clases
            CategoriesLogic catLogic = new CategoriesLogic();
            
            ShippersLogic ship = new ShippersLogic();

            // Consultas simples:
            Console.WriteLine("Mostrar Lista de Categorias Existentes");
            
            Console.WriteLine();

            foreach (var item in catLogic.GetAll())
            {
            
                Console.WriteLine($" {item.CategoryName} ");
            
            }

            Console.WriteLine("Mostrar Lista de Shippers existentes con el numero de contacto:");
            
            Console.WriteLine();
            
            foreach (var item in ship.GetAll())
            {
            
                Console.WriteLine($" {item.CompanyName} | {item.Phone} ");
            
            }

            // Ingreso de datos para insertar una nueva CAtegoria

            Console.WriteLine("Inserte una nueva Categoria:");
            
            Console.WriteLine("\nIngrese el nombre de la nueva categoria: ");
            
            string catName = Console.ReadLine();
            
            Console.WriteLine("\nIngrese la descripcion de la nueva categoria: ");
            
            string catdesc = Console.ReadLine();
            
            //************************** Inserta categoria**************************************
            
            catLogic.Insert(new Categories
            {
                CategoryID = 30,
                
                CategoryName = catName,
                
                Description = catdesc,
                
                Picture = null

            });
            
            //VAlidaciones previas antes de Eliminar una Categoria

            int idc = -1;
            
            //Consulta cantidad de Categorias
            
            int count = catLogic.GetAll().Count();
            
            Console.WriteLine("Ingrese el Id de la categoria a eliminar");

            do
            {
                Console.WriteLine($"Recordar que la cantidad de Id es hasta {count}");
                
                idc = int.Parse(Console.ReadLine());
            } while (idc > count
            
            || idc < 1);
            
            //************************** Elimina por id Categoria*************************************

            catLogic.Delete(idc);

            //Validaciones previas antes de Actualizar una categoria

            Console.WriteLine("Actualizar la descripcion de una Categoria existente");
            
            do
            {
                Console.WriteLine($"Recordar que la cantidad de Id es hasta {count}");
                
                Console.WriteLine("\nIngrese Id de categoria");
                
                idc = int.Parse(Console.ReadLine());
            } while (idc > count
            
            || idc < 1);
            
            Console.WriteLine("\nIngrese la descripcion de la categoria: ");
            
            string descCat = Console.ReadLine();

            //************************** Actualiza una categoria **************************************
            
            catLogic.Update(new Categories
            {
                Description = descCat,
            
                CategoryID = idc

            });

            // ingreso de datos antes de insertar un nuevo Shippers

            Console.WriteLine("Inserte un nuevo Shippers:");
            
            Console.WriteLine("\nIngrese el nombre del nuevo Shippers: ");
            
            string shipName = Console.ReadLine();
            
            Console.WriteLine("\nIngrese el numero de contacto: ");
            
            string shipPhone = Console.ReadLine();
            
            //************************** Inserta un Shippers ******************************************
            
            ship.Insert(new Shippers
            {
                ShipperID = 24,
            
                CompanyName = shipName,
                
                Phone = shipPhone

            });

            // Validaciones previas al Eliminar un Shippers

            int ids = -1;
            
            //Consulta cantidad de Shippers
            
            int countShip = ship.GetAll().Count();
            
            Console.WriteLine("Ingrese el Id de Shippers a eliminar");
            
            do
            {
                Console.WriteLine($"Recordar que la cantidad de Id es hasta {countShip}");
            
                ids = int.Parse(Console.ReadLine());
            } while (ids > count
            || ids < 1);
            //************************** Elimina un Shippers ******************************************

            ship.Delete(ids);

            // Validaciones previas al actualizar
            
            Console.WriteLine("Actualizar la descripcion de un Shippers existente");
            
            do
            {
                Console.WriteLine($"Recordar que la cantidad de Id es hasta {countShip}");

                Console.WriteLine("\nIngrese Id de Shippers");

                ids = int.Parse(Console.ReadLine());
            } while (ids > count
            || idc < 1);
            
            Console.WriteLine("\nIngrese el numero de contacto nuevo: ");
            
            string contactPhone = Console.ReadLine();


            //************************** Actualiza un Shippers ******************************************
            ship.Update(new Shippers
            {
                ShipperID = ids,
            
                Phone = contactPhone
            }) ;
        }
    }
}
