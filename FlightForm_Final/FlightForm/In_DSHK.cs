using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightForm
{
    public partial class In_DSHK : Form
    {
        public string IDCB { get; set; }
        public ChuyenBay cb;
        public In_DSHK()
        {
            InitializeComponent();
        }
        void CreateColumnFordataGridView()
        {
            var col_STT = new DataGridViewTextBoxColumn();
            var col_SoVe = new DataGridViewTextBoxColumn();
            var col_CMND = new DataGridViewTextBoxColumn();
            var col_Ten = new DataGridViewTextBoxColumn();
            var col_Phai = new DataGridViewTextBoxColumn();

            col_STT.HeaderText = "Số Thứ Tự";
            col_SoVe.HeaderText = "Số Vé";
            col_CMND.HeaderText = "Số CMND";
            col_Ten.HeaderText = "Họ Tên";
            col_Phai.HeaderText = "Phái";

            col_STT.Width = 100;
            col_SoVe.Width = 100;
            col_CMND.Width = 200;
            col_Ten.Width = 300;
            col_Phai.Width = 100;

            dtgvDSHK.Columns.AddRange(new DataGridViewColumn[] { col_STT, col_SoVe, col_CMND, col_Ten, col_Phai });
        }
        void LoadDSHK(ChuyenBay cb)
        {

            int count = 1;
            for (int i = 0; i < cb.SoVe; i++)
            {
                if (cb.DanhSachVe[i] != "")
                {
                    string STT = count.ToString();
                    string SoVe = (i + 1).ToString();
                    string CMND = cb.DanhSachVe[i];
                    HanhKhach hk = DanhSachHanhKhach.search(CMND);
                    string HoTen = hk.Ho.Trim() + " " + hk.Ten.Trim();
                    string Phai = hk.Phai.Trim();
                    dtgvDSHK.Rows.Add(STT, SoVe, CMND, HoTen, Phai);
                    count += 1;
                }
            }
        }

        private void DSHK_Load(object sender, EventArgs e)
        {
            ChuyenBay cb = DanhSachChuyenBay.TimMaCB(IDCB);
            CreateColumnFordataGridView();
            LoadDSHK(cb);
            lblChuyenBay.Text = "DANH SÁCH HÀNH KHÁCH THUỘC CHUYẾN BAY " + IDCB;
            DateTime myDate = cb.NgayGioKhoiHanh;
            lblThoiGian.Text = "Ngày giờ khởi hành:" + myDate.ToString("dd/MM/yyyy HH:mm");
            lblNoiDen.Text = "Nơi đến: " + cb.SanBayDen;
        }
    }
}
