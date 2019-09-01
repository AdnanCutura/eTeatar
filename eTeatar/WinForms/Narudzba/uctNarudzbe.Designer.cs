namespace WinForms.Narudzba
{
    partial class uctNarudzbe
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KorisnickoIme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKupovineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Predstava = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ocjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudzbaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txbNazivPredstave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbKorisnickoIme = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.glumacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.terminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glumacBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 33;
            this.label1.Text = "Prikaz narudžbi";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.AllowUserToAddRows = false;
            this.dgvNarudzbe.AllowUserToDeleteRows = false;
            this.dgvNarudzbe.AutoGenerateColumns = false;
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Ime,
            this.Prezime,
            this.KorisnickoIme,
            this.datumKupovineDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn,
            this.Predstava,
            this.Termin,
            this.Teatar,
            this.cijenaKarteDataGridViewTextBoxColumn,
            this.Ocjena});
            this.dgvNarudzbe.DataSource = this.narudzbaBindingSource;
            this.dgvNarudzbe.Location = new System.Drawing.Point(37, 204);
            this.dgvNarudzbe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.ReadOnly = true;
            this.dgvNarudzbe.RowHeadersWidth = 51;
            this.dgvNarudzbe.Size = new System.Drawing.Size(1388, 473);
            this.dgvNarudzbe.TabIndex = 51;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // Ime
            // 
            this.Ime.HeaderText = "Ime";
            this.Ime.MinimumWidth = 6;
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            this.Ime.Width = 125;
            // 
            // Prezime
            // 
            this.Prezime.HeaderText = "Prezime";
            this.Prezime.MinimumWidth = 6;
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            this.Prezime.Width = 125;
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.DataPropertyName = "Id";
            this.KorisnickoIme.HeaderText = "Korisnicko ime";
            this.KorisnickoIme.MinimumWidth = 6;
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.ReadOnly = true;
            this.KorisnickoIme.Width = 125;
            // 
            // datumKupovineDataGridViewTextBoxColumn
            // 
            this.datumKupovineDataGridViewTextBoxColumn.DataPropertyName = "DatumKupovine";
            this.datumKupovineDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumKupovineDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumKupovineDataGridViewTextBoxColumn.Name = "datumKupovineDataGridViewTextBoxColumn";
            this.datumKupovineDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumKupovineDataGridViewTextBoxColumn.Width = 125;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "Kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Broj karata";
            this.kolicinaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kolicinaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Predstava
            // 
            this.Predstava.HeaderText = "Predstava";
            this.Predstava.MinimumWidth = 6;
            this.Predstava.Name = "Predstava";
            this.Predstava.ReadOnly = true;
            this.Predstava.Width = 125;
            // 
            // Termin
            // 
            this.Termin.HeaderText = "Termin";
            this.Termin.MinimumWidth = 6;
            this.Termin.Name = "Termin";
            this.Termin.ReadOnly = true;
            this.Termin.Width = 125;
            // 
            // Teatar
            // 
            this.Teatar.HeaderText = "Teatar";
            this.Teatar.MinimumWidth = 6;
            this.Teatar.Name = "Teatar";
            this.Teatar.ReadOnly = true;
            this.Teatar.Width = 125;
            // 
            // cijenaKarteDataGridViewTextBoxColumn
            // 
            this.cijenaKarteDataGridViewTextBoxColumn.DataPropertyName = "CijenaKarte";
            this.cijenaKarteDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaKarteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cijenaKarteDataGridViewTextBoxColumn.Name = "cijenaKarteDataGridViewTextBoxColumn";
            this.cijenaKarteDataGridViewTextBoxColumn.ReadOnly = true;
            this.cijenaKarteDataGridViewTextBoxColumn.Width = 125;
            // 
            // Ocjena
            // 
            this.Ocjena.HeaderText = "Ocjena";
            this.Ocjena.MinimumWidth = 6;
            this.Ocjena.Name = "Ocjena";
            this.Ocjena.ReadOnly = true;
            this.Ocjena.Width = 125;
            // 
            // narudzbaBindingSource
            // 
            this.narudzbaBindingSource.DataSource = typeof(DataTransferObjects.Narudzba);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(855, 114);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 60;
            this.label5.Text = "Naziv predstave";
            // 
            // txbNazivPredstave
            // 
            this.txbNazivPredstave.BackColor = System.Drawing.Color.White;
            this.txbNazivPredstave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNazivPredstave.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNazivPredstave.Location = new System.Drawing.Point(859, 140);
            this.txbNazivPredstave.Margin = new System.Windows.Forms.Padding(4);
            this.txbNazivPredstave.MaxLength = 100;
            this.txbNazivPredstave.Name = "txbNazivPredstave";
            this.txbNazivPredstave.Size = new System.Drawing.Size(254, 30);
            this.txbNazivPredstave.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(41, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Korisničko ime";
            // 
            // txbKorisnickoIme
            // 
            this.txbKorisnickoIme.BackColor = System.Drawing.Color.White;
            this.txbKorisnickoIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbKorisnickoIme.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbKorisnickoIme.Location = new System.Drawing.Point(37, 140);
            this.txbKorisnickoIme.Margin = new System.Windows.Forms.Padding(4);
            this.txbKorisnickoIme.MaxLength = 100;
            this.txbKorisnickoIme.Name = "txbKorisnickoIme";
            this.txbKorisnickoIme.Size = new System.Drawing.Size(249, 30);
            this.txbKorisnickoIme.TabIndex = 57;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(1159, 123);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(263, 47);
            this.btnSearch.TabIndex = 56;
            this.btnSearch.Text = "Pretraga";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Prezime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Ime";
            // 
            // txbPrezime
            // 
            this.txbPrezime.BackColor = System.Drawing.Color.White;
            this.txbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrezime.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrezime.Location = new System.Drawing.Point(583, 140);
            this.txbPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrezime.MaxLength = 100;
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(254, 30);
            this.txbPrezime.TabIndex = 52;
            // 
            // txbIme
            // 
            this.txbIme.BackColor = System.Drawing.Color.White;
            this.txbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIme.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIme.Location = new System.Drawing.Point(307, 140);
            this.txbIme.Margin = new System.Windows.Forms.Padding(4);
            this.txbIme.MaxLength = 100;
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(254, 30);
            this.txbIme.TabIndex = 53;
            // 
            // glumacBindingSource
            // 
            this.glumacBindingSource.DataSource = typeof(DataTransferObjects.Glumac);
            // 
            // terminBindingSource
            // 
            this.terminBindingSource.DataSource = typeof(DataTransferObjects.Termin);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(603, 1243);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 47);
            this.button1.TabIndex = 56;
            this.button1.Text = "Pretraga";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // uctNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbNazivPredstave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbKorisnickoIme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.dgvNarudzbe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctNarudzbe";
            this.Size = new System.Drawing.Size(1477, 1343);
            this.Load += new System.EventHandler(this.UctNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudzbaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glumacBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource glumacBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.BindingSource narudzbaBindingSource;
        private System.Windows.Forms.BindingSource terminBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNazivPredstave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbKorisnickoIme;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KorisnickoIme;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKupovineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Predstava;
        private System.Windows.Forms.DataGridViewTextBoxColumn Termin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ocjena;
        private System.Windows.Forms.Button button1;
    }
}
