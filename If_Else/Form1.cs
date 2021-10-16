using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace If_Else
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int level = 30;

            if (level > 30)
            {
                MessageBox.Show("你就是大師了吧!我有事情想要拜託你...!");
            }
            else if (level ==30)
            {
                MessageBox.Show("你30等了啊!再加把勁!");
            }
            else
            {
                MessageBox.Show("我對你一點興趣都沒有!");
            }
        }
    }
}
