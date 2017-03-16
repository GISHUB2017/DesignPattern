using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FactoryPattern
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 简单工厂模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSimple_Click(object sender, EventArgs e)
        {
            ////没有使用工厂模式时
            //Henan henan = new Henan();
            //henan.City();

            //Hubei hubei = new Hubei();
            //hubei.City();

            //Hebei hebei = new Hebei();
            //hebei.City();

            //Hunan hunan = new Hunan();
            //hunan.City();


            //简单工厂模式下
            IProvince province = SimpleFactory.CreateInstance(RaceType.Henan);
            province.City();

            Henan human = (Henan)SimpleFactory.CreateInstance(RaceType.Henan);
            human.City();
            Console.WriteLine("\r\n****************************************\r\n");

            //工厂方法模式
            IProvince henan = HenanFactory.CreateInstance();
            henan.City();

            IProvince anhui = AnhuiFactory.CreateInstance();
            anhui.City();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            //一家披萨店自由点餐
            APizza a = new APizza();
            a.Make();

            BPizza b = new BPizza();
            b.Make();

            CPizza c = new CPizza();
            c.Make();

            DPizza d = new DPizza();
            d.Make();

            //简单工厂模式
            SimplePizzaFactory simple = new SimplePizzaFactory();
            simple.CreateIstance(PizzaType.A).Make();
            simple.CreateIstance(PizzaType.B).Make();
            simple.CreateIstance(PizzaType.C).Make();
            simple.CreateIstance(PizzaType.D).Make();

            //工厂模式
            APizzaFactory apizzaF = new APizzaFactory();
            apizzaF.Create().Make();

            BPizzaFactory bpizzaF = new BPizzaFactory();
            bpizzaF.Create().Make();

            CPizzaFactory cpizzaF = new CPizzaFactory();
            cpizzaF.Create().Make();

            DPizzaFactory dpizzaF = new DPizzaFactory();
            dpizzaF.Create().Make();

            //抽象工厂
            AbstractFactory1 apf1 = new AbstractFactory1();//分厂1
            apf1.CreateA().Make();
            apf1.CreateB().Make();
            apf1.CreateC().Make();
            apf1.CreateD().Make();

            AbstractFactory2 apf2 = new AbstractFactory2();//分厂2
            apf2.CreateA().Make();
            apf2.CreateB().Make();
            apf2.CreateC().Make();
            apf2.CreateD().Make();
        }
    }
}
