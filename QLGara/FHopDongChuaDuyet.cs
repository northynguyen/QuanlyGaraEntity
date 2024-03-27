using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{

    public partial class FHopDongChuaDuyet : Form
    {
        DataTable dtChiTietHD = null;
        string err;
        BLChiTietHopDongENTITY dbCTHD = new BLChiTietHopDongENTITY();
        BLThoEntity blt = new BLThoEntity();
        BLChiTietHopDongENTITY blct = new BLChiTietHopDongENTITY();
        BLHopDongENTITY blhd = new BLHopDongENTITY();
        string[] DanhSachTho = null;
        public FHopDongChuaDuyet()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvHopDong.DataSource = dbCTHD.LayChiTietHD();
                // Thay đổi độ rộng cột
                dgvHopDong.AutoResizeColumns();

                // Không cho thao tác trên các nút Lưu / Hủy
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                dgv_hopDong_CellClick(null, null);
                HopDongChuaDuyet();

                txtMaKH.Enabled = false;
                txtSoHD.Enabled = false;
                txtSoXe.Enabled = false;
                txtMaCV.Enabled = false;
                
                DanhSachTho = blt.TimDanhSachThoRanh(ref err);
                int i = 0;
                while (DanhSachTho[i] != null)
                {
                    if (i % 2 != 0)
                    {
                        cbbTho.Items.Add(DanhSachTho[i]);                  
                    }
                    i++;
                }    
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table HOPDONG. Lỗi rồi!!!");
            }
        }

        private void dgv_hopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvHopDong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txtSoHD.Text = dgvHopDong.Rows[r].Cells[0].Value.ToString();
            txtMaCV.Text = dgvHopDong.Rows[r].Cells[1].Value.ToString();
            txtTriGiaCV.Text = dgvHopDong.Rows[r].Cells[2].Value.ToString();
            txtMaTho.Text = dgvHopDong.Rows[r].Cells[3].Value.ToString();
            txtKhoanTho.Text = dgvHopDong.Rows[r].Cells[4].Value.ToString();

            string[] temp = blhd.TimThongTinHD(txtSoHD.Text, ref err);
            txtMaKH.Text = temp[0];
            txtSoXe.Text = temp[1];
            txtTriGia.Text = temp[2];
        }

        private void FHopDongChuaDuyet_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void HopDongChuaDuyet()
        {
            for (int i = 0; i < dgvHopDong.Rows.Count - 1; i++)
            {
                if (dgvHopDong.Rows[i].Cells[3].Value.ToString() != "0")
                {
                    dgvHopDong.Rows.RemoveAt(i);
                    i--;
                }    
            }    
        }

        private void cbbTho_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbbTho.SelectedIndex;
            string maTho = DanhSachTho[index + index];
            txtMaTho.Text = maTho;
        }

        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (cbbTho.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn Thợ xử lý");
                return;
            }    
            int soHD = int.Parse(this.txtSoHD.Text);
            int triGiaCV = int.Parse(this.txtTriGiaCV.Text);
            int maTho = int.Parse(this.txtMaTho.Text);
            int khoanTho = int.Parse(this.txtKhoanTho.Text);
            // BLChiTietHopDongADO blCTHD = new BLChiTietHopDongADO();
            dbCTHD.CapNhatChiTietHD(soHD, this.txtMaCV.Text, triGiaCV, maTho, khoanTho, ref err);// Load lại dữ liệu trên DataGridView
            dgvHopDong.Rows.RemoveAt(dgvHopDong.CurrentCell.RowIndex);
            //LoadData();
            // Thông báo
            MessageBox.Show("Đã sửa xong!");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
