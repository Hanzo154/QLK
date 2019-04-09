namespace QLK
{
    partial class frmXemDoanhThuTheoMarketer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvBanHang = new System.Windows.Forms.DataGridView();
            this.SplitContainer4 = new System.Windows.Forms.SplitContainer();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label23 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbMaketer = new System.Windows.Forms.ComboBox();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbTongTienCDK = new System.Windows.Forms.Label();
            this.lbTienGoc = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.lbTongBH = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbNgayXem = new System.Windows.Forms.GroupBox();
            this.tbXem = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.SplitContainer3 = new System.Windows.Forms.SplitContainer();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer4)).BeginInit();
            this.SplitContainer4.SuspendLayout();
            this.cbNgayXem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer3)).BeginInit();
            this.SplitContainer3.Panel1.SuspendLayout();
            this.SplitContainer3.Panel2.SuspendLayout();
            this.SplitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.GroupBox1);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.SplitContainer4);
            this.SplitContainer2.Panel2Collapsed = true;
            this.SplitContainer2.Size = new System.Drawing.Size(853, 482);
            this.SplitContainer2.SplitterDistance = 340;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dgvBanHang);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(853, 482);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Bán Hàng";
            // 
            // dgvBanHang
            // 
            this.dgvBanHang.AllowUserToAddRows = false;
            this.dgvBanHang.AllowUserToDeleteRows = false;
            this.dgvBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBanHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanHang.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvBanHang.Location = new System.Drawing.Point(3, 16);
            this.dgvBanHang.Name = "dgvBanHang";
            this.dgvBanHang.ReadOnly = true;
            this.dgvBanHang.RowHeadersWidth = 25;
            this.dgvBanHang.RowTemplate.Height = 24;
            this.dgvBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvBanHang.Size = new System.Drawing.Size(847, 463);
            this.dgvBanHang.TabIndex = 0;
            // 
            // SplitContainer4
            // 
            this.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer4.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer4.Name = "SplitContainer4";
            this.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.SplitContainer4.Panel2Collapsed = true;
            this.SplitContainer4.Panel2MinSize = 0;
            this.SplitContainer4.Size = new System.Drawing.Size(150, 46);
            this.SplitContainer4.SplitterDistance = 37;
            this.SplitContainer4.SplitterWidth = 1;
            this.SplitContainer4.TabIndex = 0;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label3.Location = new System.Drawing.Point(187, 34);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(69, 15);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Trạng Thái:";
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label23.Location = new System.Drawing.Point(187, 13);
            this.Label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(59, 15);
            this.Label23.TabIndex = 47;
            this.Label23.Text = "Marketer:";
            // 
            // cbStatus
            // 
            this.cbStatus.DisplayMember = "UserName";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(259, 31);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(140, 23);
            this.cbStatus.TabIndex = 46;
            // 
            // cbMaketer
            // 
            this.cbMaketer.DisplayMember = "UserName";
            this.cbMaketer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaketer.FormattingEnabled = true;
            this.cbMaketer.Location = new System.Drawing.Point(259, 10);
            this.cbMaketer.Margin = new System.Windows.Forms.Padding(2);
            this.cbMaketer.Name = "cbMaketer";
            this.cbMaketer.Size = new System.Drawing.Size(140, 23);
            this.cbMaketer.TabIndex = 46;
            // 
            // dtToDate
            // 
            this.dtToDate.CustomFormat = "";
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(64, 31);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(110, 21);
            this.dtToDate.TabIndex = 18;
            // 
            // dtFromDate
            // 
            this.dtFromDate.CustomFormat = "";
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(64, 9);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(110, 21);
            this.dtFromDate.TabIndex = 18;
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Blue;
            this.Button1.Location = new System.Drawing.Point(412, 32);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(88, 23);
            this.Button1.TabIndex = 17;
            this.Button1.Text = "Đóng";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label2.Location = new System.Drawing.Point(7, 35);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(64, 15);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Đến Ngày:";
            // 
            // lbTongTienCDK
            // 
            this.lbTongTienCDK.AutoSize = true;
            this.lbTongTienCDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTienCDK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTongTienCDK.Location = new System.Drawing.Point(516, 37);
            this.lbTongTienCDK.Name = "lbTongTienCDK";
            this.lbTongTienCDK.Size = new System.Drawing.Size(16, 15);
            this.lbTongTienCDK.TabIndex = 13;
            this.lbTongTienCDK.Text = "...";
            // 
            // lbTienGoc
            // 
            this.lbTienGoc.AutoSize = true;
            this.lbTienGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienGoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTienGoc.Location = new System.Drawing.Point(692, 36);
            this.lbTienGoc.Name = "lbTienGoc";
            this.lbTienGoc.Size = new System.Drawing.Size(16, 15);
            this.lbTienGoc.TabIndex = 11;
            this.lbTienGoc.Text = "...";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbThanhTien.Location = new System.Drawing.Point(692, 14);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(16, 15);
            this.lbThanhTien.TabIndex = 11;
            this.lbThanhTien.Text = "...";
            // 
            // lbTongBH
            // 
            this.lbTongBH.AutoSize = true;
            this.lbTongBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTongBH.Location = new System.Drawing.Point(515, 15);
            this.lbTongBH.Name = "lbTongBH";
            this.lbTongBH.Size = new System.Drawing.Size(16, 15);
            this.lbTongBH.TabIndex = 11;
            this.lbTongBH.Text = "...";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.Label1.Location = new System.Drawing.Point(8, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(55, 15);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Từ Ngày:";
            // 
            // cbNgayXem
            // 
            this.cbNgayXem.BackColor = System.Drawing.SystemColors.Control;
            this.cbNgayXem.Controls.Add(this.Label3);
            this.cbNgayXem.Controls.Add(this.Label23);
            this.cbNgayXem.Controls.Add(this.cbStatus);
            this.cbNgayXem.Controls.Add(this.cbMaketer);
            this.cbNgayXem.Controls.Add(this.dtToDate);
            this.cbNgayXem.Controls.Add(this.dtFromDate);
            this.cbNgayXem.Controls.Add(this.Button1);
            this.cbNgayXem.Controls.Add(this.Label2);
            this.cbNgayXem.Controls.Add(this.lbTongTienCDK);
            this.cbNgayXem.Controls.Add(this.lbTienGoc);
            this.cbNgayXem.Controls.Add(this.lbThanhTien);
            this.cbNgayXem.Controls.Add(this.lbTongBH);
            this.cbNgayXem.Controls.Add(this.Label1);
            this.cbNgayXem.Controls.Add(this.tbXem);
            this.cbNgayXem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbNgayXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNgayXem.Location = new System.Drawing.Point(0, 0);
            this.cbNgayXem.Name = "cbNgayXem";
            this.cbNgayXem.Size = new System.Drawing.Size(853, 57);
            this.cbNgayXem.TabIndex = 0;
            this.cbNgayXem.TabStop = false;
            // 
            // tbXem
            // 
            this.tbXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXem.ForeColor = System.Drawing.Color.Blue;
            this.tbXem.Location = new System.Drawing.Point(412, 8);
            this.tbXem.Name = "tbXem";
            this.tbXem.Size = new System.Drawing.Size(88, 23);
            this.tbXem.TabIndex = 9;
            this.tbXem.Text = "Xem";
            this.tbXem.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Purple;
            this.Label6.Location = new System.Drawing.Point(3, 3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(345, 24);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "XEM DOANH THU THEO MAKETER";
            // 
            // SplitContainer3
            // 
            this.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer3.Name = "SplitContainer3";
            this.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer3.Panel1
            // 
            this.SplitContainer3.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer3.Panel1.Controls.Add(this.Label6);
            // 
            // SplitContainer3.Panel2
            // 
            this.SplitContainer3.Panel2.Controls.Add(this.cbNgayXem);
            this.SplitContainer3.Size = new System.Drawing.Size(853, 83);
            this.SplitContainer3.SplitterDistance = 25;
            this.SplitContainer3.SplitterWidth = 1;
            this.SplitContainer3.TabIndex = 0;
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
            this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer3);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(853, 566);
            this.SplitContainer1.SplitterDistance = 83;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 3;
            // 
            // frmXemDoanhThuTheoMarketer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 566);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmXemDoanhThuTheoMarketer";
            this.Text = "frmXemDoanhThuTheoMarketer";
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer4)).EndInit();
            this.SplitContainer4.ResumeLayout(false);
            this.cbNgayXem.ResumeLayout(false);
            this.cbNgayXem.PerformLayout();
            this.SplitContainer3.Panel1.ResumeLayout(false);
            this.SplitContainer3.Panel1.PerformLayout();
            this.SplitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer3)).EndInit();
            this.SplitContainer3.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgvBanHang;
        internal System.Windows.Forms.SplitContainer SplitContainer4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.ComboBox cbStatus;
        internal System.Windows.Forms.ComboBox cbMaketer;
        internal System.Windows.Forms.DateTimePicker dtToDate;
        internal System.Windows.Forms.DateTimePicker dtFromDate;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label lbTongTienCDK;
        internal System.Windows.Forms.Label lbTienGoc;
        internal System.Windows.Forms.Label lbThanhTien;
        internal System.Windows.Forms.Label lbTongBH;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox cbNgayXem;
        internal System.Windows.Forms.Button tbXem;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.SplitContainer SplitContainer3;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}