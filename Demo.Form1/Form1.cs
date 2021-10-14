using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click (object sender, EventArgs e)
        {
            string str = "我是小歆";
            string str2 = "哈哈";

            int number = 321;

            string str3 = str + str2 + number;

            str += str2;


            MessageBox.Show(str);

            
               
           
        }

        

        
    }
}
