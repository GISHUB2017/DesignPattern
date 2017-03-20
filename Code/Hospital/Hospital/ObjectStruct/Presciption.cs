using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Presciption
    {
        List<Medicine> list = new List<Medicine>();

        public void accept(Visitor visitor)
        {
            IEnumerator<Medicine> iterator = list.GetEnumerator();

            while (iterator.MoveNext())
            {
                iterator.Current.accept(visitor);
            }
        }

        public void addMedicine(Medicine medicine)
        {
            list.Add(medicine);
        }

        public void removeMedicien(Medicine medicine)
        {
            list.Remove(medicine);
        }  
    }
}
