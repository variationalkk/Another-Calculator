using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppXiong
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //calculator = new Calculate();
            
            //新建Calculator 窗口
            Calculate calculator = new Calculate();
            //显示Calculator 窗口
            calculator.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            //新建Setting 窗口
            Setting setting = new Setting();
            //显示Setting窗口
            setting.Show();
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
