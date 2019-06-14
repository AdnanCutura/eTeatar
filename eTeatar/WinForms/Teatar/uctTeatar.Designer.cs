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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctTeatar));
            this.btnDodajTeatar = new System.Windows.Forms.Button();
            this.dgvTeatar = new System.Windows.Forms.DataGridView();
            this.BrojDvorana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.srchGrad = new System.Windows.Forms.ComboBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeOtvaranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijemeZatvaranjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teatarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teatarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTeatar
            // 
            this.btnDodajTeatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajTeatar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajTeatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTeatar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajTeatar.Location = new System.Drawing.Point(28, 494);
            this.btnDodajTeatar.Name = "btnDodajTeatar";
            this.btnDodajTeatar.Size = new System.Drawing.Size(197, 37);
            this.btnDodajTeatar.TabIndex = 25;
            this.btnDodajTeatar.Text = "Dodaj novi teatar";
            this.btnDodajTeatar.UseVisualStyleBackColor = false;
            this.btnDodajTeatar.Click += new System.EventHandler(this.BtnDodajTeatar_Click);
            // 
            // dgvTeatar
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvTeatar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTeatar.AutoGenerateColumns = false;
            this.dgvTeatar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeatar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeatar.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTeatar.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTeatar.Location = new System.Drawing.Point(28, 111);
            this.dgvTeatar.Name = "dgvTeatar";
            this.dgvTeatar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTeatar.RowHeadersWidth = 51;
            this.dgvTeatar.Size = new System.Drawing.Size(849, 377);
            this.dgvTeatar.TabIndex = 24;
            this.dgvTeatar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTeatar_CellContentClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prikaz svih teatara";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(854, 46);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(10, 10);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(20, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(681, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Pretraga po gradu";
            // 
            // srchGrad
            // 
            this.srchGrad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srchGrad.FormattingEnabled = true;
            this.srchGrad.Location = new System.Drawing.Point(684, 71);
            this.srchGrad.Name = "srchGrad";
            this.srchGrad.Size = new System.Drawing.Size(191, 26);
            this.srchGrad.TabIndex = 39;
            this.srchGrad.SelectedIndexChanged += new System.EventHandler(this.SrchGrad_SelectedIndexChanged);
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
            // teatarBindingSource
            // 
            this.teatarBindingSource.DataSource = typeof(DataTransferObjects.Teatar);
            // 
            // uctTeatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(19)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.srchGrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajTeatar);
            this.Controls.Add(this.dgvTeatar);
            this.Name = "uctTeatar";
            this.Size = new System.Drawing.Size(913, 562);
            this.Load += new System.EventHandler(this.UctTeatar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox srchGrad;
    }
}
