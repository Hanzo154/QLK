namespace QLK
{
    partial class frmSOS
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkKHNo = new System.Windows.Forms.CheckBox();
            this.btXoa = new System.Windows.Forms.Button();
            this.chkPhieuNhap = new System.Windows.Forms.CheckBox();
            this.chkMatHang = new System.Windows.Forms.CheckBox();
            this.chkKhachHang = new System.Windows.Forms.CheckBox();
            this.chkPhieuBan = new System.Windows.Forms.CheckBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.chkKHNo);
            this.GroupBox1.Controls.Add(this.btXoa);
            this.GroupBox1.Controls.Add(this.chkPhieuNhap);
            this.GroupBox1.Controls.Add(this.chkMatHang);
            this.GroupBox1.Controls.Add(this.chkKhachHang);
            this.GroupBox1.Controls.Add(this.chkPhieuBan);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(447, 192);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // chkKHNo
            // 
            this.chkKHNo.AutoSize = true;
            this.chkKHNo.Location = new System.Drawing.Point(164, 26);
            this.chkKHNo.Name = "chkKHNo";
            this.chkKHNo.Size = new System.Drawing.Size(103, 17);
            this.chkKHNo.TabIndex = 3;
            this.chkKHNo.Text = "Khách Hàng Nợ";
            this.chkKHNo.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Yellow;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Red;
            this.btXoa.Location = new System.Drawing.Point(137, 96);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(164, 39);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa Tất Cả Dữ Liệu";
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // chkPhieuNhap
            // 
            this.chkPhieuNhap.AutoSize = true;
            this.chkPhieuNhap.Location = new System.Drawing.Point(41, 61);
            this.chkPhieuNhap.Name = "chkPhieuNhap";
            this.chkPhieuNhap.Size = new System.Drawing.Size(82, 17);
            this.chkPhieuNhap.TabIndex = 1;
            this.chkPhieuNhap.Text = "Phiếu Nhập";
            this.chkPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // chkMatHang
            // 
            this.chkMatHang.AutoSize = true;
            this.chkMatHang.Location = new System.Drawing.Point(164, 61);
            this.chkMatHang.Name = "chkMatHang";
            this.chkMatHang.Size = new System.Drawing.Size(73, 17);
            this.chkMatHang.TabIndex = 0;
            this.chkMatHang.Text = "Mặt Hàng";
            this.chkMatHang.UseVisualStyleBackColor = true;
            // 
            // chkKhachHang
            // 
            this.chkKhachHang.AutoSize = true;
            this.chkKhachHang.Location = new System.Drawing.Point(294, 26);
            this.chkKhachHang.Name = "chkKhachHang";
            this.chkKhachHang.Size = new System.Drawing.Size(86, 17);
            this.chkKhachHang.TabIndex = 0;
            this.chkKhachHang.Text = "Khách Hàng";
            this.chkKhachHang.UseVisualStyleBackColor = true;
            // 
            // chkPhieuBan
            // 
            this.chkPhieuBan.AutoSize = true;
            this.chkPhieuBan.Location = new System.Drawing.Point(41, 26);
            this.chkPhieuBan.Name = "chkPhieuBan";
            this.chkPhieuBan.Size = new System.Drawing.Size(75, 17);
            this.chkPhieuBan.TabIndex = 0;
            this.chkPhieuBan.Text = "Phiếu Bán";
            this.chkPhieuBan.UseVisualStyleBackColor = true;
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer1.Name = "SplitContainer1";
            this.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer1.Panel1
            // 
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer1.Size = new System.Drawing.Size(447, 218);
            this.SplitContainer1.SplitterDistance = 25;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Red;
            this.Label9.Location = new System.Drawing.Point(3, 4);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(129, 24);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "DỮ LIỆU CŨ";
            // 
            // frmSOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 218);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmSOS";
            this.Text = "frmSOS";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox chkKHNo;
        internal System.Windows.Forms.Button btXoa;
        internal System.Windows.Forms.CheckBox chkPhieuNhap;
        internal System.Windows.Forms.CheckBox chkMatHang;
        internal System.Windows.Forms.CheckBox chkKhachHang;
        internal System.Windows.Forms.CheckBox chkPhieuBan;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label Label9;
    }
}