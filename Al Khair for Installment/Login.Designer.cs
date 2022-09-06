namespace Al_Khair_for_Installment
{
    partial class Login
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
            this.passowrd = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.loginb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passowrd
            // 
            this.passowrd.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passowrd.Location = new System.Drawing.Point(624, 238);
            this.passowrd.Multiline = true;
            this.passowrd.Name = "passowrd";
            this.passowrd.PasswordChar = '*';
            this.passowrd.Size = new System.Drawing.Size(538, 43);
            this.passowrd.TabIndex = 0;
            this.passowrd.Tag = "";
            this.passowrd.Text = "كلمة المرور";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(624, 137);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(538, 43);
            this.user.TabIndex = 1;
            this.user.Tag = "";
            this.user.Text = "اسم المستخدم";
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // loginb
            // 
            this.loginb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginb.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginb.ForeColor = System.Drawing.Color.Coral;
            this.loginb.Location = new System.Drawing.Point(796, 304);
            this.loginb.Name = "loginb";
            this.loginb.Size = new System.Drawing.Size(196, 112);
            this.loginb.TabIndex = 2;
            this.loginb.Text = "تسجيل الدخول";
            this.loginb.UseVisualStyleBackColor = false;
            this.loginb.Click += new System.EventHandler(this.loginb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(879, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "يرجا عدم محاولة اداخل معلومات خطاء كثيرا لتجنب اغلاق النظام";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Al_Khair_for_Installment.Properties.Resources.My_project_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1198, 571);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginb);
            this.Controls.Add(this.user);
            this.Controls.Add(this.passowrd);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "تسجيل دخول الادارة";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passowrd;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Button loginb;
        private System.Windows.Forms.Label label1;
    }
}