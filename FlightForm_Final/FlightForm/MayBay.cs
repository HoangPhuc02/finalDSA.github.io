using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightForm
{
    public class MayBay
    {
        public string SoHieuMB { get; set; }
        public string LoaiMB { get; set; }
        public int SoCho { get; set; }
        public int SoChuyenBay { get; set; }
        public MayBay(string shmb, string lmb, int socho)
        {
            /*this.SoHieuMB = shmb.Substring(0, Math.Min(shmb.Length, Define.MAX_LENGTH_SHMB));
            this.LoaiMB = lmb.Substring(0, Math.Min(lmb.Length, Define.MAX_LENGTH_LMB));
            this.SoCho = Math.Min(socho, Define.MAX_SOCHO);*/
            this.SoHieuMB = shmb;
            this.LoaiMB = lmb;
            this.SoCho = socho;
        }
        public MayBay(string shmb, string lmb, int socho, int sochuyenbay)
        {
            this.SoHieuMB = shmb;
            this.LoaiMB = lmb;
            this.SoCho = socho;
            this.SoChuyenBay = sochuyenbay;
        }
    }

    public class DanhSachMayBay
    {

        public static MayBay[] dsMayBay = new MayBay[Define.MAX_MAYBAY];
        public static int soLuong = 0;

        public static int ThemMayBay(string shmb, string lmb, int socho)
        {

            if (soLuong >= Define.MAX_MAYBAY)
            {
                return -1; // nếu quá tải thì báo lỗi
            }
            dsMayBay[soLuong] = new MayBay(shmb, lmb, socho);
            soLuong++;
            return 1; // nếu còn chỗ thì thêm chuyến bay
        }
        //public static int ThemMayBay2(string shmb, string lmb, int socho, int sochuyenbay)
        //{

        //    if (soLuong >= Define.MAX_MAYBAY)
        //    {
        //        return -1; // nếu quá tải thì báo lỗi
        //    }
        //    dsMayBay[soLuong] = new MayBay(shmb, lmb, socho, sochuyenbay);
        //    soLuong++;
        //    return 1; // nếu còn chỗ thì thêm chuyến bay
        //}

        public static void XoaMayBay(int viTri)
        {

            for (int i = viTri; i < soLuong - 1; i++)
            {
                dsMayBay[i] = dsMayBay[i + 1];
            }
            dsMayBay[soLuong - 1] = null;


            soLuong--;
        }

        public static int TimMayBay(string soHieuMB)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (dsMayBay[i].SoHieuMB == soHieuMB)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void HieuChinh(int viTri, MayBay mb)
        {
            dsMayBay[viTri] = mb;
        }

        public static void DocFile()
        {
            string path = "..\\data_MB.txt";
            //MayBay mb = new MayBay();
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        ThemMayBay(arr[0].Trim(), arr[1].Trim(), int.Parse(arr[2].Trim()));
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void LuuDanhSachMayBayVaoFile()
        {
            using (StreamWriter writer = new StreamWriter("..\\data_MB.txt"))
            {
                for (int i = 0; i < soLuong; i++)
                {
                    string line = dsMayBay[i].SoHieuMB + ";" + dsMayBay[i].LoaiMB + ";" + dsMayBay[i].SoCho + ";" + dsMayBay[i].SoChuyenBay;
                    writer.WriteLine(line);
                }
            }
        }
    }
}
