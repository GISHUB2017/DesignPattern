using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    /***************建造者模式实例*********************/

    /// <summary>
    /// 构造器 -- (Builder)为创建一个产品对象的各个部件指定抽象接口。
    /// </summary>
    public abstract class Builder
    {
        protected House house = new House();
        public abstract void BuildWall();
        public abstract void BuildDoor();
        public abstract void BuildWindows();
        public House GetResult()
        {
            return house;
        }
    }

    /// <summary>
    /// 房子 -- (Product)表示被构造的复杂对象。ConcreteBuilder创建该产品的内部表示并定义它的装配过程，
    /// 包含定义组成部件的类，包括将这些部件装配成最终产品的接口。
    /// </summary>
    public class House
    {
        public string Door;
        public string Windows;
        public string Wall;

        public void BuildDoor(string door)
        {
            this.Door = door;
        }

        public void BuildWindows(string windows)
        {
            this.Windows = windows;
        }

        public void BuildeWall(string wall)
        {
            this.Wall = wall;
        }

        public void GetResult(string Name)
        {
            Console.WriteLine(Name + "——建造完成");
        }
    }

    /// <summary>
    /// 构筑大房子  -- (ConcreteBuilder)实现Builder的接口以构造和装配该产品的各个部件，
    /// 定义并明确它所创建的表示，并提供一个检索产品的接口。
    /// </summary>
    public class BigHouseBuilder : Builder
    {
        public override void BuildWall()
        {
            house.BuildeWall("墙高8m,厚度50cm");
        }

        public override void BuildDoor()
        {
            house.BuildDoor("门高5m，宽5m");
        }

        public override void BuildWindows()
        {
            house.BuildWindows("落地窗");
        }
    }

    /// <summary>
    /// 构筑小房子
    /// </summary>
    public class SmallHouseBuilder : Builder
    {
        public override void BuildWall()
        {
            house.BuildeWall("墙高3m,厚度30cm");
        }

        public override void BuildDoor()
        {
            house.BuildDoor("门高2m,宽1.5m");
        }

        public override void BuildWindows()
        {
            house.BuildWindows("飘窗");
        }
    }
   
    /// <summary>
    /// 创建房子工厂 -- (Director)构造一个使用Builder接口的对象。
    /// </summary>
    public class Director
    {
        public Builder builder;
        public Director(Builder builder)
        {
            this.builder = builder;
        }
        public House CreateHouse()
        {
            this.builder.BuildDoor();
            this.builder.BuildWall();
            this.builder.BuildWindows();
            return this.builder.GetResult();
        }
    }
}
