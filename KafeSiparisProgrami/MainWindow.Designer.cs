
namespace KafeSiparisProgrami
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.button1 = new System.Windows.Forms.Button();
            this.musteriler_dtgrvw = new System.Windows.Forms.DataGridView();
            this.dtgrid_cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenle_tsmenü = new System.Windows.Forms.ToolStripMenuItem();
            this.sil_tsmenü = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_lbl = new System.Windows.Forms.Label();
            this.status_Pb = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.musteriler_dtgrvw)).BeginInit();
            this.dtgrid_cms.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // musteriler_dtgrvw
            // 
            this.musteriler_dtgrvw.AllowUserToAddRows = false;
            this.musteriler_dtgrvw.AllowUserToDeleteRows = false;
            this.musteriler_dtgrvw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.musteriler_dtgrvw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musteriler_dtgrvw.ContextMenuStrip = this.dtgrid_cms;
            this.musteriler_dtgrvw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.musteriler_dtgrvw.Location = new System.Drawing.Point(0, 45);
            this.musteriler_dtgrvw.Name = "musteriler_dtgrvw";
            this.musteriler_dtgrvw.RowHeadersWidth = 51;
            this.musteriler_dtgrvw.RowTemplate.Height = 24;
            this.musteriler_dtgrvw.Size = new System.Drawing.Size(808, 365);
            this.musteriler_dtgrvw.TabIndex = 1;
            // 
            // dtgrid_cms
            // 
            this.dtgrid_cms.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.dtgrid_cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenle_tsmenü,
            this.sil_tsmenü});
            this.dtgrid_cms.Name = "dtgrid_cms";
            this.dtgrid_cms.Size = new System.Drawing.Size(211, 80);
            this.dtgrid_cms.Opening += new System.ComponentModel.CancelEventHandler(this.dtgrid_cms_Opening);
            // 
            // düzenle_tsmenü
            // 
            this.düzenle_tsmenü.Name = "düzenle_tsmenü";
            this.düzenle_tsmenü.Size = new System.Drawing.Size(210, 24);
            this.düzenle_tsmenü.Text = "Düzenle";
            this.düzenle_tsmenü.Click += new System.EventHandler(this.düzenle_tsmenü_Click);
            // 
            // sil_tsmenü
            // 
            this.sil_tsmenü.Name = "sil_tsmenü";
            this.sil_tsmenü.Size = new System.Drawing.Size(210, 24);
            this.sil_tsmenü.Text = "Sil";
            this.sil_tsmenü.Click += new System.EventHandler(this.sil_tsmenü_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.status_lbl);
            this.panel1.Controls.Add(this.status_Pb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 44);
            this.panel1.TabIndex = 2;
            // 
            // status_lbl
            // 
            this.status_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.status_lbl.AutoEllipsis = true;
            this.status_lbl.Location = new System.Drawing.Point(0, 0);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.status_lbl.Size = new System.Drawing.Size(690, 41);
            this.status_lbl.TabIndex = 1;
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.status_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // status_Pb
            // 
            this.status_Pb.Location = new System.Drawing.Point(696, 0);
            this.status_Pb.Name = "status_Pb";
            this.status_Pb.Size = new System.Drawing.Size(109, 44);
            this.status_Pb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.status_Pb.TabIndex = 0;
            this.status_Pb.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.musteriler_dtgrvw);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Sipariş Programı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.musteriler_dtgrvw)).EndInit();
            this.dtgrid_cms.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView musteriler_dtgrvw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar status_Pb;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.ContextMenuStrip dtgrid_cms;
        private System.Windows.Forms.ToolStripMenuItem düzenle_tsmenü;
        private System.Windows.Forms.ToolStripMenuItem sil_tsmenü;
    }
}