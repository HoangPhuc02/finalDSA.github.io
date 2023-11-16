namespace FlightForm
{
    partial class DatVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatVe));
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.cbPhai = new System.Windows.Forms.ComboBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtViTri = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHieuChinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // btnDatVe
            // 
            resources.ApplyResources(this.btnDatVe, "btnDatVe");
            this.btnDatVe.BackColor = System.Drawing.Color.Yellow;
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.UseVisualStyleBackColor = false;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // txtTen
            // 
            resources.ApplyResources(this.txtTen, "txtTen");
            this.txtTen.Name = "txtTen";
            // 
            // cbPhai
            // 
            resources.ApplyResources(this.cbPhai, "cbPhai");
            this.cbPhai.FormattingEnabled = true;
            this.cbPhai.Items.AddRange(new object[] {
            resources.GetString("cbPhai.Items"),
            resources.GetString("cbPhai.Items1")});
            this.cbPhai.Name = "cbPhai";
            // 
            // txtHo
            // 
            resources.ApplyResources(this.txtHo, "txtHo");
            this.txtHo.Name = "txtHo";
            // 
            // txtCMND
            // 
            resources.ApplyResources(this.txtCMND, "txtCMND");
            this.txtCMND.Name = "txtCMND";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtViTri
            // 
            resources.ApplyResources(this.txtViTri, "txtViTri");
            this.txtViTri.Name = "txtViTri";
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.BackColor = System.Drawing.Color.Yellow;
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHieuChinh
            // 
            resources.ApplyResources(this.btnHieuChinh, "btnHieuChinh");
            this.btnHieuChinh.BackColor = System.Drawing.Color.Yellow;
            this.btnHieuChinh.Name = "btnHieuChinh";
            this.btnHieuChinh.UseVisualStyleBackColor = false;
            this.btnHieuChinh.Click += new System.EventHandler(this.btnHieuChinh_Click);
            // 
            // DatVe
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.btnHieuChinh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtViTri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPhai);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DatVe";
            this.Load += new System.EventHandler(this.DatVe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.ComboBox cbPhai;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtViTri;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHieuChinh;
    }
}