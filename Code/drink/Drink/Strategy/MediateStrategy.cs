using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    public class MediateStrategy : Strategy
    {
        public double calcPrice(double drinkPrice) 
        {
            Console.WriteLine("对于中级会员的折扣为10%");
            return drinkPrice * 0.9;
        }
    }
}
