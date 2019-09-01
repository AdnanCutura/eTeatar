namespace WinForms.Predstava
{
    partial class uctTerminiPredstave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctTerminiPredstave));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.btnDodajTermin = new System.Windows.Forms.Button();
            this.dgvTermin = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baznaCijenaKarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.terminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblHeading = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDvorana = new System.Windows.Forms.ComboBox();
            this.obavijestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predstavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teatarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBackPredstava = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predstavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(1148, 75);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchIcon.MaximumSize = new System.Drawing.Size(13, 12);
            this.searchIcon.MinimumSize = new System.Drawing.Size(27, 25);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(27, 25);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 66;
            this.searchIcon.TabStop = false;
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajTermin.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTermin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajTermin.Location = new System.Drawing.Point(45, 628);
            this.btnDodajTermin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(263, 47);
            this.btnDodajTermin.TabIndex = 64;
            this.btnDodajTermin.Text = "Dodaj novi termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.BtnDodajTermin_Click);
            // 
            // dgvTermin
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvTermin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTermin.AutoGenerateColumns = false;
            this.dgvTermin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Raleway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTermin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.baznaCijenaKarteDataGridViewTextBoxColumn,
            this.Izbrisi,
            this.Id});
            this.dgvTermin.DataSource = this.terminBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTermin.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTermin.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTermin.Location = new System.Drawing.Point(45, 157);
            this.dgvTermin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTermin.Name = "dgvTermin";
            this.dgvTermin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTermin.RowHeadersWidth = 51;
            this.dgvTermin.Size = new System.Drawing.Size(1132, 464);
            this.dgvTermin.TabIndex = 63;
            this.dgvTermin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTermin_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            this.datumVrijemeDataGridViewTextBoxColumn.Width = 125;
            // 
            // baznaCijenaKarteDataGridViewTextBoxColumn
            // 
            this.baznaCijenaKarteDataGridViewTextBoxColumn.DataPropertyName = "BaznaCijenaKarte";
            this.baznaCijenaKarteDataGridViewTextBoxColumn.HeaderText = "Bazna cijena karte";
            this.baznaCijenaKarteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.baznaCijenaKarteDataGridViewTextBoxColumn.Name = "baznaCijenaKarteDataGridViewTextBoxColumn";
            this.baznaCijenaKarteDataGridViewTextBoxColumn.Width = 125;
            // 
            // Izbrisi
            // 
            this.Izbrisi.HeaderText = "Akcija";
            this.Izbrisi.MinimumWidth = 6;
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.Text = "Izbriši";
            this.Izbrisi.ToolTipText = "Izbriši";
            this.Izbrisi.UseColumnTextForButtonValue = true;
            this.Izbrisi.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // terminBindingSource
            // 
            this.terminBindingSource.DataSource = typeof(DataTransferObjects.Termin);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(39, 43);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(251, 36);
            this.lblHeading.TabIndex = 65;
            this.lblHeading.Text = "Termini predstave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(916, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Pretraga po dvorani";
            // 
            // cmbDvorana
            // 
            this.cmbDvorana.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDvorana.FormattingEnabled = true;
            this.cmbDvorana.Location = new System.Drawing.Point(923, 109);
            this.cmbDvorana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDvorana.Name = "cmbDvorana";
            this.cmbDvorana.Size = new System.Drawing.Size(253, 32);
            this.cmbDvorana.TabIndex = 70;
            // 
            // obavijestBindingSource
            // 
            this.obavijestBindingSource.DataSource = typeof(DataTransferObjects.Obavijest);
            // 
            // predstavaBindingSource
            // 
            this.predstavaBindingSource.DataSource = typeof(DataTransferObjects.Predstava);
            // 
            // teatarBindingSource
            // 
            this.teatarBindingSource.DataSource = typeof(DataTransferObjects.Teatar);
            // 
            // lblBackPredstava
            // 
            this.lblBackPredstava.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.lblBackPredstava.AutoSize = true;
            this.lblBackPredstava.Font = new System.Drawing.Font("Raleway", 12F);
            this.lblBackPredstava.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.lblBackPredstava.Location = new System.Drawing.Point(41, 86);
            this.lblBackPredstava.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBackPredstava.Name = "lblBackPredstava";
            this.lblBackPredstava.Size = new System.Drawing.Size(187, 25);
            this.lblBackPredstava.TabIndex = 71;
            this.lblBackPredstava.TabStop = true;
            this.lblBackPredstava.Text = "Nazad na predstave";
            this.lblBackPredstava.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.lblBackPredstava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblBackPredstava_LinkClicked);
            // 
            // uctTerminiPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lblBackPredstava);
            this.Controls.Add(this.cmbDvorana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.dgvTermin);
            this.Controls.Add(this.lblHeading);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uctTerminiPredstave";
            this.Size = new System.Drawing.Size(1217, 692);
            this.Load += new System.EventHandler(this.UctTerminiPredstave_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTermin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predstavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource obavijestBindingSource;
        private System.Windows.Forms.BindingSource predstavaBindingSource;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.Button btnDodajTermin;
        private System.Windows.Forms.DataGridView dgvTermin;
        private System.Windows.Forms.BindingSource teatarBindingSource;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDvorana;
        private System.Windows.Forms.BindingSource terminBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PredstavaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DvoranaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn baznaCijenaKarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.LinkLabel lblBackPredstava;
    }
}
