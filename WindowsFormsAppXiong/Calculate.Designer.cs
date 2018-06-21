namespace WindowsFormsAppXiong
{
    partial class Calculate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CalElement = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CalTheIn = new System.Windows.Forms.Button();
            this.TheIn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MSh = new System.Windows.Forms.TextBox();
            this.PShi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.MAi = new System.Windows.Forms.TextBox();
            this.PAi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MPh = new System.Windows.Forms.TextBox();
            this.PPh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MOr = new System.Windows.Forms.TextBox();
            this.POr = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Mwa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Pwa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CalTheOut = new System.Windows.Forms.Button();
            this.TheOut = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.MVeg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.OutArea = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OutOr = new System.Windows.Forms.TextBox();
            this.OutPH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CalTheLeft = new System.Windows.Forms.Button();
            this.TheLeft = new System.Windows.Forms.TextBox();
            this.Retu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(359, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "XXX测量计算";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(75, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "元素种类:";
            // 
            // CalElement
            // 
            this.CalElement.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CalElement.FormattingEnabled = true;
            this.CalElement.Items.AddRange(new object[] {
            "Cd",
            "Pb",
            "As",
            "Cr",
            "Hg",
            "Cu",
            "Zn",
            "Ni"});
            this.CalElement.Location = new System.Drawing.Point(203, 61);
            this.CalElement.Name = "CalElement";
            this.CalElement.Size = new System.Drawing.Size(103, 32);
            this.CalElement.TabIndex = 3;
            this.CalElement.SelectedIndexChanged += new System.EventHandler(this.CalElement_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.CalTheIn);
            this.groupBox1.Controls.Add(this.TheIn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.MSh);
            this.groupBox1.Controls.Add(this.PShi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.MAi);
            this.groupBox1.Controls.Add(this.PAi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.MPh);
            this.groupBox1.Controls.Add(this.PPh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.MOr);
            this.groupBox1.Controls.Add(this.POr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Mwa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Pwa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(62, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 471);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输入元素的部分";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CalTheIn
            // 
            this.CalTheIn.Location = new System.Drawing.Point(272, 389);
            this.CalTheIn.Name = "CalTheIn";
            this.CalTheIn.Size = new System.Drawing.Size(97, 51);
            this.CalTheIn.TabIndex = 19;
            this.CalTheIn.Text = "计算";
            this.CalTheIn.UseVisualStyleBackColor = true;
            this.CalTheIn.Click += new System.EventHandler(this.CalTheIn_Click);
            // 
            // TheIn
            // 
            this.TheIn.BackColor = System.Drawing.SystemColors.Window;
            this.TheIn.Location = new System.Drawing.Point(151, 409);
            this.TheIn.Name = "TheIn";
            this.TheIn.ReadOnly = true;
            this.TheIn.Size = new System.Drawing.Size(101, 31);
            this.TheIn.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(145, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "输入的总量（g）：";
            // 
            // MSh
            // 
            this.MSh.Location = new System.Drawing.Point(272, 309);
            this.MSh.MaxLength = 6;
            this.MSh.Name = "MSh";
            this.MSh.Size = new System.Drawing.Size(97, 31);
            this.MSh.TabIndex = 16;
            this.MSh.TextChanged += new System.EventHandler(this.MSh_TextChanged);
            // 
            // PShi
            // 
            this.PShi.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.PShi.Location = new System.Drawing.Point(171, 307);
            this.PShi.Name = "PShi";
            this.PShi.Size = new System.Drawing.Size(73, 33);
            this.PShi.TabIndex = 15;
            this.PShi.SelectedIndexChanged += new System.EventHandler(this.PShi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(145, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "粪肥的比例";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(18, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 174);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "粪肥的种类";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 134);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 29);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "堆肥";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 102);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "猪粪";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 67);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "牛粪";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "鸡粪";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MAi
            // 
            this.MAi.Location = new System.Drawing.Point(272, 220);
            this.MAi.MaxLength = 6;
            this.MAi.Name = "MAi";
            this.MAi.Size = new System.Drawing.Size(97, 31);
            this.MAi.TabIndex = 12;
            this.MAi.TextChanged += new System.EventHandler(this.MAi_TextChanged);
            // 
            // PAi
            // 
            this.PAi.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.PAi.Location = new System.Drawing.Point(171, 220);
            this.PAi.Name = "PAi";
            this.PAi.Size = new System.Drawing.Size(73, 33);
            this.PAi.TabIndex = 11;
            this.PAi.SelectedIndexChanged += new System.EventHandler(this.PAi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(29, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "大气沉降";
            // 
            // MPh
            // 
            this.MPh.Location = new System.Drawing.Point(272, 167);
            this.MPh.MaxLength = 6;
            this.MPh.Name = "MPh";
            this.MPh.Size = new System.Drawing.Size(97, 31);
            this.MPh.TabIndex = 9;
            this.MPh.TextChanged += new System.EventHandler(this.MPh_TextChanged);
            // 
            // PPh
            // 
            this.PPh.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.PPh.Location = new System.Drawing.Point(171, 167);
            this.PPh.Name = "PPh";
            this.PPh.Size = new System.Drawing.Size(73, 33);
            this.PPh.TabIndex = 8;
            this.PPh.SelectedIndexChanged += new System.EventHandler(this.PPh_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(29, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "磷肥的比例";
            // 
            // MOr
            // 
            this.MOr.Location = new System.Drawing.Point(272, 111);
            this.MOr.MaxLength = 6;
            this.MOr.Name = "MOr";
            this.MOr.Size = new System.Drawing.Size(97, 31);
            this.MOr.TabIndex = 6;
            this.MOr.TextChanged += new System.EventHandler(this.MOr_TextChanged);
            // 
            // POr
            // 
            this.POr.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.POr.Location = new System.Drawing.Point(171, 111);
            this.POr.Name = "POr";
            this.POr.Size = new System.Drawing.Size(73, 33);
            this.POr.TabIndex = 5;
            this.POr.SelectedIndexChanged += new System.EventHandler(this.POr_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "有机肥的比例";
            // 
            // Mwa
            // 
            this.Mwa.Location = new System.Drawing.Point(272, 60);
            this.Mwa.MaxLength = 6;
            this.Mwa.Name = "Mwa";
            this.Mwa.Size = new System.Drawing.Size(97, 31);
            this.Mwa.TabIndex = 3;
            this.Mwa.TextChanged += new System.EventHandler(this.Mwa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(238, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "输入的质量（g）";
            // 
            // Pwa
            // 
            this.Pwa.Items.AddRange(new object[] {
            "5%",
            "10%",
            "25%",
            "50%",
            "75%",
            "90%",
            "95%"});
            this.Pwa.Location = new System.Drawing.Point(171, 60);
            this.Pwa.Name = "Pwa";
            this.Pwa.Size = new System.Drawing.Size(73, 33);
            this.Pwa.TabIndex = 1;
            this.Pwa.SelectedIndexChanged += new System.EventHandler(this.Pwa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(29, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "水的比例";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CalTheOut);
            this.groupBox3.Controls.Add(this.TheOut);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.MVeg);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.OutArea);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.OutOr);
            this.groupBox3.Controls.Add(this.OutPH);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(499, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 359);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "蔬菜带走的部分";
            // 
            // CalTheOut
            // 
            this.CalTheOut.Location = new System.Drawing.Point(224, 289);
            this.CalTheOut.Name = "CalTheOut";
            this.CalTheOut.Size = new System.Drawing.Size(97, 51);
            this.CalTheOut.TabIndex = 20;
            this.CalTheOut.Text = "计算";
            this.CalTheOut.UseVisualStyleBackColor = true;
            this.CalTheOut.Click += new System.EventHandler(this.CalTheOut_Click);
            // 
            // TheOut
            // 
            this.TheOut.Location = new System.Drawing.Point(37, 299);
            this.TheOut.MaxLength = 6;
            this.TheOut.Name = "TheOut";
            this.TheOut.ReadOnly = true;
            this.TheOut.Size = new System.Drawing.Size(110, 31);
            this.TheOut.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(32, 244);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(214, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "带走元素的总量（g）：";
            // 
            // MVeg
            // 
            this.MVeg.Location = new System.Drawing.Point(224, 183);
            this.MVeg.MaxLength = 6;
            this.MVeg.Name = "MVeg";
            this.MVeg.Size = new System.Drawing.Size(97, 31);
            this.MVeg.TabIndex = 10;
            this.MVeg.TextChanged += new System.EventHandler(this.MVeg_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(32, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "蔬菜的质量（g）：";
            // 
            // OutArea
            // 
            this.OutArea.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OutArea.FormattingEnabled = true;
            this.OutArea.Items.AddRange(new object[] {
            "北京",
            "上海",
            "广州",
            "深圳"});
            this.OutArea.Location = new System.Drawing.Point(224, 140);
            this.OutArea.Name = "OutArea";
            this.OutArea.Size = new System.Drawing.Size(97, 32);
            this.OutArea.TabIndex = 8;
            this.OutArea.SelectedIndexChanged += new System.EventHandler(this.OutArea_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(32, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 25);
            this.label13.TabIndex = 7;
            this.label13.Text = "地区选择";
            // 
            // OutOr
            // 
            this.OutOr.Location = new System.Drawing.Point(224, 99);
            this.OutOr.MaxLength = 6;
            this.OutOr.Name = "OutOr";
            this.OutOr.Size = new System.Drawing.Size(97, 31);
            this.OutOr.TabIndex = 5;
            this.OutOr.TextChanged += new System.EventHandler(this.OutOr_TextChanged);
            // 
            // OutPH
            // 
            this.OutPH.Location = new System.Drawing.Point(224, 62);
            this.OutPH.MaxLength = 6;
            this.OutPH.Name = "OutPH";
            this.OutPH.Size = new System.Drawing.Size(97, 31);
            this.OutPH.TabIndex = 4;
            this.OutPH.TextChanged += new System.EventHandler(this.OutPH_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(32, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 25);
            this.label11.TabIndex = 1;
            this.label11.Text = "有机物：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(32, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "输入的PH值：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CalTheLeft);
            this.groupBox4.Controls.Add(this.TheLeft);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(499, 502);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(363, 82);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "残留的含量（g）";
            // 
            // CalTheLeft
            // 
            this.CalTheLeft.Location = new System.Drawing.Point(224, 21);
            this.CalTheLeft.Name = "CalTheLeft";
            this.CalTheLeft.Size = new System.Drawing.Size(97, 51);
            this.CalTheLeft.TabIndex = 21;
            this.CalTheLeft.Text = "计算";
            this.CalTheLeft.UseVisualStyleBackColor = true;
            this.CalTheLeft.Click += new System.EventHandler(this.CalTheLeft_Click);
            // 
            // TheLeft
            // 
            this.TheLeft.BackColor = System.Drawing.SystemColors.Window;
            this.TheLeft.Location = new System.Drawing.Point(37, 32);
            this.TheLeft.Name = "TheLeft";
            this.TheLeft.ReadOnly = true;
            this.TheLeft.Size = new System.Drawing.Size(110, 31);
            this.TheLeft.TabIndex = 19;
            // 
            // Retu
            // 
            this.Retu.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Retu.Location = new System.Drawing.Point(765, 598);
            this.Retu.Name = "Retu";
            this.Retu.Size = new System.Drawing.Size(97, 41);
            this.Retu.TabIndex = 21;
            this.Retu.Text = "返回";
            this.Retu.UseVisualStyleBackColor = true;
            this.Retu.Click += new System.EventHandler(this.button4_Click);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 651);
            this.Controls.Add(this.Retu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CalElement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculate";
            this.Text = "Caculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CalElement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Pwa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Mwa;
        private System.Windows.Forms.TextBox MAi;
        private System.Windows.Forms.ComboBox PAi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MPh;
        private System.Windows.Forms.ComboBox PPh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MOr;
        private System.Windows.Forms.ComboBox POr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox MSh;
        private System.Windows.Forms.ComboBox PShi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CalTheIn;
        private System.Windows.Forms.TextBox TheIn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox OutArea;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox OutOr;
        private System.Windows.Forms.TextBox OutPH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button CalTheOut;
        private System.Windows.Forms.TextBox TheOut;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox MVeg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button CalTheLeft;
        private System.Windows.Forms.TextBox TheLeft;
        private System.Windows.Forms.Button Retu;
    }
}