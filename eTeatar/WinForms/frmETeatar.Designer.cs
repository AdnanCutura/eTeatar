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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserControl = new System.Windows.Forms.Panel();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.uctTeatar1 = new WinForms.Teatar.uctTeatar();
            this.uctDodajTeatar1 = new WinForms.Teatar.uctDodajTeatar();
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
            this.pnlSidebarTop.Location = new System.Drawing.Point(-2, 0);
            this.pnlSidebarTop.Name = "pnlSidebarTop";
            this.pnlSidebarTop.Size = new System.Drawing.Size(197, 223);
            this.pnlSidebarTop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime prezime";
            // 
            // imgAvatar
            // 
            this.imgAvatar.Location = new System.Drawing.Point(27, 19);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(139, 125);
            this.imgAvatar.TabIndex = 25;
            this.imgAvatar.TabStop = false;
            // 
            // pnlSidebarMenu
            // 
            this.pnlSidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.pnlSidebarMenu.Controls.Add(this.btnTeatarMeni);
            this.pnlSidebarMenu.Location = new System.Drawing.Point(-2, 219);
            this.pnlSidebarMenu.Name = "pnlSidebarMenu";
            this.pnlSidebarMenu.Size = new System.Drawing.Size(197, 409);
            this.pnlSidebarMenu.TabIndex = 4;
            // 
            // btnTeatarMeni
            // 
            this.btnTeatarMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnTeatarMeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeatarMeni.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeatarMeni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeatarMeni.Location = new System.Drawing.Point(0, 26);
            this.btnTeatarMeni.Name = "btnTeatarMeni";
            this.btnTeatarMeni.Size = new System.Drawing.Size(197, 38);
            this.btnTeatarMeni.TabIndex = 22;
            this.btnTeatarMeni.Text = "Teatar";
            this.btnTeatarMeni.UseVisualStyleBackColor = false;
            this.btnTeatarMeni.Click += new System.EventHandler(this.BtnTeatarMeni_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pnlUserControl);
            this.pnlHeader.Controls.Add(this.lblMinimize);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Location = new System.Drawing.Point(194, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1127, 62);
            this.pnlHeader.TabIndex = 24;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlHeader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "eTeatar";
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.Location = new System.Drawing.Point(2, 63);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1125, 565);
            this.pnlUserControl.TabIndex = 4;
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Font = new System.Drawing.Font("Raleway Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(1040, 9);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(24, 29);
            this.lblMinimize.TabIndex = 3;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1069, 9);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(28, 29);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // uctTeatar1
            // 
            this.uctTeatar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.uctTeatar1.Location = new System.Drawing.Point(196, 63);
            this.uctTeatar1.Name = "uctTeatar1";
            this.uctTeatar1.Size = new System.Drawing.Size(1125, 565);
            this.uctTeatar1.TabIndex = 25;
            // 
            // uctDodajTeatar1
            // 
            this.uctDodajTeatar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.uctDodajTeatar1.ForeColor = System.Drawing.Color.White;
            this.uctDodajTeatar1.Location = new System.Drawing.Point(194, 62);
            this.uctDodajTeatar1.Name = "uctDodajTeatar1";
            this.uctDodajTeatar1.Size = new System.Drawing.Size(1127, 562);
            this.uctDodajTeatar1.TabIndex = 26;
            // 
            // frmETeatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 626);
            this.Controls.Add(this.uctTeatar1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebarMenu);
            this.Controls.Add(this.pnlSidebarTop);
            this.Controls.Add(this.uctDodajTeatar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private uctTeatar uctTeatar1;
        private System.Windows.Forms.Label label1;
        private uctDodajTeatar uctDodajTeatar1;
    }
}