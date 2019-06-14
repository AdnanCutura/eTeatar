namespace WinForms.Predstava
{
    partial class uctDodajTermin
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.cmbDvorana = new System.Windows.Forms.ComboBox();
            this.dtpTermin = new System.Windows.Forms.DateTimePicker();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.mtxbBaznaCijenaKarte = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 76;
            this.label4.Text = "Bazna cijena karata";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "Dvorana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(357, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "Datum i vrijeme";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(34, 42);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(214, 29);
            this.lblHeading.TabIndex = 70;
            this.lblHeading.Text = "Dodavanje termina";
            // 
            // cmbDvorana
            // 
            this.cmbDvorana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDvorana.FormattingEnabled = true;
            this.cmbDvorana.Location = new System.Drawing.Point(39, 119);
            this.cmbDvorana.Name = "cmbDvorana";
            this.cmbDvorana.Size = new System.Drawing.Size(191, 26);
            this.cmbDvorana.TabIndex = 77;
            // 
            // dtpTermin
            // 
            this.dtpTermin.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpTermin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTermin.Location = new System.Drawing.Point(361, 119);
            this.dtpTermin.MaxDate = new System.DateTime(9998, 6, 14, 0, 0, 0, 0);
            this.dtpTermin.MinDate = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            this.dtpTermin.Name = "dtpTermin";
            this.dtpTermin.Size = new System.Drawing.Size(164, 26);
            this.dtpTermin.TabIndex = 78;
            this.dtpTermin.Value = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(40, 248);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(197, 38);
            this.btnSacuvaj.TabIndex = 79;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // mtxbBaznaCijenaKarte
            // 
            this.mtxbBaznaCijenaKarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtxbBaznaCijenaKarte.Location = new System.Drawing.Point(40, 196);
            this.mtxbBaznaCijenaKarte.Mask = "00.00 KM";
            this.mtxbBaznaCijenaKarte.Name = "mtxbBaznaCijenaKarte";
            this.mtxbBaznaCijenaKarte.Size = new System.Drawing.Size(100, 26);
            this.mtxbBaznaCijenaKarte.TabIndex = 80;
            this.mtxbBaznaCijenaKarte.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(361, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 38);
            this.button1.TabIndex = 81;
            this.button1.Text = "Odustani";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // uctDodajTermin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtxbBaznaCijenaKarte);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.dtpTermin);
            this.Controls.Add(this.cmbDvorana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHeading);
            this.Name = "uctDodajTermin";
            this.Size = new System.Drawing.Size(913, 562);
            this.Load += new System.EventHandler(this.UctDodajTermin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmbDvorana;
        private System.Windows.Forms.DateTimePicker dtpTermin;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.MaskedTextBox mtxbBaznaCijenaKarte;
        private System.Windows.Forms.Button button1;
    }
}
