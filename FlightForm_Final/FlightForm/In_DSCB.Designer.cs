namespace FlightForm
{
    partial class In_DSCB
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbPlace = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvDSCB = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSCB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH CHUYẾN BAY CÒN TRỐNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày Khởi Hành:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(427, 62);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(126, 25);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "dd/mm/yyyy";
            // 
            // lbPlace
            // 
            this.lbPlace.AutoSize = true;
            this.lbPlace.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlace.Location = new System.Drawing.Point(718, 62);
            this.lbPlace.Name = "lbPlace";
            this.lbPlace.Size = new System.Drawing.Size(56, 25);
            this.lbPlace.TabIndex = 6;
            this.lbPlace.Text = "####";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nơi Đến:";
            // 
            // dtgvDSCB
            // 
            this.dtgvDSCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSCB.Location = new System.Drawing.Point(12, 120);
            this.dtgvDSCB.Name = "dtgvDSCB";
            this.dtgvDSCB.RowHeadersWidth = 51;
            this.dtgvDSCB.RowTemplate.Height = 24;
            this.dtgvDSCB.Size = new System.Drawing.Size(1004, 476);
            this.dtgvDSCB.TabIndex = 7;
            // 
            // In_DSCB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 608);
            this.Controls.Add(this.dtgvDSCB);
            this.Controls.Add(this.lbPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "In_DSCB";
            this.Text = "In_DSCB";
            this.Load += new System.EventHandler(this.In_DSCB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSCB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvDSCB;
    }
}