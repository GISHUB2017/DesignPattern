using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Charger:Visitor
    {
        public override void visitor(MedicineA a)
        {  
            Console.WriteLine("划价员：" + name +"给药" + a.getName() +"划价:" + a.getPrice());  
        }

        public override void visitor(MedicineB b)
        {
            Console.WriteLine("划价员：" + name + "给药" + b.getName() + "划价:" + b.getPrice());  
        }  
    }
}
