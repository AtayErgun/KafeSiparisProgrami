﻿
namespace KafeSiparisProgrami
{
    partial class Musetri_Ekle_Duzenle
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
            this.musterieklebtn = new System.Windows.Forms.Button();
            this.resim_pb = new System.Windows.Forms.PictureBox();
            this.resimsecbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.musteripbr = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.resim_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numara";
            // 
            // numaratxt
            // 
            this.numaratxt.Location = new System.Drawing.Point(146, 329);
            this.numaratxt.Name = "numaratxt";
            this.numaratxt.Size = new System.Drawing.Size(158, 22);
            this.numaratxt.TabIndex = 1;
            this.numaratxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad";
            // 
            // adtxt
            // 
            this.adtxt.Location = new System.Drawing.Point(146, 382);
            this.adtxt.Name = "adtxt";
            this.adtxt.Size = new System.Drawing.Size(158, 22);
            this.adtxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad";
            // 
            // soyadtxt
            // 
            this.soyadtxt.Location = new System.Drawing.Point(146, 429);
            this.soyadtxt.Name = "soyadtxt";
            this.soyadtxt.Size = new System.Drawing.Size(158, 22);
            this.soyadtxt.TabIndex = 3;
            // 
            // musterieklebtn
            // 
            this.musterieklebtn.Location = new System.Drawing.Point(318, 476);
            this.musterieklebtn.Name = "musterieklebtn";
            this.musterieklebtn.Size = new System.Drawing.Size(127, 42);
            this.musterieklebtn.TabIndex = 4;
            this.musterieklebtn.Text = "Musteri Ekle";
            this.musterieklebtn.UseVisualStyleBackColor = true;
            this.musterieklebtn.Click += new System.EventHandler(this.musterieklebtn_Click);
            // 
            // resim_pb
            // 
            this.resim_pb.Location = new System.Drawing.Point(54, 4);
            this.resim_pb.Name = "resim_pb";
            this.resim_pb.Size = new System.Drawing.Size(535, 315);
            this.resim_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resim_pb.TabIndex = 5;
            this.resim_pb.TabStop = false;
            // 
            // resimsecbtn
            // 
            this.resimsecbtn.Location = new System.Drawing.Point(533, 287);
            this.resimsecbtn.Name = "resimsecbtn";
            this.resimsecbtn.Size = new System.Drawing.Size(56, 32);
            this.resimsecbtn.TabIndex = 6;
            this.resimsecbtn.Text = "Seç";
            this.resimsecbtn.UseVisualStyleBackColor = true;
            this.resimsecbtn.Click += new System.EventHandler(this.resimsecbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resim";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // musteripbr
            // 
            this.musteripbr.Location = new System.Drawing.Point(122, 476);
            this.musteripbr.Name = "musteripbr";
            this.musteripbr.Size = new System.Drawing.Size(120, 42);
            this.musteripbr.TabIndex = 8;
            this.musteripbr.Visible = false;
            // 
            // Musetri_Ekle_Duzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 523);
            this.Controls.Add(this.musteripbr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resimsecbtn);
            this.Controls.Add(this.resim_pb);
            this.Controls.Add(this.musterieklebtn);
            this.Controls.Add(this.soyadtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numaratxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Musetri_Ekle_Duzenle";
            this.Text = "Musteri_Ekle";
            this.Load += new System.EventHandler(this.Musetri_Ekle_Duzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resim_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox numaratxt;
        public System.Windows.Forms.TextBox adtxt;
        public System.Windows.Forms.TextBox soyadtxt;
        public System.Windows.Forms.Button musterieklebtn;
        private System.Windows.Forms.Button resimsecbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar musteripbr;
        public System.Windows.Forms.PictureBox resim_pb;
    }
}