namespace Asset_MIS_20214040057
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
            this.LoginTitleLable = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Passwd = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.PasswdLabel = new System.Windows.Forms.Label();
            this.RegBtn = new System.Windows.Forms.Button();
            this.Showpwd = new System.Windows.Forms.CheckBox();
            this.Forgot = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTitleLable
            // 
            this.LoginTitleLable.AutoSize = true;
            this.LoginTitleLable.Font = new System.Drawing.Font("思源黑体 CN Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LoginTitleLable.Location = new System.Drawing.Point(95, 49);
            this.LoginTitleLable.Name = "LoginTitleLable";
            this.LoginTitleLable.Size = new System.Drawing.Size(345, 59);
            this.LoginTitleLable.TabIndex = 0;
            this.LoginTitleLable.Text = "资产出借管理系统";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(219, 163);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(141, 25);
            this.Username.TabIndex = 1;
            // 
            // Passwd
            // 
            this.Passwd.Location = new System.Drawing.Point(219, 224);
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(141, 25);
            this.Passwd.TabIndex = 2;
            this.Passwd.UseSystemPasswordChar = true;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(163, 315);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(103, 30);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "登录";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(153, 166);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(52, 15);
            this.UserNameLable.TabIndex = 5;
            this.UserNameLable.Text = "用户名";
            // 
            // PasswdLabel
            // 
            this.PasswdLabel.AutoSize = true;
            this.PasswdLabel.Location = new System.Drawing.Point(168, 234);
            this.PasswdLabel.Name = "PasswdLabel";
            this.PasswdLabel.Size = new System.Drawing.Size(37, 15);
            this.PasswdLabel.TabIndex = 6;
            this.PasswdLabel.Text = "密码";
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(282, 315);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(103, 30);
            this.RegBtn.TabIndex = 7;
            this.RegBtn.Text = "注册";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // Showpwd
            // 
            this.Showpwd.AutoSize = true;
            this.Showpwd.Location = new System.Drawing.Point(366, 226);
            this.Showpwd.Name = "Showpwd";
            this.Showpwd.Size = new System.Drawing.Size(89, 19);
            this.Showpwd.TabIndex = 8;
            this.Showpwd.Text = "显示密码";
            this.Showpwd.UseVisualStyleBackColor = true;
            this.Showpwd.CheckedChanged += new System.EventHandler(this.Showpwd_CheckedChanged);
            // 
            // Forgot
            // 
            this.Forgot.AutoSize = true;
            this.Forgot.Location = new System.Drawing.Point(216, 383);
            this.Forgot.Name = "Forgot";
            this.Forgot.Size = new System.Drawing.Size(112, 15);
            this.Forgot.TabIndex = 9;
            this.Forgot.Text = "忘记账号或密码";
            this.Forgot.Click += new System.EventHandler(this.Forgot_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 412);
            this.Controls.Add(this.Forgot);
            this.Controls.Add(this.Showpwd);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.PasswdLabel);
            this.Controls.Add(this.UserNameLable);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.LoginTitleLable);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginTitleLable;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Passwd;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.Label PasswdLabel;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.CheckBox Showpwd;
        private System.Windows.Forms.Label Forgot;
    }
}

