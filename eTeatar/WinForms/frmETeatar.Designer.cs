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
            this.lblImePrezime = new System.Windows.Forms.Label();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.pnlSidebarMenu = new System.Windows.Forms.Panel();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.btnPredstave = new System.Windows.Forms.Button();
            this.btnGlumac = new System.Windows.Forms.Button();
            this.btnDvorane = new System.Windows.Forms.Button();
            this.btnObavijesti = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnPostavke = new System.Windows.Forms.Button();
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
            this.pnlSidebarTop.Controls.Add(this.lblImePrezime);
            this.pnlSidebarTop.Controls.Add(this.imgAvatar);
            this.pnlSidebarTop.Location = new System.Drawing.Point(-3, 0);
            this.pnlSidebarTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebarTop.Name = "pnlSidebarTop";
            this.pnlSidebarTop.Size = new System.Drawing.Size(263, 274);
            this.pnlSidebarTop.TabIndex = 3;
            // 
            // lblImePrezime
            // 
            this.lblImePrezime.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImePrezime.ForeColor = System.Drawing.Color.White;
            this.lblImePrezime.Location = new System.Drawing.Point(19, 193);
            this.lblImePrezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImePrezime.Name = "lblImePrezime";
            this.lblImePrezime.Size = new System.Drawing.Size(220, 73);
            this.lblImePrezime.TabIndex = 4;
            this.lblImePrezime.Text = "Ime prezime";
            this.lblImePrezime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgAvatar
            // 
            this.imgAvatar.Image = global::WinForms.Properties.Resources.avatar_1577909_640;
            this.imgAvatar.Location = new System.Drawing.Point(36, 23);
            this.imgAvatar.Margin = new System.Windows.Forms.Padding(4);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(185, 166);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar.TabIndex = 25;
            this.imgAvatar.TabStop = false;
            // 
            // pnlSidebarMenu
            // 
            this.pnlSidebarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(20)))), ((int)(((byte)(44)))));
            this.pnlSidebarMenu.Controls.Add(this.btnNarudzbe);
            this.pnlSidebarMenu.Controls.Add(this.btnPredstave);
            this.pnlSidebarMenu.Controls.Add(this.btnGlumac);
            this.pnlSidebarMenu.Controls.Add(this.btnDvorane);
            this.pnlSidebarMenu.Controls.Add(this.btnObavijesti);
            this.pnlSidebarMenu.Controls.Add(this.btnKorisnici);
            this.pnlSidebarMenu.Controls.Add(this.btnPostavke);
            this.pnlSidebarMenu.Controls.Add(this.btnTeatarMeni);
            this.pnlSidebarMenu.Location = new System.Drawing.Point(-3, 270);
            this.pnlSidebarMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebarMenu.Name = "pnlSidebarMenu";
            this.pnlSidebarMenu.Size = new System.Drawing.Size(263, 737);
            this.pnlSidebarMenu.TabIndex = 4;
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNarudzbe.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNarudzbe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNarudzbe.Location = new System.Drawing.Point(0, 308);
            this.btnNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(263, 47);
            this.btnNarudzbe.TabIndex = 27;
            this.btnNarudzbe.Text = "Narudžbe";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.BtnNarudzbe_Click);
            // 
            // btnPredstave
            // 
            this.btnPredstave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnPredstave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPredstave.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPredstave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPredstave.Location = new System.Drawing.Point(0, 170);
            this.btnPredstave.Margin = new System.Windows.Forms.Padding(4);
            this.btnPredstave.Name = "btnPredstave";
            this.btnPredstave.Size = new System.Drawing.Size(263, 47);
            this.btnPredstave.TabIndex = 26;
            this.btnPredstave.Text = "Predstave";
            this.btnPredstave.UseVisualStyleBackColor = false;
            this.btnPredstave.Click += new System.EventHandler(this.BtnPredstave_Click);
            // 
            // btnGlumac
            // 
            this.btnGlumac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnGlumac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGlumac.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGlumac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGlumac.Location = new System.Drawing.Point(-1, 78);
            this.btnGlumac.Margin = new System.Windows.Forms.Padding(4);
            this.btnGlumac.Name = "btnGlumac";
            this.btnGlumac.Size = new System.Drawing.Size(264, 47);
            this.btnGlumac.TabIndex = 23;
            this.btnGlumac.Text = "Glumci";
            this.btnGlumac.UseVisualStyleBackColor = false;
            this.btnGlumac.Click += new System.EventHandler(this.BtnGlumac_Click);
            // 
            // btnDvorane
            // 
            this.btnDvorane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnDvorane.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDvorane.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDvorane.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDvorane.Location = new System.Drawing.Point(-1, 124);
            this.btnDvorane.Margin = new System.Windows.Forms.Padding(4);
            this.btnDvorane.Name = "btnDvorane";
            this.btnDvorane.Size = new System.Drawing.Size(263, 47);
            this.btnDvorane.TabIndex = 26;
            this.btnDvorane.Text = "Dvorane";
            this.btnDvorane.UseVisualStyleBackColor = false;
            this.btnDvorane.Click += new System.EventHandler(this.BtnDvorane_Click);
            // 
            // btnObavijesti
            // 
            this.btnObavijesti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnObavijesti.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObavijesti.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObavijesti.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObavijesti.Location = new System.Drawing.Point(1, 216);
            this.btnObavijesti.Margin = new System.Windows.Forms.Padding(4);
            this.btnObavijesti.Name = "btnObavijesti";
            this.btnObavijesti.Size = new System.Drawing.Size(263, 47);
            this.btnObavijesti.TabIndex = 23;
            this.btnObavijesti.Text = "Obavijesti";
            this.btnObavijesti.UseVisualStyleBackColor = false;
            this.btnObavijesti.Click += new System.EventHandler(this.BtnObavijesti_Click);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKorisnici.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKorisnici.Location = new System.Drawing.Point(0, 262);
            this.btnKorisnici.Margin = new System.Windows.Forms.Padding(4);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(263, 47);
            this.btnKorisnici.TabIndex = 25;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.UseVisualStyleBackColor = false;
            this.btnKorisnici.Click += new System.EventHandler(this.BtnKorisnici_Click);
            // 
            // btnPostavke
            // 
            this.btnPostavke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnPostavke.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPostavke.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostavke.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPostavke.Location = new System.Drawing.Point(1, 354);
            this.btnPostavke.Margin = new System.Windows.Forms.Padding(4);
            this.btnPostavke.Name = "btnPostavke";
            this.btnPostavke.Size = new System.Drawing.Size(263, 47);
            this.btnPostavke.TabIndex = 24;
            this.btnPostavke.Text = "Postavke";
            this.btnPostavke.UseVisualStyleBackColor = false;
            this.btnPostavke.Click += new System.EventHandler(this.BtnPostavke_Click);
            // 
            // btnTeatarMeni
            // 
            this.btnTeatarMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(10)))), ((int)(((byte)(50)))));
            this.btnTeatarMeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTeatarMeni.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeatarMeni.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTeatarMeni.Location = new System.Drawing.Point(1, 32);
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
            this.lblWinDown.Font = new System.Drawing.Font("Raleway", 19F);
            this.lblWinDown.ForeColor = System.Drawing.Color.White;
            this.lblWinDown.Location = new System.Drawing.Point(1393, 16);
            this.lblWinDown.Name = "lblWinDown";
            this.lblWinDown.Size = new System.Drawing.Size(48, 39);
            this.lblWinDown.TabIndex = 28;
            this.lblWinDown.Text = "—";
            this.lblWinDown.Click += new System.EventHandler(this.LblWinDown_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClose.Font = new System.Drawing.Font("Raleway", 19F);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(1443, 16);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(39, 39);
            this.lblClose.TabIndex = 27;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 35);
            this.label1.TabIndex = 26;
            this.label1.Text = "eTeatar";
            // 
            // pnlUserControl
            // 
            this.pnlUserControl.AutoScrollMargin = new System.Drawing.Size(2000, 2000);
            this.pnlUserControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.pnlUserControl.Location = new System.Drawing.Point(259, 76);
            this.pnlUserControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlUserControl.Name = "pnlUserControl";
            this.pnlUserControl.Size = new System.Drawing.Size(1503, 930);
            this.pnlUserControl.TabIndex = 25;
            // 
            // frmETeatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 1007);
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
        private System.Windows.Forms.Label lblImePrezime;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlUserControl;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblWinDown;
        private System.Windows.Forms.Button btnObavijesti;
        private System.Windows.Forms.Button btnGlumac;
        private System.Windows.Forms.Button btnPostavke;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnPredstave;
        private System.Windows.Forms.Button btnDvorane;
        private System.Windows.Forms.Button btnNarudzbe;
    }
}