namespace QLphongGYM.Layout
{
    partial class GoiCuaKhach
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGoiKhach = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mãKháchHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãGóiTậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyBĐDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyKTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hLVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhToanYNDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kHACHGOIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet_GoiCuaKhach = new QLphongGYM.DATA.GYMDataSet_GoiCuaKhach();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kHACH_GOITableAdapter = new QLphongGYM.DATA.GYMDataSet_GoiCuaKhachTableAdapters.KHACH_GOITableAdapter();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGoiKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHGOIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_GoiCuaKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "         Tìm kiếm";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(767, 14);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(107, 35);
            this.bunifuFlatButton4.TabIndex = 61;
            this.bunifuFlatButton4.Text = "         Tìm kiếm";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dataGoiKhach
            // 
            this.dataGoiKhach.AllowUserToAddRows = false;
            this.dataGoiKhach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGoiKhach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGoiKhach.AutoGenerateColumns = false;
            this.dataGoiKhach.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGoiKhach.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGoiKhach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGoiKhach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGoiKhach.ColumnHeadersHeight = 25;
            this.dataGoiKhach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãKháchHàngDataGridViewTextBoxColumn,
            this.mãGóiTậpDataGridViewTextBoxColumn,
            this.ngàyBĐDataGridViewTextBoxColumn,
            this.ngàyKTDataGridViewTextBoxColumn,
            this.hLVDataGridViewTextBoxColumn,
            this.thanhToanYNDataGridViewCheckBoxColumn});
            this.dataGoiKhach.DataSource = this.kHACHGOIBindingSource;
            this.dataGoiKhach.DoubleBuffered = true;
            this.dataGoiKhach.EnableHeadersVisualStyles = false;
            this.dataGoiKhach.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGoiKhach.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGoiKhach.Location = new System.Drawing.Point(59, 61);
            this.dataGoiKhach.Name = "dataGoiKhach";
            this.dataGoiKhach.ReadOnly = true;
            this.dataGoiKhach.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGoiKhach.Size = new System.Drawing.Size(928, 388);
            this.dataGoiKhach.TabIndex = 41;
            this.dataGoiKhach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGoiKhach_Click);
            // 
            // mãKháchHàngDataGridViewTextBoxColumn
            // 
            this.mãKháchHàngDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãKháchHàngDataGridViewTextBoxColumn.DataPropertyName = "Mã khách hàng";
            this.mãKháchHàngDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.mãKháchHàngDataGridViewTextBoxColumn.Name = "mãKháchHàngDataGridViewTextBoxColumn";
            this.mãKháchHàngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãGóiTậpDataGridViewTextBoxColumn
            // 
            this.mãGóiTậpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãGóiTậpDataGridViewTextBoxColumn.DataPropertyName = "Mã gói tập";
            this.mãGóiTậpDataGridViewTextBoxColumn.HeaderText = "Mã gói tập";
            this.mãGóiTậpDataGridViewTextBoxColumn.Name = "mãGóiTậpDataGridViewTextBoxColumn";
            this.mãGóiTậpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngàyBĐDataGridViewTextBoxColumn
            // 
            this.ngàyBĐDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngàyBĐDataGridViewTextBoxColumn.DataPropertyName = "Ngày BĐ";
            this.ngàyBĐDataGridViewTextBoxColumn.HeaderText = "Ngày BĐ";
            this.ngàyBĐDataGridViewTextBoxColumn.Name = "ngàyBĐDataGridViewTextBoxColumn";
            this.ngàyBĐDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngàyKTDataGridViewTextBoxColumn
            // 
            this.ngàyKTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngàyKTDataGridViewTextBoxColumn.DataPropertyName = "Ngày KT";
            this.ngàyKTDataGridViewTextBoxColumn.HeaderText = "Ngày KT";
            this.ngàyKTDataGridViewTextBoxColumn.Name = "ngàyKTDataGridViewTextBoxColumn";
            this.ngàyKTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hLVDataGridViewTextBoxColumn
            // 
            this.hLVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hLVDataGridViewTextBoxColumn.DataPropertyName = "HLV";
            this.hLVDataGridViewTextBoxColumn.HeaderText = "HLV";
            this.hLVDataGridViewTextBoxColumn.Name = "hLVDataGridViewTextBoxColumn";
            this.hLVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thanhToanYNDataGridViewCheckBoxColumn
            // 
            this.thanhToanYNDataGridViewCheckBoxColumn.DataPropertyName = "ThanhToan(Y/N)";
            this.thanhToanYNDataGridViewCheckBoxColumn.HeaderText = "ThanhToan(Y/N)";
            this.thanhToanYNDataGridViewCheckBoxColumn.Name = "thanhToanYNDataGridViewCheckBoxColumn";
            this.thanhToanYNDataGridViewCheckBoxColumn.ReadOnly = true;
            this.thanhToanYNDataGridViewCheckBoxColumn.Width = 35;
            // 
            // kHACHGOIBindingSource
            // 
            this.kHACHGOIBindingSource.DataMember = "KHACH_GOI";
            this.kHACHGOIBindingSource.DataSource = this.gYMDataSet_GoiCuaKhach;
            // 
            // gYMDataSet_GoiCuaKhach
            // 
            this.gYMDataSet_GoiCuaKhach.DataSetName = "GYMDataSet_GoiCuaKhach";
            this.gYMDataSet_GoiCuaKhach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Mã gói tập",
            "Ngày BĐ",
            "HLV",
            "ThanhToan(Y/N)"});
            this.cmbFilter.Location = new System.Drawing.Point(513, 22);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 85;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(639, 22);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 84;
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 0;
            this.btnReload.ButtonText = "          Tải lại";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = null;
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 90D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(880, 14);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(107, 35);
            this.btnReload.TabIndex = 116;
            this.btnReload.Text = "          Tải lại";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kHACH_GOITableAdapter
            // 
            this.kHACH_GOITableAdapter.ClearBeforeFill = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "Đăng ký gói";
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.DisabledColor = System.Drawing.Color.Gray;
            this.btnInsert.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInsert.Iconimage = null;
            this.btnInsert.Iconimage_right = null;
            this.btnInsert.Iconimage_right_Selected = null;
            this.btnInsert.Iconimage_Selected = null;
            this.btnInsert.IconMarginLeft = 0;
            this.btnInsert.IconMarginRight = 0;
            this.btnInsert.IconRightVisible = true;
            this.btnInsert.IconRightZoom = 0D;
            this.btnInsert.IconVisible = true;
            this.btnInsert.IconZoom = 90D;
            this.btnInsert.IsTab = false;
            this.btnInsert.Location = new System.Drawing.Point(59, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(107, 35);
            this.btnInsert.TabIndex = 117;
            this.btnInsert.Text = "Đăng ký gói";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // GoiCuaKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.dataGoiKhach);
            this.Name = "GoiCuaKhach";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.GoiCuaKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGoiKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHGOIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_GoiCuaKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGoiKhach;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãKháchHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGóiTậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyBĐDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyKTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hLVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn thanhToanYNDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource kHACHGOIBindingSource;
        private DATA.GYMDataSet_GoiCuaKhach gYMDataSet_GoiCuaKhach;
        private DATA.GYMDataSet_GoiCuaKhachTableAdapters.KHACH_GOITableAdapter kHACH_GOITableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
    }
}
