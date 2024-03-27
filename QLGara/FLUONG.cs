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
    public partial class FLUONG : Form
    {
        string err;
        public FLUONG()
        {
            InitializeComponent();
        }

        private void FLUONG_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLGaraDataset.LUONG2' table. You can move, or remove it, as needed.
            this.lUONG2TableAdapter.Fill(this.qLGaraDataset.LUONG2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FReportLuong RP = new FReportLuong();
            RP.ShowDialog();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
           
        }
    }
}
