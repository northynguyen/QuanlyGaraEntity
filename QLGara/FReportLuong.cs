using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{
    public partial class FReportLuong : Form
    {
        public FReportLuong()
        {
            InitializeComponent();
        }

        private void FReportLuong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLGaraDataset.LUONG' table. You can move, or remove it, as needed.
            this.lUONGTableAdapter.Fill(this.qLGaraDataset.LUONG);

            this.reportViewer1.RefreshReport();
        }
    }
}
