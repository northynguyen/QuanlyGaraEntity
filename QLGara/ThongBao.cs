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
    public partial class ThongBao : Form
    {
        public int MaKH;public int[] soHD = new int[50];
        public string TenKH;
        string err;
        public ThongBao(string Ten,string MK)
        {
            InitializeComponent();
            this.MaKH = int.Parse(MK);
            this.TenKH = Ten;
        }
        public void ThayDoi(string[] temp, int id)
        {
            BLPhieuThuEntity pt = new BLPhieuThuEntity();
            Dictionary<int, int> dic = pt.TinhTien(ref err);
            dv_thongbao.Rows.Add();
            int index = int.Parse(temp[0]);
                dv_thongbao.Rows[id].Cells[0].Value = index.ToString();
            try
            {
                int tiendatra = dic[index];
                if (tiendatra >= int.Parse(temp[4]))
                {
                    dv_thongbao.Rows[id].Cells[1].Value = "Hoàn thành";
                    dv_thongbao.Rows[id].Cells[2].Value = "0";
                    dv_thongbao.Rows[id].Cells[3].Value = "0";
                    dv_thongbao.Rows[id].Cells[4].Value = "0";
                }
                else
                {
                    dv_thongbao.Rows[id].Cells[1].Value = "Chưa hoàn thành";

                    TimeSpan time = DateTime.Parse(temp[5].ToString()) - DateTime.Now;
                    dv_thongbao.Rows[id].Cells[2].Value = time.Days.ToString();
                    int temp1 = Math.Abs(int.Parse(time.Days.ToString()));

                    if (temp1 < 30)
                    {
                        dv_thongbao.Rows[id].Cells[3].Value = "0";
                        dv_thongbao.Rows[id].Cells[4].Value = (int.Parse(temp[4]) - tiendatra).ToString();
                    }
                    else
                    {
                        dv_thongbao.Rows[id].Cells[3].Value = (double.Parse(temp[4].ToString()) * (0.02)).ToString();
                        if (temp1 > 60)
                            this.lbl_thongbao.Text = "KHÁCH HÀNG ĐÃ QUÁ HẠN NỘP PHẠT MỘT SỐ HỢP ĐỒNG";
                        dv_thongbao.Rows[id].Cells[4].Value = (double.Parse(temp[4].ToString()) - tiendatra + (double.Parse(temp[4].ToString()) * (0.02))).ToString();

                    }




                }
            }
            catch
            {
                dv_thongbao.Rows[id].Cells[1].Value = "Chưa có phiếu thu";
            }
                
           
         


        }
        private void ThongBao_Load(object sender, EventArgs e)
        {
           
            BLHopDongENTITY dbhd = new BLHopDongENTITY();
            DataTable data = dbhd.LayHopDong();
            int x = data.Rows.Count;
            soHD = new int[x];
            int count = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (data.Rows[i][2].ToString() == MaKH.ToString())
                {
                    soHD[count] = int.Parse(data.Rows[i][0].ToString());
                    count++;
                }
            }
            int j = 0;
            while (soHD[j] != 0)
            {
                string[] temp = new string[7];
                temp = dbhd.TimTenThongTinHD(soHD[j].ToString(), ref err);
                ThayDoi(temp, j);
                j++;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
