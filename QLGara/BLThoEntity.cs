using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    internal class BLThoEntity
    {
        public DataTable LayTho()
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.THOes
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã thợ");
            dt.Columns.Add("Tên thợ");
            dt.Columns.Add("Nhóm");
            dt.Columns.Add("Mã nhóm trưởng");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.MaTho, p.TenTho, p.Nhom, p.NhomTruong);
            }
            return dt;
        }

        public bool XoaTho(ref string err, string MaTho)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            THO kh = new THO();
            kh.MaTho = Convert.ToInt32(MaTho);

            gr.THOes.Attach(kh);
            gr.THOes.Remove(kh);

            gr.SaveChanges();
            return true;

        }

        public bool ThemTho(int MaTho, string TenTho, int Nhom, int NhomTruong, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            THO t = new THO();
            t.MaTho = MaTho;
            t.TenTho = TenTho;
            t.Nhom = Nhom;
            t.NhomTruong = NhomTruong;
            gr.THOes.Add(t);
            gr.SaveChanges();
            return true;
        }
        public bool CapNhatTho(int MaTho, string TenTho, int Nhom, int NhomTruong, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            int a = Convert.ToInt32(MaTho);
            var t = (from Kh in gr.THOes
                           where Kh.MaTho == a
                           select Kh).SingleOrDefault();
            if (t != null)
            {
                t.MaTho = MaTho;
                t.TenTho = TenTho;
                t.Nhom = Nhom;
                t.NhomTruong = NhomTruong;
                gr.SaveChanges();
            }
            return true;
        }
        public THO TimSoT(string MaTho, ref string err)
        {
            QLGaRaEntities t = new QLGaRaEntities();
            int a=Convert.ToInt32(MaTho);
            var TPQuery = (from T in t.THOes
                          where T.MaTho == a
                           select T).SingleOrDefault();
            if (TPQuery != null)
                return TPQuery;
            else
                return null;
        }
        public string[] TimDanhSachThoRanh(ref string err)
        {
            string[] DanhSachThoRanh = new string[50];
            QLGaRaEntities t = new QLGaRaEntities();
            var currentDate = DateTime.Now.Date;
            var result = from tho in t.THOes
                         join ngay in (from hd in t.HOPDONGs
                                       join ct in t.CHITIET_HD on hd.SoHD equals ct.SoHD
                                       group ct by ct.MaTho into grp
                                       where grp.Max(ct => ct.HOPDONG.NgayGiaoDK) < currentDate
                                       select new { MaTho = grp.Key, NgayDK = grp.Max(ct => ct.HOPDONG.NgayGiaoDK) })
                         on tho.MaTho equals ngay.MaTho
                         select new { tho.MaTho, tho.TenTho };
            int i = 0;
            foreach (var a in result)
            {
                DanhSachThoRanh[i] = a.MaTho.ToString();
                i++;
                DanhSachThoRanh[i] = a.TenTho.ToString();
                i++;
            }
            return DanhSachThoRanh;
        }

    }
}
