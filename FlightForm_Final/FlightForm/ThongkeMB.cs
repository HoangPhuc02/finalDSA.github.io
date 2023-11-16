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
    public partial class ThongkeMB : Form
    {
        public ThongkeMB()
        {
            InitializeComponent();
        }
        void CreateColumnFordataGridView4()
        {
            var col_IDMB = new DataGridViewTextBoxColumn();
            var col_LuotTH = new DataGridViewTextBoxColumn();

            col_IDMB.HeaderText = "Số hiệu máy bay";
            col_LuotTH.HeaderText = "Số lượt thực hiện chuyến bay";

            col_IDMB.DataPropertyName = "SoHieuMB";
            col_LuotTH.DataPropertyName = "SoChuyenBay";

            col_IDMB.Width = 300;
            col_LuotTH.Width = 300;

            dtgvThongKe.Columns.AddRange(new DataGridViewColumn[] { col_IDMB, col_LuotTH });
        }
        void LoadTK()
        {
            string path = "..\\data_MB.txt";
            try
            {
                StreamReader sr = new StreamReader(path);
                string line = sr.ReadLine();
                List<string[]> data = new List<string[]>(); // Dùng List để lưu dữ liệu từ file
                while (line != null)
                {
                    string[] arr = line.Split(';');
                    if (arr.Length == 4)
                    {
                        string IDMB = arr[0].Trim();
                        string SoCB = arr[3].Trim();
                        data.Add(new string[] { IDMB, SoCB }); // Thêm dữ liệu vào List
                    }
                    line = sr.ReadLine();
                }
                sr.Close();
                data.Sort((x, y) => y[1].CompareTo(x[1]));
                dtgvThongKe.Rows.Clear();
                foreach (string[] rowData in data)
                {
                    dtgvThongKe.Rows.Add(rowData);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ThongkeMB_Load(object sender, EventArgs e)
        {
            CreateColumnFordataGridView4();
            LoadTK();
        }

        private void dtgvThongKe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
