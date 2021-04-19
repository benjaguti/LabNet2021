using EjercicioMethodsExtException.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMethodsExtException.Entidades
{
    public static class Logic
    {

        //Metodo CustException instancia la clase CustomException y es asigna un ma¿ensaje string como parametro
        public static void CustException() 
        {

            throw new CustomException("Error Controlado: ");
            
        }

        //MultiplicarPorQuince agarra un valor int y devuelve el valor multiplicado por quince
        public static int MultiplicarPorQuince(this int numero) 
        {
            return numero * 15;
        }



    }
}
