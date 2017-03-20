using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    public interface Strategy
    {
        /**
        * 计算图书的价格
        * @param booksPrice 图书的原价
        * @return 计算出打折后的价格
        */
        double calcPrice(double booksPrice);
    }
}
