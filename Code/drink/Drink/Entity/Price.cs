using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    public class Price
    {
        //持有一个具体的策略对象
        private Strategy strategy;
        /**
        * 构造函数，传入一个具体的策略对象
        * @param strategy 具体的策略对象
        */
        /**
        * 通过setPrice设置价格
        * @param strategy
        */

        public void setPrice(Strategy strategy)
        {
            this.strategy = strategy;
        }
        /**
        * 通过创建对象设置价格。
        * @param strategy
        */
        public Price(Strategy strategy)
        {
            this.strategy = strategy;
        }

        /**
        * 计算图书的价格
        * @param booksPrice 图书的原价
        * @return 计算出打折后的价格
        */
        public double quote(double drinkPrice)
        {
            return this.strategy.calcPrice(drinkPrice);
        }
    }
}
