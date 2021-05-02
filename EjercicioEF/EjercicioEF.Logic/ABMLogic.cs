using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEF.Logic
{
    interface ABMLogic<B>
    {
        void Insert(B newCategories);
        void Delete(int id);
        void Update(B cat);


    }
}
