using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

        }
        #region Method MB
        int PointerMB;
        void CreateColumnFordataGridView1()
        {
            var col_IDMB = new DataGridViewTextBoxColumn();
            var col_Type = new DataGridViewTextBoxColumn();
            var col_Seat = new DataGridViewTextBoxColumn();
            var col_Flight = new DataGridViewTextBoxColumn();

            col_IDMB.HeaderText = "Số hiệu máy bay";
            col_Type.HeaderText = "Loại Máy bay";
            col_Seat.HeaderText = "Số chỗ ngồi";
            col_Flight.HeaderText = "Số chuyến bay";

            col_Type.DataPropertyName = "LoaiMB";
            col_IDMB.DataPropertyName = "SoHieuMB";
            col_Seat.DataPropertyName = "SoCho";
            col_Flight.DataPropertyName = "SoChuyenBay";

            col_IDMB.Width = 200;
            col_Type.Width = 200;
            col_Seat.Width = 200;
            col_Flight.Width = 200;

            dtgvMayBay.Columns.AddRange(new DataGridViewColumn[] { col_Type, col_IDMB, col_Seat, col_Flight });
        }
        void LoadMB()
        {
            DanhSachMayBay.DocFile();
            dtgvMayBay.DataSource = DanhSachMayBay.dsMayBay;
        }
        #endregion
        #region Method CB
        public int PointerCB;
        void CreateColumnFordataGridView2()
        {
            var col_IDCB = new DataGridViewTextBoxColumn();
            var col_Time = new DataGridViewTextBoxColumn();
            var col_Place = new DataGridViewTextBoxColumn();
            var col_State = new DataGridViewTextBoxColumn();
            var col_IDMB = new DataGridViewTextBoxColumn();

            col_IDCB.HeaderText = "Mã CB";
            col_Time.HeaderText = "Thời gian xuất phát";
            col_Place.HeaderText = "Sân bay đến";
            col_State.HeaderText = "Trạng thái";
            col_IDMB.HeaderText = "Số hiệu máy bay";

            col_IDCB.DataPropertyName = "MaCB";
            col_Time.DataPropertyName = "NgayGioKhoiHanh";
            col_Place.DataPropertyName = "SanBayDen";
            col_State.DataPropertyName = "TrangThai";
            col_IDMB.DataPropertyName = "SoHieuMB";

            col_IDCB.Width = 150;
            col_Time.Width = 300;
            col_Place.Width = 150;
            col_State.Width = 150;
            col_IDMB.Width = 150;

            dtgvChuyenBay.Columns.AddRange(new DataGridViewColumn[] { col_IDCB, col_Time, col_Place, col_State, col_IDMB });
        }
        void LoadCB()
        {
            dtgvChuyenBay.Rows.Clear();
            string path = "..\\data_CB.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 5)
                    {
                        string MaCB = arr[0].Trim();
                        DateTime Time = DateTime.ParseExact(arr[1].Trim(), "dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                        string time = Time.ToString("dd/MM/yyyy hh:mm:ss tt");
                        string Desti = arr[2].Trim();
                        string Type = arr[3].Trim();
                        int type = int.Parse(arr[3].Trim());
                        if (Time <= DateTime.Now && type != Define.HUYCHUYEN)
                        {
                            Type = Define.Hoantat;//3
                            type = Define.HOANTAT;
                        }
                        string IDMB = arr[4].Trim();
                        dtgvChuyenBay.Rows.Add(MaCB, time, Desti, Type, IDMB);
                        ChuyenBay cb = new ChuyenBay(MaCB, Time, Desti, type, IDMB);
                        if (DanhSachChuyenBay.TimMaCB(MaCB) == null)
                        {
                            DanhSachChuyenBay.ThemCB(cb);
                            DanhSachChuyenBay.checkHoanTat2(cb);
                        }
                    }
                    line = sr.ReadLine();
                }
                DanhSachMayBay.LuuDanhSachMayBayVaoFile();
                dtgvMayBay.Update();
                dtgvMayBay.Refresh();
                sr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        void LoadDSV()
        {
            string path = "..\\data_DSV.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length > 1)
                    {
                        ChuyenBay cb = DanhSachChuyenBay.TimMaCB(arr[0].Trim());
                        for (int i = 1; i < arr.Length - 1; i += 2)
                        {
                            string vitri = arr[i].Trim();
                            int viTri = int.Parse(vitri);
                            cb.DanhSachVe[viTri] = arr[i + 1].Trim();
                        }
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

        private void dtgvChuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dtgvChuyenBay.Rows[e.RowIndex];

            if (row.Cells[0].Value == null) return;
            PointerCB = e.RowIndex;
            string IDCB = row.Cells[0].Value.ToString();
            txtIDCB.Clear();
            txtIDCB.Text = IDCB;

            //string Time = row.Cells[1].Value.ToString();
            //txtPlace.Clear();
            //txtPlace.Text = Time;

            string Desti = row.Cells[2].Value.ToString();
            txtPlace.Clear();
            txtPlace.Text = Desti;

            string IDMB = row.Cells[4].Value.ToString();
            txtIDMB.Clear();
            txtIDMB.Text = IDMB;

        }
        #endregion
        #region Method HK

        int PointerHK;
        void CreateColumnFordataGridView3()
        {
            var col_CMND = new DataGridViewTextBoxColumn();
            var col_Ho = new DataGridViewTextBoxColumn();
            var col_Ten = new DataGridViewTextBoxColumn();
            var col_Phai = new DataGridViewTextBoxColumn();

            col_CMND.HeaderText = "CMND";
            col_Ho.HeaderText = "Họ và tên đệm";
            col_Ten.HeaderText = "Tên";
            col_Phai.HeaderText = "Giới tính";

            col_CMND.DataPropertyName = "CMND";
            col_Ho.DataPropertyName = "Ho";
            col_Ten.DataPropertyName = "Ten";
            col_Phai.DataPropertyName = "Phai";

            col_CMND.Width = 200;
            col_Ho.Width = 250;
            col_Ten.Width = 200;
            col_Phai.Width = 200;

            dtgvHanhKhach.Columns.AddRange(new DataGridViewColumn[] { col_CMND, col_Ho, col_Ten, col_Phai });
        }
        /*void LoadHK()
        {
           DanhSachHanhKhach.DocFileHK();
            dtgvHanhKhach.DataSource = DanhSachHanhKhach.HienThiHK;
        }*/
        void LoadHK()
        {
            dtgvHanhKhach.Rows.Clear();
            string path = "..\\data_HK.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        string CMND = arr[0].Trim();
                        string Ho = arr[1].Trim();
                        string Ten = arr[2].Trim();
                        string Phai = arr[3].Trim();
                        dtgvHanhKhach.Rows.Add(CMND, Ho, Ten, Phai);
                        HanhKhach hk = new HanhKhach(CMND, Ho, Ten, Phai);
                        DanhSachHanhKhach.ThemHK(hk);
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


        #endregion

        private void FrmMain_Load(object sender, EventArgs e)
        {

            timer.Start();
            CreateColumnFordataGridView1();
            LoadMB();
            CreateColumnFordataGridView2();
            LoadCB();
            CreateColumnFordataGridView3();
            LoadHK();
            LoadDSV();
        }

        #region Button MB

        private void dtgvMayBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dtgvMayBay.Rows[e.RowIndex];

            if (row.Cells[0].Value == null) return;
            PointerMB = e.RowIndex;
            string ID_MB = row.Cells[0].Value.ToString();
            txtID.Clear();
            txtID.Text = ID_MB;

            string Type_MB = row.Cells[1].Value.ToString();
            txtLoai.Clear();
            txtLoai.Text = Type_MB;

            string Seat_MB = row.Cells[2].Value.ToString();
            txtSocho.Clear();
            txtSocho.Text = Seat_MB;
            //MessageBox.Show(e.RowIndex.ToString());
        }
        private void ThemMB_Click(object sender, EventArgs e)
        {
            string ID_MB = txtID.Text;
            string Type_MB = txtLoai.Text;
            int Seat_MB = Int32.Parse(txtSocho.Text);
            if (DanhSachMayBay.TimMayBay(ID_MB) != -1)
            {
                MessageBox.Show("Số hiệu máy bay đã tồn tại");
                txtID.Clear();
                txtID.Focus();
                return;
            }
            else if (Seat_MB < Define.MIN_SOCHO)
            {
                MessageBox.Show("Số chỗ phải lớn hơn 20");
                txtSocho.Clear();
                txtSocho.Focus();
                return;
            }
            int ThemThanhCong = DanhSachMayBay.ThemMayBay(ID_MB, Type_MB, Seat_MB);
            DanhSachMayBay.LuuDanhSachMayBayVaoFile();
            dtgvMayBay.Update();
            dtgvMayBay.Refresh();

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ID_MB = txtID.Text;
            int viTri = DanhSachMayBay.TimMayBay(ID_MB);
            if (viTri != -1)
            {
                DanhSachMayBay.XoaMayBay(viTri);
                DanhSachMayBay.LuuDanhSachMayBayVaoFile();
                dtgvMayBay.Update();
                dtgvMayBay.Refresh();
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
        private void btnHieuchinh_Click(object sender, EventArgs e)
        {
            string ID_MB = txtID.Text;
            string Type_MB = txtLoai.Text;
            int Seat_MB = Int32.Parse(txtSocho.Text);
            DataGridViewRow row = dtgvMayBay.Rows[PointerMB];
            int SoChuyenBay_MB = int.Parse(row.Cells[3].Value.ToString());
            if (DanhSachMayBay.TimMayBay(ID_MB) != -1 && PointerMB != DanhSachMayBay.TimMayBay(ID_MB))
            {
                MessageBox.Show("Số hiệu máy bay đã tồn tại");
                txtID.Clear();
                txtID.Focus();
                return;
            }
            else if (Seat_MB < Define.MIN_SOCHO)
            {
                MessageBox.Show("Số chỗ phải lớn hơn 20");
                txtSocho.Clear();
                txtSocho.Focus();
                return;
            }
            MayBay mb = new MayBay(ID_MB, Type_MB, Seat_MB, SoChuyenBay_MB);
            DanhSachMayBay.HieuChinh(PointerMB, mb);
            DanhSachMayBay.LuuDanhSachMayBayVaoFile();
            dtgvMayBay.Update();
            dtgvMayBay.Refresh();
        }
        //int danh sách
        private void button1_Click_1(object sender, EventArgs e)
        {
            ThongkeMB frm2 = new ThongkeMB();
            frm2.ShowDialog();

        }
        #endregion
        #region Button CB
        private void timer_Tick(object sender, EventArgs e)
        {
            //LoadCB();
            //LoadHK();
            //DanhSachMayBay.LuuDanhSachMayBayVaoFile();
        }
        private void ThemCB_Click(object sender, EventArgs e)
        {
            if(txtIDCB.Text == "" || txtGio.Text == "" || txtPhut.Text == ""||txtNgay.Text == ""||txtThang.Text == ""||txtNam.Text == ""||txtPlace.Text == "" ||txtIDMB.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin chuyến bay");
            }
            else
            {
                int Phut = int.Parse(txtPhut.Text);
                int Gio = int.Parse(txtGio.Text);
                int Ngay = int.Parse(txtNgay.Text);
                int Thang = int.Parse(txtThang.Text);
                int Nam = int.Parse(txtNam.Text);
                DateTime NgayGioKhoiHanh = new DateTime(Nam, Thang, Ngay, Gio, Phut, 0);
                string date = NgayGioKhoiHanh.ToString("dd/MM/yyyy hh:mm:ss tt");
                string IDCB = txtIDCB.Text;
                string Place = txtPlace.Text;
                string IDMB = txtIDMB.Text;
                if (DanhSachChuyenBay.TimMaCB(IDCB) != null || NgayGioKhoiHanh <= DateTime.Now)
                {
                    MessageBox.Show("Không tạo được chuyến bay do trùng ID hoặc ngày khởi hành sai");
                    txtIDCB.Clear();
                    txtNgay.Clear();
                    txtThang.Clear();
                    txtNam.Clear();
                    txtIDCB.Focus();
                }
                else
                {
                    ChuyenBay cb = new ChuyenBay(IDCB, NgayGioKhoiHanh, Place, IDMB);
                    DanhSachChuyenBay.ThemCB(cb);
                    dtgvChuyenBay.Rows.Add(IDCB, date, Place, 1, IDMB);
                    DanhSachChuyenBay.LuuDanhSachChuyenBayVaoFile(DanhSachChuyenBay.head);
                }
            }
            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (txtIDCB.Text == "" )
            {
                MessageBox.Show("Bạn chưa nhập thông tin chuyến bay muốn hủy");
            }
            else
            {
                string IDCB = txtIDCB.Text;
                ChuyenBay cb = DanhSachChuyenBay.TimMaCB(IDCB);
                if (DanhSachChuyenBay.HuyChuyen(cb) == true)
                {
                    for (int i = 0; i < dtgvChuyenBay.Rows.Count; i++)
                    {
                        if (dtgvChuyenBay.Rows[i].Cells[0].Value.ToString().CompareTo(IDCB) == 0)
                        {
                            dtgvChuyenBay.Rows[i].Cells[3].Value = 0;
                            MessageBox.Show("Đã Hủy Chuyến");
                            break;
                        }
                    }
                    DanhSachChuyenBay.LuuDanhSachChuyenBayVaoFile(DanhSachChuyenBay.head);
                }
                else
                {
                    MessageBox.Show("Chuyến Bay Đã Hoàn Tất");
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtIDCB.Text == "" || txtIDMB.Text == "" || txtGio.Text == "" || txtPhut.Text == "" || txtNgay.Text == "" || txtThang.Text == "" || txtNam.Text == "" || txtPlace.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin chuyến bay");
            }
            else
            {
                string IDCB = txtIDCB.Text;
                int Gio = int.Parse(txtGio.Text);
                int Phut = int.Parse(txtPhut.Text);
                int Ngay = int.Parse(txtNgay.Text);
                int Thang = int.Parse(txtThang.Text);
                int Nam = int.Parse(txtNam.Text);
                DateTime time = new DateTime(Nam, Thang, Ngay, Gio, Phut, 0);
                string Time = time.ToString("dd/MM/yyyy hh:mm:ss tt");
                ChuyenBay cb = DanhSachChuyenBay.TimMaCB(IDCB);
                if (cb != null && time > DateTime.Now)
                {
                    DanhSachChuyenBay.ChinhNgayGio(cb, time);
                    for (int i = 0; i < dtgvChuyenBay.Rows.Count; i++)
                    {
                        if (dtgvChuyenBay.Rows[i].Cells[0].Value.ToString().CompareTo(IDCB) == 0)
                        {
                            dtgvChuyenBay.Rows[i].Cells[1].Value = Time;
                            MessageBox.Show("Đã Sửa Đổi");
                            break;
                        }
                    }
                    DanhSachChuyenBay.LuuDanhSachChuyenBayVaoFile(DanhSachChuyenBay.head);

                }
                else
                {
                    MessageBox.Show("Lỗi");
                }
            }
            
            /*txtNgay.Clear();
            txtThang.Clear();
            txtNam.Clear();
            txtPlace.Clear();
            txtGio.Clear();
            txtPhut.Clear();*/
        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            if (dtgvChuyenBay.Rows[PointerCB].Cells[3].Value.ToString() == Define.Hoantat)
            {
                {
                    MessageBox.Show("Chuyến Bay Đã Hoàn Tất");
                }
            }
            else if (dtgvChuyenBay.Rows[PointerCB].Cells[3].Value.ToString() == Define.Huychuyen)
            {
                {
                    MessageBox.Show("Chuyến Bay Đã bị hủy");
                }
            }
            else
            {

                DatVe frm = new DatVe();
                frm.soHieuCB = txtIDCB.Text;
                frm.ShowDialog();
                LoadHK();
                LoadCB();
            }  
        }
        private void themKH_StyleChanged(object sender, EventArgs e)
        {

        }

        private void btnInDSHK_Click(object sender, EventArgs e)
        {
            if (txtIDCB.Text == "")
            {
                MessageBox.Show("Nhập mã chuyến bay muốn in danh sách vé");
            }
            else
            {
                In_DSHK frm3 = new In_DSHK();
                frm3.IDCB = txtIDCB.Text;
                frm3.ShowDialog();
            }
           
        }

        private void txtIDCB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInDSCB_Click(object sender, EventArgs e)
        {
            In_DSCB frm4 = new In_DSCB();
            frm4.Ngay = txtNgay.Text;
            frm4.Thang = txtThang.Text;
            frm4.Nam = txtNam.Text;
            frm4.Place = txtPlace.Text;
            frm4.ShowDialog();
            /*txtNgay.Clear();
            txtThang.Clear();
            txtNam.Clear();
            txtPlace.Clear();*/
        }
        #endregion
        #region Button HK

        private void dtgvHanhKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dtgvHanhKhach.Rows[e.RowIndex];

            if (row.Cells[0].Value == null) return;
            PointerHK = e.RowIndex;
            string CMND = row.Cells[0].Value.ToString();


            string Ho = row.Cells[1].Value.ToString();


            string Ten = row.Cells[2].Value.ToString();


            string Phai = row.Cells[3].Value.ToString();

        }
        #endregion

        private void dtgvChuyenBay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void themKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if(themKH.SelectedIndex == 2)
            {
                CreateColumnFordataGridView3();
                LoadHK();
                tabPage3.Update();
                tabPage3.Refresh();
            }
           *//* else if (themKH.SelectedIndex == 1)
            {
                tabPage2.Update();
            }
            else if (themKH.SelectedIndex == 2)
            {
                
                CreateColumnFordataGridView3();
                LoadHK();
                tabPage3.Update();
                tabPage3.Refresh();
            }*/
        }

        





        //private void ClickHK(object sender, EventArgs e)
        //{
        //    LoadHK();
        //}
    }
}
