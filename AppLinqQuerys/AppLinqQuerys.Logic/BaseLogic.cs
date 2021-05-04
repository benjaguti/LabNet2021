using AppLinqQuerys.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLinqQuerys.Logic
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
