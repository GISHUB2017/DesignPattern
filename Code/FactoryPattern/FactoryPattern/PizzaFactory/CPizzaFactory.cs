using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    class CPizzaFactory
    {
        public IPizza Create()
        {
            return new CPizza();
        }
    }
}
