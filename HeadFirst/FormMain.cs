using System;
using System.Windows.Forms;

namespace HeadFirst
{
    /// <summary>
    /// 主程序
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public FormMain()
        {
            InitializeComponent();

        }

        /// <summary>
        /// 生成器模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuilde_Click(object sender, System.EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n生成器模式测试结果：\r\n");
            Director d = new Director(new BigHouseBuilder());
            House h = d.CreateHouse();
            Console.WriteLine(string.Format("{0}\r\n{1}\r\n{2}",h.Door,h.Wall,h.Windows));
            h.GetResult("厂房");
            Console.WriteLine("\r\n");
            d = new Director(new SmallHouseBuilder());
            h = d.CreateHouse();
            Console.WriteLine(string.Format("{0}\r\n{1}\r\n{2}", h.Door, h.Wall, h.Windows));
            h.GetResult("家庭住宅");
        }

        /// <summary>
        /// 工厂方法模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDrive_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\r\n工厂方法模式测试结果：\r\n");
            DriveFactory d = new BMWFactory();
            Car c = d.CreateCar("001");
            c.Drive();
            Console.WriteLine("\r\n");
            DriveFactory d1 = new AudiFactory();
            Car c1 = d1.CreateCar("002");
            c1.Drive();  
        }

        /// <summary>
        /// 抽象方法模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbstract_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\r\n抽象工厂模式测试结果：\r\nB这个人：");
            ClientTest client1 = new ClientTest(new PeopleA());
            client1.Run();
            Console.WriteLine("\r\nA这个人：");
            ClientTest client2 = new ClientTest(new PeopleB());
            client2.Run();
        }
    }
}
