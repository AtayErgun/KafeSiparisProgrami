
namespace KafeSiparisProgrami
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Kullanıcıgrişbtn = new System.Windows.Forms.Button();
            this.yenikullanıcıbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 270);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Kullanıcıgrişbtn
            // 
            this.Kullanıcıgrişbtn.Location = new System.Drawing.Point(12, 12);
            this.Kullanıcıgrişbtn.Name = "Kullanıcıgrişbtn";
            this.Kullanıcıgrişbtn.Size = new System.Drawing.Size(109, 37);
            this.Kullanıcıgrişbtn.TabIndex = 0;
            this.Kullanıcıgrişbtn.Text = "Kullanıcı Girişi";
            this.Kullanıcıgrişbtn.UseVisualStyleBackColor = true;
            this.Kullanıcıgrişbtn.Click += new System.EventHandler(this.Kullanıcıgrişbtn_Click);
            // 
            // yenikullanıcıbtn
            // 
            this.yenikullanıcıbtn.Location = new System.Drawing.Point(140, 12);
            this.yenikullanıcıbtn.Name = "yenikullanıcıbtn";
            this.yenikullanıcıbtn.Size = new System.Drawing.Size(104, 37);
            this.yenikullanıcıbtn.TabIndex = 1;
            this.yenikullanıcıbtn.Text = "Yeni Kullanıcı ";
            this.yenikullanıcıbtn.UseVisualStyleBackColor = true;
            this.yenikullanıcıbtn.Click += new System.EventHandler(this.yenikullanıcıbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 416);
            this.Controls.Add(this.yenikullanıcıbtn);
            this.Controls.Add(this.Kullanıcıgrişbtn);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Kullanıcıgrişbtn;
        private System.Windows.Forms.Button yenikullanıcıbtn;
    }
}

