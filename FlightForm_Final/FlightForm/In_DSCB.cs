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
    public partial class In_DSCB : Form
    {
        public string Ngay { get; set; }
        public string Thang { get; set; }
        public string Nam { get; set; }
        public string Place { get; set; }
        public ChuyenBay cb;
        public In_DSCB()
        {
            InitializeComponent();
        }
        void CreateColumnFordataGridView6()
        {
            var col_IDCB = new DataGridViewTextBoxColumn();
            var col_SVCT = new DataGridViewTextBoxColumn();

            col_IDCB.HeaderText = "Mã Chuyến Bay";
            col_SVCT.HeaderText = "Số Vé Còn Trống";

            col_IDCB.DataPropertyName = "IDCB";
            col_SVCT.DataPropertyName = "SoVeConTrong";

            col_IDCB.Width = 300;
            col_SVCT.Width = 300;

            dtgvDSCB.Columns.AddRange(new DataGridViewColumn[] { col_IDCB, col_SVCT });
        }
        void LoadDSCB()
        {
            dtgvDSCB.Rows.Clear();
            lbDate.Text = Ngay + "/" + Thang + "/" + Nam;
            lbPlace.Text = Place;
            string date = Ngay + "/" + Thang + "/" + Nam;
            string place = Place;
            ChuyenBay tmp = DanhSachChuyenBay.head;
            while (tmp != null)
            {
                if (tmp.NgayGioKhoiHanh.Date.ToString("dd/MM/yyyy") == date && tmp.SanBayDen == place)
                {
                    int SVCT = 0;
                    for (int i = 0; i <tmp.SoVe;i++)
                    {
                        if (tmp.DanhSachVe[i] == "")
                            SVCT++;
                    }    
                    dtgvDSCB.Rows.Add(tmp.MaCB,SVCT);
                }
                tmp = tmp.next;
            }
            
        }
        private void In_DSCB_Load(object sender, EventArgs e)
        {
            CreateColumnFordataGridView6();
            LoadDSCB();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
