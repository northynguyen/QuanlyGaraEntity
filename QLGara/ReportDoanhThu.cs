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
    public partial class ReportDoanhThu : Form
    {
        public ReportDoanhThu()
        {
            InitializeComponent();
        }

        private void ReportDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLGaraDataset.PHIEUTHU1' table. You can move, or remove it, as needed.
            this.pHIEUTHU1TableAdapter.Fill(this.qLGaraDataset.PHIEUTHU1);
            // TODO: This line of code loads data into the 'qLGaraDataset.PHIEUTHU' table. You can move, or remove it, as needed.
            this.pHIEUTHUTableAdapter.Fill(this.qLGaraDataset.PHIEUTHU);

            this.reportViewer1.RefreshReport();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                this.pHIEUTHUTableAdapter.Fill(this.qLGaraDataset.PHIEUTHU);
            }
            else
            {
                this.pHIEUTHUTableAdapter.FillBy(this.qLGaraDataset.PHIEUTHU, txtTim.Text);
            }


            this.reportViewer1.RefreshReport();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
