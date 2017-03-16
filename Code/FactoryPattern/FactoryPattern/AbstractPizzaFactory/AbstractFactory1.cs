using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class AbstractFactory1 : AbstractPizzaFactory
    {
        public override IPizza CreateA()
        {
            return new APizza();
        }

        public override IPizza CreateB()
        {
            return new BPizza();
        }

        public override IPizza CreateC()
        {
            return new CPizza();
        }

        public override IPizza CreateD()
        {
            return new DPizza();
        }
    }
}
