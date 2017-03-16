using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 湖南省
    /// </summary>
    public class Hunan : IProvince
    {
        public void City()
        {
            Console.WriteLine("湖南省的省会是长沙");
        }


        public void Describe()
        {
            throw new NotImplementedException();
        }
    }
}
