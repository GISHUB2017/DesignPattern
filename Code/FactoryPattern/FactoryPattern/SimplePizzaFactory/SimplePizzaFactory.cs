using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    public class SimplePizzaFactory
    {
        public IPizza CreateIstance(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.A:
                    return new APizza();
                case PizzaType.B:
                    return new BPizza();
                case PizzaType.C:
                    return new CPizza();
                case PizzaType.D:
                    return new DPizza();
                default:
                    return null;
            }
        }
    }
    public enum PizzaType
    {
        A,
        B,
        C,
        D
    }
}
