namespace QLK
{
    partial class frmXemTonKho
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
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.tbIn = new System.Windows.Forms.Button();
            this.tbMaNMH = new System.Windows.Forms.TextBox();
            this.btRefesh = new System.Windows.Forms.Button();
            this.tbXem = new System.Windows.Forms.Button();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbTenMH = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.cbNhomMH = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTongBH = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TongTien});
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvInfor.Location = new System.Drawing.Point(3, 13);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.ReadOnly = true;
            this.dgvInfor.RowHeadersWidth = 35;
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfor.Size = new System.Drawing.Size(983, 407);
            this.dgvInfor.TabIndex = 0;
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle1;
            this.TongTien.FillWeight = 95.13553F;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            this.TongTien.ReadOnly = true;
            this.TongTien.Width = 90;
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBox3.Location = new System.Drawing.Point(598, 64);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.ReadOnly = true;
            this.TextBox3.Size = new System.Drawing.Size(236, 20);
            this.TextBox3.TabIndex = 13;
            // 
            // TextBox2
            // 
            this.TextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBox2.Location = new System.Drawing.Point(598, 39);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.ReadOnly = true;
            this.TextBox2.Size = new System.Drawing.Size(236, 20);
            this.TextBox2.TabIndex = 13;
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.TextBox1.Location = new System.Drawing.Point(598, 14);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.ReadOnly = true;
            this.TextBox1.Size = new System.Drawing.Size(236, 20);
            this.TextBox1.TabIndex = 13;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(521, 67);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(42, 13);
            this.Label7.TabIndex = 12;
            this.Label7.Text = "Đơn Vị:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(521, 42);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(56, 13);
            this.Label6.TabIndex = 11;
            this.Label6.Text = "Số Lượng:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(521, 17);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(49, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Đơn Giá:";
            // 
            // tbIn
            // 
            this.tbIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIn.ForeColor = System.Drawing.Color.Blue;
            this.tbIn.Location = new System.Drawing.Point(859, 62);
            this.tbIn.Name = "tbIn";
            this.tbIn.Size = new System.Drawing.Size(98, 23);
            this.tbIn.TabIndex = 9;
            this.tbIn.Text = "In";
            this.tbIn.UseVisualStyleBackColor = true;
            // 
            // tbMaNMH
            // 
            this.tbMaNMH.BackColor = System.Drawing.SystemColors.Info;
            this.tbMaNMH.Location = new System.Drawing.Point(387, 14);
            this.tbMaNMH.Name = "tbMaNMH";
            this.tbMaNMH.ReadOnly = true;
            this.tbMaNMH.Size = new System.Drawing.Size(52, 20);
            this.tbMaNMH.TabIndex = 8;
            // 
            // btRefesh
            // 
            this.btRefesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRefesh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btRefesh.Location = new System.Drawing.Point(859, 37);
            this.btRefesh.Name = "btRefesh";
            this.btRefesh.Size = new System.Drawing.Size(98, 23);
            this.btRefesh.TabIndex = 7;
            this.btRefesh.Text = "Làm Mới";
            this.btRefesh.UseVisualStyleBackColor = true;
            // 
            // tbXem
            // 
            this.tbXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbXem.Location = new System.Drawing.Point(859, 13);
            this.tbXem.Name = "tbXem";
            this.tbXem.Size = new System.Drawing.Size(98, 23);
            this.tbXem.TabIndex = 6;
            this.tbXem.Text = "Xem";
            this.tbXem.UseVisualStyleBackColor = true;
            // 
            // cbMaMH
            // 
            this.cbMaMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbMaMH.DisplayMember = "MaMH";
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(163, 64);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(276, 21);
            this.cbMaMH.TabIndex = 5;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(71, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(75, 13);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Mã Mặt Hàng:\r\n";
            // 
            // cbTenMH
            // 
            this.cbTenMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cbTenMH.DisplayMember = "TenMH";
            this.cbTenMH.FormattingEnabled = true;
            this.cbTenMH.Location = new System.Drawing.Point(163, 38);
            this.cbTenMH.Name = "cbTenMH";
            this.cbTenMH.Size = new System.Drawing.Size(276, 21);
            this.cbTenMH.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(72, 41);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Tên Mặt Hàng:\r\n";
            // 
            // cbNhomMH
            // 
            this.cbNhomMH.DisplayMember = "TenNhom";
            this.cbNhomMH.FormattingEnabled = true;
            this.cbNhomMH.Location = new System.Drawing.Point(163, 13);
            this.cbNhomMH.Name = "cbNhomMH";
            this.cbNhomMH.Size = new System.Drawing.Size(218, 21);
            this.cbNhomMH.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(72, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nhóm Mặt Hàng:\r\n";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Controls.Add(this.TextBox2);
            this.GroupBox1.Controls.Add(this.TextBox1);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.tbIn);
            this.GroupBox1.Controls.Add(this.tbMaNMH);
            this.GroupBox1.Controls.Add(this.btRefesh);
            this.GroupBox1.Controls.Add(this.tbXem);
            this.GroupBox1.Controls.Add(this.cbMaMH);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cbTenMH);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.cbNhomMH);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(989, 96);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // lbTongBH
            // 
            this.lbTongBH.AutoSize = true;
            this.lbTongBH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongBH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbTongBH.Location = new System.Drawing.Point(596, 9);
            this.lbTongBH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTongBH.Name = "lbTongBH";
            this.lbTongBH.Size = new System.Drawing.Size(69, 13);
            this.lbTongBH.TabIndex = 1;
            this.lbTongBH.Text = "Tổng Tiền:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Purple;
            this.Label4.Location = new System.Drawing.Point(4, 4);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(267, 24);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "XEM TỒN KHO MẶT HÀNG";
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
            this.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.SplitContainer2.Panel1.Controls.Add(this.lbTongBH);
            this.SplitContainer2.Panel1.Controls.Add(this.Label4);
            // 
            // SplitContainer2.Panel2
            // 
            this.SplitContainer2.Panel2.Controls.Add(this.GroupBox1);
            this.SplitContainer2.Size = new System.Drawing.Size(989, 122);
            this.SplitContainer2.SplitterDistance = 25;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Controls.Add(this.dgvInfor);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.GroupBox2.Size = new System.Drawing.Size(989, 423);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
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
            this.SplitContainer1.Panel1.Controls.Add(this.SplitContainer2);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.GroupBox2);
            this.SplitContainer1.Size = new System.Drawing.Size(989, 546);
            this.SplitContainer1.SplitterDistance = 122;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // frmXemTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 546);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmXemTonKho";
            this.Text = "frmXemTonKho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel1.PerformLayout();
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button tbIn;
        internal System.Windows.Forms.TextBox tbMaNMH;
        internal System.Windows.Forms.Button btRefesh;
        internal System.Windows.Forms.Button tbXem;
        internal System.Windows.Forms.ComboBox cbMaMH;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbTenMH;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox cbNhomMH;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lbTongBH;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
    }
}