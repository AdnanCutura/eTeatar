using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObjects.Requests;

namespace WinForms.Obavijest
{
    public partial class uctObavijest : UserControl
    {
        private readonly APIService _obavijestService = new APIService("Obavijest");

        public uctObavijest()
        {
            InitializeComponent();
        }

        private async void UctObavijest_Load(object sender, EventArgs e)
        {
            await LoadObavijesti();
        }

        private async Task LoadObavijesti(DateTime? from = null, DateTime? to = null)
        {
            List<DataTransferObjects.Obavijest> list;

            if (from == null && to != null)
                list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(new ObavijestSearchRequest
                {
                    DatumDo = to
                });


            if (from != null && to != null)
                list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(new ObavijestSearchRequest
                {
                    DatumOd = from,
                    DatumDo = to
                });

            else
                list = await _obavijestService.Get<List<DataTransferObjects.Obavijest>>(null);

            dgvObavijest.AutoGenerateColumns = false;
            dgvObavijest.DataSource = list;
        }

        private void SrchDateFrom_ValueChanged(object sender, EventArgs e)
        {
            srchDateFrom.CustomFormat = "dd.MM.yyyy";
        }

        private void SrchDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                srchDateFrom.CustomFormat = " ";
        }

        private async void SearchIcon_Click(object sender, EventArgs e)
        {
            if (srchDateFrom.CustomFormat == " ")
                await LoadObavijesti(null, srchDateTo.Value);
            else
                await LoadObavijesti(srchDateFrom.Value, srchDateTo.Value);
        }
    }
}
