using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    class BLChiTietHopDongENTITY
    {
        public DataTable LayChiTietHD()
        {
            QLGaRaEntities qlGaraEntity = new QLGaRaEntities();
            var qlGara =
            from p in qlGaraEntity.CHITIET_HD
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số HD");
            dt.Columns.Add("Mã CV");
            dt.Columns.Add("Trị Giá CV");
            dt.Columns.Add("Mã Thợ");
            dt.Columns.Add("Khoán Thợ");
            foreach (var p in qlGara)
            {
                dt.Rows.Add(p.SoHD, p.MaCV,p.TriGiaCV,p.MaTho,p.KhoanTho);
            }
            return dt;
        }
        public bool ThemChiTietHD(int SoHD, string MaCV, int TriGiaCV, int MaTho, int KhoanTho, ref string err)
        {
            QLGaRaEntities qlGaraEntity = new QLGaRaEntities();
            CHITIET_HD cthd = new CHITIET_HD();
            cthd.SoHD = SoHD;
            cthd.MaCV = MaCV;
            cthd.TriGiaCV= TriGiaCV;
            cthd.MaTho= MaTho;
            cthd.KhoanTho= KhoanTho;
            qlGaraEntity.CHITIET_HD.Add(cthd);
            qlGaraEntity.SaveChanges();
            return true;
        }
        public bool XoaChiTietHD(ref string err, int SoHD)
        {
            QLGaRaEntities cthdEntity = new QLGaRaEntities();
            CHITIET_HD cthd = new CHITIET_HD();
            cthd.SoHD = SoHD ;
            cthdEntity.CHITIET_HD.Attach(cthd);
            cthdEntity.CHITIET_HD.Remove(cthd);
            cthdEntity.SaveChanges();
            return true;
        }
        public bool CapNhatChiTietHD(int SoHD, string MaCV, int TriGiaCV, int MaTho, int KhoanTho, ref string err)
        {
            QLGaRaEntities cthdEntity = new QLGaRaEntities();
            var cthdQuery = (from cthd in cthdEntity.CHITIET_HD
                           where cthd.SoHD == SoHD
                           select cthd).SingleOrDefault();
            if (cthdQuery != null)
            {
                cthdQuery.MaCV = MaCV;
                cthdQuery.TriGiaCV = TriGiaCV;
                cthdQuery.MaTho= MaTho;
                cthdQuery.KhoanTho= KhoanTho;
                cthdEntity.SaveChanges();
            }
            return true;
        }
        public CHITIET_HD TimChiTietHD(int SoHD, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var cthdQuery = from cthd in gr.CHITIET_HD
                          where cthd.SoHD == SoHD
                          select cthd;
            if (cthdQuery != null)
                return cthdQuery.SingleOrDefault();
            else
                return null;
        }
        public string[] TimThongTinChiTietHD(string SoHD, ref string err)
        {
            string[] a = new string[4];
            int sohd = Convert.ToInt32(SoHD);
            QLGaRaEntities gr = new QLGaRaEntities();
            var cthdQuery = (from hd in gr.CHITIET_HD
                           where hd.SoHD == sohd
                           select hd).SingleOrDefault();
            a[0] = cthdQuery.MaCV.ToString();
            a[1] = cthdQuery.TriGiaCV.ToString();
            a[2] = cthdQuery.MaTho.ToString();
            a[3] = cthdQuery.KhoanTho.ToString();
            return a;
        }
    }
}
