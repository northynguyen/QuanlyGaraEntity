using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    internal class BLPhieuThuEntity
    {
        public DataTable LayPhieuThu()
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.PHIEUTHUs
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số phiếu thu");
            dt.Columns.Add("Mã số hợp đồng");
            dt.Columns.Add("Ngày lập hợp đồng");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ tên khác hàng");
            dt.Columns.Add("Số tiền");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.SoPT, p.SoHD, p.NgayLapPT, p.MaKH,p.HoTen,p.SoTienThu);
            }
            return dt;
        }
        public DataTable Lay1Lay1Mapt(string sopt)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.PHIEUTHUs
                where p.SoPT == sopt
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số phiếu thu");
            dt.Columns.Add("Mã số hợp đồng");
            dt.Columns.Add("Ngày lập hợp đồng");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ tên khác hàng");
            dt.Columns.Add("Số tiền");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.SoPT, p.SoHD, p.NgayLapPT, p.MaKH, p.HoTen, p.SoTienThu);
            }
            return dt;
        }
        public DataTable Lay1SoHD(string sohd)
        {
            int a = int.Parse(sohd);
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.PHIEUTHUs
                where p.SoHD == a
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số phiếu thu");
            dt.Columns.Add("Mã số hợp đồng");
            dt.Columns.Add("Ngày lập hợp đồng");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ tên khác hàng");
            dt.Columns.Add("Số tiền");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.SoPT, p.SoHD, p.NgayLapPT, p.MaKH, p.HoTen, p.SoTienThu);
            }
            return dt;
        }
        public DataTable Lay1MaKH(string makh)
        {
            int a = int.Parse(makh);
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.PHIEUTHUs
                where p.MaKH == a
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Số phiếu thu");
            dt.Columns.Add("Mã số hợp đồng");
            dt.Columns.Add("Ngày lập hợp đồng");
            dt.Columns.Add("Mã khách hàng");
            dt.Columns.Add("Họ tên khác hàng");
            dt.Columns.Add("Số tiền");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.SoPT, p.SoHD, p.NgayLapPT, p.MaKH, p.HoTen, p.SoTienThu);
            }
            return dt;
        }
        public bool XoaPT(ref string err, string SoPT)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            PHIEUTHU kh = new PHIEUTHU();
            kh.SoPT = SoPT;

            gr.PHIEUTHUs.Attach(kh);
            gr.PHIEUTHUs.Remove(kh);

            gr.SaveChanges();
            return true;

        }

        public bool ThemPhieuThu(string SoPT, DateTime NgayLap, int SoHD, int MaKH, string HoTen, int SoTienThu, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            PHIEUTHU p = new PHIEUTHU();
            p.SoPT = SoPT;
            p.SoHD=SoHD;
            p.NgayLapPT = NgayLap;
            p.MaKH=MaKH;
            p.HoTen = HoTen;
            p.SoTienThu=SoTienThu;
            gr.PHIEUTHUs.Add(p);
            gr.SaveChanges();
            return true;
        }
        public bool CapNhatPhieuThu(string SoPT, DateTime NgayLap, int SoHD, int MaKH, string HoTen, int SoTienThu, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
           
            var p = (from Kh in gr.PHIEUTHUs
                     where Kh.SoPT == SoPT
                     select Kh).SingleOrDefault();
            if (p != null)
            {
                p.SoPT = SoPT;
                p.SoHD = SoHD;
                p.NgayLapPT = NgayLap;
                p.MaKH = MaKH;
                p.HoTen = HoTen;
                p.SoTienThu = SoTienThu;
                gr.SaveChanges();
            }
            return true;
        }
        public PHIEUTHU TimSoPT(string SoPT, ref string err)
        {
            QLGaRaEntities t = new QLGaRaEntities();
            var TPQuery = (from T in t.PHIEUTHUs
                           where T.SoPT == SoPT
                           select T).SingleOrDefault();
            if (TPQuery != null)
                return TPQuery;
            else
                return null;
        }
        public Dictionary<int, int> TinhTien(ref string err)
        {
            QLGaRaEntities dbContext = new QLGaRaEntities();
            
            var TPQuery = (from PT in dbContext.PHIEUTHUs
                           group PT by PT.SoHD into soHDgroup
                           select new
                           {
                               SoHD = soHDgroup.Key,
                               total = soHDgroup.Sum(p => p.SoTienThu)
                           }).ToDictionary(x => x.SoHD, x => x.total.GetValueOrDefault());

            if (TPQuery != null)
                return TPQuery;
            else
                return null;
            
        }
    }
}
