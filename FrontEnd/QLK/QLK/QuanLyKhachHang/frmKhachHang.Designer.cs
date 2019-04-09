namespace QLK
{
    partial class frmKhachHang
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
            this.Label9 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.btIn = new System.Windows.Forms.Button();
            this.btF5 = new System.Windows.Forms.Button();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.btSua = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Purple;
            this.Label9.Location = new System.Drawing.Point(3, -1);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(146, 24);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "KHÁCH HÀNG";
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
            this.SplitContainer2.Size = new System.Drawing.Size(982, 535);
            this.SplitContainer2.SplitterDistance = 331;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Controls.Add(this.cbTenKH);
            this.GroupBox2.Controls.Add(this.cbMaKH);
            this.GroupBox2.Controls.Add(this.btIn);
            this.GroupBox2.Controls.Add(this.btF5);
            this.GroupBox2.Controls.Add(this.tbTenKH);
            this.GroupBox2.Controls.Add(this.tbMaKH);
            this.GroupBox2.Controls.Add(this.btThem);
            this.GroupBox2.Controls.Add(this.tbGhiChu);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.btSua);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.btXoa);
            this.GroupBox2.Controls.Add(this.btLuu);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.tbSDT);
            this.GroupBox2.Controls.Add(this.tbDC);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.GroupBox2.Size = new System.Drawing.Size(331, 535);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            // 
            // cbTenKH
            // 
            this.cbTenKH.DisplayMember = "TenKH";
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Location = new System.Drawing.Point(68, 50);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(250, 23);
            this.cbTenKH.TabIndex = 3;
            // 
            // cbMaKH
            // 
            this.cbMaKH.DisplayMember = "MaKH";
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(68, 17);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(250, 23);
            this.cbMaKH.TabIndex = 2;
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(241, 214);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(80, 23);
            this.btIn.TabIndex = 22;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // btF5
            // 
            this.btF5.Location = new System.Drawing.Point(241, 180);
            this.btF5.Name = "btF5";
            this.btF5.Size = new System.Drawing.Size(80, 23);
            this.btF5.TabIndex = 21;
            this.btF5.Text = "F5";
            this.btF5.UseVisualStyleBackColor = true;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(68, 51);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(250, 21);
            this.tbTenKH.TabIndex = 0;
            this.tbTenKH.Visible = false;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(68, 17);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(250, 21);
            this.tbMaKH.TabIndex = 20;
            this.tbMaKH.Visible = false;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Blue;
            this.btThem.Location = new System.Drawing.Point(68, 180);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(80, 23);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(68, 143);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.ReadOnly = true;
            this.tbGhiChu.Size = new System.Drawing.Size(250, 21);
            this.tbGhiChu.TabIndex = 18;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(11, 146);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(54, 15);
            this.Label8.TabIndex = 17;
            this.Label8.Text = "Ghi Chú:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 15);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Mã KH:";
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Blue;
            this.btSua.Location = new System.Drawing.Point(68, 214);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(80, 23);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 53);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(51, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tên KH:";
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Blue;
            this.btXoa.Location = new System.Drawing.Point(154, 214);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(80, 23);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.Blue;
            this.btLuu.Location = new System.Drawing.Point(154, 180);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(80, 23);
            this.btLuu.TabIndex = 14;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(11, 116);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(44, 15);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Số ĐT:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(11, 86);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(50, 15);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "Địa Chỉ:";
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(68, 113);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.ReadOnly = true;
            this.tbSDT.Size = new System.Drawing.Size(250, 21);
            this.tbSDT.TabIndex = 11;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(68, 83);
            this.tbDC.Name = "tbDC";
            this.tbDC.ReadOnly = true;
            this.tbDC.Size = new System.Drawing.Size(250, 21);
            this.tbDC.TabIndex = 10;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dgvInfor);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(650, 535);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvInfor.Location = new System.Drawing.Point(3, 16);
            this.dgvInfor.MultiSelect = false;
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.ReadOnly = true;
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfor.Size = new System.Drawing.Size(644, 516);
            this.dgvInfor.TabIndex = 0;
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
            this.SplitContainer1.Size = new System.Drawing.Size(982, 566);
            this.SplitContainer1.SplitterDistance = 30;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 2;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 566);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.ComboBox cbTenKH;
        internal System.Windows.Forms.ComboBox cbMaKH;
        internal System.Windows.Forms.Button btIn;
        internal System.Windows.Forms.Button btF5;
        internal System.Windows.Forms.TextBox tbTenKH;
        internal System.Windows.Forms.TextBox tbMaKH;
        internal System.Windows.Forms.Button btThem;
        internal System.Windows.Forms.TextBox tbGhiChu;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btSua;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button btXoa;
        internal System.Windows.Forms.Button btLuu;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox tbSDT;
        internal System.Windows.Forms.TextBox tbDC;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}