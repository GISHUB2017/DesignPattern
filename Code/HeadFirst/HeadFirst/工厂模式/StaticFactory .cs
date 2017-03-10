using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    /***************工厂方法模式实例*********************/

    //抽象产品
    /// <summary>
    /// 汽车
    /// </summary>
    public abstract class Car
    {
        /// <summary>
        /// 名称
        /// </summary>
        private string Name;
        /// <summary>
        /// 功能
        /// </summary>
        public abstract void Drive();
        
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
    }
    
    //具体产品
    /// <summary>
    /// 宝马
    /// </summary>
    public class BWMCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("司机把品牌为：宝马，名字为：" + this.GetName() + "的车开走了");
        }
    }

    /// <summary>
    /// 奥迪
    /// </summary>
    public class AudiCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("司机把品牌为：奥迪，名字为：" + this.GetName() + "的车开走了");
        }
    }

    //抽象工厂
    /// <summary>
    /// 实现开车的功能
    /// </summary>
    public abstract class DriveFactory
    {
        public abstract Car CreateCar(string name); 
    }

    //具体工厂
    /// <summary>
    /// 宝马
    /// </summary>
    public class BMWFactory : DriveFactory
    {
        public override Car CreateCar(string name)
        {
            BWMCar car = new BWMCar();
            car.SetName(name);
            return car;
        }
    }

    /// <summary>
    /// 奥迪
    /// </summary>
    public class AudiFactory : DriveFactory
    {
        public override Car CreateCar(string name)
        {
            AudiCar car = new AudiCar();
            car.SetName(name);
            return car;
        }
    }
}
