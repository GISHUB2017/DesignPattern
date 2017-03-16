using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 河南省工厂
    /// </summary>
    public class HenanFactory
    {
        public static IProvince CreateInstance()
        {
            Console.WriteLine("反射创建");
            return new Henan();
        }
    }
}
