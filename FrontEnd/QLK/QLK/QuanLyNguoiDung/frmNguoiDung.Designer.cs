namespace QLK
{
    partial class frmNguoiDung
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
            this.UserNameDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.tbNameDs = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.btF5 = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbChucNang = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Label9 = new System.Windows.Forms.Label();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
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
            // UserNameDetail
            // 
            this.UserNameDetail.DataPropertyName = "UserNameDetail";
            this.UserNameDetail.HeaderText = "Tên Người Dùng";
            this.UserNameDetail.Name = "UserNameDetail";
            this.UserNameDetail.ReadOnly = true;
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameDetail});
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.Location = new System.Drawing.Point(3, 16);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.ReadOnly = true;
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfor.Size = new System.Drawing.Size(475, 393);
            this.dgvInfor.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.dgvInfor);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(481, 412);
            this.GroupBox1.TabIndex = 1;
            this.GroupBox1.TabStop = false;
            // 
            // tbNameDs
            // 
            this.tbNameDs.Location = new System.Drawing.Point(68, 36);
            this.tbNameDs.Margin = new System.Windows.Forms.Padding(2);
            this.tbNameDs.Name = "tbNameDs";
            this.tbNameDs.ReadOnly = true;
            this.tbNameDs.Size = new System.Drawing.Size(172, 20);
            this.tbNameDs.TabIndex = 13;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 37);
            this.Label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(29, 13);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "Tên:";
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(167, 184);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(73, 23);
            this.btDong.TabIndex = 11;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            // 
            // btF5
            // 
            this.btF5.Location = new System.Drawing.Point(79, 184);
            this.btF5.Name = "btF5";
            this.btF5.Size = new System.Drawing.Size(73, 23);
            this.btF5.TabIndex = 10;
            this.btF5.Text = "F5";
            this.btF5.UseVisualStyleBackColor = true;
            // 
            // btLuu
            // 
            this.btLuu.Enabled = false;
            this.btLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLuu.ForeColor = System.Drawing.Color.DarkViolet;
            this.btLuu.Location = new System.Drawing.Point(167, 155);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(73, 23);
            this.btLuu.TabIndex = 9;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btXoa.Location = new System.Drawing.Point(79, 155);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(73, 23);
            this.btXoa.TabIndex = 8;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSua.Location = new System.Drawing.Point(167, 127);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(73, 23);
            this.btSua.TabIndex = 7;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btThem.Location = new System.Drawing.Point(79, 127);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(73, 23);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Mã NV:";
            // 
            // cbChucNang
            // 
            this.cbChucNang.Enabled = false;
            this.cbChucNang.FormattingEnabled = true;
            this.cbChucNang.Location = new System.Drawing.Point(68, 87);
            this.cbChucNang.Name = "cbChucNang";
            this.cbChucNang.Size = new System.Drawing.Size(172, 21);
            this.cbChucNang.TabIndex = 5;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 63);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Mật Khẩu:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 90);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(64, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Chức Năng:";
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(68, 12);
            this.tbTen.Name = "tbTen";
            this.tbTen.ReadOnly = true;
            this.tbTen.Size = new System.Drawing.Size(172, 20);
            this.tbTen.TabIndex = 2;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Location = new System.Drawing.Point(68, 60);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.ReadOnly = true;
            this.tbMatKhau.Size = new System.Drawing.Size(172, 20);
            this.tbMatKhau.TabIndex = 3;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Controls.Add(this.tbNameDs);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.btDong);
            this.GroupBox2.Controls.Add(this.btF5);
            this.GroupBox2.Controls.Add(this.btLuu);
            this.GroupBox2.Controls.Add(this.btXoa);
            this.GroupBox2.Controls.Add(this.btSua);
            this.GroupBox2.Controls.Add(this.btThem);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.cbChucNang);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.tbTen);
            this.GroupBox2.Controls.Add(this.tbMatKhau);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(315, 412);
            this.GroupBox2.TabIndex = 6;
            this.GroupBox2.TabStop = false;
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
            this.SplitContainer2.Size = new System.Drawing.Size(800, 412);
            this.SplitContainer2.SplitterDistance = 315;
            this.SplitContainer2.TabIndex = 0;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Purple;
            this.Label9.Location = new System.Drawing.Point(3, 4);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(149, 24);
            this.Label9.TabIndex = 3;
            this.Label9.Text = "NGƯỜI DÙNG";
            // 
            // SplitContainer1
            // 
            this.SplitContainer1.BackColor = System.Drawing.SystemColors.Control;
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
            this.SplitContainer1.Size = new System.Drawing.Size(800, 450);
            this.SplitContainer1.SplitterDistance = 34;
            this.SplitContainer1.TabIndex = 1;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
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

        internal System.Windows.Forms.DataGridViewTextBoxColumn UserNameDetail;
        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox tbNameDs;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btDong;
        internal System.Windows.Forms.Button btF5;
        internal System.Windows.Forms.Button btLuu;
        internal System.Windows.Forms.Button btXoa;
        internal System.Windows.Forms.Button btSua;
        internal System.Windows.Forms.Button btThem;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbChucNang;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox tbTen;
        internal System.Windows.Forms.TextBox tbMatKhau;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}