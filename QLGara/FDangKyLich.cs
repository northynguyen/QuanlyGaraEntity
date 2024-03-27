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
    public partial class FDangKyLich : Form
    {
        BLCongViecEntity dbKH = new BLCongViecEntity();
        string err;
        public FDangKyLich()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dgvCongViec.DataSource = dbKH.LayCongViec();
                dgvCongViec.AutoResizeColumns();
                // Không cho thao tác trên các nút Lưu / Hủy

                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                //bthThoat.Enabled = true;
                //dgvKhachHang_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
            cbbCongViec.SelectedIndex = -1;
        }
        private void FDangKyLich_Load(object sender, EventArgs e)
        {
            LoadData();
            for (int i = 0; i < dgvCongViec.Rows.Count - 1; i++)
            {
                cbbCongViec.Items.Add(dgvCongViec.Rows[i].Cells[1].Value.ToString());
            }    
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "" || txtSoXe.Text == "" ||
                cbbCongViec.SelectedIndex == -1)
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            else
            {
                BLHopDongENTITY blhd = new BLHopDongENTITY();
                BLChiTietHopDongENTITY blcthd = new BLChiTietHopDongENTITY();
                BLKhachHangEntity btkh = new BLKhachHangEntity();

                int SoHD = blhd.TimSoHDLonNhat(ref err) + 1;
                int MaKH = Convert.ToInt32(txtMaKH.Text);
                string MaCV = null;
                int TriGiaVC = 0;
                int KhoanTho = 0;

                string HoTen = btkh.TimTenKhachHang(txtMaKH.Text, ref err);

                for (int i = 0; i < dgvCongViec.Rows.Count - 1; i++)
                {
                    if (cbbCongViec.SelectedItem.ToString() == dgvCongViec.Rows[i].Cells[1].Value.ToString())
                    {
                        MaCV = dgvCongViec.Rows[i].Cells[0].Value.ToString();
                        TriGiaVC = Convert.ToInt32(dgvCongViec.Rows[i].Cells[2].Value.ToString());
                        KhoanTho = Convert.ToInt32(dgvCongViec.Rows[i].Cells[3].Value.ToString());
                        break;
                    }    
                }
                int TriGiaHD = TriGiaVC + KhoanTho;
                blhd.ThemHopDong(SoHD, dtpNgayGiaoXe.Value, MaKH, txtSoXe.Text, TriGiaHD, dtpNgayGiaoXe.Value, dtpNgayLayXe.Value, ref err);
                blcthd.ThemChiTietHD(SoHD, MaCV, TriGiaVC, 0, KhoanTho, ref err);
                MessageBox.Show("Đã đăng ký xong. Yêu cầu của bạn đang được duyệt!");
                this.Close();
            }    
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

            txtMaKH.Text = null;
            txtSoXe.Text = null;
            cbbCongViec.SelectedIndex = -1;
        }
    }
}
