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

        private void btnSimple_Click(object sender, EventArgs e)
        {
            IRace race = SimpleFactory.CreateInstance(RaceType.Human);
            race.ShowKing();

            Console.WriteLine("****************************************");

            Human human = (Human)SimpleFactory.CreateInstance(RaceType.Human);
            human.ShowKing();
        }
    }
}
