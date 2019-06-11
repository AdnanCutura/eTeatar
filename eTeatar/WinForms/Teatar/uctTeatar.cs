using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Teatar
{
    public partial class uctTeatar : UserControl
    {
        private readonly APIService _teatarService = new APIService("Teatar");
        public uctTeatar()
        {
            InitializeComponent();
        }

        private static uctTeatar _instance;
        public static uctTeatar Instance => _instance ?? (_instance = new uctTeatar());

        private async void UctTeatar_Load(object sender, EventArgs e)
        {
            await LoadTeatri();
        }

        private async void DgvTeatar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTeatar.Columns[e.ColumnIndex].Name == "Izbrisi")
            {
                if (MessageBox.Show("Jeste li sigurni", "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var id = dgvTeatar.Rows[e.RowIndex].Cells["Id"].Value;
                    await _teatarService.Delete<DataTransferObjects.Teatar>(id);
                    await LoadTeatri();
                }
            }
        }

        private async Task LoadTeatri()
        {
            var list = await _teatarService.Get<List<DataTransferObjects.Teatar>>(null);

            dgvTeatar.AutoGenerateColumns = false;
            dgvTeatar.DataSource = list;
            for (int i = 0; i < list.Count(); i++)
            {
                dgvTeatar.Rows[i].Cells["BrojDvorana"].Value = list[i].Dvorane.Count;
            }

        }

        private void BtnDodajTeatar_Click(object sender, EventArgs e)
        {
            PanelSwitcher.setToTop(uctDodajTeatar.Instance);
        }
    }
}
