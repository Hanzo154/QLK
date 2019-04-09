namespace QLK
{
    partial class frmDuLieuCu
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
            this.dtpNgayXoa = new System.Windows.Forms.DateTimePicker();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label9 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.chkPhieuNhap = new System.Windows.Forms.CheckBox();
            this.chkPhieuBan = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgayXoa
            // 
            this.dtpNgayXoa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXoa.Location = new System.Drawing.Point(102, 18);
            this.dtpNgayXoa.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgayXoa.Name = "dtpNgayXoa";
            this.dtpNgayXoa.Size = new System.Drawing.Size(151, 20);
            this.dtpNgayXoa.TabIndex = 3;
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
            this.SplitContainer1.Size = new System.Drawing.Size(381, 213);
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
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.dtpNgayXoa);
            this.GroupBox1.Controls.Add(this.btXoa);
            this.GroupBox1.Controls.Add(this.chkPhieuNhap);
            this.GroupBox1.Controls.Add(this.chkPhieuBan);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(381, 187);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 21);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Xóa Trước Ngày:";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Purple;
            this.btXoa.Location = new System.Drawing.Point(102, 95);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(150, 34);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa Dữ Liệu Cũ";
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // chkPhieuNhap
            // 
            this.chkPhieuNhap.AutoSize = true;
            this.chkPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPhieuNhap.Location = new System.Drawing.Point(102, 61);
            this.chkPhieuNhap.Name = "chkPhieuNhap";
            this.chkPhieuNhap.Size = new System.Drawing.Size(92, 17);
            this.chkPhieuNhap.TabIndex = 1;
            this.chkPhieuNhap.Text = "Phiếu Nhập";
            this.chkPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // chkPhieuBan
            // 
            this.chkPhieuBan.AutoSize = true;
            this.chkPhieuBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPhieuBan.Location = new System.Drawing.Point(102, 41);
            this.chkPhieuBan.Name = "chkPhieuBan";
            this.chkPhieuBan.Size = new System.Drawing.Size(84, 17);
            this.chkPhieuBan.TabIndex = 0;
            this.chkPhieuBan.Text = "Phiếu Bán";
            this.chkPhieuBan.UseVisualStyleBackColor = true;
            // 
            // frmDuLieuCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 213);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmDuLieuCu";
            this.Text = "frmDuLieuCu";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DateTimePicker dtpNgayXoa;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btXoa;
        internal System.Windows.Forms.CheckBox chkPhieuNhap;
        internal System.Windows.Forms.CheckBox chkPhieuBan;
    }
}