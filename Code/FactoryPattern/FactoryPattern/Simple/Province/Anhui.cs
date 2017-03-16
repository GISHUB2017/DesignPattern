using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class Anhui:IProvince
    {
        public void City()
        {
            Console.WriteLine("安徽省的省会是合肥");
        }

        public void Describe()
        {
            throw new NotImplementedException();
        }
    }
}
