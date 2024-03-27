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
    public partial class FCongViecEntity : Form
    {
        DataTable dtCongViec = null;
        string err;
        bool Them;
        BLCongViecEntity dbCV = new BLCongViecEntity();
        public FCongViecEntity()
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
                dtCongViec = new DataTable();
                dtCongViec.Clear();

                dgvCongViec.DataSource = dbCV.LayCongViec();
                dgvCongViec.AutoResizeColumns();
                // Không cho thao tác trên các nút Lưu / Hủy
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //bthThoat.Enabled = true;
                dgvKhachHang_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvCongViec.CurrentCell.RowIndex;
            this.txtMaCV.Text = dgvCongViec.Rows[r].Cells[0].Value.ToString();
            this.txtNoiDungCV.Text = dgvCongViec.Rows[r].Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            this.panel1.Enabled = true;
            dgvKhachHang_CellClick(null, null);
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            this.panel1.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            this.txtMaCV.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaCV.ResetText();
            txtNoiDungCV.ResetText();
            // Không cho thao tác trên các nút Lưu / Hủy
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            panel1.Enabled = false;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    BLCongViecEntity blCV = new BLCongViecEntity();
                    blCV.ThemCongViec(this.txtMaCV.Text, this.txtNoiDungCV.Text, ref err);
                    LoadData();
                    MessageBox.Show("Da them!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong them duoc. Loi roi!!");
                }
            }
            else
            {
                BLCongViecEntity blCV = new BLCongViecEntity();
                blCV.CapNhatCongViec(this.txtMaCV.Text, this.txtNoiDungCV.Text, ref err);
                LoadData();
                MessageBox.Show("Da sua xong");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaCV.Enabled = true;
            txtMaCV.ResetText();
            txtNoiDungCV.ResetText();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //bthThoat.Enabled = false;
            txtMaCV.Focus();
        }

        private void FCongViecEntity_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Có chắc muốn xóa không!!", "Trả lời",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (traloi == DialogResult.Yes)
                {
                    int r = dgvCongViec.CurrentCell.RowIndex;
                    string strKhachHang = dgvCongViec.Rows[r].Cells[0].Value.ToString();
                    dbCV.XoaCongViec(ref err, strKhachHang);
                    LoadData();
                    MessageBox.Show("Đã xóa xong!!");
                }
                else
                {

                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được lỗi rồi!!");
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            BLCongViecEntity blKH = new BLCongViecEntity();
            CONGVIEC a = new CONGVIEC();
            a = blKH.TimKhachHang(txtTim.Text, ref err);
            if (a != null)
            {
                this.lblMaCV.Text = a.MaCV.ToString();
                this.lblNoiDungCV.Text = a.NoiDungVC;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                lblMaCV.ResetText();
                lblNoiDungCV.ResetText();
            }
        }

        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dem = 0;
            if (cbbTinh.SelectedIndex == 1)
            {
                for (int i = 0; i < dgvCongViec.Rows.Count - 1; i++)
                    if (dgvCongViec.Rows[i].Cells[2].Value.ToString() == "Thủ Đức")
                    {
                        dem++;
                    }
                string text = "Tổng số KH ở Thủ Đức: " + dem.ToString();
                lblTinh.Text = text;
            }
            else if (cbbTinh.SelectedIndex == 0)
            {
                string text = "Tổng số công việc: " + (dgvCongViec.Rows.Count - 1).ToString();
                lblTinh.Text = text;
            }
        }
    }
}
