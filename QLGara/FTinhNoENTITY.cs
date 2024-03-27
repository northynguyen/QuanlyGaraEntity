using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QLGara
{
    public partial class FTinhNoENTITY : Form
    {
        string err;
        bool Them;
        BLHopDongENTITY hd = new BLHopDongENTITY();
        public FTinhNoENTITY()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dgv_hopDong.DataSource = hd.LayHopDong_TinhNo();
                // Thay đổi độ rộng cột
                dgv_hopDong.AutoResizeColumns();
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "Số ngày còn lại của hợp đồng"; // Tiêu đề của cột
                column.Name = "NgayConLai"; // Tên duy nhất của cột
                dgv_hopDong.Columns.Add(column);

                DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
                column1.HeaderText = "Số tiền đã trả"; // Tiêu đề của cột
                column1.Name = "DaTra"; // Tên duy nhất của cột
                dgv_hopDong.Columns.Add(column1);
                SoNgayConLai();
                TienDaNop();

                    // Thay đổi độ rộng cột
                    dgv_hopDong.AutoResizeColumns();
                
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table thợ. Lỗi rồi!!!");
            }


        }
        
        private void SoNgayConLai()
        {
            for (int i = 0; i < dgv_hopDong.Rows.Count-1; i++)
            {

                if (DateTime.TryParse(dgv_hopDong.Rows[i].Cells[4].Value.ToString(), out DateTime dateTimeValue))
                {
                    TimeSpan time = dateTimeValue - DateTime.Now;
                    dgv_hopDong.Rows[i].Cells[5].Value = time.Days;
                }

            }
            
        }
        private void TienDaNop()
        {

            BLPhieuThuEntity pt = new BLPhieuThuEntity();
            Dictionary<int, int> dic = pt.TinhTien(ref err);
            for (int i = 0; i < dgv_hopDong.Rows.Count-1; i++)
            {
                try
                {
                    int index = int.Parse(dgv_hopDong.Rows[i].Cells[0].Value.ToString());
                    dgv_hopDong.Rows[i].Cells[6].Value = dic[index];
                }
                catch
                {
                    dgv_hopDong.Rows[i].Cells[6].Value = 0;
                }



            }
        }
        private void FTinhNoLinQ_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        

        private void dgv_hopDong_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dgv_hopDong.Rows[e.RowIndex];
            int value = Convert.ToInt32(row.Cells[5].Value); // Thay "ColumnName" bằng tên cột bạn muốn kiểm tra
            if (Convert.ToInt32(row.Cells[6].Value) >= Convert.ToInt32(row.Cells[3].Value))
            {
                row.DefaultCellStyle.BackColor = Color.Green;
                // Đặt màu chữ cho hàng
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else if (value < 0)
            {
                // Đặt màu nền cho hàng
                row.DefaultCellStyle.BackColor = Color.Red;
                // Đặt màu chữ cho hàng
                row.DefaultCellStyle.ForeColor = Color.White;
            }

            else
            {
                // Đặt màu mặc định cho hàng
                row.DefaultCellStyle.BackColor = dgv_hopDong.DefaultCellStyle.BackColor;
                row.DefaultCellStyle.ForeColor = dgv_hopDong.DefaultCellStyle.ForeColor;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void dgv_hopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_hopDong.CurrentCell.RowIndex;
            BLKhachHangEntity kh = new BLKhachHangEntity();


            this.lblMaKH.Text = dgv_hopDong.Rows[r].Cells[1].Value.ToString();

            KHACHHANG a = new KHACHHANG();
            a = kh.TimKhachHang(this.lblMaKH.Text, ref err);
            this.lblTenKH.Text = a.TenKH.ToString();

            this.lblNgayCon.Text = dgv_hopDong.Rows[r].Cells[5].Value.ToString();
            int temp = (int.Parse(this.lblNgayCon.Text));

            if (temp>0 || int.Parse(dgv_hopDong.Rows[r].Cells[3].Value.ToString()) <= int.Parse(dgv_hopDong.Rows[r].Cells[6].Value.ToString()))
            {
                this.lblTienPhat.Text = "0";
                this.lbl_thongbao.Text = "";
            }
            else
            {
                this.lblTienPhat.Text = (double.Parse(dgv_hopDong.Rows[r].Cells[3].Value.ToString()) * (0.02)).ToString();
                if (temp < -60)
                {
                    this.lbl_thongbao.Text = "KHÁCH HÀNG ĐÃ QUÁ HẠNG NỘP PHẠT,CẦN LIÊN LẠC !\nSố điện thoai: " + a.DienThoai.ToString() + "\nĐịa chỉ: " + a.DiaChi.ToString();
                }
                else
                {
                    this.lbl_thongbao.Text = "KHÁCH HÀNG ĐÃ QUÁ HẠNG HỢP ĐỒNG!\nYÊU CẦU KHÁCH HÀNG NỘP PHẠT";
                }
            }


            if (int.Parse(dgv_hopDong.Rows[r].Cells[3].Value.ToString()) > int.Parse(dgv_hopDong.Rows[r].Cells[6].Value.ToString()))
            {
                this.lblTienCon.Text = (double.Parse(dgv_hopDong.Rows[r].Cells[3].Value.ToString()) - int.Parse(dgv_hopDong.Rows[r].Cells[6].Value.ToString()) + double.Parse(this.lblTienPhat.Text)).ToString();
            }
            else
            {
                this.lblTienCon.Text = "0";
            }

            //    MessageBox.Show("Không lấy được nội dung trong table thợ. Lỗi rồi!!!");
        }
    }
}
//(double.Parse(dgv_hopDong.Rows[r].Cells[3].Value.ToString())*(1+0.02)).ToString();