using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class DPizzaFactory
    {
        public IPizza Create()
        {
            return new CPizza();
        }
    }
}
