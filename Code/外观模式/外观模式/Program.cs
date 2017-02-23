using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade.MovieFacade movie = new Facade.MovieFacade();
            Facade.Projector projector = new Facade.Projector();

            //首先是观看电影 
            movie.OpenMovie();
            Console.WriteLine();

            //然后是将投影仪模式调到宽屏模式 
            projector.SetWideScreen();
            //再将投影仪模式调回普通模式 
            projector.SetStandardScreen();
            Console.WriteLine();

            //最后就是关闭电影了 
            movie.CloseMovie();
            Console.ReadKey();


        }
    }
      
      
    



}

namespace Facade
{
    public class Projector
    {
        public void OpenProjector()
        {
            Console.WriteLine("打开投影仪");
        }
        public void CloseProjector()
        {
            Console.WriteLine("关闭投影仪");
        }
        public void SetWideScreen()
        {
            Console.WriteLine("投影仪状态为宽屏模式");
        }
        public void SetStandardScreen()
        {
            Console.WriteLine("投影仪状态为标准模式");
        }
    }

    public class Amplifier
    {
        public void OpenAmplifier()
        {
            Console.WriteLine("打开功放机");
        }
        public void CloseAmplifier()
        {
            Console.WriteLine("关闭功放机");
        }
    }

    public class Screen
    {
        public void OpenScreen()
        {
            Console.WriteLine("打开屏幕");
        }
        public void CloseScreen()
        {
            Console.WriteLine("关闭屏幕");
        }
    }

    public class DVDPlayer
    {
        public void OpenDVDPlayer()
        {
            Console.WriteLine("打开 DVD 播放器");
        }
        public void CloseDVDPlayer()
        {
            Console.WriteLine("关闭 DVD 播放器");
        }
    }

    public class Light
    {
        public void OpenLight()
        {
            Console.WriteLine("打开灯光");
        }
        public void CloseLight()
        {
            Console.WriteLine("关闭灯光");
        }
    }

    public class MovieFacade
    {
        /// <summary> 
        /// 在外观类中必须保存有子系统中各个对象 
        /// </summary> 
        private Projector projector;
        private Amplifier amplifier;
        private Screen screen;
        private DVDPlayer dvdPlayer;
        private Light light;
        public MovieFacade()
        {
            projector = new Projector();
            amplifier = new Amplifier();
            screen = new Screen();
            dvdPlayer = new DVDPlayer();
            light = new Light();
        }
        /// <summary> 
        /// 打开电影 
        /// </summary> 
        public void OpenMovie()
        {
            //先打开投影仪 
            projector.OpenProjector();
            //再打开功放 
            amplifier.OpenAmplifier();
            //再打开屏幕 
            screen.OpenScreen();
            //再打开 DVD 
            dvdPlayer.OpenDVDPlayer();
            //再打开灯光 
            light.OpenLight();
        }
        /// <summary> 
        /// 关闭电影 
        /// </summary> 
        public void CloseMovie()
        {
            //关闭投影仪 
            projector.CloseProjector();
            //关闭功放 
            amplifier.CloseAmplifier();
            //关闭屏幕 
            screen.CloseScreen();
            //关闭 DVD 
            dvdPlayer.CloseDVDPlayer();
            //关闭灯光 
            light.CloseLight();
        }
    }
}

