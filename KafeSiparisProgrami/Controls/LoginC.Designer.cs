
namespace KafeSiparisProgrami.LoginCFolder
{
    partial class LoginC
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
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.gostercheckBox = new System.Windows.Forms.CheckBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(131, 21);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(130, 22);
            this.emailtxt.TabIndex = 2;
            this.emailtxt.TextChanged += new System.EventHandler(this.emailtxt_TextChanged);
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(131, 62);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(130, 22);
            this.sifretxt.TabIndex = 2;
            this.sifretxt.TextChanged += new System.EventHandler(this.sifretxt_TextChanged);
            // 
            // gostercheckBox
            // 
            this.gostercheckBox.AutoSize = true;
            this.gostercheckBox.Location = new System.Drawing.Point(279, 61);
            this.gostercheckBox.Name = "gostercheckBox";
            this.gostercheckBox.Size = new System.Drawing.Size(73, 21);
            this.gostercheckBox.TabIndex = 3;
            this.gostercheckBox.Text = "Göster";
            this.gostercheckBox.UseVisualStyleBackColor = true;
            this.gostercheckBox.CheckedChanged += new System.EventHandler(this.gostercheckBox_CheckedChanged);
            // 
            // Loginbtn
            // 
            this.Loginbtn.Location = new System.Drawing.Point(154, 108);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(89, 38);
            this.Loginbtn.TabIndex = 4;
            this.Loginbtn.Text = "Giriş Yap";
            this.Loginbtn.UseVisualStyleBackColor = true;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // LoginC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.gostercheckBox);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginC";
            this.Size = new System.Drawing.Size(380, 168);
            this.Load += new System.EventHandler(this.LoginC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox gostercheckBox;
        public System.Windows.Forms.TextBox emailtxt;
        public System.Windows.Forms.TextBox sifretxt;
        public System.Windows.Forms.Button Loginbtn;
    }
}
