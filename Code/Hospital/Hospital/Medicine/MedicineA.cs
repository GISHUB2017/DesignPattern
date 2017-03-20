using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class MedicineA : Medicine
    {
         public MedicineA(String name, double price)
            : base(name, price)
        {
        }

         public override void accept(Visitor visitor)
        {
            visitor.visitor(this);
        }
    }
}
