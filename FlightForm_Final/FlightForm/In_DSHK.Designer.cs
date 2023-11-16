namespace FlightForm
{
    partial class In_DSHK
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
            this.lblNoiDen = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.lblChuyenBay = new System.Windows.Forms.Label();
            this.dtgvDSHK = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoiDen
            // 
            this.lblNoiDen.AutoSize = true;
            this.lblNoiDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiDen.Location = new System.Drawing.Point(460, 65);
            this.lblNoiDen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNoiDen.Name = "lblNoiDen";
            this.lblNoiDen.Size = new System.Drawing.Size(237, 29);
            this.lblNoiDen.TabIndex = 9;
            this.lblNoiDen.Text = "Nơi đến : xxxxxxxxxxx";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(34, 65);
            this.lblThoiGian.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(434, 29);
            this.lblThoiGian.TabIndex = 8;
            this.lblThoiGian.Text = "Ngày giờ khởi hành: dd/mm/yyyy hh:mm";
            // 
            // lblChuyenBay
            // 
            this.lblChuyenBay.AutoSize = true;
            this.lblChuyenBay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuyenBay.Location = new System.Drawing.Point(34, 7);
            this.lblChuyenBay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblChuyenBay.Name = "lblChuyenBay";
            this.lblChuyenBay.Size = new System.Drawing.Size(648, 29);
            this.lblChuyenBay.TabIndex = 7;
            this.lblChuyenBay.Text = "DANH SÁCH HÀNH KHÁCH THUỘC CHUYẾN BAY ######";
            // 
            // dtgvDSHK
            // 
            this.dtgvDSHK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHK.Location = new System.Drawing.Point(14, 123);
            this.dtgvDSHK.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvDSHK.Name = "dtgvDSHK";
            this.dtgvDSHK.RowHeadersWidth = 51;
            this.dtgvDSHK.RowTemplate.Height = 24;
            this.dtgvDSHK.Size = new System.Drawing.Size(850, 1088);
            this.dtgvDSHK.TabIndex = 6;
            // 
            // In_DSHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 676);
            this.Controls.Add(this.lblNoiDen);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.lblChuyenBay);
            this.Controls.Add(this.dtgvDSHK);
            this.Name = "In_DSHK";
            this.Text = "In_DSHK";
            this.Load += new System.EventHandler(this.DSHK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoiDen;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label lblChuyenBay;
        private System.Windows.Forms.DataGridView dtgvDSHK;
    }
}