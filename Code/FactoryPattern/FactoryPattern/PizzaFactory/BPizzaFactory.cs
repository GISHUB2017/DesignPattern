using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class BPizzaFactory
    {
        public IPizza Create()
        {
            return new BPizza();
        }
    }
}
