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

        public static void CustException() 
        {

            throw new CustomException("Error Controlado: ");
            
        }

        public static int MultiplicarPorQuince(this int numero) 
        {
            return numero * 15;
        }



    }
}
