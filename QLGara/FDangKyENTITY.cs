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
    public partial class FDangKyENTITY : Form
    {
        BLDangKyENTITY dk=new BLDangKyENTITY();

        public FDangKyENTITY()
        {
            InitializeComponent();
        }

        private void link_dangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btn_dangKy_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_matKhau.Text.Equals(txt_xacNhanMK.Text))
                {
                    string hoVaTen = txt_ho.Text + txt_ten.Text;
                    dk.ThemNguoiDung(hoVaTen, txt_diaChi.Text, txt_dienThoai.Text, txt_tenTaiKhoan.Text, txt_matKhau.Text);
                    MessageBox.Show("Đăng ký thành công", "Chúc mừng");
                    this.Close();
                }
                else
                {
                    txt_xacNhanMK.Clear();
                    txt_xacNhanMK.Focus();
                    messXacNhanMK.Text = "Mật khẩu đã nhập không khớp";
                }
            }
            catch
            {
                messtk.Text = "Tài khoản đã tồn tại";
                txt_tenTaiKhoan.Clear();
                txt_tenTaiKhoan.Focus();
            }
                
        }

        private void FDangKyENTITY_Load(object sender, EventArgs e)
        {

        }
    }
}
