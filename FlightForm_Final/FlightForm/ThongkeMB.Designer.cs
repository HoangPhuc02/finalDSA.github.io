namespace FlightForm
{
    partial class ThongkeMB
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
            this.dtgvThongKe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Máy Bay";
            // 
            // dtgvThongKe
            // 
            this.dtgvThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThongKe.Location = new System.Drawing.Point(12, 54);
            this.dtgvThongKe.Name = "dtgvThongKe";
            this.dtgvThongKe.RowHeadersWidth = 51;
            this.dtgvThongKe.RowTemplate.Height = 24;
            this.dtgvThongKe.Size = new System.Drawing.Size(776, 586);
            this.dtgvThongKe.TabIndex = 1;
            this.dtgvThongKe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThongKe_CellContentClick);
            // 
            // ThongkeMB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.dtgvThongKe);
            this.Controls.Add(this.label1);
            this.Name = "ThongkeMB";
            this.Text = "ChinhSua";
            this.Load += new System.EventHandler(this.ThongkeMB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThongKe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvThongKe;
    }
}