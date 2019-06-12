namespace WinForms.KorisnickiNalog
{
    partial class uctPostavke
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
            this.txbNovaSifra = new System.Windows.Forms.TextBox();
            this.txbNovaSifraPotvrda = new System.Windows.Forms.TextBox();
            this.lblNovaSifra = new System.Windows.Forms.Label();
            this.lblNovaSifraPotvrda = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.imgAvatar = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.lblHeading.Size = new System.Drawing.Size(111, 29);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "Postavke";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIme.ForeColor = System.Drawing.Color.White;
            this.lblIme.Location = new System.Drawing.Point(33, 89);
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
            this.txbIme.Location = new System.Drawing.Point(36, 110);
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
            this.lblPrezime.Location = new System.Drawing.Point(34, 169);
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
            this.txbPrezime.Location = new System.Drawing.Point(37, 190);
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
            this.txbEmail.Location = new System.Drawing.Point(360, 400);
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
            this.label1.Location = new System.Drawing.Point(357, 379);
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
            this.txbBrojTelefona.Location = new System.Drawing.Point(361, 313);
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
            this.label2.Location = new System.Drawing.Point(358, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Broj telefona";
            // 
            // txbNovaSifra
            // 
            this.txbNovaSifra.BackColor = System.Drawing.Color.White;
            this.txbNovaSifra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNovaSifra.CausesValidation = false;
            this.txbNovaSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNovaSifra.Location = new System.Drawing.Point(36, 313);
            this.txbNovaSifra.MaxLength = 100;
            this.txbNovaSifra.Name = "txbNovaSifra";
            this.txbNovaSifra.PasswordChar = '*';
            this.txbNovaSifra.Size = new System.Drawing.Size(191, 24);
            this.txbNovaSifra.TabIndex = 29;
            this.txbNovaSifra.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNovaSifra_Validating);
            // 
            // txbNovaSifraPotvrda
            // 
            this.txbNovaSifraPotvrda.BackColor = System.Drawing.Color.White;
            this.txbNovaSifraPotvrda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNovaSifraPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNovaSifraPotvrda.Location = new System.Drawing.Point(36, 400);
            this.txbNovaSifraPotvrda.MaxLength = 100;
            this.txbNovaSifraPotvrda.Name = "txbNovaSifraPotvrda";
            this.txbNovaSifraPotvrda.PasswordChar = '*';
            this.txbNovaSifraPotvrda.Size = new System.Drawing.Size(191, 24);
            this.txbNovaSifraPotvrda.TabIndex = 29;
            this.txbNovaSifraPotvrda.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNovaSifraPotvrda_Validating);
            // 
            // lblNovaSifra
            // 
            this.lblNovaSifra.AutoSize = true;
            this.lblNovaSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSifra.ForeColor = System.Drawing.Color.White;
            this.lblNovaSifra.Location = new System.Drawing.Point(33, 292);
            this.lblNovaSifra.Name = "lblNovaSifra";
            this.lblNovaSifra.Size = new System.Drawing.Size(79, 20);
            this.lblNovaSifra.TabIndex = 30;
            this.lblNovaSifra.Text = "Nova sifra";
            // 
            // lblNovaSifraPotvrda
            // 
            this.lblNovaSifraPotvrda.AutoSize = true;
            this.lblNovaSifraPotvrda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovaSifraPotvrda.ForeColor = System.Drawing.Color.White;
            this.lblNovaSifraPotvrda.Location = new System.Drawing.Point(33, 379);
            this.lblNovaSifraPotvrda.Name = "lblNovaSifraPotvrda";
            this.lblNovaSifraPotvrda.Size = new System.Drawing.Size(135, 20);
            this.lblNovaSifraPotvrda.TabIndex = 30;
            this.lblNovaSifraPotvrda.Text = "Potvrda nove sifre";
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
            this.btnDodajSliku.Location = new System.Drawing.Point(362, 213);
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
            this.imgAvatar.Location = new System.Drawing.Point(385, 64);
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
            // uctPostavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.imgAvatar);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.lblNovaSifraPotvrda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNovaSifra);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.txbNovaSifraPotvrda);
            this.Controls.Add(this.txbBrojTelefona);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbNovaSifra);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.lblHeading);
            this.Name = "uctPostavke";
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
        private System.Windows.Forms.TextBox txbNovaSifra;
        private System.Windows.Forms.TextBox txbNovaSifraPotvrda;
        private System.Windows.Forms.Label lblNovaSifra;
        private System.Windows.Forms.Label lblNovaSifraPotvrda;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.PictureBox imgAvatar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
