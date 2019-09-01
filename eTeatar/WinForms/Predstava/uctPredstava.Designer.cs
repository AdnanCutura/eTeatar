namespace WinForms.Predstava
{
    partial class uctPredstava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctPredstava));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajPredstavu = new System.Windows.Forms.Button();
            this.dgvPredstava = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajanjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reziserImePrezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojUloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Termin = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.predstavaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.srchNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTeatar = new System.Windows.Forms.ComboBox();
            this.teatarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.obavijestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predstavaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(1141, 63);
            this.searchIcon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchIcon.MaximumSize = new System.Drawing.Size(13, 12);
            this.searchIcon.MinimumSize = new System.Drawing.Size(27, 25);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(27, 25);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 53;
            this.searchIcon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 36);
            this.label1.TabIndex = 52;
            this.label1.Text = "Prikaz svih predstava";
            // 
            // btnDodajPredstavu
            // 
            this.btnDodajPredstavu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajPredstavu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajPredstavu.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPredstavu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajPredstavu.Location = new System.Drawing.Point(38, 617);
            this.btnDodajPredstavu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajPredstavu.Name = "btnDodajPredstavu";
            this.btnDodajPredstavu.Size = new System.Drawing.Size(263, 47);
            this.btnDodajPredstavu.TabIndex = 51;
            this.btnDodajPredstavu.Text = "Dodaj novu predstavu";
            this.btnDodajPredstavu.UseVisualStyleBackColor = false;
            this.btnDodajPredstavu.Click += new System.EventHandler(this.BtnDodajPredstavu_Click);
            // 
            // dgvPredstava
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvPredstava.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPredstava.AutoGenerateColumns = false;
            this.dgvPredstava.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Raleway", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPredstava.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPredstava.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPredstava.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazivDataGridViewTextBoxColumn,
            this.trajanjeDataGridViewTextBoxColumn,
            this.reziserImePrezimeDataGridViewTextBoxColumn,
            this.BrojUloga,
            this.Termin,
            this.Izbrisi});
            this.dgvPredstava.DataSource = this.predstavaBindingSource;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Raleway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPredstava.DefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPredstava.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPredstava.Location = new System.Drawing.Point(37, 145);
            this.dgvPredstava.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPredstava.Name = "dgvPredstava";
            this.dgvPredstava.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPredstava.RowHeadersWidth = 51;
            this.dgvPredstava.Size = new System.Drawing.Size(1134, 464);
            this.dgvPredstava.TabIndex = 50;
            this.dgvPredstava.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPredstava_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // trajanjeDataGridViewTextBoxColumn
            // 
            this.trajanjeDataGridViewTextBoxColumn.DataPropertyName = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.HeaderText = "Trajanje";
            this.trajanjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trajanjeDataGridViewTextBoxColumn.Name = "trajanjeDataGridViewTextBoxColumn";
            this.trajanjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // reziserImePrezimeDataGridViewTextBoxColumn
            // 
            this.reziserImePrezimeDataGridViewTextBoxColumn.DataPropertyName = "ReziserImePrezime";
            this.reziserImePrezimeDataGridViewTextBoxColumn.HeaderText = "Režiser";
            this.reziserImePrezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reziserImePrezimeDataGridViewTextBoxColumn.Name = "reziserImePrezimeDataGridViewTextBoxColumn";
            this.reziserImePrezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // BrojUloga
            // 
            this.BrojUloga.DataPropertyName = "BrojUloga";
            this.BrojUloga.HeaderText = "Broj uloga";
            this.BrojUloga.MinimumWidth = 6;
            this.BrojUloga.Name = "BrojUloga";
            this.BrojUloga.Width = 125;
            // 
            // Termin
            // 
            this.Termin.HeaderText = "Termin";
            this.Termin.MinimumWidth = 6;
            this.Termin.Name = "Termin";
            this.Termin.Text = "Pregled termina";
            this.Termin.ToolTipText = "Pregled termina";
            this.Termin.UseColumnTextForButtonValue = true;
            this.Termin.Width = 125;
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
            // predstavaBindingSource
            // 
            this.predstavaBindingSource.DataSource = typeof(DataTransferObjects.Predstava);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(580, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Pretraga po nazivu";
            // 
            // srchNaziv
            // 
            this.srchNaziv.BackColor = System.Drawing.Color.White;
            this.srchNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srchNaziv.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchNaziv.Location = new System.Drawing.Point(585, 97);
            this.srchNaziv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.srchNaziv.MaxLength = 100;
            this.srchNaziv.Name = "srchNaziv";
            this.srchNaziv.Size = new System.Drawing.Size(254, 29);
            this.srchNaziv.TabIndex = 60;
            this.srchNaziv.TextChanged += new System.EventHandler(this.SrchNaziv_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(909, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Pretraga po teatru";
            // 
            // cmbTeatar
            // 
            this.cmbTeatar.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTeatar.FormattingEnabled = true;
            this.cmbTeatar.Location = new System.Drawing.Point(916, 97);
            this.cmbTeatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTeatar.Name = "cmbTeatar";
            this.cmbTeatar.Size = new System.Drawing.Size(253, 32);
            this.cmbTeatar.TabIndex = 62;
            this.cmbTeatar.SelectedIndexChanged += new System.EventHandler(this.CmbTeatar_SelectedIndexChanged);
            // 
            // teatarBindingSource
            // 
            this.teatarBindingSource.DataSource = typeof(DataTransferObjects.Teatar);
            // 
            // obavijestBindingSource
            // 
            this.obavijestBindingSource.DataSource = typeof(DataTransferObjects.Obavijest);
            // 
            // uctPredstava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.cmbTeatar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.srchNaziv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajPredstavu);
            this.Controls.Add(this.dgvPredstava);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uctPredstava";
            this.Size = new System.Drawing.Size(1217, 692);
            this.Load += new System.EventHandler(this.UctPredstava_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPredstava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predstavaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teatarBindingSource;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.BindingSource obavijestBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPredstavu;
        private System.Windows.Forms.DataGridView dgvPredstava;
        private System.Windows.Forms.BindingSource predstavaBindingSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox srchNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTeatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trajanjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reziserImePrezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojUloga;
        private System.Windows.Forms.DataGridViewButtonColumn Termin;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
    }
}
