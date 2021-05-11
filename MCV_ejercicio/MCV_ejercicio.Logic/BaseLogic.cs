using MCV_ejercicio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCV_ejercicio.Logic
{
    public class BaseLogic
    {

        protected readonly NorthwindContext context;

        public BaseLogic()
        {
            context = new NorthwindContext();
        }
        
    }
}
