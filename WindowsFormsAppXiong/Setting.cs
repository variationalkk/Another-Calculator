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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        //本页的蔬菜对象
        public TheElement ElementSet;
        //设置部分的变量
        //索引
        public string Set_PWa, Set_POr, Set_PPh, Set_PAir, Set_PShi, Set_Area;
        //索引相对应的值
        public string Set_PWa_value, Set_POr_value, Set_PPh_value, Set_PAir_value, Set_PShi_value, Set_Area_value;
        public string[,] Set_ShitType = new string[2, 6];
        public int ShitType;

        //判断是否为数字的函数
        public static bool IsNumberic(string oText)
        {
            try
            {
                double var1 = Convert.ToDouble(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }


        //------------------选择各部分的百分比-----------------

        //选择水的比例，并保存比例至Set_PWa
        private void SetPwa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SetPwa.Text)
            {
                case "5%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 0];
                    break;
                case "10%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 1];
                    break;
                case "25%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 2];
                    break;
                case "50%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 3];
                    break;
                case "75%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 4];
                    break;
                case "90%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 5];
                    break;
                case "95%":
                    Set_PWa = SetPwa.Text;
                    SetPwa_value.Text = ElementSet.PWater[1, 6];
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        //选择有机肥的比例，并保存比例至Set_POr
        private void SetPOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SetPOrg.Text)
            {
                case "5%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 0];
                    break;
                case "10%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 1];
                    break;
                case "25%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 2];
                    break;
                case "50%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 3];
                    break;
                case "75%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 4];
                    break;
                case "90%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 5];
                    break;
                case "95%":
                    Set_POr = SetPOrg.Text;
                    SetPOrg_value.Text = ElementSet.POrgano[1, 6];
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        //选择磷肥的比例，并保存比例至Set_PPh
        private void SetPPho_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SetPPho.Text)
            {
                case "5%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 0];
                    break;
                case "10%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 1];
                    break;
                case "25%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 2];
                    break;
                case "50%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 3];
                    break;
                case "75%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 4];
                    break;
                case "90%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 5];
                    break;
                case "95%":
                    Set_PPh = SetPPho.Text;
                    SetPPho_value.Text = ElementSet.PPhosphorus[1, 6];
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        //选择粪肥的比例，并保存比例至Set_PShi
        private void SetPShi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Set_ShitType[1, 3] == null)
            {
                MessageBox.Show("请先选择粪肥种类！");
                return ;
            }
            else
            {
                switch (SetPShi.Text)
                {
                    case "5%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1, 0];
                        break;
                    case "10%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1,1];
                        break;
                    case "25%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1,2];
                        break;
                    case "50%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1,3];
                        break;
                    case "75%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1,4];
                        break;
                    case "90%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1,5];
                        break;
                    case "95%":
                        Set_PShi = SetPShi.Text;
                        SetPShi_value.Text = Set_ShitType[1,6];
                        break;
                    default:
                        MessageBox.Show("无效的输入");
                        break;
                }
            }
        }

        //选择大气沉降，并保存比例至Set_PAir
        private void SetPAir_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SetPAir.Text)
            {
                case "5%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 0];
                    break;
                case "10%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 1];
                    break;
                case "25%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 2];
                    break;
                case "50%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 3];
                    break;
                case "75%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 4];
                    break;
                case "90%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 5];
                    break;
                case "95%":
                    Set_PAir = SetPAir.Text;
                    SetPAir_value.Text = ElementSet.PAir[1, 6];
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        //选择地区选择，并保存比例至Set_Area
        private void SetArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SetArea.Text)
            {
                case "北京":
                    Set_Area = SetArea.Text;
                    SetArea_value.Text = ElementSet.POut[1, 0];
                    break;
                case "上海":
                    Set_Area = SetArea.Text;
                    SetArea_value.Text = ElementSet.POut[1, 1];
                    break;
                case "广州":
                    Set_Area = SetArea.Text;
                    SetArea_value.Text = ElementSet.POut[1, 2];
                    break;
                case "深圳":
                    Set_Area = SetArea.Text;
                    SetArea_value.Text = ElementSet.POut[1, 3];
                    break;
                case "90%":
                    Set_Area = SetArea.Text;
                    SetArea_value.Text = ElementSet.POut[1, 4];
                    break;
                case "95%":
                    Set_Area = SetArea.Text;
                    SetArea_value.Text = ElementSet.POut[1, 5];
                    break;
                default:
                    MessageBox.Show("无效的输入");
                    break;
            }
        }

        



        //-------------------选择粪肥---------------------------
        //选择鸡粪
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Set_ShitType = ElementSet.PChecken;
            ShitType = 0;
        }   

        //选择牛粪
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Set_ShitType = ElementSet.PBull;
            ShitType = 1;
        }

        //选择猪粪
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Set_ShitType = ElementSet.PBig;
            ShitType = 2;
        }

        //选择堆肥
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Set_ShitType = ElementSet.PMix;
            ShitType = 3;
        }


        //--------------------修改-------------------------------
        //修改水的值，并保存新的值至Set_PWa_value
        private void SetPwa_value_TextChanged(object sender, EventArgs e)
        {
            if (SetPwa.Text == "")
            {
                MessageBox.Show("请先选择百分比");
            }
            else if (IsNumberic(SetPwa_value.Text) == true)
            {
                Set_PWa_value = SetPwa_value.Text;
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //修改有机肥，并保存新的值至Set_POr_value
        private void SetPOrg_value_TextChanged(object sender, EventArgs e)
        {
            if (SetPOrg.Text == "")
            {
                MessageBox.Show("请先选择百分比");
            }
            else if (IsNumberic(SetPOrg_value.Text) == true)
            {
                Set_POr_value = SetPOrg_value.Text;
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //修改磷肥，并保存新的值至Set_PPh_value
        private void SetPPho_value_TextChanged(object sender, EventArgs e)
        {
            if (SetPPho.Text == "")
            {
                MessageBox.Show("请先选择百分比");
            }
            else if (IsNumberic(SetPPho_value.Text) == true)
            {
                Set_PPh_value = SetPPho_value.Text;
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
        }

        //修改大气沉降，并保存新的值至Set_PAir_value
        private void SetPAir_value_TextChanged(object sender, EventArgs e)
        {
            if (SetPAir.Text == "")
            {
                MessageBox.Show("请先选择百分比");
            }
            else if (IsNumberic(SetPAir_value.Text) == true)
            {
                Set_PAir_value = SetPAir_value.Text;
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
            
        }

        //修改地区，并保存新的值至Set_Area_value
        private void SetArea_value_TextChanged(object sender, EventArgs e)
        {
            if (SetArea.Text == "")
            {
                MessageBox.Show("请先选择百分比");
            }
            else if (IsNumberic(SetArea_value.Text) == true)
            {
                Set_Area_value = SetArea_value.Text;
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
                
            
        }

        //修改粪肥，并保存新的值至Set_PShi_value
        private void SetPShi_value_TextChanged(object sender, EventArgs e)
        {
            if (SetPShi.Text == "")
            {
                MessageBox.Show("请先选择百分比");
            }
            else if (IsNumberic(SetPShi_value.Text) == true)
            {
                Set_PShi_value = SetPShi_value.Text;
            }
            else
            {
                MessageBox.Show("请输入数字！！");
            }
            
        }

        
        //------------------按键与元素选择--------------------------
        //返回键
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //元素的选择
        private void Element_Set_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Element_Set.Text)
            {
                case "Cd":
                    ElementSet = Login.ElementData_Cd;
                    break;
                case "Pb":
                    ElementSet = Login.ElementData_Pb;
                    break;
                case "As":
                    ElementSet = Login.ElementData_As;
                    break;
                case "Cr":
                    ElementSet = Login.ElementData_Cr;
                    break;
                case "Hg":
                    ElementSet = Login.ElementData_Hg;
                    break;
                case "Cu":
                    ElementSet = Login.ElementData_Cu;
                    break;
                case "Zn":
                    ElementSet = Login.ElementData_Zn;
                    break;
                case "Ni":
                    ElementSet = Login.ElementData_Ni;
                    break;
                default:
                    MessageBox.Show("无效的元素种类");
                    break;
            }
        }

        //判定是否选择元素
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            if (Element_Set.Text == "")
            {
                MessageBox.Show("请先选择元素！");
            }
        }

        //修改按钮,保存新的值至 ElementSet 对象中
        private void SaveSetting_Click(object sender, EventArgs e)
        {
            switch (Set_PWa)
            {
                case "5%":
                    ElementSet.PWater[1, 0] = Set_PWa_value;
                    break;
                case "10%":
                    ElementSet.PWater[1, 1] = Set_PWa_value;
                    break;
                case "25%":
                    ElementSet.PWater[1, 2] = Set_PWa_value;
                    break;
                case "50%":
                    ElementSet.PWater[1, 3] = Set_PWa_value;
                    break;
                case "75%":
                    ElementSet.PWater[1, 4] = Set_PWa_value;
                    break;
                case "90%":
                    ElementSet.PWater[1, 5] = Set_PWa_value;
                    break;
                case "95%":
                    ElementSet.PWater[1, 6] = Set_PWa_value;
                    break;

            }
            switch (Set_POr)
            {
                case "5%":
                    ElementSet.POrgano[1, 0] = Set_POr_value;
                    break;
                case "10%":
                    ElementSet.POrgano[1, 1] = Set_POr_value;
                    break;
                case "25%":
                    ElementSet.POrgano[1, 2] = Set_POr_value;
                    break;
                case "50%":
                    ElementSet.POrgano[1, 3] = Set_POr_value;
                    break;
                case "75%":
                    ElementSet.POrgano[1, 4] = Set_POr_value;
                    break;
                case "90%":
                    ElementSet.POrgano[1, 5] = Set_POr_value;
                    break;
                case "95%":
                    ElementSet.POrgano[1, 6] = Set_POr_value;
                    break;
            }
            switch (Set_PPh)
            {
                case "5%":
                    ElementSet.PPhosphorus[1, 0] = Set_PPh_value;
                    break;
                case "10%":
                    ElementSet.PPhosphorus[1, 1] = Set_PPh_value;
                    break;
                case "25%":
                    ElementSet.PPhosphorus[1, 2] = Set_PPh_value;
                    break;
                case "50%":
                    ElementSet.PPhosphorus[1, 3] = Set_PPh_value;
                    break;
                case "75%":
                    ElementSet.PPhosphorus[1, 4] = Set_PPh_value;
                    break;
                case "90%":
                    ElementSet.PPhosphorus[1, 5] = Set_PPh_value;
                    break;
                case "95%":
                    ElementSet.PPhosphorus[1, 6] = Set_PPh_value;
                    break;
            }
            switch (Set_PAir)
            {
                case "5%":
                    ElementSet.PAir[1, 0] = Set_PAir_value;
                    break;
                case "10%":
                    ElementSet.PAir[1, 1] = Set_PAir_value;
                    break;
                case "25%":
                    ElementSet.PAir[1, 2] = Set_PAir_value;
                    break;
                case "50%":
                    ElementSet.PAir[1, 3] = Set_PAir_value;
                    break;
                case "75%":
                    ElementSet.PAir[1, 4] = Set_PAir_value;
                    break;
                case "90%":
                    ElementSet.PAir[1, 5] = Set_PAir_value;
                    break;
                case "95%":
                    ElementSet.PAir[1, 6] = Set_PAir_value;
                    break;
            }
            switch (Set_Area)
            {
                case "北京":
                    ElementSet.POut[1, 0] = Set_Area_value;
                    break;
                case "上海":
                    ElementSet.POut[1, 1] = Set_Area_value;
                    break;
                case "广州":
                    ElementSet.POut[1, 2] = Set_Area_value;
                    break;
                case "深圳":
                    ElementSet.POut[1, 3] = Set_Area_value;
                    break;
                case "90%":
                    ElementSet.POut[1, 4] = Set_Area_value;
                    break;
                case "95%":
                    ElementSet.POut[1, 5] = Set_Area_value;
                    break;

            }
            switch (Set_PShi)
            {
                case "5%":
                    Set_ShitType[1, 0] = Set_PShi_value;
                    break;
                case "10%":
                    Set_ShitType[1, 1] = Set_PShi_value;
                    break;
                case "25%":
                    Set_ShitType[1, 2] = Set_PShi_value;
                    break;
                case "50%":
                    Set_ShitType[1, 3] = Set_PShi_value;
                    break;
                case "75%":
                    Set_ShitType[1, 4] = Set_PShi_value;
                    break;
                case "90%":
                    Set_ShitType[1, 5] = Set_PShi_value;
                    break;
                case "95%":
                    Set_ShitType[1, 6] = Set_PShi_value;
                    break;


            }
            switch (ShitType)
            {
                case 0 :
                    ElementSet.PChecken = Set_ShitType;
                    break;
                case 1 :
                    ElementSet.PBull = Set_ShitType;
                    break;
                case 2 :
                    ElementSet.PBig = Set_ShitType;
                    break;
                case 3 :
                    ElementSet.PMix = Set_ShitType;
                    break;
            }
            switch (Element_Set.Text)
            {
                case "Cd":
                    Login.ElementData_Cd = ElementSet;
                    break;
                case "Pb":
                    Login.ElementData_Pb = ElementSet;
                    break;
                case "As":
                    Login.ElementData_As = ElementSet;
                    break;
                case "Cr":
                    Login.ElementData_Cr = ElementSet;
                    break;
                case "Hg":
                    Login.ElementData_Hg = ElementSet;
                    break;
                case "Cu":
                    Login.ElementData_Cu = ElementSet;
                    break;
                case "Zn":
                    Login.ElementData_Zn = ElementSet;
                    break;
                case "Ni":
                    Login.ElementData_Ni = ElementSet;
                    break;
            }
            MessageBox.Show("修改成功");
            
        }

        }
}


