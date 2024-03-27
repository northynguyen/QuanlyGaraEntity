using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    
    internal class BLDangNhapEntity
    {
        QLGaRaEntities gr = new QLGaRaEntities();
        public bool LayAdmin(string TK,string MK)
        {
            
            
            var ads = (from ad in gr.ADMINs
                       where (ad.TenAdmin == TK && ad.MatKhau==MK)
                       select ad).SingleOrDefault();
            if (ads == null)
            {
                return false;
            }
            return true;
        }
        public bool LayNguoiDung(string TK, string MK)
        {            
            var ads = (from ad in gr.NGUOIDUNGs
                       where (ad.TenNguoiDung == TK && ad.MatKhau == MK)
                       select ad).SingleOrDefault();
            if (ads == null)
            {
                return false;
            }
            return true;
        }
        public string LayMatKhau(string Tk)
        {
            var mks = (from mk in gr.NGUOIDUNGs
                       where (mk.TenNguoiDung == Tk )
                       select mk).SingleOrDefault();
            if (mks == null)
            {
                return "Tài khoản không tồn tại";
            }
            return "Mật khẩu của bạn là "+mks.MatKhau;
        }
        public string LayMaKH(string Tk)
        {
            var mks = (from mk in gr.NGUOIDUNGs
                       where (mk.TenNguoiDung == Tk)
                       select mk).SingleOrDefault();
            if (mks == null)
            {
                return "Tài khoản không tồn tại";
            }
            return mks.MaKH.ToString();
        }


    }
}
