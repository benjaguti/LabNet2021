using AppLinqQuerys.Data;
using AppLinqQuerys.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqQuerys.Logic
{
    public class CustomerLogic : BaseLogic
    {
        public List<Customers>getAll() 
        {
            return context.Customers.ToList();
        }


        public void ObjCustom() 
        {
            var query = from custom in context.Customers
                        select custom;
            Console.WriteLine("Consulta de un objeto Customer");
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName}" );
                break;
            }

        }

        public void CustomWhas() 
        {
            var query = from custom in context.Customers
                        where custom.Region == "WA"
                        select custom;

            Console.WriteLine("Consulta de Customers de Washington");
            try
            {
                if (query.Count() != 0)
                {
                    foreach (var item in query)
                    {
                        Console.WriteLine($"{item.CustomerID} - {item.CompanyName}");
                    }

                }
                else 
                {
                    Console.WriteLine("No existen Customers en Washington");
                }

            }
            catch (Exception)
            {
                throw;
            }


        }

        public void CustomMayMinus() 
        {
            var query = from custom in context.Customers
                        select custom;
            Console.WriteLine("Consulta de Customers en Mayuscula");
            Console.WriteLine();
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CompanyName.ToUpper()}");
            }
            Console.WriteLine();
            Console.WriteLine("Consulta de Customers en Minuscula");
            Console.WriteLine();

            foreach (var item in query)
            {
                Console.WriteLine($"{item.CompanyName.ToLower()}");
            }

        }

        public void CustomJoin() 
        {
            string fec = "1997/01/01";
            DateTime fecha = Convert.ToDateTime(fec);

            var query = from custom in context.Customers
                        join ord in context.Orders
                        on new{custom.CustomerID} equals
                        new {ord.CustomerID}
                        where custom.Region == "WA" &&
                        ord.OrderDate > fecha
                        select new {custom.CompanyName, custom.CustomerID};
            
            Console.WriteLine("Consulta de un objeto Customer");
           
            foreach (var item in query)
            {
                Console.WriteLine($"{item.CustomerID} - {item.CompanyName}");
            }
        }

    }
}
