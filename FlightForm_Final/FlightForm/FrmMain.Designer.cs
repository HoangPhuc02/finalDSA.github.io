namespace FlightForm
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.themKH = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLoai = new System.Windows.Forms.TextBox();
            this.btnHieuchinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSocho = new System.Windows.Forms.TextBox();
            this.btnThemMB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvMayBay = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnInDSCB = new System.Windows.Forms.Button();
            this.txtIDMB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInDSHK = new System.Windows.Forms.Button();
            this.ThemCB = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtPhut = new System.Windows.Forms.TextBox();
            this.txtGio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDCB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dtgvChuyenBay = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgvHanhKhach = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.themKH.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMayBay)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanhKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // themKH
            // 
            this.themKH.AllowDrop = true;
            this.themKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.themKH.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.themKH.CausesValidation = false;
            this.themKH.Controls.Add(this.tabPage1);
            this.themKH.Controls.Add(this.tabPage2);
            this.themKH.Controls.Add(this.tabPage3);
            this.themKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themKH.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.themKH.ItemSize = new System.Drawing.Size(400, 50);
            this.themKH.Location = new System.Drawing.Point(0, 0);
            this.themKH.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.themKH.Multiline = true;
            this.themKH.Name = "themKH";
            this.themKH.Padding = new System.Drawing.Point(0, 0);
            this.themKH.SelectedIndex = 0;
            this.themKH.Size = new System.Drawing.Size(1881, 738);
            this.themKH.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.themKH.TabIndex = 5;
            this.themKH.SelectedIndexChanged += new System.EventHandler(this.themKH_SelectedIndexChanged);
            this.themKH.StyleChanged += new System.EventHandler(this.themKH_StyleChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dtgvMayBay);
            this.tabPage1.Controls.Add(this.btnThongKe);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage1.Size = new System.Drawing.Size(1873, 680);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý máy bay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.txtLoai);
            this.panel1.Controls.Add(this.btnHieuchinh);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSocho);
            this.panel1.Controls.Add(this.btnThemMB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1169, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 409);
            this.panel1.TabIndex = 14;
            // 
            // txtLoai
            // 
            this.txtLoai.Location = new System.Drawing.Point(237, 42);
            this.txtLoai.Multiline = true;
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(328, 54);
            this.txtLoai.TabIndex = 12;
            // 
            // btnHieuchinh
            // 
            this.btnHieuchinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHieuchinh.BackColor = System.Drawing.Color.Yellow;
            this.btnHieuchinh.Location = new System.Drawing.Point(418, 272);
            this.btnHieuchinh.Name = "btnHieuchinh";
            this.btnHieuchinh.Size = new System.Drawing.Size(164, 72);
            this.btnHieuchinh.TabIndex = 15;
            this.btnHieuchinh.Text = "Hiệu chỉnh";
            this.btnHieuchinh.UseVisualStyleBackColor = false;
            this.btnHieuchinh.Click += new System.EventHandler(this.btnHieuchinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.BackColor = System.Drawing.Color.Yellow;
            this.btnXoa.Location = new System.Drawing.Point(237, 272);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(158, 72);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(237, 115);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(328, 54);
            this.txtID.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Loại Máy Bay";
            // 
            // txtSocho
            // 
            this.txtSocho.Location = new System.Drawing.Point(237, 193);
            this.txtSocho.Multiline = true;
            this.txtSocho.Name = "txtSocho";
            this.txtSocho.Size = new System.Drawing.Size(135, 54);
            this.txtSocho.TabIndex = 13;
            // 
            // btnThemMB
            // 
            this.btnThemMB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMB.BackColor = System.Drawing.Color.Yellow;
            this.btnThemMB.Location = new System.Drawing.Point(58, 272);
            this.btnThemMB.Name = "btnThemMB";
            this.btnThemMB.Size = new System.Drawing.Size(158, 72);
            this.btnThemMB.TabIndex = 2;
            this.btnThemMB.Text = "Thêm";
            this.btnThemMB.UseVisualStyleBackColor = false;
            this.btnThemMB.Click += new System.EventHandler(this.ThemMB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Hiệu Máy Bay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số chỗ";
            // 
            // dtgvMayBay
            // 
            this.dtgvMayBay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvMayBay.BackgroundColor = System.Drawing.Color.White;
            this.dtgvMayBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMayBay.Location = new System.Drawing.Point(8, 96);
            this.dtgvMayBay.Name = "dtgvMayBay";
            this.dtgvMayBay.RowHeadersWidth = 51;
            this.dtgvMayBay.RowTemplate.Height = 24;
            this.dtgvMayBay.Size = new System.Drawing.Size(959, 581);
            this.dtgvMayBay.TabIndex = 3;
            this.dtgvMayBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMayBay_CellClick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongKe.BackColor = System.Drawing.Color.Yellow;
            this.btnThongKe.Location = new System.Drawing.Point(737, 6);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(242, 72);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "Thống kê máy bay";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách máy bay";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FloralWhite;
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dtgvChuyenBay);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1873, 680);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý chuyến bay";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.btnInDSCB);
            this.panel3.Controls.Add(this.txtIDMB);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.btnInDSHK);
            this.panel3.Controls.Add(this.ThemCB);
            this.panel3.Controls.Add(this.txtNam);
            this.panel3.Controls.Add(this.txtThang);
            this.panel3.Controls.Add(this.txtNgay);
            this.panel3.Controls.Add(this.txtPhut);
            this.panel3.Controls.Add(this.txtGio);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtPlace);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtIDCB);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnDatVe);
            this.panel3.Controls.Add(this.btnSua);
            this.panel3.Location = new System.Drawing.Point(1302, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(729, 571);
            this.panel3.TabIndex = 16;
            // 
            // btnInDSCB
            // 
            this.btnInDSCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSCB.BackColor = System.Drawing.Color.Yellow;
            this.btnInDSCB.Location = new System.Drawing.Point(240, 464);
            this.btnInDSCB.Name = "btnInDSCB";
            this.btnInDSCB.Size = new System.Drawing.Size(177, 72);
            this.btnInDSCB.TabIndex = 36;
            this.btnInDSCB.Text = "In DSCB";
            this.btnInDSCB.UseVisualStyleBackColor = false;
            this.btnInDSCB.Click += new System.EventHandler(this.btnInDSCB_Click);
            // 
            // txtIDMB
            // 
            this.txtIDMB.Location = new System.Drawing.Point(175, 256);
            this.txtIDMB.Multiline = true;
            this.txtIDMB.Name = "txtIDMB";
            this.txtIDMB.Size = new System.Drawing.Size(149, 51);
            this.txtIDMB.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "ID máy bay";
            // 
            // btnInDSHK
            // 
            this.btnInDSHK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInDSHK.BackColor = System.Drawing.Color.DarkOrange;
            this.btnInDSHK.Location = new System.Drawing.Point(452, 464);
            this.btnInDSHK.Name = "btnInDSHK";
            this.btnInDSHK.Size = new System.Drawing.Size(238, 73);
            this.btnInDSHK.TabIndex = 1;
            this.btnInDSHK.Text = "In DSHK";
            this.btnInDSHK.UseVisualStyleBackColor = false;
            this.btnInDSHK.Click += new System.EventHandler(this.btnInDSHK_Click);
            // 
            // ThemCB
            // 
            this.ThemCB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ThemCB.BackColor = System.Drawing.Color.DarkOrange;
            this.ThemCB.Location = new System.Drawing.Point(452, 362);
            this.ThemCB.Name = "ThemCB";
            this.ThemCB.Size = new System.Drawing.Size(238, 73);
            this.ThemCB.TabIndex = 2;
            this.ThemCB.Text = "Thêm chuyến bay";
            this.ThemCB.UseVisualStyleBackColor = false;
            this.ThemCB.Click += new System.EventHandler(this.ThemCB_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(559, 192);
            this.txtNam.Multiline = true;
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(115, 42);
            this.txtNam.TabIndex = 33;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(342, 192);
            this.txtThang.Multiline = true;
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(115, 42);
            this.txtThang.TabIndex = 32;
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(108, 192);
            this.txtNgay.Multiline = true;
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(115, 42);
            this.txtNgay.TabIndex = 31;
            // 
            // txtPhut
            // 
            this.txtPhut.Location = new System.Drawing.Point(342, 132);
            this.txtPhut.Multiline = true;
            this.txtPhut.Name = "txtPhut";
            this.txtPhut.Size = new System.Drawing.Size(115, 42);
            this.txtPhut.TabIndex = 30;
            // 
            // txtGio
            // 
            this.txtGio.Location = new System.Drawing.Point(108, 132);
            this.txtGio.Multiline = true;
            this.txtGio.Name = "txtGio";
            this.txtGio.Size = new System.Drawing.Size(115, 39);
            this.txtGio.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(489, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 29);
            this.label12.TabIndex = 28;
            this.label12.Text = "Năm";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 29);
            this.label13.TabIndex = 27;
            this.label13.Text = "Ngày";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(258, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 29);
            this.label14.TabIndex = 26;
            this.label14.Text = "Tháng ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(258, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 29);
            this.label15.TabIndex = 25;
            this.label15.Text = "Phút";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(25, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 29);
            this.label16.TabIndex = 24;
            this.label16.Text = "Giờ";
            // 
            // txtPlace
            // 
            this.txtPlace.Location = new System.Drawing.Point(452, 64);
            this.txtPlace.Multiline = true;
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(222, 42);
            this.txtPlace.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(337, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 29);
            this.label17.TabIndex = 22;
            this.label17.Text = "Nơi đến";
            // 
            // txtIDCB
            // 
            this.txtIDCB.Location = new System.Drawing.Point(108, 64);
            this.txtIDCB.Multiline = true;
            this.txtIDCB.Name = "txtIDCB";
            this.txtIDCB.Size = new System.Drawing.Size(211, 42);
            this.txtIDCB.TabIndex = 21;
            this.txtIDCB.TextChanged += new System.EventHandler(this.txtIDCB_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(25, 77);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 29);
            this.label18.TabIndex = 20;
            this.label18.Text = "IDCB";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.BackColor = System.Drawing.Color.Yellow;
            this.btnHuy.Location = new System.Drawing.Point(240, 362);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(177, 72);
            this.btnHuy.TabIndex = 16;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDatVe
            // 
            this.btnDatVe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatVe.BackColor = System.Drawing.Color.Yellow;
            this.btnDatVe.Location = new System.Drawing.Point(30, 466);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(177, 72);
            this.btnDatVe.TabIndex = 14;
            this.btnDatVe.Text = "Danh sách vé / Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.BackColor = System.Drawing.Color.Yellow;
            this.btnSua.Location = new System.Drawing.Point(30, 362);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(177, 72);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtgvChuyenBay
            // 
            this.dtgvChuyenBay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvChuyenBay.BackgroundColor = System.Drawing.Color.White;
            this.dtgvChuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenBay.Location = new System.Drawing.Point(6, 113);
            this.dtgvChuyenBay.Name = "dtgvChuyenBay";
            this.dtgvChuyenBay.RowHeadersWidth = 51;
            this.dtgvChuyenBay.RowTemplate.Height = 24;
            this.dtgvChuyenBay.Size = new System.Drawing.Size(1100, 567);
            this.dtgvChuyenBay.TabIndex = 3;
            this.dtgvChuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuyenBay_CellClick);
            this.dtgvChuyenBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuyenBay_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh sách chuyến bay";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dtgvHanhKhach);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 54);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1873, 680);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý khách";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgvHanhKhach
            // 
            this.dtgvHanhKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvHanhKhach.BackgroundColor = System.Drawing.Color.White;
            this.dtgvHanhKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHanhKhach.Location = new System.Drawing.Point(42, 96);
            this.dtgvHanhKhach.Name = "dtgvHanhKhach";
            this.dtgvHanhKhach.RowHeadersWidth = 51;
            this.dtgvHanhKhach.RowTemplate.Height = 24;
            this.dtgvHanhKhach.Size = new System.Drawing.Size(1223, 581);
            this.dtgvHanhKhach.TabIndex = 16;
            this.dtgvHanhKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHanhKhach_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách khách hàng";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 780);
            this.Controls.Add(this.themKH);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "5";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.themKH.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMayBay)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenBay)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHanhKhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl themKH;
        private System.Windows.Forms.DataGridView dtgvMayBay;
        private System.Windows.Forms.Button btnThemMB;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ThemCB;
        private System.Windows.Forms.Button btnInDSHK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLoai;
        private System.Windows.Forms.Button btnHieuchinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSocho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvHanhKhach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtIDMB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtPhut;
        private System.Windows.Forms.TextBox txtGio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDCB;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.DataGridView dtgvChuyenBay;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnInDSCB;
        private System.Windows.Forms.Timer timer;
    }
}

