namespace WinForms.Glumac
{
    partial class uctGlumac
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
            this.dgvGlumac = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biografijaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Izbrisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.glumacBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txbIme = new System.Windows.Forms.TextBox();
            this.txbPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glumacBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajTeatar
            // 
            this.btnDodajTeatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.btnDodajTeatar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDodajTeatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajTeatar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajTeatar.Location = new System.Drawing.Point(28, 476);
            this.btnDodajTeatar.Name = "btnDodajTeatar";
            this.btnDodajTeatar.Size = new System.Drawing.Size(197, 38);
            this.btnDodajTeatar.TabIndex = 25;
            this.btnDodajTeatar.Text = "Dodaj novog glumca";
            this.btnDodajTeatar.UseVisualStyleBackColor = false;
            this.btnDodajTeatar.Click += new System.EventHandler(this.BtnDodajTeatar_Click);
            // 
            // dgvGlumac
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvGlumac.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGlumac.AutoGenerateColumns = false;
            this.dgvGlumac.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGlumac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGlumac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGlumac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.biografijaDataGridViewTextBoxColumn,
            this.Spol,
            this.Izbrisi});
            this.dgvGlumac.DataSource = this.glumacBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGlumac.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGlumac.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvGlumac.Location = new System.Drawing.Point(28, 77);
            this.dgvGlumac.Name = "dgvGlumac";
            this.dgvGlumac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvGlumac.RowHeadersWidth = 51;
            this.dgvGlumac.Size = new System.Drawing.Size(849, 393);
            this.dgvGlumac.TabIndex = 24;
            this.dgvGlumac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGlumac_CellContentClick_1);
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
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.Width = 125;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // biografijaDataGridViewTextBoxColumn
            // 
            this.biografijaDataGridViewTextBoxColumn.DataPropertyName = "Biografija";
            this.biografijaDataGridViewTextBoxColumn.HeaderText = "Biografija";
            this.biografijaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biografijaDataGridViewTextBoxColumn.Name = "biografijaDataGridViewTextBoxColumn";
            this.biografijaDataGridViewTextBoxColumn.Width = 125;
            // 
            // Spol
            // 
            this.Spol.HeaderText = "Spol";
            this.Spol.MinimumWidth = 6;
            this.Spol.Name = "Spol";
            this.Spol.Width = 125;
            // 
            // Izbrisi
            // 
            this.Izbrisi.DataPropertyName = "Izbrisi";
            this.Izbrisi.HeaderText = "Akcija";
            this.Izbrisi.MinimumWidth = 6;
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.Text = "Izbrisi";
            this.Izbrisi.Width = 125;
            // 
            // glumacBindingSource
            // 
            this.glumacBindingSource.DataSource = typeof(DataTransferObjects.Glumac);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Prikaz svih glumaca";
            // 
            // txbIme
            // 
            this.txbIme.BackColor = System.Drawing.Color.White;
            this.txbIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIme.Location = new System.Drawing.Point(922, 109);
            this.txbIme.MaxLength = 100;
            this.txbIme.Name = "txbIme";
            this.txbIme.Size = new System.Drawing.Size(191, 24);
            this.txbIme.TabIndex = 27;
            // 
            // txbPrezime
            // 
            this.txbPrezime.BackColor = System.Drawing.Color.White;
            this.txbPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrezime.Location = new System.Drawing.Point(922, 191);
            this.txbPrezime.MaxLength = 100;
            this.txbPrezime.Name = "txbPrezime";
            this.txbPrezime.Size = new System.Drawing.Size(191, 24);
            this.txbPrezime.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(919, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 28;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(919, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 29;
            this.label3.Text = "Prezime";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(69)))), ((int)(((byte)(64)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Search.Location = new System.Drawing.Point(916, 259);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(197, 38);
            this.Search.TabIndex = 30;
            this.Search.Text = "Pretraga";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // uctGlumac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Search);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbPrezime);
            this.Controls.Add(this.txbIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodajTeatar);
            this.Controls.Add(this.dgvGlumac);
            this.Name = "uctGlumac";
            this.Size = new System.Drawing.Size(1191, 562);
            this.Load += new System.EventHandler(this.UctGlumac_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGlumac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glumacBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajTeatar;
        private System.Windows.Forms.DataGridView dgvGlumac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource glumacBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biografijaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.DataGridViewButtonColumn Izbrisi;
        private System.Windows.Forms.TextBox txbIme;
        private System.Windows.Forms.TextBox txbPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Search;
    }
}
