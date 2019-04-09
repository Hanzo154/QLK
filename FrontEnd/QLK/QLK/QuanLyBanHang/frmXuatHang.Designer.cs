namespace QLK
{
    partial class frmXuatHang
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
            this.tbXemMaDH = new System.Windows.Forms.Button();
            this.tbNgayXuatOld = new System.Windows.Forms.MaskedTextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.tbXem = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.tbXH = new System.Windows.Forms.TextBox();
            this.chkDK = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.tbNgayXuat = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.NgayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTongTienPX = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbThanhTien = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbMaPH = new System.Windows.Forms.ComboBox();
            this.cbSoPhieu = new System.Windows.Forms.ComboBox();
            this.cbNgayBan = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label10 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.tbIn = new System.Windows.Forms.Button();
            this.tbHuy = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.tbThem = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbXemMaDH
            // 
            this.tbXemMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXemMaDH.Location = new System.Drawing.Point(226, 73);
            this.tbXemMaDH.Name = "tbXemMaDH";
            this.tbXemMaDH.Size = new System.Drawing.Size(56, 23);
            this.tbXemMaDH.TabIndex = 21;
            this.tbXemMaDH.Text = "Xem";
            this.tbXemMaDH.UseVisualStyleBackColor = true;
            // 
            // tbNgayXuatOld
            // 
            this.tbNgayXuatOld.BackColor = System.Drawing.Color.Orange;
            this.tbNgayXuatOld.Location = new System.Drawing.Point(90, 244);
            this.tbNgayXuatOld.Mask = "00/00/0000";
            this.tbNgayXuatOld.Name = "tbNgayXuatOld";
            this.tbNgayXuatOld.Size = new System.Drawing.Size(130, 20);
            this.tbNgayXuatOld.TabIndex = 20;
            this.tbNgayXuatOld.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbNgayXuatOld.ValidatingType = typeof(System.DateTime);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(13, 249);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(76, 13);
            this.Label11.TabIndex = 19;
            this.Label11.Text = "Ngày Xuất Cũ:";
            // 
            // tbXem
            // 
            this.tbXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXem.Location = new System.Drawing.Point(226, 243);
            this.tbXem.Name = "tbXem";
            this.tbXem.Size = new System.Drawing.Size(56, 23);
            this.tbXem.TabIndex = 4;
            this.tbXem.Text = "Xem";
            this.tbXem.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(198, 132);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(25, 13);
            this.Label9.TabIndex = 18;
            this.Label9.Text = "XH:";
            // 
            // tbXH
            // 
            this.tbXH.BackColor = System.Drawing.SystemColors.Info;
            this.tbXH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXH.Location = new System.Drawing.Point(223, 129);
            this.tbXH.Name = "tbXH";
            this.tbXH.ReadOnly = true;
            this.tbXH.Size = new System.Drawing.Size(17, 20);
            this.tbXH.TabIndex = 17;
            // 
            // chkDK
            // 
            this.chkDK.AutoSize = true;
            this.chkDK.Location = new System.Drawing.Point(245, 132);
            this.chkDK.Name = "chkDK";
            this.chkDK.Size = new System.Drawing.Size(41, 17);
            this.chkDK.TabIndex = 16;
            this.chkDK.Text = "DK";
            this.chkDK.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 131);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(60, 13);
            this.Label1.TabIndex = 15;
            this.Label1.Text = "Ngày Xuất:";
            // 
            // tbNgayXuat
            // 
            this.tbNgayXuat.BackColor = System.Drawing.SystemColors.Info;
            this.tbNgayXuat.Location = new System.Drawing.Point(90, 128);
            this.tbNgayXuat.Name = "tbNgayXuat";
            this.tbNgayXuat.ReadOnly = true;
            this.tbNgayXuat.Size = new System.Drawing.Size(105, 20);
            this.tbNgayXuat.TabIndex = 14;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(13, 222);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(76, 13);
            this.Label8.TabIndex = 13;
            this.Label8.Text = "Tổng Tiền PX:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(13, 194);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(47, 13);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Tên KH:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dgvInfor);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(655, 499);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AllowUserToDeleteRows = false;
            this.dgvInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NgayXuat});
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvInfor.Location = new System.Drawing.Point(3, 16);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.RowHeadersWidth = 30;
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfor.Size = new System.Drawing.Size(649, 480);
            this.dgvInfor.TabIndex = 0;
            // 
            // NgayXuat
            // 
            this.NgayXuat.DataPropertyName = "NgayXuat";
            this.NgayXuat.HeaderText = "Ngày Xuất";
            this.NgayXuat.Name = "NgayXuat";
            // 
            // tbTongTienPX
            // 
            this.tbTongTienPX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbTongTienPX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongTienPX.ForeColor = System.Drawing.Color.Red;
            this.tbTongTienPX.Location = new System.Drawing.Point(90, 218);
            this.tbTongTienPX.Name = "tbTongTienPX";
            this.tbTongTienPX.Size = new System.Drawing.Size(192, 20);
            this.tbTongTienPX.TabIndex = 11;
            this.tbTongTienPX.Text = "0";
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.tbXemMaDH);
            this.GroupBox3.Controls.Add(this.tbNgayXuatOld);
            this.GroupBox3.Controls.Add(this.Label11);
            this.GroupBox3.Controls.Add(this.tbXem);
            this.GroupBox3.Controls.Add(this.Label9);
            this.GroupBox3.Controls.Add(this.tbXH);
            this.GroupBox3.Controls.Add(this.chkDK);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.tbNgayXuat);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.Label7);
            this.GroupBox3.Controls.Add(this.tbTongTienPX);
            this.GroupBox3.Controls.Add(this.tbTenKH);
            this.GroupBox3.Controls.Add(this.tbMaKH);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.tbThanhTien);
            this.GroupBox3.Controls.Add(this.Label4);
            this.GroupBox3.Controls.Add(this.Label3);
            this.GroupBox3.Controls.Add(this.cbMaPH);
            this.GroupBox3.Controls.Add(this.cbSoPhieu);
            this.GroupBox3.Controls.Add(this.cbNgayBan);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox3.Location = new System.Drawing.Point(3, 13);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GroupBox3.Size = new System.Drawing.Size(301, 276);
            this.GroupBox3.TabIndex = 0;
            this.GroupBox3.TabStop = false;
            // 
            // tbTenKH
            // 
            this.tbTenKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbTenKH.Location = new System.Drawing.Point(90, 191);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(192, 20);
            this.tbTenKH.TabIndex = 10;
            // 
            // tbMaKH
            // 
            this.tbMaKH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbMaKH.Location = new System.Drawing.Point(90, 164);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(192, 20);
            this.tbMaKH.TabIndex = 9;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(13, 167);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(43, 13);
            this.Label6.TabIndex = 8;
            this.Label6.Text = "Mã KH:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(13, 105);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Tổng Tiền:";
            // 
            // tbThanhTien
            // 
            this.tbThanhTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tbThanhTien.Location = new System.Drawing.Point(90, 102);
            this.tbThanhTien.Name = "tbThanhTien";
            this.tbThanhTien.Size = new System.Drawing.Size(192, 20);
            this.tbThanhTien.TabIndex = 6;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(13, 78);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(44, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Mã ĐH:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(13, 50);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Số Phiếu:";
            // 
            // cbMaPH
            // 
            this.cbMaPH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbMaPH.DisplayMember = "MaDH";
            this.cbMaPH.FormattingEnabled = true;
            this.cbMaPH.Location = new System.Drawing.Point(90, 74);
            this.cbMaPH.Name = "cbMaPH";
            this.cbMaPH.Size = new System.Drawing.Size(130, 21);
            this.cbMaPH.TabIndex = 3;
            // 
            // cbSoPhieu
            // 
            this.cbSoPhieu.DisplayMember = "SoPhieu";
            this.cbSoPhieu.FormattingEnabled = true;
            this.cbSoPhieu.Location = new System.Drawing.Point(90, 46);
            this.cbSoPhieu.Name = "cbSoPhieu";
            this.cbSoPhieu.Size = new System.Drawing.Size(192, 21);
            this.cbSoPhieu.TabIndex = 2;
            // 
            // cbNgayBan
            // 
            this.cbNgayBan.DisplayMember = "NgayBan";
            this.cbNgayBan.FormattingEnabled = true;
            this.cbNgayBan.Location = new System.Drawing.Point(90, 18);
            this.cbNgayBan.Name = "cbNgayBan";
            this.cbNgayBan.Size = new System.Drawing.Size(192, 21);
            this.cbNgayBan.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(57, 13);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Ngày Bán:";
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.SplitContainer1.Panel1.Controls.Add(this.Label10);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(963, 526);
            this.SplitContainer1.SplitterDistance = 26;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Purple;
            this.Label10.Location = new System.Drawing.Point(3, 2);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(201, 24);
            this.Label10.TabIndex = 1;
            this.Label10.Text = "PHIẾU XUẤT HÀNG";
            // 
            // SplitContainer2
            // 
            this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer2.Name = "SplitContainer2";
            // 
            // SplitContainer2.Panel1
            // 
            this.SplitContainer2.Panel1.Controls.Add(this.GroupBox2);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer2.Size = new System.Drawing.Size(963, 499);
            this.SplitContainer2.SplitterDistance = 307;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.GroupBox2.Controls.Add(this.GroupBox4);
            this.GroupBox2.Controls.Add(this.GroupBox3);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 120);
            this.GroupBox2.Size = new System.Drawing.Size(307, 499);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.tbIn);
            this.GroupBox4.Controls.Add(this.tbHuy);
            this.GroupBox4.Controls.Add(this.btXoa);
            this.GroupBox4.Controls.Add(this.tbThem);
            this.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox4.Location = new System.Drawing.Point(3, 289);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(301, 90);
            this.GroupBox4.TabIndex = 1;
            this.GroupBox4.TabStop = false;
            // 
            // tbIn
            // 
            this.tbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbIn.Location = new System.Drawing.Point(185, 51);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(75, 22);
            this.tbIn.TabIndex = 3;
            this.tbIn.Text = "In";
            this.tbIn.UseVisualStyleBackColor = true;
            // 
            // tbHuy
            // 
            this.tbHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHuy.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbHuy.Location = new System.Drawing.Point(95, 50);
            this.tbHuy.Name = "tbHuy";
            this.tbHuy.Size = new System.Drawing.Size(75, 23);
            this.tbHuy.TabIndex = 2;
            this.tbHuy.Text = "Hủy";
            this.tbHuy.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btXoa.Location = new System.Drawing.Point(185, 20);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // tbThem
            // 
            this.tbThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbThem.Location = new System.Drawing.Point(95, 20);
            this.tbThem.Name = "tbThem";
            this.tbThem.Size = new System.Drawing.Size(75, 23);
            this.tbThem.TabIndex = 0;
            this.tbThem.Text = "Thêm";
            this.tbThem.UseVisualStyleBackColor = true;
            // 
            // frmXuatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 526);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmXuatHang";
            this.Text = "frmXuatHang";
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button tbXemMaDH;
        internal System.Windows.Forms.MaskedTextBox tbNgayXuatOld;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Button tbXem;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox tbXH;
        internal System.Windows.Forms.CheckBox chkDK;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox tbNgayXuat;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.DataGridViewTextBoxColumn NgayXuat;
        internal System.Windows.Forms.TextBox tbTongTienPX;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.TextBox tbTenKH;
        internal System.Windows.Forms.TextBox tbMaKH;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox tbThanhTien;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbMaPH;
        internal System.Windows.Forms.ComboBox cbSoPhieu;
        internal System.Windows.Forms.ComboBox cbNgayBan;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.Button tbIn;
        internal System.Windows.Forms.Button tbHuy;
        internal System.Windows.Forms.Button btXoa;
        internal System.Windows.Forms.Button tbThem;
    }
}