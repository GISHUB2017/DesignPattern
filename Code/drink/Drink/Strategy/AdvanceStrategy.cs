using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    public class AdvanceStrategy : Strategy
    {
        public double calcPrice(double drinkPrice)
        {
            Console.WriteLine("对于高级会员的折扣为20%");
            return drinkPrice * 0.8;
        }
    }
}
