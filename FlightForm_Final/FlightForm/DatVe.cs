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
    public partial class DatVe : Form
    {

        public string soHieuCB {get;set;}
        public bool NhapThongTin = false;

        private List<Button> buttons = new List<Button>();
        public ChuyenBay cb;
        public DatVe()
        {
            InitializeComponent();
        }

        private void DatVe_Load(object sender, EventArgs e)
        {
            txtCMND.Enabled = false;
            txtHo.Enabled = false;
            txtTen.Enabled = false;
            cbPhai.Enabled = false;
            txtViTri.Enabled = false;
            btnHieuChinh.Enabled = false;
            cb = DanhSachChuyenBay.TimMaCB(soHieuCB);
            int soVe = cb.SoVe;
            int X = 20;
            int Y = 1;
            int count = 1;
            int i = 0;
            while(count <= soVe)
            {
                Button btn = new Button();
                btn.Size = new Size(35, 35);
                btn.Name = count.ToString();
                btn.Text = count.ToString();
                btn.Click += new EventHandler(this.button_click);
                btn.BackColor = Color.WhiteSmoke;
                btn.Location = new Point(40 * (i + 1), (40 * Y));
                buttons.Add(btn);
                Controls.Add(btn);
                count++;
                i++;
                if (i == X)
                {
                    i = 0;
                    Y++;
                }
            }    
            for(int index = 0; index < cb.DanhSachVe.Count; index++)
            {
                if(cb.DanhSachVe[index] != "")
                {
                    buttons[index].BackColor = Color.Red;
                }    
            }    
         
        }
        void button_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtCMND.Clear();
            txtHo.Clear();
            txtTen.Clear();
            cbPhai.Text = ""; 
            txtViTri.Clear();
            txtViTri.Text = btn.Text;
            if (btn.BackColor == Color.Red)
            {
                txtCMND.Enabled = false;
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                cbPhai.Enabled = true;          
                btnHieuChinh.Enabled = true;
                txtCMND.Text = cb.DanhSachVe[int.Parse(txtViTri.Text) - 1];
                HanhKhach hk = DanhSachHanhKhach.search(txtCMND.Text);
                txtCMND.Text = hk.CMND;
                txtHo.Text = hk.Ho;
                txtTen.Text = hk.Ten;
                cbPhai.Text = hk.Phai;
            }   
            else if(btn.BackColor == Color.WhiteSmoke)
            {
                txtCMND.Enabled = true;
                txtHo.Enabled = false;
                txtTen.Enabled = false;
                cbPhai.Enabled = false;
                btnHieuChinh.Enabled = false;
            }    
            txtViTri.Text = btn.Text;
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string CMND = txtCMND.Text;
            int vitri = int.Parse(txtViTri.Text);
            if (cb.DanhSachVe.Contains(CMND))
            {
                string viTri = null;
                for(int i = 0;i<cb.DanhSachVe.Count;i++)
                {
                    if (cb.DanhSachVe[i] == CMND)
                    {
                        viTri = (i+1).ToString();
                        break;
                    }
                }    
                MessageBox.Show("Bạn đã đặt vé chuyến này ở ghế thứ " + viTri);
            }
            else
            {
                if (NhapThongTin == true)
                {
                    string Ho = txtHo.Text;
                    string Ten = txtTen.Text;
                    string Phai = cbPhai.Text;
                    HanhKhach temp = new HanhKhach(CMND, Ho, Ten, Phai);
                    DanhSachHanhKhach.ThemHK(temp);
                    DanhSachHanhKhach.LuuDanhSachHanhKhachVaoFile(DanhSachHanhKhach.root);
                    NhapThongTin = false;
                }
                if (DanhSachHanhKhach.isItExsit(DanhSachHanhKhach.root, CMND) == false)
                {
                    NhapThongTin = true;
                    
                }
                else
                {
                    txtCMND.Enabled = false;
                    btnHieuChinh.Enabled = true;
                    HanhKhach hk = DanhSachHanhKhach.search(CMND);
                    txtCMND.Text = hk.CMND;
                    txtHo.Text = hk.Ho;
                    txtTen.Text = hk.Ten;
                    cbPhai.Text = hk.Phai;
                    buttons[vitri - 1].BackColor = Color.Red;
                    DanhSachChuyenBay.DatVe(soHieuCB, vitri-1, CMND);
                }
                txtHo.Enabled = true;
                txtTen.Enabled = true;
                cbPhai.Enabled = true;
                txtCMND.Enabled = false;
            }
            //if(ChuyenBay.DatVe())
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {

            /* System.Threading.Thread t = new System.Threading.Thread(
                new System.Threading.ThreadStart(() => {
                    FrmMain frm = new FrmMain();
                    frm.ShowDialog();
                }));
             t.Start();*/
            /* FrmMain frm = new FrmMain();
             this.Hide();
             frm.ShowDialog();*/
            
            ChuyenBay tmp = DanhSachChuyenBay.head;
            while (tmp != null)
            {
                if (tmp.MaCB == soHieuCB)
                {
                    int isItfull = 1;
                    int i = 0;
                    while(i < tmp.SoVe)
                    {
                        if (tmp.DanhSachVe[i] == "")
                        {
                            isItfull = 0;
                            break;
                        }
                        i++;
                    }
                    if (isItfull == 1) tmp.TrangThai = Define.HETVE;
                    break;
                }
                tmp = tmp.next;
            }
            DanhSachChuyenBay.LuuDanhSachDatVeChuyenBayVaoFile(DanhSachChuyenBay.head);
            DanhSachChuyenBay.LuuDanhSachChuyenBayVaoFile(DanhSachChuyenBay.head);
            this.Close();
        }

        private void btnHieuChinh_Click(object sender, EventArgs e)
        {
            string CMND = txtCMND.Text;
            HanhKhach hkcu = DanhSachHanhKhach.search(CMND);
            //DanhSachHanhKhach.delete(CMND);
            string Ho = txtHo.Text;
            string Ten = txtTen.Text;
            string Phai = cbPhai.Text;
            HanhKhach temp = new HanhKhach(CMND, Ho, Ten, Phai);
            DanhSachHanhKhach.EditDataHK(hkcu,temp);
            DanhSachHanhKhach.LuuDanhSachHanhKhachVaoFile(DanhSachHanhKhach.root);
            MessageBox.Show("Đã Hiệu Chỉnh");
            //btnHieuChinh.Enabled = false;
        }
    }
}
