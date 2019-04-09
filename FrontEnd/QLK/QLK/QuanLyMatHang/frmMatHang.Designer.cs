namespace QLK
{
    partial class frmMatHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DonGiaGoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDGGocNb = new System.Windows.Forms.TextBox();
            this.tbDGBanNb = new System.Windows.Forms.TextBox();
            this.tbDgGoc = new System.Windows.Forms.TextBox();
            this.TableMatHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label11 = new System.Windows.Forms.Label();
            this.tbSL = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.tbF5 = new System.Windows.Forms.Button();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.tbMaMH = new System.Windows.Forms.TextBox();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.tbTenMH = new System.Windows.Forms.TextBox();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.TableDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btThem = new System.Windows.Forms.Button();
            this.tbDacDiem = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btSua = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.cbTenNhomMH = new System.Windows.Forms.ComboBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.cbMaNhomMH = new System.Windows.Forms.ComboBox();
            this.tbCongTy = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTenDV = new System.Windows.Forms.ComboBox();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Label9 = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.TableMatHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDonViTinhBindingSource)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DonGiaGoc
            // 
            this.DonGiaGoc.DataPropertyName = "DonGiaGoc";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.DonGiaGoc.DefaultCellStyle = dataGridViewCellStyle1;
            this.DonGiaGoc.HeaderText = "Đơn Giá Gốc";
            this.DonGiaGoc.Name = "DonGiaGoc";
            this.DonGiaGoc.ReadOnly = true;
            this.DonGiaGoc.Width = 70;
            // 
            // tbDGGocNb
            // 
            this.tbDGGocNb.Location = new System.Drawing.Point(590, 43);
            this.tbDGGocNb.Name = "tbDGGocNb";
            this.tbDGGocNb.Size = new System.Drawing.Size(129, 21);
            this.tbDGGocNb.TabIndex = 27;
            // 
            // tbDGBanNb
            // 
            this.tbDGBanNb.Location = new System.Drawing.Point(590, 12);
            this.tbDGBanNb.Name = "tbDGBanNb";
            this.tbDGBanNb.Size = new System.Drawing.Size(129, 21);
            this.tbDGBanNb.TabIndex = 27;
            // 
            // tbDgGoc
            // 
            this.tbDgGoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDgGoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TableMatHangBindingSource, "DonGiaGoc", true));
            this.tbDgGoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDgGoc.ForeColor = System.Drawing.Color.Black;
            this.tbDgGoc.Location = new System.Drawing.Point(463, 42);
            this.tbDgGoc.Name = "tbDgGoc";
            this.tbDgGoc.Size = new System.Drawing.Size(126, 22);
            this.tbDgGoc.TabIndex = 26;
            // 
            // TableMatHangBindingSource
            // 
            this.TableMatHangBindingSource.DataMember = "TableMatHang";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(398, 47);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(53, 15);
            this.Label11.TabIndex = 25;
            this.Label11.Text = "ĐG Gốc:";
            // 
            // tbSL
            // 
            this.tbSL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbSL.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TableMatHangBindingSource, "SoLuong", true));
            this.tbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSL.ForeColor = System.Drawing.Color.Red;
            this.tbSL.Location = new System.Drawing.Point(464, 70);
            this.tbSL.Name = "tbSL";
            this.tbSL.ReadOnly = true;
            this.tbSL.Size = new System.Drawing.Size(101, 22);
            this.tbSL.TabIndex = 24;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(398, 74);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(63, 15);
            this.Label10.TabIndex = 23;
            this.Label10.Text = "Số Lượng:";
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(828, 86);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(84, 23);
            this.btDong.TabIndex = 22;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            // 
            // tbF5
            // 
            this.tbF5.Location = new System.Drawing.Point(828, 54);
            this.tbF5.Name = "tbF5";
            this.tbF5.Size = new System.Drawing.Size(84, 23);
            this.tbF5.TabIndex = 21;
            this.tbF5.Text = "F5";
            this.tbF5.UseVisualStyleBackColor = true;
            // 
            // cbMaMH
            // 
            this.cbMaMH.DataSource = this.TableMatHangBindingSource;
            this.cbMaMH.DisplayMember = "MaMH";
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(116, 41);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(108, 23);
            this.cbMaMH.TabIndex = 3;
            // 
            // tbMaMH
            // 
            this.tbMaMH.Location = new System.Drawing.Point(116, 41);
            this.tbMaMH.Name = "tbMaMH";
            this.tbMaMH.Size = new System.Drawing.Size(108, 21);
            this.tbMaMH.TabIndex = 0;
            // 
            // cbTenMH
            // 
            this.cbTenMH.DataSource = this.TableMatHangBindingSource;
            this.cbTenMH.DisplayMember = "TenMH";
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(116, 12);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(238, 23);
            this.cbTenMH.TabIndex = 2;
            // 
            // tbTenMH
            // 
            this.tbTenMH.Location = new System.Drawing.Point(116, 13);
            this.tbTenMH.Name = "tbTenMH";
            this.tbTenMH.Size = new System.Drawing.Size(238, 21);
            this.tbTenMH.TabIndex = 20;
            this.tbTenMH.Visible = false;
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AutoGenerateColumns = false;
            this.dgvInfor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DonGiaGoc});
            this.dgvInfor.DataSource = this.TableMatHangBindingSource;
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvInfor.Location = new System.Drawing.Point(3, 16);
            this.dgvInfor.MultiSelect = false;
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.ReadOnly = true;
            this.dgvInfor.RowHeadersWidth = 30;
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfor.Size = new System.Drawing.Size(936, 396);
            this.dgvInfor.TabIndex = 0;
            // 
            // TableDonViTinhBindingSource
            // 
            this.TableDonViTinhBindingSource.DataMember = "TableDonViTinh";
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Blue;
            this.btThem.Location = new System.Drawing.Point(737, 20);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(84, 23);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // tbDacDiem
            // 
            this.tbDacDiem.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TableMatHangBindingSource, "DacDiem", true));
            this.tbDacDiem.Location = new System.Drawing.Point(463, 99);
            this.tbDacDiem.Name = "tbDacDiem";
            this.tbDacDiem.ReadOnly = true;
            this.tbDacDiem.Size = new System.Drawing.Size(258, 21);
            this.tbDacDiem.TabIndex = 18;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(398, 102);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(65, 15);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Đặc Điểm:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Tên Mặt Hàng:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Mã Mặt Hàng:";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Blue;
            this.btXoa.Location = new System.Drawing.Point(737, 86);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(84, 23);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.Blue;
            this.btLuu.Location = new System.Drawing.Point(828, 20);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(84, 23);
            this.btLuu.TabIndex = 14;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dgvInfor);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(942, 415);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Blue;
            this.btSua.Location = new System.Drawing.Point(737, 54);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(84, 23);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(399, 16);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(53, 15);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "ĐG Bán:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 73);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(91, 15);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Tên Nhóm MH:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(565, 75);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(54, 15);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Công Ty:";
            // 
            // cbTenNhomMH
            // 
            this.cbTenNhomMH.DisplayMember = "TenNhom";
            this.cbTenNhomMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenNhomMH.FormattingEnabled = true;
            this.cbTenNhomMH.Location = new System.Drawing.Point(116, 70);
            this.cbTenNhomMH.Name = "cbTenNhomMH";
            this.cbTenNhomMH.Size = new System.Drawing.Size(238, 23);
            this.cbTenNhomMH.TabIndex = 5;
            // 
            // tbDonGia
            // 
            this.tbDonGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDonGia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TableMatHangBindingSource, "DonGia", true));
            this.tbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDonGia.Location = new System.Drawing.Point(464, 12);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.ReadOnly = true;
            this.tbDonGia.Size = new System.Drawing.Size(125, 22);
            this.tbDonGia.TabIndex = 11;
            // 
            // cbMaNhomMH
            // 
            this.cbMaNhomMH.DisplayMember = "MaNhom";
            this.cbMaNhomMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhomMH.FormattingEnabled = true;
            this.cbMaNhomMH.Location = new System.Drawing.Point(116, 99);
            this.cbMaNhomMH.Name = "cbMaNhomMH";
            this.cbMaNhomMH.Size = new System.Drawing.Size(238, 23);
            this.cbMaNhomMH.TabIndex = 6;
            // 
            // tbCongTy
            // 
            this.tbCongTy.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.TableMatHangBindingSource, "MaCT", true));
            this.tbCongTy.Location = new System.Drawing.Point(622, 71);
            this.tbCongTy.Name = "tbCongTy";
            this.tbCongTy.ReadOnly = true;
            this.tbCongTy.Size = new System.Drawing.Size(97, 21);
            this.tbCongTy.TabIndex = 10;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(24, 102);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(85, 15);
            this.Label4.TabIndex = 7;
            this.Label4.Text = "Mã Nhóm MH";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(226, 46);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(46, 15);
            this.Label5.TabIndex = 9;
            this.Label5.Text = "Đơn Vị:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Controls.Add(this.tbDGGocNb);
            this.GroupBox2.Controls.Add(this.tbDGBanNb);
            this.GroupBox2.Controls.Add(this.tbDgGoc);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.tbSL);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.btDong);
            this.GroupBox2.Controls.Add(this.tbF5);
            this.GroupBox2.Controls.Add(this.cbMaMH);
            this.GroupBox2.Controls.Add(this.tbMaMH);
            this.GroupBox2.Controls.Add(this.cbTenMH);
            this.GroupBox2.Controls.Add(this.tbTenMH);
            this.GroupBox2.Controls.Add(this.btThem);
            this.GroupBox2.Controls.Add(this.tbDacDiem);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.btSua);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btXoa);
            this.GroupBox2.Controls.Add(this.btLuu);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.cbTenNhomMH);
            this.GroupBox2.Controls.Add(this.tbDonGia);
            this.GroupBox2.Controls.Add(this.cbMaNhomMH);
            this.GroupBox2.Controls.Add(this.tbCongTy);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.cbTenDV);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.GroupBox2.Size = new System.Drawing.Size(942, 130);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            // 
            // cbTenDV
            // 
            this.cbTenDV.DataSource = this.TableDonViTinhBindingSource;
            this.cbTenDV.DisplayMember = "MaDV";
            this.cbTenDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTenDV.FormattingEnabled = true;
            this.cbTenDV.Location = new System.Drawing.Point(275, 41);
            this.cbTenDV.Name = "cbTenDV";
            this.cbTenDV.Size = new System.Drawing.Size(80, 23);
            this.cbTenDV.TabIndex = 8;
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
            this.SplitContainer2.Panel1.Controls.Add(this.GroupBox2);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer2.Size = new System.Drawing.Size(942, 546);
            this.SplitContainer2.SplitterDistance = 130;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Purple;
            this.Label9.Location = new System.Drawing.Point(-1, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(119, 24);
            this.Label9.TabIndex = 2;
            this.Label9.Text = "MẶT HÀNG";
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
            this.SplitContainer1.Panel1.Controls.Add(this.Label9);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(942, 572);
            this.SplitContainer1.SplitterDistance = 25;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // frmMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 572);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmMatHang";
            this.Text = "frmMatHang";
            ((System.ComponentModel.ISupportInitialize)(this.TableMatHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDonViTinhBindingSource)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn DonGiaGoc;
        internal System.Windows.Forms.TextBox tbDGGocNb;
        internal System.Windows.Forms.TextBox tbDGBanNb;
        internal System.Windows.Forms.TextBox tbDgGoc;
        internal System.Windows.Forms.BindingSource TableMatHangBindingSource;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox tbSL;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button btDong;
        internal System.Windows.Forms.Button tbF5;
        internal System.Windows.Forms.ComboBox cbMaMH;
        internal System.Windows.Forms.TextBox tbMaMH;
        internal System.Windows.Forms.ComboBox cbTenMH;
        internal System.Windows.Forms.TextBox tbTenMH;
        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.BindingSource TableDonViTinhBindingSource;
        internal System.Windows.Forms.Button btThem;
        internal System.Windows.Forms.TextBox tbDacDiem;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btXoa;
        internal System.Windows.Forms.Button btLuu;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btSua;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ComboBox cbTenNhomMH;
        internal System.Windows.Forms.TextBox tbDonGia;
        internal System.Windows.Forms.ComboBox cbMaNhomMH;
        internal System.Windows.Forms.TextBox tbCongTy;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox cbTenDV;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}