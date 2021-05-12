using MCV_ejercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCV_ejercicio.Logic
{
    public class ShipperLogic: BaseLogic, ABMLogic<Shippers>
    {
        public void Delete(int id)
        {
            var shippersDelete = context.Shippers.Find(id);

            context.Shippers.Remove(shippersDelete);

            context.SaveChanges();
        }



        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Insert(Shippers newShip)
        {
            context.Shippers.Add(newShip);

            context.SaveChanges();
        }

        public Shippers Obtener(int id) 
        {
            var shipUpdate = context.Shippers.Find(id);
            return shipUpdate;
        }
        public void Update(Shippers ship)
        {
            var shipUpdate = context.Shippers.Find(ship.ShipperID);

            shipUpdate.CompanyName = ship.CompanyName;
            shipUpdate.Phone = ship.Phone;


            context.SaveChanges();
        }

    }
}
