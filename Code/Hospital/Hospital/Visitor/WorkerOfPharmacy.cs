using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class WorkerOfPharmacy:Visitor{

        public override void visitor(MedicineA a)
        {  
            Console.WriteLine("药房工作者：" + name + "拿药 ：" + a.getName());  
        }

        public override void visitor(MedicineB b)
        {
            Console.WriteLine("药房工作者：" + name + "拿药 ：" + b.getName());  
        }  
    }
}
