using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    class BLHopDongENTITY
    {
        public DataTable LayHopDong()
        {
            QLGaRaEntities qlGaraEntity = new QLGaRaEntities();
            var qlGara =
            from p in qlGaraEntity.HOPDONGs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số HĐ");
            dt.Columns.Add("Ngày HĐ");
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Số Xe");
            dt.Columns.Add("Trị Giá HĐ");
            dt.Columns.Add("Ngày Giao");
            dt.Columns.Add("Ngày Thu");
            foreach (var p in qlGara)
            {
                dt.Rows.Add(p.SoHD, p.NgayHD, p.MaKH, p.SoXe, p.TriGiaHD,p.NgayGiaoDK,p.NgayNgThu);
            }
            return dt;
        }
        public DataTable Lay1HopDong(string soHD)
        {
            int a=int.Parse(soHD);
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.HOPDONGs
                where p.SoHD ==a
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số HĐ");
            dt.Columns.Add("Ngày HĐ");
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Số Xe");
            dt.Columns.Add("Trị Giá HĐ");
            dt.Columns.Add("Ngày Giao");
            dt.Columns.Add("Ngày Thu");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.SoHD, p.NgayHD, p.MaKH, p.SoXe, p.TriGiaHD, p.NgayGiaoDK, p.NgayNgThu);
            }
        
            return dt;
        }
        public DataTable Lay1Makh(string makh)
        {
            int a = int.Parse(makh);
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.HOPDONGs
                where p.MaKH == a
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số HĐ");
            dt.Columns.Add("Ngày HĐ");
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Số Xe");
            dt.Columns.Add("Trị Giá HĐ");
            dt.Columns.Add("Ngày Giao");
            dt.Columns.Add("Ngày Thu");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.SoHD, p.NgayHD, p.MaKH, p.SoXe, p.TriGiaHD, p.NgayGiaoDK, p.NgayNgThu);
            }

            return dt;
        }
        public DataTable LayHopDong_TinhNo()
        {
            QLGaRaEntities qlGaraEntity = new QLGaRaEntities();
            var qlGara =
            from p in qlGaraEntity.HOPDONGs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số HĐ");
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Số Xe");
            dt.Columns.Add("Trị Giá HĐ");
            dt.Columns.Add("Ngày Thu");
            foreach (var p in qlGara)
            {
                dt.Rows.Add(p.SoHD, p.MaKH, p.SoXe, p.TriGiaHD, p.NgayNgThu);
            }
            return dt;
        }
        public DataTable LayMotPhanHopDong()
        {
            QLGaRaEntities qlGaraEntity = new QLGaRaEntities();
            var qlGara =
            from p in qlGaraEntity.HOPDONGs
            select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số HĐ");
            dt.Columns.Add("Mã Khách Hàng");
            dt.Columns.Add("Trị Giá HĐ");
            dt.Columns.Add("Ngày Nghiệm Thu");
            foreach (var p in qlGara)
            {
                dt.Rows.Add(p.SoHD, p.MaKH, p.TriGiaHD, p.NgayNgThu);
            }
            return dt;
        }
        public bool ThemHopDong(int SoHD, DateTime NgayHD, int MaKH, string SoXe, int TriGiaHD, DateTime NgayGiao, DateTime NgayThu, ref string err)
        {
            QLGaRaEntities qlGaraEntity = new QLGaRaEntities();
            HOPDONG cthd = new HOPDONG();
            cthd.SoHD = SoHD;
            cthd.NgayHD = NgayHD;
            cthd.MaKH = MaKH;
            cthd.SoXe=SoXe;
            cthd.TriGiaHD = TriGiaHD;
            cthd.NgayGiaoDK = NgayGiao;
            cthd.NgayNgThu = NgayThu;
            qlGaraEntity.HOPDONGs.Add(cthd);
            qlGaraEntity.SaveChanges();
            return true;
        }
        public bool XoaHopDong(ref string err, int SoHD)
        {
            QLGaRaEntities cthdEntity = new QLGaRaEntities();
            CHITIET_HD cthd = new CHITIET_HD();
            cthd.SoHD = SoHD;
            cthdEntity.CHITIET_HD.Attach(cthd);
            cthdEntity.CHITIET_HD.Remove(cthd);
            cthdEntity.SaveChanges();
            return true;
        }
        public bool CapNhatHopDong(int SoHD, DateTime NgayHD, int MaKH, string SoXe, int TriGiaHD, DateTime NgayGiao, DateTime NgayThu, ref string err)
        {
            QLGaRaEntities cthdEntity = new QLGaRaEntities();
            var cthdQuery = (from cthd in cthdEntity.HOPDONGs
                             where cthd.SoHD == SoHD
                             select cthd).SingleOrDefault();
            if (cthdQuery != null)
            {
                cthdQuery.NgayHD = NgayHD;
                cthdQuery.MaKH = MaKH;
                cthdQuery.SoXe = SoXe;
                cthdQuery.TriGiaHD = TriGiaHD;
                cthdQuery.NgayGiaoDK = NgayGiao;
                cthdQuery.NgayNgThu = NgayThu;
                cthdEntity.SaveChanges();
            }
            return true;
        }
        public HOPDONG TimHopDong(int SoHD,ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var hdQuery=from hd in gr.HOPDONGs
                        where hd.SoHD == SoHD
                        select hd;
            if (hdQuery != null)
                return hdQuery.SingleOrDefault();
            else
                return null;
        }
        public string[] TimTenThongTinHD(string SoHD, ref string err)
        {
            string[] a = new string[7];
            int sohd = Convert.ToInt32(SoHD);
            QLGaRaEntities gr = new QLGaRaEntities();
            var hdQuery = (from hd in gr.HOPDONGs
                          where hd.SoHD == sohd
                          select hd).SingleOrDefault();
            if(hdQuery != null)
            {
                        a[0]= hdQuery.SoHD.ToString();
                        a[1] = hdQuery.NgayHD.ToString();
                        a[2] = hdQuery.SoXe.ToString();
                        a[3] = hdQuery.NgayGiaoDK.ToString();
                        a[4]=hdQuery.TriGiaHD.ToString();
                        a[5]=hdQuery.NgayNgThu.ToString();
                        a[6]=hdQuery.MaKH.ToString();
                            return a;
            }    
            return null;
            
        }
        public string[] TimThongTinHD(string SoHD, ref string err)
        {
            string[] a = new string[3];
            int sohd = Convert.ToInt32(SoHD);
            QLGaRaEntities gr = new QLGaRaEntities();
            var hdQuery = (from hd in gr.HOPDONGs
                           where hd.SoHD == sohd
                           select hd).SingleOrDefault();
            a[0] = hdQuery.MaKH.ToString();
            a[1] = hdQuery.SoXe.ToString();
            a[2] = hdQuery.TriGiaHD.ToString();
            return a;
        }
        public int TimSoHDLonNhat(ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            int maxSoHD = Convert.ToInt32(gr.HOPDONGs.Max(ma => ma.SoHD));
            
            return maxSoHD;
        }
    }
}
