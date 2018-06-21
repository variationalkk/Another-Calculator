namespace WindowsFormsAppXiong
{
    partial class Setting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.Element_Set = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveSetting = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SetArea_value = new System.Windows.Forms.TextBox();
            this.SetArea = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SetPShi_value = new System.Windows.Forms.TextBox();
            this.SetPShi = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SetPAir_value = new System.Windows.Forms.TextBox();
            this.SetPAir = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SetPPho_value = new System.Windows.Forms.TextBox();
            this.SetPPho = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SetPOrg_value = new System.Windows.Forms.TextBox();
            this.SetPOrg = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetPwa_value = new System.Windows.Forms.TextBox();
            this.SetPwa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Element_Set
            // 
            this.Element_Set.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Element_Set.FormattingEnabled = true;
            this.Element_Set.Items.AddRange(new object[] {
            "Cd",
            "Pb",
            "As",
            "Cr",
            "Hg",
            "Cu",
            "Zn",
            "Ni"});
            this.Element_Set.Location = new System.Drawing.Point(178, 61);
            this.Element_Set.Name = "Element_Set";
            this.Element_Set.Size = new System.Drawing.Size(103, 32);
            this.Element_Set.TabIndex = 6;
            this.Element_Set.SelectedIndexChanged += new System.EventHandler(this.Element_Set_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(50, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "元素种类:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(348, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "参数查看与修改";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveSetting);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.SetArea_value);
            this.groupBox1.Controls.Add(this.SetArea);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.SetPShi_value);
            this.groupBox1.Controls.Add(this.SetPShi);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SetPAir_value);
            this.groupBox1.Controls.Add(this.SetPAir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.SetPPho_value);
            this.groupBox1.Controls.Add(this.SetPPho);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SetPOrg_value);
            this.groupBox1.Controls.Add(this.SetPOrg);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.SetPwa_value);
            this.groupBox1.Controls.Add(this.SetPwa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(65, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 390);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入部分参数";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // SaveSetting
            // 
            this.SaveSetting.Location = new System.Drawing.Point(642, 320);
            this.SaveSetting.Name = "SaveSetting";
            this.SaveSetting.Size = new System.Drawing.Size(97, 39);
            this.SaveSetting.TabIndex = 32;
            this.SaveSetting.Text = "修改";
            this.SaveSetting.UseVisualStyleBackColor = true;
            this.SaveSetting.Click += new System.EventHandler(this.SaveSetting_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(284, 275);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 31;
            this.label14.Text = "对应的值";
            // 
            // SetArea_value
            // 
            this.SetArea_value.Location = new System.Drawing.Point(275, 313);
            this.SetArea_value.MaxLength = 6;
            this.SetArea_value.Name = "SetArea_value";
            this.SetArea_value.Size = new System.Drawing.Size(97, 31);
            this.SetArea_value.TabIndex = 30;
            this.SetArea_value.TextChanged += new System.EventHandler(this.SetArea_value_TextChanged);
            // 
            // SetArea
            // 
            this.SetArea.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SetArea.FormattingEnabled = true;
            this.SetArea.Items.AddRange(new object[] {
            "北京",
            "上海",
            "广州",
            "深圳"});
            this.SetArea.Location = new System.Drawing.Point(136, 313);
            this.SetArea.Name = "SetArea";
            this.SetArea.Size = new System.Drawing.Size(110, 32);
            this.SetArea.TabIndex = 29;
            this.SetArea.SelectedIndexChanged += new System.EventHandler(this.SetArea_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(34, 320);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 25);
            this.label13.TabIndex = 28;
            this.label13.Text = "C土";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 275);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "带走部分的参数";
            // 
            // SetPShi_value
            // 
            this.SetPShi_value.Location = new System.Drawing.Point(642, 73);
            this.SetPShi_value.MaxLength = 6;
            this.SetPShi_value.Name = "SetPShi_value";
            this.SetPShi_value.Size = new System.Drawing.Size(97, 31);
            this.SetPShi_value.TabIndex = 26;
            this.SetPShi_value.TextChanged += new System.EventHandler(this.SetPShi_value_TextChanged);
            // 
            // SetPShi
            // 
            this.SetPShi.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.SetPShi.Location = new System.Drawing.Point(553, 73);
            this.SetPShi.Name = "SetPShi";
            this.SetPShi.Size = new System.Drawing.Size(69, 33);
            this.SetPShi.TabIndex = 25;
            this.SetPShi.SelectedIndexChanged += new System.EventHandler(this.SetPShi_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(651, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "对应的值";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(538, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "粪肥的比例";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton4.Location = new System.Drawing.Point(431, 175);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 29);
            this.radioButton4.TabIndex = 22;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "堆肥";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton3.Location = new System.Drawing.Point(431, 143);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 29);
            this.radioButton3.TabIndex = 21;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "猪粪";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton2.Location = new System.Drawing.Point(431, 108);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 29);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "牛粪";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radioButton1.Location = new System.Drawing.Point(432, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 29);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "鸡粪";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(414, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "粪肥的种类";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(171, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "百分比";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(284, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "对应的值";
            // 
            // SetPAir_value
            // 
            this.SetPAir_value.Location = new System.Drawing.Point(275, 217);
            this.SetPAir_value.MaxLength = 6;
            this.SetPAir_value.Name = "SetPAir_value";
            this.SetPAir_value.Size = new System.Drawing.Size(97, 31);
            this.SetPAir_value.TabIndex = 15;
            this.SetPAir_value.TextChanged += new System.EventHandler(this.SetPAir_value_TextChanged);
            // 
            // SetPAir
            // 
            this.SetPAir.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.SetPAir.Location = new System.Drawing.Point(174, 217);
            this.SetPAir.Name = "SetPAir";
            this.SetPAir.Size = new System.Drawing.Size(72, 33);
            this.SetPAir.TabIndex = 14;
            this.SetPAir.SelectedIndexChanged += new System.EventHandler(this.SetPAir_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(32, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "大气沉降";
            // 
            // SetPPho_value
            // 
            this.SetPPho_value.Location = new System.Drawing.Point(275, 171);
            this.SetPPho_value.MaxLength = 6;
            this.SetPPho_value.Name = "SetPPho_value";
            this.SetPPho_value.Size = new System.Drawing.Size(97, 31);
            this.SetPPho_value.TabIndex = 12;
            this.SetPPho_value.TextChanged += new System.EventHandler(this.SetPPho_value_TextChanged);
            // 
            // SetPPho
            // 
            this.SetPPho.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.SetPPho.Location = new System.Drawing.Point(174, 171);
            this.SetPPho.Name = "SetPPho";
            this.SetPPho.Size = new System.Drawing.Size(72, 33);
            this.SetPPho.TabIndex = 11;
            this.SetPPho.SelectedIndexChanged += new System.EventHandler(this.SetPPho_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(32, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "磷肥的比例";
            // 
            // SetPOrg_value
            // 
            this.SetPOrg_value.Location = new System.Drawing.Point(275, 120);
            this.SetPOrg_value.MaxLength = 6;
            this.SetPOrg_value.Name = "SetPOrg_value";
            this.SetPOrg_value.Size = new System.Drawing.Size(97, 31);
            this.SetPOrg_value.TabIndex = 9;
            this.SetPOrg_value.TextChanged += new System.EventHandler(this.SetPOrg_value_TextChanged);
            // 
            // SetPOrg
            // 
            this.SetPOrg.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.SetPOrg.Location = new System.Drawing.Point(174, 120);
            this.SetPOrg.Name = "SetPOrg";
            this.SetPOrg.Size = new System.Drawing.Size(72, 33);
            this.SetPOrg.TabIndex = 8;
            this.SetPOrg.SelectedIndexChanged += new System.EventHandler(this.SetPOrg_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(32, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "有机肥的比例";
            // 
            // SetPwa_value
            // 
            this.SetPwa_value.Location = new System.Drawing.Point(275, 74);
            this.SetPwa_value.MaxLength = 6;
            this.SetPwa_value.Name = "SetPwa_value";
            this.SetPwa_value.Size = new System.Drawing.Size(97, 31);
            this.SetPwa_value.TabIndex = 6;
            this.SetPwa_value.TextChanged += new System.EventHandler(this.SetPwa_value_TextChanged);
            // 
            // SetPwa
            // 
            this.SetPwa.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.SetPwa.Location = new System.Drawing.Point(174, 74);
            this.SetPwa.Name = "SetPwa";
            this.SetPwa.Size = new System.Drawing.Size(72, 33);
            this.SetPwa.TabIndex = 5;
            this.SetPwa.SelectedIndexChanged += new System.EventHandler(this.SetPwa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "水的比例";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(769, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 33;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Element_Set);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Setting";
            this.Text = "Administer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Element_Set;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SetPAir_value;
        private System.Windows.Forms.ComboBox SetPAir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SetPPho_value;
        private System.Windows.Forms.ComboBox SetPPho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SetPOrg_value;
        private System.Windows.Forms.ComboBox SetPOrg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SetPwa_value;
        private System.Windows.Forms.ComboBox SetPwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SetPShi_value;
        private System.Windows.Forms.ComboBox SetPShi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox SetArea_value;
        private System.Windows.Forms.ComboBox SetArea;
        private System.Windows.Forms.Button SaveSetting;
        private System.Windows.Forms.Button button2;
    }
}