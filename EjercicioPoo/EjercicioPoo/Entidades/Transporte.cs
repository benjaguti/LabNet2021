using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo.Entidades
{
    public abstract class Transporte
    {
        private int pasajeros;
        private string nombre;
        private string tipoTransporte;

        public Transporte(string tipoTransporte,string nombre, int cantPasajeros) 
        {
            this.tipoTransporte = tipoTransporte;
            this.nombre = nombre; 
            this.pasajeros = cantPasajeros;
        }
        public string TipoTransporte
        {
            get => tipoTransporte;
            set => tipoTransporte = value;
        }
        public string Nombre 
        {
            get => nombre;
            set => nombre = value;
        }

        public int Pasajeros
        {
            get => pasajeros;
            set => pasajeros = value;

        }

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
