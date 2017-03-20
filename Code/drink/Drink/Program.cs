using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            //选择并创建需要使用的策略对象
            Strategy strategy = new MediateStrategy();
            //创建环境
            Price price = new Price(strategy);
            //计算价格
            double quote = price.quote(300);
            Console.WriteLine("图书的最终价格为：" + quote);


            //选择并创建需要使用的策略对象
            Strategy strategy1 = new AdvanceStrategy();
            //创建环境
            Price price1 = new Price(strategy1);
            //计算价格
            double quote1 = price1.quote(300);
            Console.WriteLine("图书的最终价格为：" + quote1);


            Console.ReadLine();
        }
    }
}
