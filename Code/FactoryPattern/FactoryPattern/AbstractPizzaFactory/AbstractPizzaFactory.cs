using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public abstract class AbstractPizzaFactory
    {
        public abstract IPizza CreateA();
        public abstract IPizza CreateB();
        public abstract IPizza CreateC();
        public abstract IPizza CreateD();
    }
}
