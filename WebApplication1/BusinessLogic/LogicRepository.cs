using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class LogicRepository<T> : ILogicRepository<T>
    {
       

        protected LogicRepository()
        {
           
        }

     
        public abstract T GetOrganisation();

       
    }
}
