namespace WindowsFormsAppXiong
{
    partial class Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAdminister = new System.Windows.Forms.Button();
            this.BtnUsing = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(142, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "XXX测量应用";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(146, 236);
            this.Username.MaxLength = 15;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(182, 25);
            this.Username.TabIndex = 3;
            // 
            // Passwd
            // 
            this.Passwd.Location = new System.Drawing.Point(146, 300);
            this.Passwd.MaxLength = 15;
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(182, 25);
            this.Passwd.TabIndex = 4;
            this.Passwd.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(52, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "管理员：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(62, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码：";
            // 
            // BtnAdminister
            // 
            this.BtnAdminister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdminister.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnAdminister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAdminister.Location = new System.Drawing.Point(227, 120);
            this.BtnAdminister.Name = "BtnAdminister";
            this.BtnAdminister.Size = new System.Drawing.Size(141, 53);
            this.BtnAdminister.TabIndex = 2;
            this.BtnAdminister.Text = "管理员";
            this.BtnAdminister.UseVisualStyleBackColor = true;
            this.BtnAdminister.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnUsing
            // 
            this.BtnUsing.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnUsing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsing.Location = new System.Drawing.Point(57, 120);
            this.BtnUsing.Name = "BtnUsing";
            this.BtnUsing.Size = new System.Drawing.Size(150, 53);
            this.BtnUsing.TabIndex = 1;
            this.BtnUsing.Text = "直接使用";
            this.BtnUsing.UseVisualStyleBackColor = true;
            this.BtnUsing.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(444, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.BtnAdminister);
            this.Controls.Add(this.BtnUsing);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "主界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnUsing;
        private System.Windows.Forms.Button BtnAdminister;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

