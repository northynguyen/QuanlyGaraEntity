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
    public partial class FDangNhap : Form
    {
        bool dangKy=false;
        bool IsLogin = false;
        public string Ten;
        public int MaKH;
        BLDangNhapEntity dn=new BLDangNhapEntity();
        
        public FDangNhap()
        {
            InitializeComponent();
            
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void lbl_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dangKy = true;
            txt_tenDangNhap.Focus();
            if (dangKy)
            {
                if (rb_admin.Checked)
                {
                    MessageBox.Show("Chỉ người sử dụng mới được đăng ký tài khoản", "Thông báo!");
                }
                else
                {
                    FDangKyENTITY dk = new FDangKyENTITY();
                    dk.ShowDialog();
                }
            }
        }

        private void btn_dangNhap_Click(object sender, EventArgs e)
        {
            dangKy = false;
            Ten = txt_tenDangNhap.Text.ToString();
            if (rb_admin.Checked)
            {
                if (dn.LayAdmin(txt_tenDangNhap.Text, txt_matKhau.Text))
                {
                    this.Hide();
                    IsLogin = true;
                    FAdminENTITY admin = new FAdminENTITY(Ten);
                    admin.ShowDialog();
                    this.Show();
                }
                else lbl_messenger2.Text = "Tên tài khoản hoặc mật khẩu không chính xác!";
            } 
            else
            {
                if (dn.LayNguoiDung(txt_tenDangNhap.Text, txt_matKhau.Text))
                {
                    MaKH = Convert.ToInt32(dn.LayMaKH(txt_tenDangNhap.Text));
                    this.Hide();
                    IsLogin = true;
                    FNguoiDungENTITY nd = new FNguoiDungENTITY(Ten, MaKH);
                    nd.ShowDialog();
                    this.Show();
                }
                else lbl_messenger2.Text = "Tên tài khoản hoặc mật khẩu không chính xác!";
            }
        }

        private void lbl_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BLDangNhapEntity dn = new BLDangNhapEntity();
            if (dn.LayMatKhau(txt_tenDangNhap.Text) != null)
            {
                lbl_messenger2.Text =dn.LayMatKhau(txt_tenDangNhap.Text);
            }            
            else
            {
                lbl_messenger2.Text = dn.LayMatKhau(txt_tenDangNhap.Text);
            }


              
        }

        private void txt_tenDangNhap_TextChanged(object sender, EventArgs e)
        {
            lbl_messenger2.Text = "";
        }
    }
}
