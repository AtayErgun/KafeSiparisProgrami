
namespace KafeSiparisProgrami.Controls
{
    partial class CreateuserUC
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
            this.createbtn = new System.Windows.Forms.Button();
            this.gostercheckBox = new System.Windows.Forms.CheckBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(88, 136);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(129, 37);
            this.createbtn.TabIndex = 11;
            this.createbtn.Text = "Kullanıcı Oluştur";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.Click += new System.EventHandler(this.Createbtn_Click);
            // 
            // gostercheckBox
            // 
            this.gostercheckBox.AutoSize = true;
            this.gostercheckBox.Location = new System.Drawing.Point(243, 82);
            this.gostercheckBox.Name = "gostercheckBox";
            this.gostercheckBox.Size = new System.Drawing.Size(73, 21);
            this.gostercheckBox.TabIndex = 10;
            this.gostercheckBox.Text = "Göster";
            this.gostercheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(88, 80);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(129, 22);
            this.passwordtxt.TabIndex = 9;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(88, 34);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(129, 22);
            this.emailtxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "E Mail";
            // 
            // CreateuserUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createbtn);
            this.Controls.Add(this.gostercheckBox);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateuserUC";
            this.Size = new System.Drawing.Size(321, 213);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox gostercheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox passwordtxt;
        public System.Windows.Forms.TextBox emailtxt;
        public System.Windows.Forms.Button createbtn;
    }
}
