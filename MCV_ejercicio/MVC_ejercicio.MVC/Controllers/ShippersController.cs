using MCV_ejercicio.Entities;
using MCV_ejercicio.Logic;
using MVC_ejercicio.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_ejercicio.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShipperLogic logic = new ShipperLogic();
        // GET: Shippers
        public ActionResult Index()
        {

            List<Shippers> shippers = logic.GetAll();

            List<ShippersView> shippersView = shippers.Select(s => new ShippersView
            {
                Id = s.ShipperID,
                CompanyName = s.CompanyName,
                PhoneNumber = s.Phone

            }).ToList();

            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShippersView shipView) 
        {
            try
            {
                Shippers shippersEntity = new Shippers { CompanyName = shipView.CompanyName, Phone= shipView.PhoneNumber};

                logic.Insert(shippersEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }
        } 

    }
}