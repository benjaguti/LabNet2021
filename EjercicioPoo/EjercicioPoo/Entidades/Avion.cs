﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo.Entidades
{
    public class Avion : Transporte
    {

        public Avion(string tipoTransporte,string nombre, int pasajeros) : base(tipoTransporte,nombre,pasajeros) 
        {

        }


        public override string Avanzar()
        {
            throw new NotImplementedException();
        }

        public override string Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
