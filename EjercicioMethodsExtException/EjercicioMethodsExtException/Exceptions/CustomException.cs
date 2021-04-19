using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioMethodsExtException.Exceptions
{
    public class CustomException: Exception
    {
        public CustomException(string message) : base(message + "La excepcion fue controlada") 
        {

        }
    }
}
