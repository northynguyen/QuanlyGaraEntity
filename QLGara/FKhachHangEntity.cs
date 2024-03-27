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
    public partial class FKhachHangEntity : Form
    {
        DataTable dtKhachHang = null;
        string err;
        bool Them;
        BLKhachHangEntity dbKH = new BLKhachHangEntity();
        public FKhachHangEntity()
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
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();

                dgvKhachHang.DataSource = dbKH.LayKhachHang();
                dgvKhachHang.AutoResizeColumns();
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
        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhachHang.CurrentCell.RowIndex;
            this.txtMaKH.Text = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenKH.Text = dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.txtDienThoai.Text = dgvKhachHang.Rows[r].Cells[3].Value.ToString();
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
            this.txtMaKH.Enabled = false;
            this.txtTenKH.Focus();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtDienThoai.ResetText();
            txtDiaChi.ResetText();
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
                    BLKhachHangEntity blKH = new BLKhachHangEntity();
                    blKH.ThemKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, this.txtDiaChi.Text, this.txtDienThoai.Text, ref err);
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
                BLKhachHangEntity blKH = new BLKhachHangEntity();
                blKH.CapNhatKhachHang(this.txtMaKH.Text, this.txtTenKH.Text, this.txtDiaChi.Text, this.txtDienThoai.Text, ref err);
                LoadData();
                MessageBox.Show("Da sua xong");
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaKH.Enabled = true;
            txtMaKH.ResetText();
            txtTenKH.ResetText();
            txtDiaChi.ResetText();
            txtDienThoai.ResetText();
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            //bthThoat.Enabled = false;
            txtMaKH.Focus();
        }
        private void FKhachHangEntity_Load(object sender, EventArgs e)
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
                    int r = dgvKhachHang.CurrentCell.RowIndex;
                    string strKhachHang = dgvKhachHang.Rows[r].Cells[0].Value.ToString();
                    dbKH.XoaKhachHang(ref err, strKhachHang);
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
            BLKhachHangEntity blKH = new BLKhachHangEntity();
            KHACHHANG a = new KHACHHANG();
            a = blKH.TimKhachHang(txtTim.Text, ref err);
            if (a != null)
            {
                this.lblMaKH.Text = a.MaKH.ToString();
                this.lblTenKH.Text = a.TenKH;
                this.lblDiaChi.Text = a.DiaChi;
                this.lblDienThoai.Text = a.DienThoai;
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
                lblMaKH.ResetText();
                lblTenKH.ResetText();
                lblDiaChi.ResetText();
                lblDienThoai.ResetText();
            }
        }
        private void cbbTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dem = 0;
            if (cbbTinh.SelectedIndex == 0)
            {
                for (int i = 0; i < dgvKhachHang.Rows.Count - 1; i++)
                    if (dgvKhachHang.Rows[i].Cells[2].Value.ToString() == "Thủ Đức")
                    {
                        dem++;
                    }
                string text = "Tổng số KH ở Thủ Đức: " + dem.ToString();
                lblTinh.Text = text;
            }
            else if (cbbTinh.SelectedIndex == 1)
            {
                string text = "Tổng số KH: " + (dgvKhachHang.Rows.Count - 1).ToString();
                lblTinh.Text = text;
            }
        }
    }
}
