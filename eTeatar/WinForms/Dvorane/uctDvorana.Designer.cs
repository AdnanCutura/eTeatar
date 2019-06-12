namespace WinForms.Dvorane
{
    partial class uctDvorana
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
            this.txbNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblTeatar = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.btnDodajDvoranu = new System.Windows.Forms.Button();
            this.dgvDvorana = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Akcija = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dvoranaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbTeatri = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvorana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvoranaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 33;
            this.label1.Text = "Prikaz svih dvorana";
            // 
            // txbNaziv
            // 
            this.txbNaziv.BackColor = System.Drawing.Color.White;
            this.txbNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNaziv.Location = new System.Drawing.Point(830, 108);
            this.txbNaziv.MaxLength = 100;
            this.txbNaziv.Name = "txbNaziv";
            this.txbNaziv.Size = new System.Drawing.Size(191, 24);
            this.txbNaziv.TabIndex = 35;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.ForeColor = System.Drawing.Color.White;
            this.lblNaziv.Location = new System.Drawing.Point(827, 87);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(45, 18);
            this.lblNaziv.TabIndex = 36;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblTeatar
            // 
            this.lblTeatar.AutoSize = true;
            this.lblTeatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeatar.ForeColor = System.Drawing.Color.White;
            this.lblTeatar.Location = new System.Drawing.Point(827, 169);
            this.lblTeatar.Name = "lblTeatar";
            this.lblTeatar.Size = new System.Drawing.Size(50, 18);
            this.lblTeatar.TabIndex = 37;
            this.lblTeatar.Text = "Teatar";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search.Location = new System.Drawing.Point(828, 258);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(197, 38);
            this.Search.TabIndex = 38;
            this.Search.Text = "Pretraga";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // btnDodajDvoranu
            // 
            this.btnDodajDvoranu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajDvoranu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajDvoranu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajDvoranu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajDvoranu.Location = new System.Drawing.Point(55, 488);
            this.btnDodajDvoranu.Name = "btnDodajDvoranu";
            this.btnDodajDvoranu.Size = new System.Drawing.Size(197, 38);
            this.btnDodajDvoranu.TabIndex = 32;
            this.btnDodajDvoranu.Text = "Dodaj novu dvoranu";
            this.btnDodajDvoranu.UseVisualStyleBackColor = false;
            this.btnDodajDvoranu.Click += new System.EventHandler(this.BtnDodajDvoranu_Click);
            // 
            // dgvDvorana
            // 
            this.dgvDvorana.AllowUserToAddRows = false;
            this.dgvDvorana.AllowUserToDeleteRows = false;
            this.dgvDvorana.AutoGenerateColumns = false;
            this.dgvDvorana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDvorana.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.Teatar,
            this.Akcija});
            this.dgvDvorana.DataSource = this.dvoranaBindingSource;
            this.dgvDvorana.Location = new System.Drawing.Point(55, 78);
            this.dgvDvorana.Name = "dgvDvorana";
            this.dgvDvorana.ReadOnly = true;
            this.dgvDvorana.Size = new System.Drawing.Size(744, 385);
            this.dgvDvorana.TabIndex = 39;
            this.dgvDvorana.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDvorana_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazivDataGridViewTextBoxColumn.Width = 300;
            // 
            // Teatar
            // 
            this.Teatar.HeaderText = "Teatar";
            this.Teatar.Name = "Teatar";
            this.Teatar.ReadOnly = true;
            this.Teatar.Width = 300;
            // 
            // Akcija
            // 
            this.Akcija.HeaderText = "Izbrisi";
            this.Akcija.Name = "Akcija";
            this.Akcija.ReadOnly = true;
            this.Akcija.Text = "Izbrisi";
            this.Akcija.ToolTipText = "Izbrisi";
            this.Akcija.UseColumnTextForButtonValue = true;
            // 
            // dvoranaBindingSource
            // 
            this.dvoranaBindingSource.DataSource = typeof(DataTransferObjects.Dvorana);
            // 
            // cmbTeatri
            // 
            this.cmbTeatri.FormattingEnabled = true;
            this.cmbTeatri.Location = new System.Drawing.Point(830, 190);
            this.cmbTeatri.Name = "cmbTeatri";
            this.cmbTeatri.Size = new System.Drawing.Size(191, 21);
            this.cmbTeatri.TabIndex = 40;
            // 
            // uctDvorana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTeatri);
            this.Controls.Add(this.dgvDvorana);
            this.Controls.Add(this.btnDodajDvoranu);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.lblTeatar);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.txbNaziv);
            this.Controls.Add(this.label1);
            this.Name = "uctDvorana";
            this.Size = new System.Drawing.Size(1070, 562);
            this.Load += new System.EventHandler(this.UctDvorana_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDvorana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvoranaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbNaziv;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblTeatar;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button btnDodajDvoranu;
        private System.Windows.Forms.DataGridView dgvDvorana;
        private System.Windows.Forms.BindingSource dvoranaBindingSource;
        private System.Windows.Forms.ComboBox cmbTeatri;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teatar;
        private System.Windows.Forms.DataGridViewButtonColumn Akcija;
    }
}
