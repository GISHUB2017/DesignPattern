using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 河北省
    /// </summary>
    public class Hebei : IProvince
    {
        public void City()
        {
            Console.WriteLine("河北省的省会是石家庄");
        }


        public void Describe()
        {
            throw new NotImplementedException();
        }
    }
}
