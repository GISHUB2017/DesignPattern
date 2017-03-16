using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class AnhuiFactory
    {
        public static IProvince CreateInstance()
        {
            return new Anhui();
        }
    }
}
