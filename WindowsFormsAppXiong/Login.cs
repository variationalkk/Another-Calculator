﻿using System;
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
        //保存数据的元素实体，每个实体都是一种元素：
        public static TheElement ElementData_Cd = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_Pb = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_As = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_Cr = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_Hg = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_Cu = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_Zn = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        public static TheElement ElementData_Ni = new TheElement
        {
            PWater = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POrgano = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PPhosphorus = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PAir = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PChecken = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBull = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PBig = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            PMix = new string[2, 7] {
            {"5%","10%","25%","50%","75%","90%","95%" },
            {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } },
            POut = new string[2, 6] {
            {"北京","上海","广州","深圳","90%","95%" },
            {"0.1","0.25","0.5","0.75","0.9","0.95" } }
        };
        private string Usname = "Ad"+"m"+"inXi"+"ong", Password = "Xio"+"ng"+"Su"+"Y"+"a";


        //按键“计算”
        private void button1_Click(object sender, EventArgs e)
        {
            //calculator = new Calculate();
            
            //新建Calculator 窗口
            Calculate calculator = new Calculate();
            //显示Calculator 窗口
            calculator.Show();
            
           
            
        }
        //按键“设置”
        private void button2_Click(object sender, EventArgs e)
        {
            if (Username.Text == "" | Passwd.Text == "")
            {
                MessageBox.Show("请输入用户名和密码！");
            }
            else if (Username.Text == Usname && Passwd.Text == Password)
            {
                //新建Setting 窗口
                Setting setting = new Setting();
                //显示Setting窗口
                setting.Show();
            }
            else
            {
                MessageBox.Show("错误的用户名或密码！");
            }
            
        }

    }
}
namespace WindowsFormsAppXiong
{
    public class TheElement
    {
        public string[,] PWater;
        public string[,] POrgano;
        public string[,] PPhosphorus;
        public string[,] PAir;
        public string[,] PChecken;
        public string[,] PBull;
        public string[,] PBig;
        public string[,] PMix;
        public string[,] POut;

    }
    //元素类，其中存放每一种对应的比例值
    //public class TheElement
    //{
    //    public string[,] PWater= new string[2, 7] { 
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] POrgano = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] PPhosphorus = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] PAir = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] PChecken = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] PBull = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] PBig = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] PMix = new string[2, 7] {
    //        {"5%","10%","25%","50%","75%","90%","95%" },
    //        {"0.05","0.1","0.25","0.5","0.75","0.9","0.95" } };
    //    public string[,] POut = new string[2, 6] {
    //        {"北京","上海","广州","深圳","90%","95%" },
    //        {"0.1","0.25","0.5","0.75","0.9","0.95" } };

    //}
    //质量类，存放输入的质量
    public class TheQuality
    {
        float MWat;
        float MOrg;
        float MPho;
        float MAir;
        float MShi;

    }

    //蔬菜类 存放输出的参数部分
    public class Vegetable
    {
        float PH;
        float Org;
        float Area;
        float MVeg;
        //计算输出的元素量
        void Calculate()
        {
           
        }
    }

}