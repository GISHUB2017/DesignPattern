using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public abstract class Visitor
    {
        protected String name;

        public void setName(String name)
        {
            this.name = name;
        }


        public abstract void visitor(MedicineA a);

        public abstract void visitor(MedicineB b);
    } 
}
