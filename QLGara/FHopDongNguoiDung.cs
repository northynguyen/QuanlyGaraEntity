using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace QLGara
{

    public partial class FHopDongNguoiDung : Form
    {
        DataTable dtChiTietHD = null;
        string err;
        BLChiTietHopDongENTITY dbCTHD = new BLChiTietHopDongENTITY();
        BLHopDongENTITY blhd = new BLHopDongENTITY();

        public string TenKH;
        public int MaKH;

        public FHopDongNguoiDung(string Ten, int Ma)
        {
            InitializeComponent();
            TenKH = Ten;
            MaKH = Ma;
        }
        void LoadData()
        {
            try
            {                
                // Đưa dữ liệu lên DataGridView
                dgvHopDong.DataSource = blhd.LayMotPhanHopDong();
                // Thay đổi độ rộng cột
                dgvHopDong.AutoResizeColumns();

                // Không cho thao tác trên các nút Lưu / Hủy
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                dgv_hopDong_CellClick(null, null);
                HopDongChuaDuyet();


                txtMaKH.ResetText();
                txtSoHD.ResetText();
                txtSoXe.ResetText();
                txtMaCV.ResetText();
                txtKhoanTho.ResetText();
                txtMaCV.ResetText();
                txtTriGia.ResetText();
                txtTriGiaCV.ResetText();
                txtNgayNghiemThu.ResetText();
                txtNgayNghiemThu.ResetText();
                txtNgayHopDong.ResetText();
                txtNgayGiao.ResetText();
                txtMaTho.ResetText();

                lblDuyet.ResetText();

                txtMaKH.Enabled = false;
                txtSoHD.Enabled = false;
                txtSoXe.Enabled = false;
                txtMaCV.Enabled = false;
                txtKhoanTho.Enabled = false;
                txtMaCV.Enabled = false;
                txtTriGia.Enabled = false;
                txtTriGiaCV.Enabled = false;
                txtMaTho.Enabled = false;
                txtTenKhachHang.Enabled = false;
                txtNgayNghiemThu.Enabled = false;
                txtNgayHopDong.Enabled = false;
                txtNgayGiao.Enabled = false;

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
            txtMaKH.Text = dgvHopDong.Rows[r].Cells[1].Value.ToString();
            txtTriGia.Text = dgvHopDong.Rows[r].Cells[2].Value.ToString();
            txtNgayNghiemThu.Text = dgvHopDong.Rows[r].Cells[3].Value.ToString();


            string[] temp = blhd.TimTenThongTinHD(txtSoHD.Text, ref err);
            txtNgayHopDong.Text = temp[1];
            txtSoXe.Text = temp[2];
            txtNgayGiao.Text = temp[3];

            string[] tempChiTietHopDong = dbCTHD.TimThongTinChiTietHD(txtSoHD.Text, ref err);
            txtMaCV.Text = tempChiTietHopDong[0];           
            txtTriGiaCV.Text = tempChiTietHopDong[1];
            txtMaTho.Text = tempChiTietHopDong[2];
            txtKhoanTho.Text = tempChiTietHopDong[3];

            txtTenKhachHang.Text = TenKH;

            if (tempChiTietHopDong[2] != "0")
            {
                lblDuyet.Text = "ĐÃ DUYỆT";
                //lblDuyet.BackColor = Color.DarkGreen;
                lblDuyet.ForeColor = Color.DarkGreen;
            } 
            else
            {
                lblDuyet.Text = "CHƯA DUYỆT";
                //lblDuyet.BackColor = Color.DarkGreen;
                lblDuyet.ForeColor = Color.Red;
            }    
        }

        private void FHopDongChuaDuyet_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void HopDongChuaDuyet()
        {
            for (int i = 0; i < dgvHopDong.Rows.Count - 1; i++)
            {
                if (dgvHopDong.Rows[i].Cells[1].Value.ToString() != MaKH.ToString())
                {
                    dgvHopDong.Rows.RemoveAt(i);
                    i--;
                }    
            }    
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
