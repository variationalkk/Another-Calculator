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
    public partial class Calculate : Form
    {
        public Calculate()
        {
            InitializeComponent();
        }
        //本页面的元素对象；
        public TheElement ElementCal ;
        //输入部分需要计算的的参数
        public double Cal_PWa, Cal_POrg, Cal_PPho, Cal_PAir, Cal_PShi, Cal_In;
        public string [,] ShitType = new string[2,7];
        public double Cal_Mwa, Cal_Morg, Cal_Mpho, Cal_Mair, Cal_Mshi;
        //输出部分需要的参数：
        public double PH_value, Org_value, Area_value, Mvege_value, Out_value,Left_value;
        public double Alpha1=0.1, Alpha2=0.2, Alpha3=0.3,N_oflog=4;

        
        //--------粪肥的选择----------------
        //选择猪粪
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           ShitType = ElementCal.PBig;
        }

        //选择堆肥
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ShitType = ElementCal.PMix;
        }

        //选择牛粪
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ShitType = ElementCal.PBull;
        }

        //选择鸡粪
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ShitType = ElementCal.PChecken;
        }

        //-------------输入各种质量-------------------
        
        //水的质量
        private void Mwa_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(Mwa.Text) == true)
            {
                Cal_Mwa = double.Parse(Mwa.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //有机肥的质量
        private void MOr_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(MOr.Text) == true)
            {
                Cal_Morg = double.Parse(MOr.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }
        
        //磷肥的质量
        private void MPh_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(MPh.Text) == true)
            {
                Cal_Mpho = double.Parse(MPh.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }
        
        //大气沉降质量
        private void MAi_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(MAi.Text) == true)
            {
                Cal_Mair = double.Parse(MAi.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //粪肥的质量
        private void MSh_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(MSh.Text)==true )
            {
                Cal_Mshi = double.Parse(MSh.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }


        //----------------各种比例---------------------

        //有机物的比例
        private void POr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (POr.Text)
            {
                case "5%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 0]);
                    break;
                case "10%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 1]);
                    break;
                case "25%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 2]);
                    break;
                case "50%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 3]);
                    break;
                case "75%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 4]);
                    break;
                case "90%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 5]);
                    break;
                case "95%":
                    Cal_POrg = double.Parse(ElementCal.POrgano[1, 6]);
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        //磷肥的比例
        private void PPh_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PPh.Text)
            {
                case "5%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 0]);
                    break;
                case "10%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 1]);
                    break;
                case "25%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 2]);
                    break;
                case "50%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 3]);
                    break;
                case "75%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 4]);
                    break;
                case "90%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 5]);
                    break;
                case "95%":
                    Cal_PPho = double.Parse(ElementCal.PPhosphorus[1, 6]);
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }
        
        //大气沉降的比例
        private void PAi_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PAi.Text)
            {
                case "5%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 0]);
                    break;
                case "10%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 1]);
                    break;
                case "25%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 2]);
                    break;
                case "50%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 3]);
                    break;
                case "75%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 4]);
                    break;
                case "90%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 5]);
                    break;
                case "95%":
                    Cal_PAir = double.Parse(ElementCal.PAir[1, 6]);
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }
        
        //水的比例
        private void Pwa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Pwa.Text)
            {
                case "5%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 0]);
                    break;
                case "10%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 1]);
                    break;
                case "25%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 2]);
                    break;
                case "50%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 3]);
                    break;
                case "75%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 4]);
                    break;
                case "90%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 5]);
                    break;
                case "95%":
                    Cal_PWa = double.Parse(ElementCal.PWater[1, 6]);
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        //粪肥的比例
        private void PShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ShitType[1, 3] == null)
            {
                MessageBox.Show("请先选择粪肥种类！");
                PShi.Text = "";
            }
            else
            {
                switch (PShi.Text)
                {
                    case "5%":
                        Cal_PShi = double.Parse(ShitType[1, 0]);
                        break;
                    case "10%":
                        Cal_PShi = double.Parse(ShitType[1, 1]);
                        break;
                    case "25%":
                        Cal_PShi = double.Parse(ShitType[1, 2]);
                        break;
                    case "50%":
                        Cal_PShi = double.Parse(ShitType[1, 3]);
                        break;
                    case "75%":
                        Cal_PShi = double.Parse(ShitType[1, 4]);
                        break;
                    case "90%":
                        Cal_PShi = double.Parse(ShitType[1, 5]);
                        break;
                    case "95%":
                        Cal_PShi = double.Parse(ShitType[1, 6]);
                        break;
                    default:
                        MessageBox.Show("无效的输入");
                        break;
                }
            }
        }

        //------------------元素与按键-----------------

        //按键“返回”
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //判定是否选择元素
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (CalElement.Text == "")
            {
                MessageBox.Show("请先选择元素！");
            }
        }

        //元素的选择
        private void CalElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CalElement.Text)
            {
                case "Cd":
                    this.ElementCal = Login.ElementData_Cd;
                    break;
                case "Pb":
                    this.ElementCal = Login.ElementData_Pb;
                    break;
                case "As":
                    this.ElementCal = Login.ElementData_As;
                    break;
                case "Cr":
                    this.ElementCal = Login.ElementData_Cr;
                    break;
                case "Hg":
                    this.ElementCal = Login.ElementData_Hg;
                    break;
                case "Cu":
                    this.ElementCal = Login.ElementData_Cu;
                    break;
                case "Zn":
                    this.ElementCal = Login.ElementData_Zn;
                    break;
                case "Ni":
                    this.ElementCal = Login.ElementData_Ni;
                    break;

                default:
                    MessageBox.Show("无效的元素种类");
                    break;
            }
        }

        
        
        //*****************************************************//
        
        //-------------------输出部分--------------------

        //PH值
        private void OutPH_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(OutPH.Text) == true)
            {
                PH_value = double.Parse(OutPH.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //有机物
        private void OutOr_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(OutOr.Text) == true)
            {
                Org_value = double.Parse(OutOr.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //地区选择
        private void OutArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OutArea.Text)
            {
                case "北京":
                    Area_value = double.Parse(ElementCal.POut[1,0]);
                    break;
                case "上海":
                    Area_value = double.Parse(ElementCal.POut[1, 1]);
                    break;
                case "广州":
                    Area_value = double.Parse(ElementCal.POut[1, 2]);
                    break;
                case "深圳":
                    Area_value = double.Parse(ElementCal.POut[1, 3]);
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
                    
            }
        }

        //蔬菜的质量
        private void MVeg_TextChanged(object sender, EventArgs e)
        {
            if (Setting.IsNumberic(MVeg.Text) == true)
            {
                Mvege_value = double.Parse(MVeg.Text);
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
           
        }

        //-----------------“计算”按键-------------------

        //计算输出的量
        private void CalTheOut_Click(object sender, EventArgs e)
        {
            double temple;
            temple = (Alpha1 + Alpha2 * PH_value + Alpha3 * Math.Log10(Org_value) +N_oflog*Math.Log10(Area_value));
            Out_value = Math.Pow(10, temple)* Mvege_value;
            TheOut.Text = Out_value.ToString();
        }

        //计算输入的量
        private void CalTheIn_Click(object sender, EventArgs e)
        {
            Cal_In = Cal_PWa * Cal_Mwa + Cal_POrg * Cal_Morg + Cal_PPho * Cal_Mpho + Cal_PAir * Cal_Mair + Cal_PShi * Cal_Mshi;
            TheIn.Text = Cal_In.ToString();
        }

        //计算残留的含量
        private void CalTheLeft_Click(object sender, EventArgs e)
        {
            Left_value = Cal_In - Out_value;
            TheLeft.Text = Left_value.ToString();
        }
    }
}
