namespace QLK
{
    partial class frmNhapHangVaoKho
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
            this.lbThongTin = new System.Windows.Forms.GroupBox();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.cbSoPhieu = new System.Windows.Forms.ComboBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btMoi = new System.Windows.Forms.Button();
            this.btGiaMoi = new System.Windows.Forms.Button();
            this.lbDonVi = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tbXem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.tbRefesh = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.tbGGnb = new System.Windows.Forms.TextBox();
            this.tbGiaGoc = new System.Windows.Forms.TextBox();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.tbDGnb = new System.Windows.Forms.TextBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbChinh = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.NhapKhpo = new System.Windows.Forms.GroupBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.tbSLThem = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tbSLCu = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.NhapKhpo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbThongTin
            // 
            this.lbThongTin.BackColor = System.Drawing.SystemColors.Control;
            this.lbThongTin.Controls.Add(this.dgvInfor);
            this.lbThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbThongTin.Location = new System.Drawing.Point(0, 0);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(983, 443);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.TabStop = false;
            this.lbThongTin.Text = "Thông Tin:";
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AllowUserToDeleteRows = false;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonGiaBan,
            this.GhiChu});
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvInfor.Location = new System.Drawing.Point(3, 16);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfor.Size = new System.Drawing.Size(977, 424);
            this.dgvInfor.TabIndex = 0;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.DonGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.DonGiaBan.HeaderText = "ĐG Bán Nhập";
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 77;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Width = 77;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhiChu.Location = new System.Drawing.Point(541, 69);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(370, 22);
            this.tbGhiChu.TabIndex = 19;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(458, 72);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(48, 13);
            this.Label11.TabIndex = 18;
            this.Label11.Text = "Ghi Chú:";
            // 
            // cbSoPhieu
            // 
            this.cbSoPhieu.FormattingEnabled = true;
            this.cbSoPhieu.Location = new System.Drawing.Point(282, 13);
            this.cbSoPhieu.Name = "cbSoPhieu";
            this.cbSoPhieu.Size = new System.Drawing.Size(77, 21);
            this.cbSoPhieu.TabIndex = 17;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(113, 12);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(109, 20);
            this.dtNgayNhap.TabIndex = 16;
            // 
            // btMoi
            // 
            this.btMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMoi.Location = new System.Drawing.Point(365, 13);
            this.btMoi.Name = "btMoi";
            this.btMoi.Size = new System.Drawing.Size(64, 23);
            this.btMoi.TabIndex = 15;
            this.btMoi.Text = "Mới";
            this.btMoi.UseVisualStyleBackColor = true;
            // 
            // btGiaMoi
            // 
            this.btGiaMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGiaMoi.Location = new System.Drawing.Point(910, 40);
            this.btGiaMoi.Name = "btGiaMoi";
            this.btGiaMoi.Size = new System.Drawing.Size(46, 23);
            this.btGiaMoi.TabIndex = 15;
            this.btGiaMoi.Text = "Sửa";
            this.btGiaMoi.UseVisualStyleBackColor = true;
            // 
            // lbDonVi
            // 
            this.lbDonVi.AutoSize = true;
            this.lbDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonVi.Location = new System.Drawing.Point(865, 17);
            this.lbDonVi.Name = "lbDonVi";
            this.lbDonVi.Size = new System.Drawing.Size(16, 15);
            this.lbDonVi.TabIndex = 14;
            this.lbDonVi.Text = "...";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.tbXem);
            this.GroupBox1.Controls.Add(this.btSua);
            this.GroupBox1.Controls.Add(this.tbRefesh);
            this.GroupBox1.Location = new System.Drawing.Point(113, 90);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(316, 37);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            // 
            // tbXem
            // 
            this.tbXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbXem.Location = new System.Drawing.Point(17, 10);
            this.tbXem.Name = "tbXem";
            this.tbXem.Size = new System.Drawing.Size(91, 23);
            this.tbXem.TabIndex = 15;
            this.tbXem.Text = "Xem";
            this.tbXem.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btSua.Location = new System.Drawing.Point(112, 10);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(91, 23);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // tbRefesh
            // 
            this.tbRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRefesh.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tbRefesh.Location = new System.Drawing.Point(209, 10);
            this.tbRefesh.Name = "tbRefesh";
            this.tbRefesh.Size = new System.Drawing.Size(91, 23);
            this.tbRefesh.TabIndex = 20;
            this.tbRefesh.Text = "F5";
            this.tbRefesh.UseVisualStyleBackColor = true;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(838, 19);
            this.Label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(25, 13);
            this.Label9.TabIndex = 26;
            this.Label9.Text = "ĐV:";
            // 
            // tbGGnb
            // 
            this.tbGGnb.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbGGnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGGnb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbGGnb.Location = new System.Drawing.Point(836, 41);
            this.tbGGnb.Name = "tbGGnb";
            this.tbGGnb.ReadOnly = true;
            this.tbGGnb.Size = new System.Drawing.Size(74, 20);
            this.tbGGnb.TabIndex = 25;
            // 
            // tbGiaGoc
            // 
            this.tbGiaGoc.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbGiaGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGiaGoc.Location = new System.Drawing.Point(742, 41);
            this.tbGiaGoc.Name = "tbGiaGoc";
            this.tbGiaGoc.ReadOnly = true;
            this.tbGiaGoc.Size = new System.Drawing.Size(93, 22);
            this.tbGiaGoc.TabIndex = 25;
            // 
            // cbMaMH
            // 
            this.cbMaMH.BackColor = System.Drawing.Color.White;
            this.cbMaMH.DisplayMember = "MaMH";
            this.cbMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(113, 68);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(316, 24);
            this.cbMaMH.TabIndex = 6;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(696, 46);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(49, 13);
            this.Label10.TabIndex = 24;
            this.Label10.Text = "Giá Gốc:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.btThem);
            this.GroupBox2.Controls.Add(this.btLuu);
            this.GroupBox2.Controls.Add(this.btClose);
            this.GroupBox2.Location = new System.Drawing.Point(568, 91);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(312, 34);
            this.GroupBox2.TabIndex = 22;
            this.GroupBox2.TabStop = false;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btThem.Location = new System.Drawing.Point(6, 9);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(89, 23);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btLuu.Location = new System.Drawing.Point(112, 9);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(89, 23);
            this.btLuu.TabIndex = 15;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btClose.Location = new System.Drawing.Point(207, 9);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(91, 23);
            this.btClose.TabIndex = 20;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            // 
            // tbDGnb
            // 
            this.tbDGnb.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.tbDGnb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDGnb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbDGnb.Location = new System.Drawing.Point(622, 41);
            this.tbDGnb.Name = "tbDGnb";
            this.tbDGnb.ReadOnly = true;
            this.tbDGnb.Size = new System.Drawing.Size(74, 20);
            this.tbDGnb.TabIndex = 12;
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
            this.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer1.Panel1.Controls.Add(this.lbChinh);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(983, 607);
            this.SplitContainer1.SplitterDistance = 28;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // lbChinh
            // 
            this.lbChinh.AutoSize = true;
            this.lbChinh.Location = new System.Drawing.Point(892, 5);
            this.lbChinh.Name = "lbChinh";
            this.lbChinh.Size = new System.Drawing.Size(19, 13);
            this.lbChinh.TabIndex = 1;
            this.lbChinh.Text = "....";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Purple;
            this.Label1.Location = new System.Drawing.Point(4, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(231, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NHẬP HÀNG VÀO KHO";
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
            this.SplitContainer2.Panel1.Controls.Add(this.NhapKhpo);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.lbThongTin);
            this.SplitContainer2.Size = new System.Drawing.Size(983, 578);
            this.SplitContainer2.SplitterDistance = 134;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // NhapKhpo
            // 
            this.NhapKhpo.BackColor = System.Drawing.SystemColors.Control;
            this.NhapKhpo.Controls.Add(this.Label9);
            this.NhapKhpo.Controls.Add(this.tbGGnb);
            this.NhapKhpo.Controls.Add(this.tbGiaGoc);
            this.NhapKhpo.Controls.Add(this.cbMaMH);
            this.NhapKhpo.Controls.Add(this.Label10);
            this.NhapKhpo.Controls.Add(this.GroupBox2);
            this.NhapKhpo.Controls.Add(this.GroupBox1);
            this.NhapKhpo.Controls.Add(this.tbGhiChu);
            this.NhapKhpo.Controls.Add(this.Label11);
            this.NhapKhpo.Controls.Add(this.cbSoPhieu);
            this.NhapKhpo.Controls.Add(this.dtNgayNhap);
            this.NhapKhpo.Controls.Add(this.btMoi);
            this.NhapKhpo.Controls.Add(this.btGiaMoi);
            this.NhapKhpo.Controls.Add(this.lbDonVi);
            this.NhapKhpo.Controls.Add(this.tbDGnb);
            this.NhapKhpo.Controls.Add(this.tbDonGia);
            this.NhapKhpo.Controls.Add(this.Label8);
            this.NhapKhpo.Controls.Add(this.tbSLThem);
            this.NhapKhpo.Controls.Add(this.Label7);
            this.NhapKhpo.Controls.Add(this.tbSLCu);
            this.NhapKhpo.Controls.Add(this.Label6);
            this.NhapKhpo.Controls.Add(this.cbTenMH);
            this.NhapKhpo.Controls.Add(this.Label5);
            this.NhapKhpo.Controls.Add(this.Label4);
            this.NhapKhpo.Controls.Add(this.Label3);
            this.NhapKhpo.Controls.Add(this.Label2);
            this.NhapKhpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NhapKhpo.Location = new System.Drawing.Point(0, 0);
            this.NhapKhpo.Name = "NhapKhpo";
            this.NhapKhpo.Size = new System.Drawing.Size(983, 134);
            this.NhapKhpo.TabIndex = 0;
            this.NhapKhpo.TabStop = false;
            this.NhapKhpo.Text = "Nhập Kho:";
            // 
            // tbDonGia
            // 
            this.tbDonGia.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(541, 41);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.ReadOnly = true;
            this.tbDonGia.Size = new System.Drawing.Size(82, 22);
            this.tbDonGia.TabIndex = 12;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(457, 43);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(80, 15);
            this.Label8.TabIndex = 11;
            this.Label8.Text = "Đơn Giá Bán:";
            // 
            // tbSLThem
            // 
            this.tbSLThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSLThem.ForeColor = System.Drawing.Color.Red;
            this.tbSLThem.Location = new System.Drawing.Point(742, 13);
            this.tbSLThem.Name = "tbSLThem";
            this.tbSLThem.Size = new System.Drawing.Size(93, 22);
            this.tbSLThem.TabIndex = 10;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(698, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 15);
            this.Label7.TabIndex = 9;
            this.Label7.Text = "Thêm:";
            // 
            // tbSLCu
            // 
            this.tbSLCu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbSLCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSLCu.Location = new System.Drawing.Point(541, 13);
            this.tbSLCu.Name = "tbSLCu";
            this.tbSLCu.ReadOnly = true;
            this.tbSLCu.Size = new System.Drawing.Size(155, 22);
            this.tbSLCu.TabIndex = 8;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(458, 16);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(81, 15);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Số Lượng Cũ:";
            // 
            // cbTenMH
            // 
            this.cbTenMH.DisplayMember = "TenMH";
            this.cbTenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(113, 39);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(316, 24);
            this.cbTenMH.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(33, 73);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(51, 15);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Mã MH:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(33, 42);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(54, 15);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Tên MH:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(224, 15);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(60, 15);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Số Phiếu:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(33, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 15);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Ngày Nhập";
            // 
            // frmNhapHangVaoKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 607);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmNhapHangVaoKho";
            this.Text = "frmNhapHangVaoKho";
            this.lbThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.NhapKhpo.ResumeLayout(false);
            this.NhapKhpo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox lbThongTin;
        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        internal System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        internal System.Windows.Forms.TextBox tbGhiChu;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.ComboBox cbSoPhieu;
        internal System.Windows.Forms.DateTimePicker dtNgayNhap;
        internal System.Windows.Forms.Button btMoi;
        internal System.Windows.Forms.Button btGiaMoi;
        internal System.Windows.Forms.Label lbDonVi;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button tbXem;
        internal System.Windows.Forms.Button btSua;
        internal System.Windows.Forms.Button tbRefesh;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox tbGGnb;
        internal System.Windows.Forms.TextBox tbGiaGoc;
        internal System.Windows.Forms.ComboBox cbMaMH;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btThem;
        internal System.Windows.Forms.Button btLuu;
        internal System.Windows.Forms.Button btClose;
        internal System.Windows.Forms.TextBox tbDGnb;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label lbChinh;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox NhapKhpo;
        internal System.Windows.Forms.TextBox tbDonGia;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tbSLThem;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox tbSLCu;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbTenMH;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}