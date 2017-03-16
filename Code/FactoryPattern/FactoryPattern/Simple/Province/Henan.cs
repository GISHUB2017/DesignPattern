using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 河南省
    /// </summary>
    public class Henan : IProvince
    {
        public void City()
        {
            Console.WriteLine("河南省省会是郑州市");
        }


        public void Describe()
        {
            throw new NotImplementedException();
        }
    }
}
