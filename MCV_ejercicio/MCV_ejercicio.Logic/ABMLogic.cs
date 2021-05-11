using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCV_ejercicio.Logic
{
    interface ABMLogic<B>
    {
        List<B> GetAll();
        void Insert(B newCategories);
        void Delete(int id);
        void Update(B cat);
    }
}
