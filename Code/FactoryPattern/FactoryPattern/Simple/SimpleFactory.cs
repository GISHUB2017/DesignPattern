using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryPattern
{
    //***********************************************************
    /// <summary>
    /// 简单工厂
    /// </summary>
    public static class SimpleFactory
    {
        public static IRace CreateInstance(RaceType type)
        {
            switch(type)
            {
                case RaceType.Human:
                    return new Human();
                case RaceType.Orc:
                    return new Orc();
                case RaceType.Undead:
                    return new Undead();
                case RaceType.Night:
                    return new Nigth();
                default:
                    return new Human();
            }
        }
        
    }
    public enum RaceType
    {
        Human,
        Orc,
        Undead,
        Night
    }
}
