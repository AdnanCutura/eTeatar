namespace WinForms.Obavijest
{
    partial class uctObavijest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctObavijest));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajObavijest = new System.Windows.Forms.Button();
            this.dgvObavijest = new System.Windows.Forms.DataGridView();
            this.obavijestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.srchDateFrom = new System.Windows.Forms.DateTimePicker();
            this.srchDateTo = new System.Windows.Forms.DateTimePicker();
            this.teatarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naslovDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumVrijemeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sadrzajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slikaLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 42;
            this.label1.Text = "Prikaz svih obavijesti";
            // 
            // btnDodajObavijest
            // 
            this.btnDodajObavijest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajObavijest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajObavijest.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajObavijest.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajObavijest.Location = new System.Drawing.Point(29, 494);
            this.btnDodajObavijest.Name = "btnDodajObavijest";
            this.btnDodajObavijest.Size = new System.Drawing.Size(197, 38);
            this.btnDodajObavijest.TabIndex = 41;
            this.btnDodajObavijest.Text = "Dodaj novu obavijest";
            this.btnDodajObavijest.UseVisualStyleBackColor = false;
            // 
            // dgvObavijest
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvObavijest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvObavijest.AutoGenerateColumns = false;
            this.dgvObavijest.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObavijest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvObavijest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.naslovDataGridViewTextBoxColumn,
            this.datumVrijemeDataGridViewTextBoxColumn,
            this.sadrzajDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.slikaLinkDataGridViewTextBoxColumn,
            this.Izbrisi});
            this.dgvObavijest.DataSource = this.obavijestBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObavijest.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObavijest.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvObavijest.Location = new System.Drawing.Point(29, 111);
            this.dgvObavijest.Name = "dgvObavijest";
            this.dgvObavijest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvObavijest.RowHeadersWidth = 51;
            this.dgvObavijest.Size = new System.Drawing.Size(849, 377);
            this.dgvObavijest.TabIndex = 40;
            // 
            // obavijestBindingSource
            // 
            this.obavijestBindingSource.DataSource = typeof(DataTransferObjects.Obavijest);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(566, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Pretraga po datumu";
            // 
            // searchIcon
            // 
            this.searchIcon.Image = ((System.Drawing.Image)(resources.GetObject("searchIcon.Image")));
            this.searchIcon.Location = new System.Drawing.Point(856, 44);
            this.searchIcon.MaximumSize = new System.Drawing.Size(10, 10);
            this.searchIcon.MinimumSize = new System.Drawing.Size(20, 20);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(20, 20);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchIcon.TabIndex = 43;
            this.searchIcon.TabStop = false;
            this.searchIcon.Click += new System.EventHandler(this.SearchIcon_Click);
            // 
            // srchDateFrom
            // 
            this.srchDateFrom.CustomFormat = " ";
            this.srchDateFrom.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.srchDateFrom.Location = new System.Drawing.Point(597, 72);
            this.srchDateFrom.Name = "srchDateFrom";
            this.srchDateFrom.Size = new System.Drawing.Size(119, 25);
            this.srchDateFrom.TabIndex = 46;
            this.srchDateFrom.ValueChanged += new System.EventHandler(this.SrchDateFrom_ValueChanged);
            this.srchDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SrchDateFrom_KeyDown);
            // 
            // srchDateTo
            // 
            this.srchDateTo.CustomFormat = "dd.MM.yyyy";
            this.srchDateTo.Font = new System.Drawing.Font("Raleway", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.srchDateTo.Location = new System.Drawing.Point(758, 72);
            this.srchDateTo.Name = "srchDateTo";
            this.srchDateTo.Size = new System.Drawing.Size(119, 25);
            this.srchDateTo.TabIndex = 47;
            this.srchDateTo.Value = new System.DateTime(2019, 6, 12, 15, 33, 36, 0);
            // 
            // teatarBindingSource
            // 
            this.teatarBindingSource.DataSource = typeof(DataTransferObjects.Teatar);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // naslovDataGridViewTextBoxColumn
            // 
            this.naslovDataGridViewTextBoxColumn.DataPropertyName = "Naslov";
            this.naslovDataGridViewTextBoxColumn.HeaderText = "Naslov";
            this.naslovDataGridViewTextBoxColumn.Name = "naslovDataGridViewTextBoxColumn";
            // 
            // datumVrijemeDataGridViewTextBoxColumn
            // 
            this.datumVrijemeDataGridViewTextBoxColumn.DataPropertyName = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.HeaderText = "DatumVrijeme";
            this.datumVrijemeDataGridViewTextBoxColumn.Name = "datumVrijemeDataGridViewTextBoxColumn";
            // 
            // sadrzajDataGridViewTextBoxColumn
            // 
            this.sadrzajDataGridViewTextBoxColumn.DataPropertyName = "Sadrzaj";
            this.sadrzajDataGridViewTextBoxColumn.HeaderText = "Sadrzaj";
            this.sadrzajDataGridViewTextBoxColumn.Name = "sadrzajDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AdministratorId";
            this.dataGridViewTextBoxColumn1.HeaderText = "AdministratorId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // slikaLinkDataGridViewTextBoxColumn
            // 
            this.slikaLinkDataGridViewTextBoxColumn.DataPropertyName = "SlikaLink";
            this.slikaLinkDataGridViewTextBoxColumn.HeaderText = "SlikaLink";
            this.slikaLinkDataGridViewTextBoxColumn.Name = "slikaLinkDataGridViewTextBoxColumn";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(564, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Od";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(722, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Do";
            // 
            // uctObavijest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.srchDateTo);
            this.Controls.Add(this.srchDateFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajObavijest);
            this.Controls.Add(this.dgvObavijest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchIcon);
            this.Name = "uctObavijest";
            this.Size = new System.Drawing.Size(913, 562);
            this.Load += new System.EventHandler(this.UctObavijest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obavijestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajObavijest;
        private System.Windows.Forms.DataGridView dgvObavijest;
        private System.Windows.Forms.BindingSource teatarBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.DateTimePicker srchDateFrom;
        private System.Windows.Forms.DateTimePicker srchDateTo;
        private System.Windows.Forms.BindingSource obavijestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn administratorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naslovDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumVrijemeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sadrzajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn slikaLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
