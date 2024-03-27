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
    public partial class FAdminENTITY : Form
    {
        TabPage pt = new TabPage("Phiếu Thu");
        TabPage kh = new TabPage("Khách Hàng");
        TabPage hd = new TabPage("Hợp Đồng");
        TabPage cthd = new TabPage("Chi Tiết Hợp Đồng");
        TabPage t = new TabPage("Thợ");
        TabPage cv = new TabPage("Công Việc");
        public FAdminENTITY(string Ten)
        {
            InitializeComponent();
            lblTenNguoiDung.Text = Ten;
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }
        

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKhachHangEntity myForm = new FKhachHangEntity();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(kh, myForm);
        }

        private void HợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHopDongENTITY myForm = new FHopDongENTITY();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(hd, myForm);
        }

        private void chiTiếtHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FChiTietHopDongENTITY myForm = new FChiTietHopDongENTITY();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(cthd, myForm);
        }

        private void phiếuThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FPhieuThuEntity myForm = new FPhieuThuEntity();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(pt, myForm);
        }

        private void côngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCongViecEntity myForm = new FCongViecEntity();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(cv, myForm);
        }

        private void thợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThoEntity myForm = new FThoEntity();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(t, myForm);
        }
        public void AddTab(TabPage tp, Form a)
        {
            tabControl.SelectedTab = tp;
            foreach (TabPage temp in tabControl.TabPages)
            {
                if (temp.Text == tp.Text)
                    return;
            }
            tabControl.TabPages.Add(tp);
            a.TopLevel = false;
            tp.Controls.Clear();
            tp.Controls.Add(a);
            a.Show();
        }
        private void ptbThoat_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == null)
                return;
            tabControl.SelectedTab.Dispose();
        }
        private void tsmThongTin_Click(object sender, EventArgs e)
        {
            FTinhNoENTITY myForm = new FTinhNoENTITY();
            myForm.Show();
        }



        private void menuHopDongChuaDuyet_Click(object sender, EventArgs e)
        {
            TabPage hhcd = new TabPage("Hợp Đồng Chưa Duyệt");
            FHopDongChuaDuyet myForm = new FHopDongChuaDuyet();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(hhcd, myForm);
        }

        private void menuHopDongChuaDuyet_Click_1(object sender, EventArgs e)
        {
            TabPage rptl = new TabPage("Report tính lương");
            FLUONG myForm = new FLUONG();
            myForm.FormBorderStyle = FormBorderStyle.None;
            AddTab(rptl, myForm);
        }

        private void menuHopDongChuaDuyet_Click_2(object sender, EventArgs e)
        {
            ReportDoanhThu myForm = new ReportDoanhThu();
            myForm.ShowDialog();
            
        }

        private void menuHopDongChuaDuyet_Click_3(object sender, EventArgs e)
        {
            ReportHopDong myform= new ReportHopDong();
            myform.ShowDialog();
        }
    }
}
