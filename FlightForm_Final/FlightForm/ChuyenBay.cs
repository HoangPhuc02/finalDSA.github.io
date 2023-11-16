using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightForm
{

    public class ChuyenBay
    {
        public string MaCB { get; set; }
        public DateTime NgayGioKhoiHanh { get; set; }
        public string SanBayDen { get; set; }
        public int TrangThai { get; set; }
        public string SoHieuMB { get; set; }
        public List<string> DanhSachVe;
        public int SoVe { get; set; }
        public int SoVeDaDat { get; set; }
        public ChuyenBay next;
        //khoi tao
        public ChuyenBay(string maCB, DateTime ngayGioKhoiHanh, string sanBayDen, string soHieuMB)
        {
            this.MaCB = maCB;
            this.NgayGioKhoiHanh = ngayGioKhoiHanh;
            this.SanBayDen = sanBayDen;
            this.TrangThai = 1;
            this.SoHieuMB = soHieuMB;
            this.SoVe = DanhSachMayBay.dsMayBay[DanhSachMayBay.TimMayBay(soHieuMB)].SoCho;
            this.DanhSachVe = new List<string>(Enumerable.Repeat("", this.SoVe));
            this.SoVeDaDat = 0;
            this.next = null;
        }
        public ChuyenBay(string maCB, DateTime ngayGioKhoiHanh, string sanBayDen, int trangThai, string soHieuMB)
        {
            this.MaCB = maCB;
            this.NgayGioKhoiHanh = ngayGioKhoiHanh;
            this.SanBayDen = sanBayDen;
            this.TrangThai = trangThai;
            this.SoHieuMB = soHieuMB;
            this.SoVe = DanhSachMayBay.dsMayBay[DanhSachMayBay.TimMayBay(soHieuMB)].SoCho;
            this.DanhSachVe = new List<string>(Enumerable.Repeat("", this.SoVe));
            this.SoVeDaDat = 0;
            this.next = null;
        }
        public static bool DatVe(HanhKhach hk, int viTri, ChuyenBay cb)
        {
            for (int i = 0; i < cb.SoVe; i++)
            {
                if (cb.DanhSachVe.Contains(hk.CMND))
                {
                    //Console.WriteLine("Hanh khach da ton tai.");
                    return false;
                }
            }

            if (cb.DanhSachVe[viTri] == "")
            {
                cb.DanhSachVe[viTri] = hk.CMND;
                cb.SoVeDaDat++;
                return true;
                //Console.WriteLine("Hanh khach da ton tai.");
            }

            return false;
        }
    }


    public class DanhSachChuyenBay
    {
        public static ChuyenBay head;
        public static ChuyenBay tail;
        public static int size;
        public DanhSachChuyenBay()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public static int length()
        {
            return size;
        }

        public static bool isEmpty()
        {
            return size == 0;
        }
        public static void ThemCB(ChuyenBay cb)
        {
            ChuyenBay newest = cb;
            if (isEmpty())
                head = newest;
            else
                tail.next = newest;
            tail = newest;
            size = size + 1;
        }
        public static ChuyenBay TimMaCB(string MaCB)
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                if (tmp.MaCB == MaCB)
                    return tmp;
                tmp = tmp.next;
            }
            return null;
        }
        
        public static bool HuyChuyen(ChuyenBay temp)
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                if (tmp.MaCB == temp.MaCB)
                {
                    if (temp.TrangThai == Define.CONVE || temp.TrangThai == Define.HETVE)
                    {
                        temp.TrangThai = Define.HUYCHUYEN;
                        size--;
                        return true;
                    }
                }    
                
                tmp = tmp.next;
            }
            return false;
        }

        public static bool ChinhNgayGio(ChuyenBay temp, DateTime a)
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                if (tmp.MaCB == temp.MaCB)
                {
                    
                        temp.NgayGioKhoiHanh = a;
                        return true;
                    
                }

                tmp = tmp.next;
            }
            return false;
        }
        public static void DatVe(string MaCB,int viTri, string CMND)
        {
            
            
                ChuyenBay tmp = head;
                while (tmp != null)
                {
                    if (tmp.MaCB == MaCB && tmp.SoVe > viTri)
                    {
                        tmp.DanhSachVe[viTri] = CMND;
                        tmp.SoVeDaDat++;
                    }
                    tmp = tmp.next;
                }
              
            
        }
        public static bool DaDuKhach(string MaCB)
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                if (tmp.MaCB == MaCB)
                {
                    if (tmp.SoVeDaDat < tmp.SoVe) return false;
                    else
                    {
                        tmp.TrangThai = Define.HETVE;
                        return true;
                    }               
                }    
                tmp = tmp.next;
            }
            return false;
        }
        public static int SoVeChuaBan(string MaCB)
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                if (tmp.MaCB == MaCB)
                {
                    break;
                }
                tmp = tmp.next;
            }
            return tmp.SoVe - tmp.SoVeDaDat;
        }
        public static void checkHoanTat(ChuyenBay temp)
        {
            if (temp.TrangThai == Define.HETVE || temp.TrangThai == Define.CONVE)
            {
                if (temp.NgayGioKhoiHanh <= DateTime.Now)
                {
                    temp.TrangThai = Define.HOANTAT;
                    DanhSachMayBay.dsMayBay[DanhSachMayBay.TimMayBay(temp.SoHieuMB)].SoChuyenBay++;
                }
            }
        }
        public static void checkHoanTatAll()
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                checkHoanTat(tmp);
                tmp = tmp.next;
            }
        }
        public static void checkHoanTat2(ChuyenBay temp)
        {
            if (temp.TrangThai == Define.HOANTAT)
            {
                DanhSachMayBay.dsMayBay[DanhSachMayBay.TimMayBay(temp.SoHieuMB)].SoChuyenBay++;
            }
        }
        public static void checkHoanTatAll2()
        {
            ChuyenBay tmp = head;
            while (tmp != null)
            {
                checkHoanTat2(tmp);
                tmp = tmp.next;
            }
        }
        public static void LuuDanhSachChuyenBayVaoFile(ChuyenBay head)
        {
            using (StreamWriter writer = new StreamWriter("..\\data_CB.txt"))
            {
                ChuyenBay temp = head;
                while (temp != null)
                {
                    string IDCB = temp.MaCB.Trim();
                    string Time = temp.NgayGioKhoiHanh.ToString("dd/MM/yyyy hh:mm:ss tt");
                    string Desti = temp.SanBayDen.Trim();
                    string Type = temp.TrangThai.ToString().Trim();
                    string IDMB = temp.SoHieuMB.Trim();
                    string line = IDCB + ";" + Time + ";" + Desti + ";" + Type + ";" + IDMB;
                    writer.WriteLine(line);
                    temp = temp.next;
                }
            }
        }
        public static void LuuDanhSachDatVeChuyenBayVaoFile(ChuyenBay head)
        {
            using (StreamWriter writer = new StreamWriter("..\\data_DSV.txt"))
            {
                ChuyenBay temp = head;
                while (temp != null)
                {
                    string IDCB = temp.MaCB.Trim();
                    string line = IDCB + ";";
                    for (int i = 0; i < temp.DanhSachVe.Count; i++)
                    {
                        if (temp.DanhSachVe[i] != "") line += i.ToString() + ";" + temp.DanhSachVe[i] + ";";
                    }
                   
                    writer.WriteLine(line);
                    temp = temp.next;
                }
            }
        }
    }
}
