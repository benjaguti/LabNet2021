using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMethodsExtException.Exceptions
{
    public class CustomException: Exception
    {
        //Se realiza el constructor de la excepcion propia, se envia un mensaje por parametro mas un
        //mensaje preestablecido concatenado
        public CustomException(string message) : base(message + "La excepcion fue controlada") 
        {

        }
    }
}
