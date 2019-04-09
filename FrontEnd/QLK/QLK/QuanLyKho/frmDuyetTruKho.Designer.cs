namespace QLK
{
    partial class frmDuyetTruKho
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
            this.NguoiLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maketer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btXem = new System.Windows.Forms.Button();
            this.btDK = new System.Windows.Forms.Button();
            this.tbToDate = new System.Windows.Forms.MaskedTextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.tbFromDate = new System.Windows.Forms.MaskedTextBox();
            this.tbMaDH = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.cbDK = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDuyetKho = new System.Windows.Forms.DataGridView();
            this.chkChonALL = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
            this.SplitContainer2.Panel1.SuspendLayout();
            this.SplitContainer2.Panel2.SuspendLayout();
            this.SplitContainer2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyetKho)).BeginInit();
            this.SuspendLayout();
            // 
            // NguoiLap
            // 
            this.NguoiLap.DataPropertyName = "NguoiLap";
            this.NguoiLap.HeaderText = "Người Lập";
            this.NguoiLap.Name = "NguoiLap";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            this.TenKH.Width = 110;
            // 
            // Maketer
            // 
            this.Maketer.DataPropertyName = "Maketer";
            this.Maketer.HeaderText = "Maketer";
            this.Maketer.Name = "Maketer";
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
            this.SplitContainer1.Panel1.Controls.Add(this.Label6);
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            this.SplitContainer1.Panel1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.SplitContainer2);
            this.SplitContainer1.Size = new System.Drawing.Size(969, 517);
            this.SplitContainer1.SplitterDistance = 33;
            this.SplitContainer1.SplitterWidth = 1;
            this.SplitContainer1.TabIndex = 1;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label6.Location = new System.Drawing.Point(551, 13);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(407, 14);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "Khi duyệt kho thì không được nhập hay xuất hàng vào hệ thống";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.Purple;
            this.Label1.Location = new System.Drawing.Point(3, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(347, 24);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "XEM PHIẾU HÀNG VÀ DUYỆT KHO";
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
            this.SplitContainer2.Panel2.Controls.Add(this.GroupBox2);
            this.SplitContainer2.Size = new System.Drawing.Size(969, 483);
            this.SplitContainer2.SplitterDistance = 63;
            this.SplitContainer2.SplitterWidth = 1;
            this.SplitContainer2.TabIndex = 0;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox1.Controls.Add(this.btXem);
            this.GroupBox1.Controls.Add(this.btDK);
            this.GroupBox1.Controls.Add(this.tbToDate);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.tbFromDate);
            this.GroupBox1.Controls.Add(this.tbMaDH);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.cbDK);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(969, 63);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            // 
            // btXem
            // 
            this.btXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXem.ForeColor = System.Drawing.Color.Navy;
            this.btXem.Location = new System.Drawing.Point(712, 35);
            this.btXem.Name = "btXem";
            this.btXem.Size = new System.Drawing.Size(133, 23);
            this.btXem.TabIndex = 9;
            this.btXem.Text = "Xem";
            this.btXem.UseVisualStyleBackColor = true;
            // 
            // btDK
            // 
            this.btDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDK.ForeColor = System.Drawing.Color.Navy;
            this.btDK.Location = new System.Drawing.Point(712, 10);
            this.btDK.Name = "btDK";
            this.btDK.Size = new System.Drawing.Size(133, 23);
            this.btDK.TabIndex = 8;
            this.btDK.Text = "Duyệt Kho";
            this.btDK.UseVisualStyleBackColor = true;
            // 
            // tbToDate
            // 
            this.tbToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToDate.Location = new System.Drawing.Point(513, 35);
            this.tbToDate.Mask = "00/00/0000";
            this.tbToDate.Name = "tbToDate";
            this.tbToDate.Size = new System.Drawing.Size(143, 22);
            this.tbToDate.TabIndex = 7;
            this.tbToDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbToDate.ValidatingType = typeof(System.DateTime);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(358, 39);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(148, 16);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Đến Ngày dd/mm/yyyy:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(358, 14);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(140, 16);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Từ Ngày dd/mm/yyyy:";
            // 
            // tbFromDate
            // 
            this.tbFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFromDate.Location = new System.Drawing.Point(513, 11);
            this.tbFromDate.Mask = "00/00/0000";
            this.tbFromDate.Name = "tbFromDate";
            this.tbFromDate.Size = new System.Drawing.Size(143, 22);
            this.tbFromDate.TabIndex = 4;
            this.tbFromDate.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.tbFromDate.ValidatingType = typeof(System.DateTime);
            // 
            // tbMaDH
            // 
            this.tbMaDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaDH.Location = new System.Drawing.Point(112, 36);
            this.tbMaDH.Name = "tbMaDH";
            this.tbMaDH.Size = new System.Drawing.Size(155, 22);
            this.tbMaDH.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(40, 38);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(53, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Tag = "";
            this.Label3.Text = "Mã DH:";
            // 
            // cbDK
            // 
            this.cbDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDK.FormattingEnabled = true;
            this.cbDK.Location = new System.Drawing.Point(112, 11);
            this.cbDK.Name = "cbDK";
            this.cbDK.Size = new System.Drawing.Size(155, 24);
            this.cbDK.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(39, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Duyệt Kho:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.GroupBox2.Controls.Add(this.chkChonALL);
            this.GroupBox2.Controls.Add(this.dgvDuyetKho);
            this.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(969, 419);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            // 
            // dgvDuyetKho
            // 
            this.dgvDuyetKho.AllowUserToAddRows = false;
            this.dgvDuyetKho.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvDuyetKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuyetKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKH,
            this.Maketer,
            this.NguoiLap});
            this.dgvDuyetKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDuyetKho.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dgvDuyetKho.Location = new System.Drawing.Point(3, 16);
            this.dgvDuyetKho.Name = "dgvDuyetKho";
            this.dgvDuyetKho.RowHeadersWidth = 30;
            this.dgvDuyetKho.RowTemplate.Height = 24;
            this.dgvDuyetKho.Size = new System.Drawing.Size(963, 400);
            this.dgvDuyetKho.TabIndex = 0;
            // 
            // chkChonALL
            // 
            this.chkChonALL.AutoSize = true;
            this.chkChonALL.BackColor = System.Drawing.SystemColors.Control;
            this.chkChonALL.Location = new System.Drawing.Point(71, 27);
            this.chkChonALL.Name = "chkChonALL";
            this.chkChonALL.Size = new System.Drawing.Size(45, 17);
            this.chkChonALL.TabIndex = 1;
            this.chkChonALL.Text = "ALL";
            this.chkChonALL.UseVisualStyleBackColor = false;
            // 
            // frmDuyetTruKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 517);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmDuyetTruKho";
            this.Text = "frmDuyetTruKho";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            this.SplitContainer2.Panel1.ResumeLayout(false);
            this.SplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
            this.SplitContainer2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuyetKho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridViewTextBoxColumn NguoiLap;
        internal System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Maketer;
        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.SplitContainer SplitContainer2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btXem;
        internal System.Windows.Forms.Button btDK;
        internal System.Windows.Forms.MaskedTextBox tbToDate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.MaskedTextBox tbFromDate;
        internal System.Windows.Forms.TextBox tbMaDH;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cbDK;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.CheckBox chkChonALL;
        internal System.Windows.Forms.DataGridView dgvDuyetKho;
    }
}