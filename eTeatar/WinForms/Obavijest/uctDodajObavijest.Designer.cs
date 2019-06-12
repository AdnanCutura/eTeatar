namespace WinForms.Obavijest
{
    partial class uctDodajObavijest
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
            this.components = new System.ComponentModel.Container();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.rtxbSadrzaj = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.imgSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(39, 498);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(191, 38);
            this.btnSacuvaj.TabIndex = 59;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Naziv obavijesti";
            // 
            // txbNaziv
            // 
            this.txbNaziv.BackColor = System.Drawing.Color.White;
            this.txbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNaziv.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNaziv.Location = new System.Drawing.Point(39, 120);
            this.txbNaziv.MaxLength = 100;
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(191, 25);
            this.txbNaziv.TabIndex = 45;
            this.txbNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNaziv_Validating);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(34, 41);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(241, 29);
            this.lblHeading.TabIndex = 44;
            this.lblHeading.Text = "Dodavanje obavijesti";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 64;
            this.label4.Text = "Sadržaj";
            // 
            // rtxbSadrzaj
            // 
            this.rtxbSadrzaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbSadrzaj.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbSadrzaj.Location = new System.Drawing.Point(39, 269);
            this.rtxbSadrzaj.Name = "rtxbSadrzaj";
            this.rtxbSadrzaj.Size = new System.Drawing.Size(831, 197);
            this.rtxbSadrzaj.TabIndex = 65;
            this.rtxbSadrzaj.Text = "";
            this.rtxbSadrzaj.Validating += new System.ComponentModel.CancelEventHandler(this.RtxbSadrzaj_Validating);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajSliku.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajSliku.Location = new System.Drawing.Point(39, 182);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(191, 38);
            this.btnDodajSliku.TabIndex = 63;
            this.btnDodajSliku.Text = "Dodaj Sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // imgSlika
            // 
            this.imgSlika.Image = global::WinForms.Properties.Resources.news_placeholder;
            this.imgSlika.Location = new System.Drawing.Point(253, 122);
            this.imgSlika.Margin = new System.Windows.Forms.Padding(2);
            this.imgSlika.Name = "imgSlika";
            this.imgSlika.Size = new System.Drawing.Size(191, 98);
            this.imgSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSlika.TabIndex = 62;
            this.imgSlika.TabStop = false;
            // 
            // uctDodajObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.rtxbSadrzaj);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.imgSlika);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.lblHeading);
            this.Name = "uctDodajObavijest";
            this.Size = new System.Drawing.Size(913, 562);
            this.Load += new System.EventHandler(this.UctDodajObavijest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxbSadrzaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox imgSlika;
    }
}
