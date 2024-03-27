using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    internal class BLKhachHangEntity
    {
        public DataTable LayKhachHang()
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.KHACHHANGs
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Số điện thoại");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.MaKH, p.TenKH, p.DiaChi, p.DienThoai);
            }
            return dt;
        }

        public bool XoaKhachHang(ref string err, string MaKH)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            KHACHHANG kh = new KHACHHANG();
            kh.MaKH = Convert.ToInt32(MaKH);
            gr.KHACHHANGs.Attach(kh);
            gr.KHACHHANGs.Remove(kh);
            gr.SaveChanges();
            return true;

        }

        public bool ThemKhachHang(string MaKH, string TenKH, string DiaChi, string DienThoai, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            KHACHHANG kh = new KHACHHANG();
            kh.MaKH = Convert.ToInt32(MaKH);
            kh.TenKH = TenKH;
            kh.DiaChi = DiaChi;
            kh.DienThoai = DienThoai;
            gr.KHACHHANGs.Add(kh);
            gr.SaveChanges();
            return true;
        }
        public bool CapNhatKhachHang(string MaKH, string TenKH, string DiaChi, string DienThoai, ref string err)
        {
            int a = Convert.ToInt32(MaKH);
            QLGaRaEntities gr = new QLGaRaEntities();
            var KHQuery = (from KH in gr.KHACHHANGs
                           where KH.MaKH == a
                           select KH).SingleOrDefault();
            if (KHQuery != null)
            {
                KHQuery.TenKH = TenKH;
                KHQuery.DiaChi = DiaChi;
                KHQuery.DienThoai = DienThoai;
                gr.SaveChanges();
            }
            return true;
        }
        public KHACHHANG TimKhachHang(string MaKH, ref string err)
        {
            QLGaRaEntities kh = new QLGaRaEntities();
            int a = Convert.ToInt32(MaKH);
            var TPQuery = from KH in kh.KHACHHANGs
                          where KH.MaKH == a
                          select KH;
            if (TPQuery != null)
                return TPQuery.SingleOrDefault();
            else
                return null;
        }
        public string TimTenKhachHang(string MaKH, ref string err)
        {
            string tenKH = null;
            QLGaRaEntities kh = new QLGaRaEntities();
            int a = Convert.ToInt32(MaKH);
            var TPQuery = (from KH in kh.KHACHHANGs
                          where KH.MaKH == a
                          select KH).SingleOrDefault();
            tenKH = TPQuery.TenKH.ToString();
            return tenKH;
        }
    }
}
