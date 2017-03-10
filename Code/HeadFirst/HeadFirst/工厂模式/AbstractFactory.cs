using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    /***************抽象工厂模式实例*********************/

    /// <summary>
    /// 抽象工厂
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    /// <summary>
    /// 抽象产品A
    /// </summary>
    public abstract class AbstractProductA
    {
        public abstract void Interact(AbstractProductB b);
    }
    
    /// <summary>
    /// 抽象产品B
    /// </summary>
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    /// <summary>
    /// 客户端
    /// </summary>
    public class Client
    {
        private AbstractProductA AbstractProductA;
        private AbstractProductB AbstractProductB;
        public Client(AbstractFactory factory)
        {
            AbstractProductA = factory.CreateProductA();
            AbstractProductB = factory.CreateProductB();
        }
        public void Run()
        {
            AbstractProductB.Interact(AbstractProductA);
            AbstractProductA.Interact(AbstractProductB);
        }
    }

    /// <summary>
    /// 具体产品A1
    /// </summary>
    public class ProductA1 : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(string.Format("我是产品{0}：我的产品内容为{1}",this.GetType().Name,b.GetType().Name));
        }
    }

    /// <summary>
    /// 具体产品B1
    /// </summary>
    public class ProductB1 :AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(string.Format("我是产品{0}：我的产品内容为{1}", this.GetType().Name, a.GetType().Name));
        }
    }

    public class ProductA2 : AbstractProductA
    {
        public override void Interact(AbstractProductB b)
        {
            Console.WriteLine(string.Format("我是产品{0}：我的产品内容为{1}", this.GetType().Name, b.GetType().Name));
        }
    }

    public class ProductB2 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(string.Format("我是产品{0}：我的产品内容为{1}", this.GetType().Name, a.GetType().Name));
        }
    }

    /// <summary>
    /// 具体工厂1
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    public class ConcreteFactory2 : AbstractFactory
    {

        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
