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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.searchIcon.Location = new System.Drawing.Point(861, 50);
            this.searchIcon.MaximumSize = new System.Drawing.Size(10, 10);
            this.searchIcon.MinimumSize = new System.Drawing.Size(20, 20);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(20, 20);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 66;
            this.searchIcon.TabStop = false;
            // 
            // btnDodajTermin
            // 
            this.btnDodajTermin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajTermin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajTermin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTermin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajTermin.Location = new System.Drawing.Point(34, 500);
            this.btnDodajTermin.Name = "btnDodajTermin";
            this.btnDodajTermin.Size = new System.Drawing.Size(197, 38);
            this.btnDodajTermin.TabIndex = 64;
            this.btnDodajTermin.Text = "Dodaj novi termin";
            this.btnDodajTermin.UseVisualStyleBackColor = false;
            this.btnDodajTermin.Click += new System.EventHandler(this.BtnDodajTermin_Click);
            // 
            // dgvTermin
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvTermin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTermin.AutoGenerateColumns = false;
            this.dgvTermin.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTermin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTermin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTermin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.baznaCijenaKarteDataGridViewTextBoxColumn,
            this.Izbrisi,
            this.Id});
            this.dgvTermin.DataSource = this.terminBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTermin.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTermin.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTermin.Location = new System.Drawing.Point(34, 117);
            this.dgvTermin.Name = "dgvTermin";
            this.dgvTermin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTermin.RowHeadersWidth = 51;
            this.dgvTermin.Size = new System.Drawing.Size(849, 377);
            this.dgvTermin.TabIndex = 63;
            this.dgvTermin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTermin_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "Datum i vrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            // 
            // baznaCijenaKarteDataGridViewTextBoxColumn
            // 
            this.baznaCijenaKarteDataGridViewTextBoxColumn.DataPropertyName = "BaznaCijenaKarte";
            this.baznaCijenaKarteDataGridViewTextBoxColumn.HeaderText = "Bazna cijena karte";
            this.baznaCijenaKarteDataGridViewTextBoxColumn.Name = "baznaCijenaKarteDataGridViewTextBoxColumn";
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
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // terminBindingSource
            // 
            this.terminBindingSource.DataSource = typeof(DataTransferObjects.Termin);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.White;
            this.lblHeading.Location = new System.Drawing.Point(29, 24);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(208, 29);
            this.lblHeading.TabIndex = 65;
            this.lblHeading.Text = "Termini predstave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(687, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "Pretraga po dvorani";
            // 
            // cmbDvorana
            // 
            this.cmbDvorana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDvorana.FormattingEnabled = true;
            this.cmbDvorana.Location = new System.Drawing.Point(692, 78);
            this.cmbDvorana.Name = "cmbDvorana";
            this.cmbDvorana.Size = new System.Drawing.Size(191, 26);
            this.cmbDvorana.TabIndex = 70;
            this.cmbDvorana.SelectedIndexChanged += new System.EventHandler(this.CmbDvorana_SelectedIndexChanged);
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
            this.lblBackPredstava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBackPredstava.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.lblBackPredstava.Location = new System.Drawing.Point(31, 59);
            this.lblBackPredstava.Name = "lblBackPredstava";
            this.lblBackPredstava.Size = new System.Drawing.Size(151, 20);
            this.lblBackPredstava.TabIndex = 71;
            this.lblBackPredstava.TabStop = true;
            this.lblBackPredstava.Text = "Nazad na predstave";
            this.lblBackPredstava.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.lblBackPredstava.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblBackPredstava_LinkClicked);
            // 
            // uctTerminiPredstave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.lblBackPredstava);
            this.Controls.Add(this.cmbDvorana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.btnDodajTermin);
            this.Controls.Add(this.dgvTermin);
            this.Controls.Add(this.lblHeading);
            this.Name = "uctTerminiPredstave";
            this.Size = new System.Drawing.Size(913, 562);
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
