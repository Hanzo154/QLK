namespace QLK
{
    partial class frmDonViTinh
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
            this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvInfor = new System.Windows.Forms.DataGridView();
            this.TableDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
            this.SplitContainer1.Panel1.SuspendLayout();
            this.SplitContainer1.Panel2.SuspendLayout();
            this.SplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDonViTinhBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.SplitContainer1.Panel1.Controls.Add(this.Label1);
            // 
            // SplitContainer1.Panel2
            // 
            this.SplitContainer1.Panel2.Controls.Add(this.dgvInfor);
            this.SplitContainer1.Size = new System.Drawing.Size(548, 394);
            this.SplitContainer1.SplitterDistance = 32;
            this.SplitContainer1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Purple;
            this.Label1.Location = new System.Drawing.Point(3, 4);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(188, 24);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "NHÓM MẶT HÀNG";
            // 
            // dgvInfor
            // 
            this.dgvInfor.AllowUserToAddRows = false;
            this.dgvInfor.AutoGenerateColumns = false;
            this.dgvInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfor.DataSource = this.TableDonViTinhBindingSource;
            this.dgvInfor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInfor.Location = new System.Drawing.Point(0, 0);
            this.dgvInfor.Name = "dgvInfor";
            this.dgvInfor.RowTemplate.Height = 24;
            this.dgvInfor.Size = new System.Drawing.Size(548, 358);
            this.dgvInfor.TabIndex = 0;
            // 
            // TableDonViTinhBindingSource
            // 
            this.TableDonViTinhBindingSource.DataMember = "TableDonViTinh";
            // 
            // frmDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 394);
            this.Controls.Add(this.SplitContainer1);
            this.Name = "frmDonViTinh";
            this.Text = "frmDonViTinh";
            this.SplitContainer1.Panel1.ResumeLayout(false);
            this.SplitContainer1.Panel1.PerformLayout();
            this.SplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
            this.SplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableDonViTinhBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.SplitContainer SplitContainer1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgvInfor;
        internal System.Windows.Forms.BindingSource TableDonViTinhBindingSource;
    }
}