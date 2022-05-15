namespace Asset_MIS_20214040057
{
    partial class RegFrm
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
            this.RegBtn = new System.Windows.Forms.Button();
            this.PasswdLable = new System.Windows.Forms.Label();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.Passwd = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.RegLable = new System.Windows.Forms.Label();
            this.RePasswdLable = new System.Windows.Forms.Label();
            this.RePasswd = new System.Windows.Forms.TextBox();
            this.IsManage = new System.Windows.Forms.CheckBox();
            this.BackLoginBtn = new System.Windows.Forms.Button();
            this.InputVerCode = new System.Windows.Forms.TextBox();
            this.VerCodeText = new System.Windows.Forms.Label();
            this.VerCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegBtn
            // 
            this.RegBtn.Location = new System.Drawing.Point(126, 364);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(103, 30);
            this.RegBtn.TabIndex = 14;
            this.RegBtn.Text = "注册";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // PasswdLable
            // 
            this.PasswdLable.AutoSize = true;
            this.PasswdLable.Location = new System.Drawing.Point(152, 181);
            this.PasswdLable.Name = "PasswdLable";
            this.PasswdLable.Size = new System.Drawing.Size(37, 15);
            this.PasswdLable.TabIndex = 13;
            this.PasswdLable.Text = "密码";
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(137, 134);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(52, 15);
            this.UserNameLable.TabIndex = 12;
            this.UserNameLable.Text = "用户名";
            // 
            // Passwd
            // 
            this.Passwd.Location = new System.Drawing.Point(203, 178);
            this.Passwd.Name = "Passwd";
            this.Passwd.Size = new System.Drawing.Size(141, 25);
            this.Passwd.TabIndex = 10;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(203, 131);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(141, 25);
            this.Username.TabIndex = 9;
            // 
            // RegLable
            // 
            this.RegLable.AutoSize = true;
            this.RegLable.Font = new System.Drawing.Font("思源黑体 CN Heavy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RegLable.Location = new System.Drawing.Point(159, 49);
            this.RegLable.Name = "RegLable";
            this.RegLable.Size = new System.Drawing.Size(185, 59);
            this.RegLable.TabIndex = 8;
            this.RegLable.Text = "用户注册";
            // 
            // RePasswdLable
            // 
            this.RePasswdLable.AutoSize = true;
            this.RePasswdLable.Location = new System.Drawing.Point(107, 229);
            this.RePasswdLable.Name = "RePasswdLable";
            this.RePasswdLable.Size = new System.Drawing.Size(82, 15);
            this.RePasswdLable.TabIndex = 15;
            this.RePasswdLable.Text = "再输入一次";
            // 
            // RePasswd
            // 
            this.RePasswd.Location = new System.Drawing.Point(203, 226);
            this.RePasswd.Name = "RePasswd";
            this.RePasswd.Size = new System.Drawing.Size(141, 25);
            this.RePasswd.TabIndex = 16;
            // 
            // IsManage
            // 
            this.IsManage.AutoSize = true;
            this.IsManage.Location = new System.Drawing.Point(203, 327);
            this.IsManage.Name = "IsManage";
            this.IsManage.Size = new System.Drawing.Size(104, 19);
            this.IsManage.TabIndex = 17;
            this.IsManage.Text = "是否管理员";
            this.IsManage.UseVisualStyleBackColor = true;
            // 
            // BackLoginBtn
            // 
            this.BackLoginBtn.Location = new System.Drawing.Point(257, 364);
            this.BackLoginBtn.Name = "BackLoginBtn";
            this.BackLoginBtn.Size = new System.Drawing.Size(103, 30);
            this.BackLoginBtn.TabIndex = 18;
            this.BackLoginBtn.Text = "返回";
            this.BackLoginBtn.UseVisualStyleBackColor = true;
            this.BackLoginBtn.Click += new System.EventHandler(this.BackLoginBtn_Click);
            // 
            // InputVerCode
            // 
            this.InputVerCode.Location = new System.Drawing.Point(203, 273);
            this.InputVerCode.Name = "InputVerCode";
            this.InputVerCode.Size = new System.Drawing.Size(79, 25);
            this.InputVerCode.TabIndex = 19;
            // 
            // VerCodeText
            // 
            this.VerCodeText.AutoSize = true;
            this.VerCodeText.Location = new System.Drawing.Point(137, 276);
            this.VerCodeText.Name = "VerCodeText";
            this.VerCodeText.Size = new System.Drawing.Size(52, 15);
            this.VerCodeText.TabIndex = 20;
            this.VerCodeText.Text = "验证码";
            // 
            // VerCode
            // 
            this.VerCode.AutoSize = true;
            this.VerCode.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.VerCode.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerCode.Location = new System.Drawing.Point(288, 273);
            this.VerCode.Name = "VerCode";
            this.VerCode.Size = new System.Drawing.Size(56, 25);
            this.VerCode.TabIndex = 21;
            this.VerCode.Text = "1314";
            this.VerCode.Click += new System.EventHandler(this.VerCode_Click);
            // 
            // RegFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.VerCode);
            this.Controls.Add(this.VerCodeText);
            this.Controls.Add(this.InputVerCode);
            this.Controls.Add(this.BackLoginBtn);
            this.Controls.Add(this.IsManage);
            this.Controls.Add(this.RePasswd);
            this.Controls.Add(this.RePasswdLable);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.PasswdLable);
            this.Controls.Add(this.UserNameLable);
            this.Controls.Add(this.Passwd);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.RegLable);
            this.Name = "RegFrm";
            this.Text = "RegFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Label PasswdLable;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.TextBox Passwd;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label RegLable;
        private System.Windows.Forms.Label RePasswdLable;
        private System.Windows.Forms.TextBox RePasswd;
        private System.Windows.Forms.CheckBox IsManage;
        private System.Windows.Forms.Button BackLoginBtn;
        private System.Windows.Forms.TextBox InputVerCode;
        private System.Windows.Forms.Label VerCodeText;
        private System.Windows.Forms.Label VerCode;
    }
}