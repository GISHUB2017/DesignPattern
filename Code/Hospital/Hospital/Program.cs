using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine a = new MedicineA("板蓝根", 11.0);  
            Medicine b = new MedicineB("感康", 14.3);  
          
            Presciption presciption = new Presciption();  
            presciption.addMedicine(a);  
            presciption.addMedicine(b);  
          
            Visitor charger = new Charger();  
            charger.setName("张三");  
          
            Visitor workerOfPharmacy = new WorkerOfPharmacy();  
            workerOfPharmacy.setName("李四");  
          
            presciption.accept(charger);  
            Console.WriteLine("-------------------------------------");  
            presciption.accept(workerOfPharmacy);

            Console.ReadLine();
        }
    }
}
