namespace WinForms.Predstava
{
    partial class uctDodajPredstavu
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
            this.label3 = new System.Windows.Forms.Label();
            this.txbTrajanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.rtxbOpis = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbReziser = new System.Windows.Forms.TextBox();
            this.imgPredstava = new System.Windows.Forms.PictureBox();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNazivIzvornogDjela = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPisacIzvornogDjela = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dgvZanr = new System.Windows.Forms.DataGridView();
            this.Zanr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odabir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvGlumac = new System.Windows.Forms.DataGridView();
            this.glumacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NazivUloge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Glumac = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.imgPredstava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glumacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 43;
            this.label3.Text = "Trajanje";
            // 
            // txbTrajanje
            // 
            this.txbTrajanje.BackColor = System.Drawing.Color.White;
            this.txbTrajanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTrajanje.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTrajanje.Location = new System.Drawing.Point(39, 185);
            this.txbTrajanje.MaxLength = 100;
            this.txbTrajanje.Name = "txbTrajanje";
            this.txbTrajanje.Size = new System.Drawing.Size(191, 25);
            this.txbTrajanje.TabIndex = 42;
            this.txbTrajanje.Validating += new System.ComponentModel.CancelEventHandler(this.TxbTrajanje_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Naziv predstave";
            // 
            // txbNaziv
            // 
            this.txbNaziv.BackColor = System.Drawing.Color.White;
            this.txbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNaziv.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNaziv.Location = new System.Drawing.Point(39, 121);
            this.txbNaziv.MaxLength = 100;
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(191, 25);
            this.txbNaziv.TabIndex = 40;
            this.txbNaziv.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNaziv_Validating);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(34, 42);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(248, 29);
            this.lblHeading.TabIndex = 39;
            this.lblHeading.Text = "Dodavanje predstave";
            // 
            // rtxbOpis
            // 
            this.rtxbOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxbOpis.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxbOpis.Location = new System.Drawing.Point(39, 317);
            this.rtxbOpis.Name = "rtxbOpis";
            this.rtxbOpis.Size = new System.Drawing.Size(836, 138);
            this.rtxbOpis.TabIndex = 67;
            this.rtxbOpis.Text = "";
            this.rtxbOpis.Validating += new System.ComponentModel.CancelEventHandler(this.RtxbOpis_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 66;
            this.label1.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(325, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Režiser";
            // 
            // txbReziser
            // 
            this.txbReziser.BackColor = System.Drawing.Color.White;
            this.txbReziser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbReziser.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReziser.Location = new System.Drawing.Point(328, 121);
            this.txbReziser.MaxLength = 100;
            this.txbReziser.Name = "txbReziser";
            this.txbReziser.Size = new System.Drawing.Size(243, 25);
            this.txbReziser.TabIndex = 44;
            this.txbReziser.Validating += new System.ComponentModel.CancelEventHandler(this.TxbReziser_Validating);
            // 
            // imgPredstava
            // 
            this.imgPredstava.Image = global::WinForms.Properties.Resources.news_placeholder;
            this.imgPredstava.Location = new System.Drawing.Point(632, 89);
            this.imgPredstava.Margin = new System.Windows.Forms.Padding(2);
            this.imgPredstava.Name = "imgPredstava";
            this.imgPredstava.Size = new System.Drawing.Size(243, 125);
            this.imgPredstava.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPredstava.TabIndex = 62;
            this.imgPredstava.TabStop = false;
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajSliku.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajSliku.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajSliku.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajSliku.Location = new System.Drawing.Point(632, 240);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(243, 38);
            this.btnDodajSliku.TabIndex = 63;
            this.btnDodajSliku.Text = "Dodaj Sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = false;
            this.btnDodajSliku.Click += new System.EventHandler(this.BtnDodajSliku_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(325, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 19);
            this.label5.TabIndex = 71;
            this.label5.Text = "Naziv izvornog djela";
            // 
            // txbNazivIzvornogDjela
            // 
            this.txbNazivIzvornogDjela.BackColor = System.Drawing.Color.White;
            this.txbNazivIzvornogDjela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNazivIzvornogDjela.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivIzvornogDjela.Location = new System.Drawing.Point(328, 253);
            this.txbNazivIzvornogDjela.MaxLength = 100;
            this.txbNazivIzvornogDjela.Name = "txbNazivIzvornogDjela";
            this.txbNazivIzvornogDjela.Size = new System.Drawing.Size(243, 25);
            this.txbNazivIzvornogDjela.TabIndex = 70;
            this.txbNazivIzvornogDjela.Validating += new System.ComponentModel.CancelEventHandler(this.TxbNazivIzvornogDjela_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(325, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 19);
            this.label6.TabIndex = 69;
            this.label6.Text = "Pisac izvornog cjela";
            // 
            // txbPisacIzvornogDjela
            // 
            this.txbPisacIzvornogDjela.BackColor = System.Drawing.Color.White;
            this.txbPisacIzvornogDjela.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPisacIzvornogDjela.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPisacIzvornogDjela.Location = new System.Drawing.Point(328, 185);
            this.txbPisacIzvornogDjela.MaxLength = 100;
            this.txbPisacIzvornogDjela.Name = "txbPisacIzvornogDjela";
            this.txbPisacIzvornogDjela.Size = new System.Drawing.Size(243, 25);
            this.txbPisacIzvornogDjela.TabIndex = 68;
            this.txbPisacIzvornogDjela.Validating += new System.ComponentModel.CancelEventHandler(this.TxbPisacIzvornogDjela_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSacuvaj.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(39, 702);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(191, 38);
            this.btnSacuvaj.TabIndex = 72;
            this.btnSacuvaj.Text = "Sačuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.BtnSacuvaj_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // dgvZanr
            // 
            this.dgvZanr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZanr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Zanr,
            this.Id,
            this.Odabir});
            this.dgvZanr.Location = new System.Drawing.Point(42, 504);
            this.dgvZanr.Name = "dgvZanr";
            this.dgvZanr.Size = new System.Drawing.Size(323, 167);
            this.dgvZanr.TabIndex = 73;
            // 
            // Zanr
            // 
            this.Zanr.DataPropertyName = "Naziv";
            this.Zanr.HeaderText = "Žanr";
            this.Zanr.Name = "Zanr";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ZanrId";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Odabir
            // 
            this.Odabir.HeaderText = "Odabir";
            this.Odabir.Name = "Odabir";
            // 
            // dgvGlumac
            // 
            this.dgvGlumac.AllowUserToOrderColumns = true;
            this.dgvGlumac.AutoGenerateColumns = false;
            this.dgvGlumac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlumac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NazivUloge,
            this.Glumac});
            this.dgvGlumac.DataSource = this.glumacBindingSource;
            this.dgvGlumac.Location = new System.Drawing.Point(438, 504);
            this.dgvGlumac.Name = "dgvGlumac";
            this.dgvGlumac.Size = new System.Drawing.Size(437, 167);
            this.dgvGlumac.TabIndex = 74;
            // 
            // glumacBindingSource
            // 
            this.glumacBindingSource.DataSource = typeof(DataTransferObjects.Glumac);
            // 
            // NazivUloge
            // 
            this.NazivUloge.HeaderText = "NazivUloge";
            this.NazivUloge.Name = "NazivUloge";
            // 
            // Glumac
            // 
            this.Glumac.DataPropertyName = "Ime";
            this.Glumac.DataSource = this.glumacBindingSource;
            this.Glumac.DisplayMember = "Ime";
            this.Glumac.HeaderText = "Glumac";
            this.Glumac.Name = "Glumac";
            this.Glumac.ToolTipText = "Glumac";
            this.Glumac.ValueMember = "Id";
            // 
            // uctDodajPredstavu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.dgvGlumac);
            this.Controls.Add(this.dgvZanr);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNazivIzvornogDjela);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPisacIzvornogDjela);
            this.Controls.Add(this.rtxbOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.imgPredstava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbReziser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTrajanje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.lblHeading);
            this.Name = "uctDodajPredstavu";
            this.Size = new System.Drawing.Size(913, 808);
            this.Load += new System.EventHandler(this.UctDodajPredstavu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPredstava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZanr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glumacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTrajanje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.RichTextBox rtxbOpis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbReziser;
        private System.Windows.Forms.PictureBox imgPredstava;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNazivIzvornogDjela;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPisacIzvornogDjela;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dgvZanr;
        private System.Windows.Forms.DataGridView dgvGlumac;
        private System.Windows.Forms.BindingSource glumacBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zanr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Odabir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivUloge;
        private System.Windows.Forms.DataGridViewComboBoxColumn Glumac;
    }
}
