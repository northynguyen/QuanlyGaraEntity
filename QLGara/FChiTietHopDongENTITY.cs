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
    public partial class FChiTietHopDongENTITY : Form
    {
        bool Them;
        string err;
        BLChiTietHopDongENTITY ctHD = new BLChiTietHopDongENTITY();
        public FChiTietHopDongENTITY()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgv_chiTietHD.DataSource = ctHD.LayChiTietHD();
                // Thay đổi độ rộng cột
                dgv_chiTietHD.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                // Xóa trống các đối tượng trong Panel
                this.txt_soHD.ResetText();
                this.txt_maCV.ResetText();
                this.txt_triGiaCV.ResetText();
                this.txt_maTho.ResetText();
                this.txt_khoanTho.ResetText();

                // Không cho thao tác trên các nút Lưu / Hủy
                this.btn_luu.Enabled = false;
                this.btn_huy.Enabled = false;
                this.pn_attribute.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btn_them.Enabled = true;
                this.btn_sua.Enabled = true;
                this.btn_xoa.Enabled = true;
                this.btn_reload.Enabled = true;
                //
                dgv_chiTietHD_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table CHITIET_HD. Lỗi rồi!!!");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgv_chiTietHD.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strChiTietHD =
                dgv_chiTietHD.Rows[r].Cells[0].Value.ToString();
                int soHD = int.Parse(strChiTietHD);
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    ctHD.XoaChiTietHD(ref err, soHD);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            int soHD = int.Parse(this.txt_soHD.Text);
            int triGiaCV = int.Parse(this.txt_triGiaCV.Text);
            int maTho = int.Parse(this.txt_maTho.Text);
            int khoanTho = int.Parse(this.txt_khoanTho.Text);
            // Mở kết nối
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                // Thực hiện lệnh
                BLChiTietHopDongENTITY ctHD = new BLChiTietHopDongENTITY();

                    ctHD.ThemChiTietHD(soHD, this.txt_maCV.Text, triGiaCV, maTho, khoanTho, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLChiTietHopDongENTITY ctHD = new BLChiTietHopDongENTITY();
                ctHD.CapNhatChiTietHD(soHD, this.txt_maCV.Text, triGiaCV, maTho, khoanTho, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            txt_soHD.Enabled = true;
            // Xóa trống các đối tượng trong Panel
            this.txt_soHD.ResetText();
            this.txt_maCV.ResetText();
            this.txt_triGiaCV.ResetText();
            this.txt_maTho.ResetText();
            this.txt_khoanTho.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            pn_attribute.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            txt_soHD.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            pn_attribute.Enabled = true;
            dgv_chiTietHD_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btn_luu.Enabled = true;
            btn_huy.Enabled = true;
            pn_attribute.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btn_them.Enabled = false;
            btn_sua.Enabled = false;
            btn_xoa.Enabled = false;

            // Đưa con trỏ đến TextField txtTenCty
            txt_soHD.Enabled = false;
            txt_maCV.Focus();
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel
            this.txt_soHD.ResetText();
            this.txt_maCV.ResetText();
            this.txt_triGiaCV.ResetText();
            this.txt_maTho.ResetText();
            this.txt_khoanTho.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btn_them.Enabled = true;
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel
            btn_luu.Enabled = false;
            btn_huy.Enabled = false;
            pn_attribute.Enabled = false;
            dgv_chiTietHD_CellClick(null, null);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_chiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgv_chiTietHD.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            txt_soHD.Text = dgv_chiTietHD.Rows[r].Cells[0].Value.ToString();
            txt_maCV.Text = dgv_chiTietHD.Rows[r].Cells[1].Value.ToString();
            txt_triGiaCV.Text = dgv_chiTietHD.Rows[r].Cells[2].Value.ToString();
            txt_maTho.Text = dgv_chiTietHD.Rows[r].Cells[3].Value.ToString();
            txt_khoanTho.Text = dgv_chiTietHD.Rows[r].Cells[4].Value.ToString();
        }

        private void FChiTietHopDongENTITY_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            BLChiTietHopDongENTITY cthd = new BLChiTietHopDongENTITY();
            CHITIET_HD a = new CHITIET_HD();
            int soHD = int.Parse(txt_timKiem.Text);
            a = cthd.TimChiTietHD(soHD, ref err);
            if (a != null)
            {
                txt_tkSoHD.Text = a.SoHD.ToString();
                txt_tkMaCV.Text = a.MaCV.ToString();
                txt_tkTriGiaCV.Text = a.TriGiaCV.ToString();
                txt_tkMaTho.Text=a.MaTho.ToString();
                txt_tkKhoanTho.Text=a.KhoanTho.ToString() ;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                txt_tkSoHD.ResetText();
                txt_tkMaCV.ResetText();
                txt_tkTriGiaCV.ResetText();
                txt_tkMaTho.ResetText();
                txt_tkKhoanTho.ResetText();
            }
        }
    }
}
