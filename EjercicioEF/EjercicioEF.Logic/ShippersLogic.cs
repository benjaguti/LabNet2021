using EjercicioEF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    public class ShippersLogic : BaseLogic, ABMLogic<Shippers>
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

        public void Update(Shippers ship)
        {
            var shipUpdate = context.Shippers.Find(ship.ShipperID);

            shipUpdate.Phone = ship.Phone;

            context.SaveChanges();
        }


    }
}
