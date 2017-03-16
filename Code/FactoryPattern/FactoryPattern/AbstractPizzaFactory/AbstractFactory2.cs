using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    public class AbstractFactory2 : AbstractPizzaFactory
    {
        public override IPizza CreateA()
        {
            Write();
            return new APizza();
        }

        public override IPizza CreateB()
        {
            Write();
            return new BPizza();
        }

        public override IPizza CreateC()
        {
            Write();
            return new CPizza();
        }

        public override IPizza CreateD()
        {
            Write();
            return new DPizza();
        }
        void Write()
        {
            Console.WriteLine("来自二号店:");
        }
    }
}
