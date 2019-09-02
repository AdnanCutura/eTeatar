using System.ComponentModel;

namespace WinForms.Teatar
{
    partial class uctDodajTeatar
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txbVrijemeZatvaranja = new System.Windows.Forms.MaskedTextBox();
            this.txbVrijemeOtvaranja = new System.Windows.Forms.MaskedTextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.cmbGrad = new System.Windows.Forms.ComboBox();
            this.cmbDrzava = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBrojTelefona = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbAdresa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txbVrijemeZatvaranja
            // 
            this.txbVrijemeZatvaranja.Font = new System.Drawing.Font("Raleway", 11.25F);
            this.txbVrijemeZatvaranja.Location = new System.Drawing.Point(600, 306);
            this.txbVrijemeZatvaranja.Margin = new System.Windows.Forms.Padding(4);
            this.txbVrijemeZatvaranja.Mask = "00:00";
            this.txbVrijemeZatvaranja.Name = "txbVrijemeZatvaranja";
            this.txbVrijemeZatvaranja.Size = new System.Drawing.Size(68, 30);
            this.txbVrijemeZatvaranja.TabIndex = 41;
            this.txbVrijemeZatvaranja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbVrijemeZatvaranja.ValidatingType = typeof(System.DateTime);
            this.txbVrijemeZatvaranja.Validating += new System.ComponentModel.CancelEventHandler(this.TxbVrijemeZatvaranja_Validating);
            // 
            // txbVrijemeOtvaranja
            // 
            this.txbVrijemeOtvaranja.Font = new System.Drawing.Font("Raleway", 11.25F);
            this.txbVrijemeOtvaranja.Location = new System.Drawing.Point(232, 302);
            this.txbVrijemeOtvaranja.Margin = new System.Windows.Forms.Padding(4);
            this.txbVrijemeOtvaranja.Mask = "00:00";
            this.txbVrijemeOtvaranja.Name = "txbVrijemeOtvaranja";
            this.txbVrijemeOtvaranja.Size = new System.Drawing.Size(68, 30);
            this.txbVrijemeOtvaranja.TabIndex = 40;
            this.txbVrijemeOtvaranja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbVrijemeOtvaranja.ValidatingType = typeof(System.DateTime);
            this.txbVrijemeOtvaranja.Validating += new System.ComponentModel.CancelEventHandler(this.TxbVrijemeOtvaranja_Validating);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(40, 399);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(255, 47);
            this.btnSacuvaj.TabIndex = 39;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // cmbGrad
            // 
            this.cmbGrad.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrad.FormattingEnabled = true;
            this.cmbGrad.Location = new System.Drawing.Point(415, 228);
            this.cmbGrad.Margin = new System.Windows.Forms.Padding(4);
            this.cmbGrad.Name = "cmbGrad";
            this.cmbGrad.Size = new System.Drawing.Size(253, 30);
            this.cmbGrad.TabIndex = 38;
            this.cmbGrad.SelectedIndexChanged += new System.EventHandler(this.CmbGrad_SelectedIndexChanged);
            this.cmbGrad.Validating += new System.ComponentModel.CancelEventHandler(this.CmbGrad_Validating);
            // 
            // cmbDrzava
            // 
            this.cmbDrzava.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrzava.FormattingEnabled = true;
            this.cmbDrzava.Location = new System.Drawing.Point(415, 144);
            this.cmbDrzava.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDrzava.Name = "cmbDrzava";
            this.cmbDrzava.Size = new System.Drawing.Size(253, 30);
            this.cmbDrzava.TabIndex = 37;
            this.cmbDrzava.SelectedIndexChanged += new System.EventHandler(this.CmbDrzava_SelectedIndexChanged);
            this.cmbDrzava.Validating += new System.ComponentModel.CancelEventHandler(this.CmbDrzava_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(411, 310);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Vrijeme zatvaranja";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(780, 202);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 24);
            this.label7.TabIndex = 35;
            this.label7.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.Color.White;
            this.txbEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmail.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(784, 228);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.MaxLength = 100;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(254, 30);
            this.txbEmail.TabIndex = 34;
            this.txbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxbEmail_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(411, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Grad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(411, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "Država";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(43, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 24);
            this.label5.TabIndex = 31;
            this.label5.Text = "Vrijeme otvaranja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(780, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 30;
            this.label4.Text = "Broj telefona";
            // 
            // txbBrojTelefona
            // 
            this.txbBrojTelefona.BackColor = System.Drawing.Color.White;
            this.txbBrojTelefona.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbBrojTelefona.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrojTelefona.Location = new System.Drawing.Point(784, 144);
            this.txbBrojTelefona.Margin = new System.Windows.Forms.Padding(4);
            this.txbBrojTelefona.MaxLength = 100;
            this.txbBrojTelefona.Name = "txbBrojTelefona";
            this.txbBrojTelefona.Size = new System.Drawing.Size(254, 30);
            this.txbBrojTelefona.TabIndex = 29;
            this.txbBrojTelefona.Validating += new System.ComponentModel.CancelEventHandler(this.TxbBrojTelefona_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(44, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Adresa";
            // 
            // txbAdresa
            // 
            this.txbAdresa.BackColor = System.Drawing.Color.White;
            this.txbAdresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbAdresa.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAdresa.Location = new System.Drawing.Point(40, 227);
            this.txbAdresa.Margin = new System.Windows.Forms.Padding(4);
            this.txbAdresa.MaxLength = 100;
            this.txbAdresa.Name = "txbAdresa";
            this.txbAdresa.Size = new System.Drawing.Size(254, 30);
            this.txbAdresa.TabIndex = 27;
            this.txbAdresa.Validating += new System.ComponentModel.CancelEventHandler(this.TxbAdresa_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Naziv teatra";
            // 
            // txbNaziv
            // 
            this.txbNaziv.BackColor = System.Drawing.Color.White;
            this.txbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNaziv.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNaziv.Location = new System.Drawing.Point(40, 143);
            this.txbNaziv.Margin = new System.Windows.Forms.Padding(4);
            this.txbNaziv.MaxLength = 100;
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(254, 30);
            this.txbNaziv.TabIndex = 25;
            this.txbNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNaziv_Validating);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(33, 46);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(252, 35);
            this.lblHeading.TabIndex = 24;
            this.lblHeading.Text = "Dodavanje teatra";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(415, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 47);
            this.button1.TabIndex = 82;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uctDodajTeatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbVrijemeZatvaranja);
            this.Controls.Add(this.txbVrijemeOtvaranja);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbGrad);
            this.Controls.Add(this.cmbDrzava);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbBrojTelefona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbAdresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.lblHeading);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctDodajTeatar";
            this.Size = new System.Drawing.Size(1217, 692);
            this.Load += new System.EventHandler(this.UctDodajTeatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox txbVrijemeZatvaranja;
        private System.Windows.Forms.MaskedTextBox txbVrijemeOtvaranja;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.ComboBox cmbGrad;
        private System.Windows.Forms.ComboBox cmbDrzava;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBrojTelefona;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbAdresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button button1;
    }
}
