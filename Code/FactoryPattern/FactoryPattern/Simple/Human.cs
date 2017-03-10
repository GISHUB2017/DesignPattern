using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class Human:IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("人皇是我");
        }
    }
}
