
namespace KafeSiparisProgrami.Controls
{
    partial class LoginUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.gostercheckBox = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(104, 35);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(129, 22);
            this.emailtxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(104, 81);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(129, 22);
            this.passwordtxt.TabIndex = 3;
            // 
            // gostercheckBox
            // 
            this.gostercheckBox.AutoSize = true;
            this.gostercheckBox.Location = new System.Drawing.Point(259, 83);
            this.gostercheckBox.Name = "gostercheckBox";
            this.gostercheckBox.Size = new System.Drawing.Size(73, 21);
            this.gostercheckBox.TabIndex = 4;
            this.gostercheckBox.Text = "Göster";
            this.gostercheckBox.UseVisualStyleBackColor = true;
            this.gostercheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.gostercheckBox.Click += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(130, 141);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(103, 34);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Giriş Yap";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.gostercheckBox);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(360, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gostercheckBox;
        public System.Windows.Forms.TextBox emailtxt;
        public System.Windows.Forms.TextBox passwordtxt;
        public System.Windows.Forms.Button loginbtn;
    }
}
