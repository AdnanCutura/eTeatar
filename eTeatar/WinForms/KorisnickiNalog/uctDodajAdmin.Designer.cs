namespace WinForms.KorisnickiNalog
{
    partial class uctDodajAdmin
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBrojTelefona = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSifra = new System.Windows.Forms.TextBox();
            this.txbSifraPotvrda = new System.Windows.Forms.TextBox();
            this.lblSifa = new System.Windows.Forms.Label();
            this.lblSifraPotvrda = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txbKorisnickoIme = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(31, 38);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(234, 29);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "Dodaj novog admina";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.White;
            this.lblIme.Location = new System.Drawing.Point(33, 155);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(36, 20);
            this.lblIme.TabIndex = 28;
            this.lblIme.Text = "Ime";
            // 
            // txbIme
            // 
            this.txbIme.BackColor = System.Drawing.Color.White;
            this.txbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIme.Location = new System.Drawing.Point(36, 176);
            this.txbIme.MaxLength = 100;
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(191, 24);
            this.txbIme.TabIndex = 27;
            this.txbIme.Validating += new System.ComponentModel.CancelEventHandler(this.TxbIme_Validating);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrezime.ForeColor = System.Drawing.Color.White;
            this.lblPrezime.Location = new System.Drawing.Point(34, 221);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(66, 20);
            this.lblPrezime.TabIndex = 30;
            this.lblPrezime.Text = "Prezime";
            // 
            // txbPrezime
            // 
            this.txbPrezime.BackColor = System.Drawing.Color.White;
            this.txbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrezime.Location = new System.Drawing.Point(37, 242);
            this.txbPrezime.MaxLength = 100;
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(191, 24);
            this.txbPrezime.TabIndex = 29;
            this.txbPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.TxbPrezime_Validating);
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(360, 411);
            this.txbEmail.MaxLength = 100;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(191, 24);
            this.txbEmail.TabIndex = 27;
            this.txbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmail_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(357, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Email";
            // 
            // txbBrojTelefona
            // 
            this.txbBrojTelefona.BackColor = System.Drawing.Color.White;
            this.txbBrojTelefona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBrojTelefona.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrojTelefona.Location = new System.Drawing.Point(361, 341);
            this.txbBrojTelefona.MaxLength = 100;
            this.txbBrojTelefona.Name = "txbBrojTelefona";
            this.txbBrojTelefona.Size = new System.Drawing.Size(191, 24);
            this.txbBrojTelefona.TabIndex = 29;
            this.txbBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.TxbBrojTelefona_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(358, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Broj telefona";
            // 
            // txbSifra
            // 
            this.txbSifra.BackColor = System.Drawing.Color.White;
            this.txbSifra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSifra.CausesValidation = false;
            this.txbSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSifra.Location = new System.Drawing.Point(36, 341);
            this.txbSifra.MaxLength = 100;
            this.txbSifra.Name = "txbSifra";
            this.txbSifra.PasswordChar = '*';
            this.txbSifra.Size = new System.Drawing.Size(191, 24);
            this.txbSifra.TabIndex = 29;
            this.txbSifra.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNovaSifra_Validating);
            // 
            // txbSifraPotvrda
            // 
            this.txbSifraPotvrda.BackColor = System.Drawing.Color.White;
            this.txbSifraPotvrda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSifraPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSifraPotvrda.Location = new System.Drawing.Point(36, 410);
            this.txbSifraPotvrda.MaxLength = 100;
            this.txbSifraPotvrda.Name = "txbSifraPotvrda";
            this.txbSifraPotvrda.PasswordChar = '*';
            this.txbSifraPotvrda.Size = new System.Drawing.Size(191, 24);
            this.txbSifraPotvrda.TabIndex = 29;
            this.txbSifraPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNovaSifraPotvrda_Validating);
            // 
            // lblSifa
            // 
            this.lblSifa.AutoSize = true;
            this.lblSifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifa.ForeColor = System.Drawing.Color.White;
            this.lblSifa.Location = new System.Drawing.Point(33, 320);
            this.lblSifa.Name = "lblSifa";
            this.lblSifa.Size = new System.Drawing.Size(37, 20);
            this.lblSifa.TabIndex = 30;
            this.lblSifa.Text = "Sifa";
            // 
            // lblSifraPotvrda
            // 
            this.lblSifraPotvrda.AutoSize = true;
            this.lblSifraPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifraPotvrda.ForeColor = System.Drawing.Color.White;
            this.lblSifraPotvrda.Location = new System.Drawing.Point(33, 389);
            this.lblSifraPotvrda.Name = "lblSifraPotvrda";
            this.lblSifraPotvrda.Size = new System.Drawing.Size(97, 20);
            this.lblSifraPotvrda.TabIndex = 30;
            this.lblSifraPotvrda.Text = "Potvrda sifre";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(37, 491);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(191, 38);
            this.btnSacuvaj.TabIndex = 40;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajSliku.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajSliku.Location = new System.Drawing.Point(363, 243);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(191, 38);
            this.btnDodajSliku.TabIndex = 41;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // imgAvatar
            // 
            this.imgAvatar.Image = global::WinForms.Properties.Resources.avatar_1577909_640;
            this.imgAvatar.Location = new System.Drawing.Point(386, 94);
            this.imgAvatar.Name = "imgAvatar";
            this.imgAvatar.Size = new System.Drawing.Size(139, 125);
            this.imgAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAvatar.TabIndex = 42;
            this.imgAvatar.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Korisnicko Ime";
            // 
            // txbKorisnickoIme
            // 
            this.txbKorisnickoIme.BackColor = System.Drawing.Color.White;
            this.txbKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKorisnickoIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKorisnickoIme.Location = new System.Drawing.Point(36, 115);
            this.txbKorisnickoIme.MaxLength = 100;
            this.txbKorisnickoIme.Name = "txbKorisnickoIme";
            this.txbKorisnickoIme.Size = new System.Drawing.Size(191, 24);
            this.txbKorisnickoIme.TabIndex = 43;
            this.txbKorisnickoIme.Validating += new System.ComponentModel.CancelEventHandler(this.TxbKorisnickoIme_Validating_1);
            // 
            // uctDodajAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbKorisnickoIme);
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblSifraPotvrda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSifa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txbSifraPotvrda);
            this.Controls.Add(this.txbBrojTelefona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSifra);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.lblHeading);
            this.Name = "uctDodajAdmin";
            this.Size = new System.Drawing.Size(1127, 566);
            this.Load += new System.EventHandler(this.UctPostavke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBrojTelefona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSifra;
        private System.Windows.Forms.TextBox txbSifraPotvrda;
        private System.Windows.Forms.Label lblSifa;
        private System.Windows.Forms.Label lblSifraPotvrda;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbKorisnickoIme;
    }
}
