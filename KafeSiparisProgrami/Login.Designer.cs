
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
            this.girisyapbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // girisyapbtn
            // 
            this.girisyapbtn.Location = new System.Drawing.Point(284, 171);
            this.girisyapbtn.Name = "girisyapbtn";
            this.girisyapbtn.Size = new System.Drawing.Size(119, 43);
            this.girisyapbtn.TabIndex = 0;
            this.girisyapbtn.Text = "Giriş Yap";
            this.girisyapbtn.UseVisualStyleBackColor = true;
            this.girisyapbtn.Click += new System.EventHandler(this.girisyapbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.girisyapbtn);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button girisyapbtn;
    }
}

