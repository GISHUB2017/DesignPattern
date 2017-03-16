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
    }
}
