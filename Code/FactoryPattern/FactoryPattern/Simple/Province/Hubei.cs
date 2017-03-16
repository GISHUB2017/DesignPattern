using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 湖北省
    /// </summary>
    public class Hubei : IProvince
    {
        public void City()
        {
            Console.WriteLine("湖北省省会是武汉市");
        }


        public void Describe()
        {
            throw new NotImplementedException();
        }
    }
}
