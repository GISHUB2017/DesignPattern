using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class APizza : IPizza
    {
        public void Make()
        {
            Console.WriteLine("A种口味的披萨，配料包括：面粉，白糖,奶酪等...");
        }
    }
}
