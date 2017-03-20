using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    public class NormalStrategy : Strategy
    {
        public double calcPrice(double drinkPrice)
        {
            // TODO Auto-generated method stub
            Console.WriteLine("对于一般人没有折扣");
            return drinkPrice;
        }
    }
}
