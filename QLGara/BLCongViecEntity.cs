using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGara
{
    internal class BLCongViecEntity
    {
        public DataTable LayCongViec()
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var khs =
                from p in gr.CONGVIECs
                select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã công việc");
            dt.Columns.Add("Nội dung CV");
            dt.Columns.Add("Trị giá CV");
            dt.Columns.Add("Khoán thợ");
            foreach (var p in khs)
            {
                dt.Rows.Add(p.MaCV, p.NoiDungVC, p.TriGiaCV, p.KhoanTho);
            }
            return dt;
        }

        public bool XoaCongViec(ref string err, string MaCV)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            CONGVIEC cv = new CONGVIEC();
            cv.MaCV = MaCV;
            gr.CONGVIECs.Attach(cv);
            gr.CONGVIECs.Remove(cv);
            gr.SaveChanges();
            return true;
        }

        public bool ThemCongViec(string MaCV, string NoiDungCV, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            CONGVIEC cv = new CONGVIEC();
            cv.MaCV = MaCV;
            cv.NoiDungVC = NoiDungCV;
            gr.CONGVIECs.Add(cv);
            gr.SaveChanges();
            return true;
        }
        public bool CapNhatCongViec(string MaCV, string NoiDungCV, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var CVQuery = (from KH in gr.CONGVIECs
                           where KH.MaCV == MaCV
                           select KH).SingleOrDefault();
            if (CVQuery != null)
            {
                CVQuery.NoiDungVC = NoiDungCV;
                gr.SaveChanges();
            }
            return true;
        }
        public CONGVIEC TimKhachHang(string MaCV, ref string err)
        {
            QLGaRaEntities gr = new QLGaRaEntities();
            var CVQuery = from KH in gr.CONGVIECs
                          where KH.MaCV == MaCV
                          select KH;
            if (CVQuery != null)
                return CVQuery.SingleOrDefault();
            else
                return null;
        }
    }
}
