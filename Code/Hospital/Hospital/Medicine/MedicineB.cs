using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class MedicineB : Medicine
    {
        public MedicineB(String name, double price)
            : base(name, price)
        {
        }

        public override void accept(Visitor visitor)
        {
            visitor.visitor(this);
        }
    }
}
