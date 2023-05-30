
namespace KafeSiparisProgrami
{
    partial class Musetri_Ekle
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
            this.label1 = new System.Windows.Forms.Label();
            this.numaratxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadtxt = new System.Windows.Forms.TextBox();
            this.ogrencieklebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numaratxt
            // 
            this.numaratxt.Location = new System.Drawing.Point(146, 37);
            this.numaratxt.Name = "numaratxt";
            this.numaratxt.Size = new System.Drawing.Size(158, 22);
            this.numaratxt.TabIndex = 1;
            this.numaratxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(146, 90);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(158, 22);
            this.adtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(146, 137);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(158, 22);
            this.soyadtxt.TabIndex = 1;
            // 
            // ogrencieklebtn
            // 
            this.ogrencieklebtn.Location = new System.Drawing.Point(259, 187);
            this.ogrencieklebtn.Name = "ogrencieklebtn";
            this.ogrencieklebtn.Size = new System.Drawing.Size(111, 37);
            this.ogrencieklebtn.TabIndex = 2;
            this.ogrencieklebtn.Text = "Ekle";
            this.ogrencieklebtn.UseVisualStyleBackColor = true;
            // 
            // Musetri_Ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 225);
            this.Controls.Add(this.ogrencieklebtn);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numaratxt);
            this.Controls.Add(this.label1);
            this.Name = "Musetri_Ekle";
            this.Text = "Musetri_Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numaratxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyadtxt;
        private System.Windows.Forms.Button ogrencieklebtn;
    }
}