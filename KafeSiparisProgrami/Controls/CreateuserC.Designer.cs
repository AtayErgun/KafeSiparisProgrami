
namespace KafeSiparisProgrami.Controls
{
    partial class CreateuserC
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
            this.Createubtn = new System.Windows.Forms.Button();
            this.gostercheckBox = new System.Windows.Forms.CheckBox();
            this.sifretxt = new System.Windows.Forms.TextBox();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Createubtn
            // 
            this.Createubtn.Location = new System.Drawing.Point(105, 122);
            this.Createubtn.Name = "Createubtn";
            this.Createubtn.Size = new System.Drawing.Size(120, 47);
            this.Createubtn.TabIndex = 10;
            this.Createubtn.Text = "Kullanıcı Oluştur";
            this.Createubtn.UseVisualStyleBackColor = true;
            this.Createubtn.Click += new System.EventHandler(this.createubtn_Click);
            // 
            // gostercheckBox
            // 
            this.gostercheckBox.AutoSize = true;
            this.gostercheckBox.Location = new System.Drawing.Point(264, 75);
            this.gostercheckBox.Name = "gostercheckBox";
            this.gostercheckBox.Size = new System.Drawing.Size(73, 21);
            this.gostercheckBox.TabIndex = 9;
            this.gostercheckBox.Text = "Göster";
            this.gostercheckBox.UseVisualStyleBackColor = true;
            this.gostercheckBox.CheckedChanged += new System.EventHandler(this.gostercheckBox_CheckedChanged);
            // 
            // sifretxt
            // 
            this.sifretxt.Location = new System.Drawing.Point(105, 75);
            this.sifretxt.Name = "sifretxt";
            this.sifretxt.PasswordChar = '*';
            this.sifretxt.Size = new System.Drawing.Size(130, 22);
            this.sifretxt.TabIndex = 7;
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(105, 30);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(130, 22);
            this.emailtxt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Mail";
            // 
            // CreateuserC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Createubtn);
            this.Controls.Add(this.gostercheckBox);
            this.Controls.Add(this.sifretxt);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateuserC";
            this.Size = new System.Drawing.Size(342, 201);
            this.Load += new System.EventHandler(this.CreateuserC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox gostercheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button Createubtn;
        public System.Windows.Forms.TextBox sifretxt;
        public System.Windows.Forms.TextBox emailtxt;
    }
}
