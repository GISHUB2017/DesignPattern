using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    /*****************************简单工厂模式******************************
     * 优点：
     * 1、解除了Model与Control之间的耦合度
     * 
     * 
     * 缺点：
     * 1、工厂内部是高度耦合的
     * 2、工厂不稳定、违反了单一职责
     * 3、不符合开闭原则，对扩展开放，对修改封闭
     * 综合来说：只是把耦合度增加了
    */
    /// <summary>
    /// 简单工厂
    /// </summary>
    public static class SimpleFactory
    {
        /// <summary>
        /// 创建实例
        /// </summary>
        /// <param name="type">实例类型</param>
        /// <returns></returns>
        public static IProvince CreateInstance(RaceType type)
        {
            switch(type)
            {
                case RaceType.Henan:
                    return new Henan();
                case RaceType.Hunan:
                    return new Hunan();
                case RaceType.Hebei:
                    return new Hebei();
                case RaceType.Hubei:
                    return new Hubei();
                default:
                    return new Henan();
            }
        }
        
    }
    
    /// <summary>
    ///省份类型 
    /// </summary>
    public enum RaceType
    {
        Henan,
        Hunan,
        Hebei,
        Hubei
    }
}
