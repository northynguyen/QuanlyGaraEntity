using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGara
{
    internal class BLDangKyENTITY
    {
        public bool ThemNguoiDung(string hoVaTen, string diaChi, string dienThoai, string TK, string MK)
        {

            QLGaRaEntities gr = new QLGaRaEntities();

            var maxMaKH = gr.KHACHHANGs.Max(ma => ma.MaKH);
            NGUOIDUNG nd = new NGUOIDUNG();
            
            nd.TenNguoiDung = TK;
            nd.MatKhau = MK;
            nd.MaKH= maxMaKH+1;             
            

            KHACHHANG kh = new KHACHHANG();
            kh.TenKH = hoVaTen;
            kh.DiaChi = diaChi;
            kh.DienThoai = dienThoai;
            kh.MaKH = maxMaKH+1;
            gr.NGUOIDUNGs.Add(nd);
            gr.KHACHHANGs.Add(kh);
            gr.SaveChanges();
            return true;
        }
    }
}
