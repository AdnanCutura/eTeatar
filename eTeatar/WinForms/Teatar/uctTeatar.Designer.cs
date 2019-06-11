namespace WinForms.Teatar
{
    partial class uctTeatar
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
            this.btnDodajTeatar = new System.Windows.Forms.Button();
            this.dgvTeatar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojDvorana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.teatarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTeatar
            // 
            this.btnDodajTeatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajTeatar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajTeatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTeatar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajTeatar.Location = new System.Drawing.Point(37, 586);
            this.btnDodajTeatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDodajTeatar.Name = "btnDodajTeatar";
            this.btnDodajTeatar.Size = new System.Drawing.Size(263, 47);
            this.btnDodajTeatar.TabIndex = 25;
            this.btnDodajTeatar.Text = "Dodaj novi teatar";
            this.btnDodajTeatar.UseVisualStyleBackColor = false;
            this.btnDodajTeatar.Click += new System.EventHandler(this.BtnDodajTeatar_Click);
            // 
            // dgvTeatar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvTeatar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeatar.AutoGenerateColumns = false;
            this.dgvTeatar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeatar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeatar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeatar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.nazivDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn,
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn,
            this.BrojDvorana,
            this.Izbrisi});
            this.dgvTeatar.DataSource = this.teatarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeatar.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeatar.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTeatar.Location = new System.Drawing.Point(37, 95);
            this.dgvTeatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTeatar.Name = "dgvTeatar";
            this.dgvTeatar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTeatar.RowHeadersWidth = 51;
            this.dgvTeatar.Size = new System.Drawing.Size(1132, 484);
            this.dgvTeatar.TabIndex = 24;
            this.dgvTeatar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTeatar_CellContentClick);
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
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "BrojTelefona";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Broj telefona";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrijemeOtvaranjaDataGridViewTextBoxColumn
            // 
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeOtvaranja";
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn.HeaderText = "R.v. Od";
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn.Name = "vrijemeOtvaranjaDataGridViewTextBoxColumn";
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // vrijemeZatvaranjaDataGridViewTextBoxColumn
            // 
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn.DataPropertyName = "VrijemeZatvaranja";
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn.HeaderText = "R.v. Do";
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn.Name = "vrijemeZatvaranjaDataGridViewTextBoxColumn";
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn.Width = 125;
            // 
            // BrojDvorana
            // 
            this.BrojDvorana.DataPropertyName = "BrojDvorana";
            this.BrojDvorana.HeaderText = "Broj dvorana";
            this.BrojDvorana.MinimumWidth = 6;
            this.BrojDvorana.Name = "BrojDvorana";
            this.BrojDvorana.Width = 125;
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
            // teatarBindingSource
            // 
            this.teatarBindingSource.DataSource = typeof(DataTransferObjects.Teatar);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prikaz svih teatara";
            // 
            // uctTeatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajTeatar);
            this.Controls.Add(this.dgvTeatar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uctTeatar";
            this.Size = new System.Drawing.Size(1217, 692);
            this.Load += new System.EventHandler(this.UctTeatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTeatar;
        private System.Windows.Forms.DataGridView dgvTeatar;
        private System.Windows.Forms.BindingSource teatarBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeOtvaranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijemeZatvaranjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojDvorana;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
    }
}
