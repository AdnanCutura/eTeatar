namespace WinForms.Teatar
{
    partial class frmETeatar
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
            this.pnlSidebarTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.pnlSidebarMenu = new System.Windows.Forms.Panel();
            this.btnTeatarMeni = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWinDown = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.pnlSidebarTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            this.pnlSidebarMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebarTop
            // 
            this.pnlSidebarTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.pnlSidebarTop.Controls.Add(this.label2);
            this.pnlSidebarTop.Controls.Add(this.imgAvatar);
            this.pnlSidebarTop.Location = new System.Drawing.Point(-3, 0);
            this.pnlSidebarTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebarTop.Name = "pnlSidebarTop";
            this.pnlSidebarTop.Size = new System.Drawing.Size(263, 274);
            this.pnlSidebarTop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime prezime";
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(36, 23);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(185, 154);
            this.imgAvatar.TabIndex = 25;
            this.imgAvatar.TabStop = false;
            // 
            // pnlSidebarMenu
            // 
            this.pnlSidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.pnlSidebarMenu.Controls.Add(this.btnTeatarMeni);
            this.pnlSidebarMenu.Location = new System.Drawing.Point(-3, 270);
            this.pnlSidebarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebarMenu.Name = "pnlSidebarMenu";
            this.pnlSidebarMenu.Size = new System.Drawing.Size(263, 503);
            this.pnlSidebarMenu.TabIndex = 4;
            // 
            // btnTeatarMeni
            // 
            this.btnTeatarMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnTeatarMeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeatarMeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeatarMeni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeatarMeni.Location = new System.Drawing.Point(0, 32);
            this.btnTeatarMeni.Margin = new System.Windows.Forms.Padding(4);
            this.btnTeatarMeni.Name = "btnTeatarMeni";
            this.btnTeatarMeni.Size = new System.Drawing.Size(263, 47);
            this.btnTeatarMeni.TabIndex = 22;
            this.btnTeatarMeni.Text = "Teatar";
            this.btnTeatarMeni.UseVisualStyleBackColor = false;
            this.btnTeatarMeni.Click += new System.EventHandler(this.BtnTeatarMeni_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.pnlHeader.Controls.Add(this.lblWinDown);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Location = new System.Drawing.Point(259, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1503, 76);
            this.pnlHeader.TabIndex = 24;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // lblWinDown
            // 
            this.lblWinDown.AutoSize = true;
            this.lblWinDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWinDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.lblWinDown.ForeColor = System.Drawing.Color.White;
            this.lblWinDown.Location = new System.Drawing.Point(1400, 16);
            this.lblWinDown.Name = "lblWinDown";
            this.lblWinDown.Size = new System.Drawing.Size(37, 39);
            this.lblWinDown.TabIndex = 28;
            this.lblWinDown.Text = "—";
            this.lblWinDown.Click += new System.EventHandler(this.LblWinDown_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1443, 16);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(40, 39);
            this.lblClose.TabIndex = 27;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "eTeatar";
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.pnlUserControl.Location = new System.Drawing.Point(259, 76);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1503, 697);
            this.pnlUserControl.TabIndex = 25;
            // 
            // frmETeatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 770);
            this.Controls.Add(this.pnlUserControl);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebarMenu);
            this.Controls.Add(this.pnlSidebarTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmETeatar";
            this.Text = "frmETeatar";
            this.Load += new System.EventHandler(this.FrmTeatar_Load);
            this.pnlSidebarTop.ResumeLayout(false);
            this.pnlSidebarTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            this.pnlSidebarMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlSidebarTop;
        private System.Windows.Forms.Panel pnlSidebarMenu;
        private System.Windows.Forms.Button btnTeatarMeni;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblWinDown;
    }
}