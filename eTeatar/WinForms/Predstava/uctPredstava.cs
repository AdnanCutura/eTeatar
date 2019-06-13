﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects.Requests;

namespace WinForms.Predstava
{
    public partial class uctPredstava : UserControl
    {
        private readonly APIService _predstavaService = new APIService("Predstava");
        private readonly APIService _teatarService = new APIService("Teatar");

        public uctPredstava()
        {
            InitializeComponent();
        }

        private async void UctPredstava_Load(object sender, EventArgs e)
        {
            await LoadPredstava();
            await LoadTeatar();
        }

        #region Učitavanje podataka

        private async Task LoadPredstava(string naziv = null, string teatarId = null)
        {
            try
            {
                List<DataTransferObjects.Predstava> list = new List<DataTransferObjects.Predstava>();

                var search = new DataTransferObjects.Requests.PredstavaSearchRequest
                {
                    TeatarId = teatarId,
                    Naziv = naziv,
                    AreAktualnePredstave = false
                };

                list = await _predstavaService.Get<List<DataTransferObjects.Predstava>>(search);
                
                dgvPredstava.AutoGenerateColumns = false;
                dgvPredstava.DataSource = list;

                for (int i = 0; i < list.Count(); i++)
                {
                    dgvPredstava.Rows[i].Cells["BrojUloga"].Value = list[i].Uloge.Count;
                }
            }
            catch 
            {
                
            }

        }
        private async Task LoadTeatar()
        {
            var list = await _teatarService.Get<List<DataTransferObjects.Teatar>>(null);

            list.Insert(0, new DataTransferObjects.Teatar());

            cmbTeatar.DisplayMember = "Naziv";
            cmbTeatar.ValueMember = "Id";
            cmbTeatar.DataSource = list;
        }

        #endregion

        #region Pretraga

        private async void CmbTeatar_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teatarId = cmbTeatar.SelectedValue?.ToString();
            await LoadPredstava(srchNaziv?.Text, teatarId);

        }
        #endregion

        private async void SrchNaziv_TextChanged(object sender, EventArgs e)
        {
            var teatarId = cmbTeatar.SelectedValue?.ToString();
            await LoadPredstava(srchNaziv?.Text, teatarId);
        }

        private void BtnDodajPredstavu_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(new uctDodajPredstavu());
        }

        private async void DgvPredstava_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvPredstava.Rows[e.RowIndex].Cells["id"].Value;

            //Todo: ako postoje termini nije moguce obrisati
            if (dgvPredstava.Columns[e.ColumnIndex].Name == "Izbrisi")
            {
                if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    await _predstavaService.Delete<DataTransferObjects.Predstava>(id);
                    await LoadPredstava();
                    return;
                }
            }

            PanelSwitcher.setToTop(new uctDodajPredstavu(id.ToString()));
        }
    }
}
