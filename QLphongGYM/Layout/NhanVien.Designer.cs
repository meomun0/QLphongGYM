namespace QLphongGYM.Layout
{
    partial class NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataNhanVien = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mãNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốĐiệnThoạiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chứcVụDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caLàmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyBĐDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lươngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quêQuánDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet_NhanVien = new QLphongGYM.GYMDataSet_NhanVien();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.nHANVIENTableAdapter = new QLphongGYM.GYMDataSet_NhanVienTableAdapters.NHANVIENTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNhanVien
            // 
            this.dataNhanVien.AllowUserToAddRows = false;
            this.dataNhanVien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataNhanVien.AutoGenerateColumns = false;
            this.dataNhanVien.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataNhanVien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataNhanVien.ColumnHeadersHeight = 25;
            this.dataNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãNVDataGridViewTextBoxColumn,
            this.tênDataGridViewTextBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.sốĐiệnThoạiDataGridViewTextBoxColumn,
            this.chứcVụDataGridViewTextBoxColumn,
            this.caLàmDataGridViewTextBoxColumn,
            this.ngàyBĐDataGridViewTextBoxColumn,
            this.lươngDataGridViewTextBoxColumn,
            this.quêQuánDataGridViewTextBoxColumn,
            this.isDelDataGridViewCheckBoxColumn});
            this.dataNhanVien.DataSource = this.nHANVIENBindingSource;
            this.dataNhanVien.DoubleBuffered = true;
            this.dataNhanVien.EnableHeadersVisualStyles = false;
            this.dataNhanVien.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataNhanVien.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataNhanVien.Location = new System.Drawing.Point(13, 76);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.ReadOnly = true;
            this.dataNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataNhanVien.Size = new System.Drawing.Size(1020, 374);
            this.dataNhanVien.TabIndex = 0;
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNhanVien_CellClick);
            // 
            // mãNVDataGridViewTextBoxColumn
            // 
            this.mãNVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãNVDataGridViewTextBoxColumn.DataPropertyName = "Mã NV";
            this.mãNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.mãNVDataGridViewTextBoxColumn.Name = "mãNVDataGridViewTextBoxColumn";
            this.mãNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênDataGridViewTextBoxColumn
            // 
            this.tênDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tênDataGridViewTextBoxColumn.DataPropertyName = "Tên";
            this.tênDataGridViewTextBoxColumn.HeaderText = "Tên";
            this.tênDataGridViewTextBoxColumn.Name = "tênDataGridViewTextBoxColumn";
            this.tênDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "NS";
            this.nSDataGridViewTextBoxColumn.HeaderText = "NS";
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.ReadOnly = true;
            this.nSDataGridViewTextBoxColumn.Width = 70;
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "GT";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            this.gTDataGridViewTextBoxColumn.ReadOnly = true;
            this.gTDataGridViewTextBoxColumn.Width = 40;
            // 
            // sốĐiệnThoạiDataGridViewTextBoxColumn
            // 
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.DataPropertyName = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.Name = "sốĐiệnThoạiDataGridViewTextBoxColumn";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // chứcVụDataGridViewTextBoxColumn
            // 
            this.chứcVụDataGridViewTextBoxColumn.DataPropertyName = "Chức vụ";
            this.chứcVụDataGridViewTextBoxColumn.HeaderText = "Chức vụ";
            this.chứcVụDataGridViewTextBoxColumn.Name = "chứcVụDataGridViewTextBoxColumn";
            this.chứcVụDataGridViewTextBoxColumn.ReadOnly = true;
            this.chứcVụDataGridViewTextBoxColumn.Width = 80;
            // 
            // caLàmDataGridViewTextBoxColumn
            // 
            this.caLàmDataGridViewTextBoxColumn.DataPropertyName = "Ca làm";
            this.caLàmDataGridViewTextBoxColumn.HeaderText = "Ca làm";
            this.caLàmDataGridViewTextBoxColumn.Name = "caLàmDataGridViewTextBoxColumn";
            this.caLàmDataGridViewTextBoxColumn.ReadOnly = true;
            this.caLàmDataGridViewTextBoxColumn.Width = 60;
            // 
            // ngàyBĐDataGridViewTextBoxColumn
            // 
            this.ngàyBĐDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngàyBĐDataGridViewTextBoxColumn.DataPropertyName = "Ngày BĐ";
            this.ngàyBĐDataGridViewTextBoxColumn.HeaderText = "Ngày BĐ";
            this.ngàyBĐDataGridViewTextBoxColumn.Name = "ngàyBĐDataGridViewTextBoxColumn";
            this.ngàyBĐDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lươngDataGridViewTextBoxColumn
            // 
            this.lươngDataGridViewTextBoxColumn.DataPropertyName = "Lương";
            this.lươngDataGridViewTextBoxColumn.HeaderText = "Lương";
            this.lươngDataGridViewTextBoxColumn.Name = "lươngDataGridViewTextBoxColumn";
            this.lươngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quêQuánDataGridViewTextBoxColumn
            // 
            this.quêQuánDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quêQuánDataGridViewTextBoxColumn.DataPropertyName = "Quê quán";
            this.quêQuánDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.quêQuánDataGridViewTextBoxColumn.Name = "quêQuánDataGridViewTextBoxColumn";
            this.quêQuánDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDelDataGridViewCheckBoxColumn
            // 
            this.isDelDataGridViewCheckBoxColumn.DataPropertyName = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.HeaderText = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.Name = "isDelDataGridViewCheckBoxColumn";
            this.isDelDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDelDataGridViewCheckBoxColumn.Width = 35;
            // 
            // nHANVIENBindingSource
            // 
            this.nHANVIENBindingSource.DataMember = "NHANVIEN";
            this.nHANVIENBindingSource.DataSource = this.gYMDataSet_NhanVien;
            // 
            // gYMDataSet_NhanVien
            // 
            this.gYMDataSet_NhanVien.DataSetName = "GYMDataSet_NhanVien";
            this.gYMDataSet_NhanVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(687, 19);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 42;
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "         Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = null;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 90D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(813, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(107, 35);
            this.btnTimKiem.TabIndex = 41;
            this.btnTimKiem.Text = "         Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã NV",
            "Tên",
            "Số điện thoại",
            "Chức vụ",
            "Ca làm",
            "Quê quán"});
            this.cmbFilter.Location = new System.Drawing.Point(561, 19);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 68;
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
            this.btnReload.Location = new System.Drawing.Point(926, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(107, 35);
            this.btnReload.TabIndex = 120;
            this.btnReload.Text = "          Tải lại";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsert.BorderRadius = 0;
            this.btnInsert.ButtonText = "             Thêm";
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
            this.btnInsert.Location = new System.Drawing.Point(13, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(107, 35);
            this.btnInsert.TabIndex = 119;
            this.btnInsert.Text = "             Thêm";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dataNhanVien);
            this.Name = "NhanVien";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataNhanVien;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.ComboBox cmbFilter;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private GYMDataSet_NhanVien gYMDataSet_NhanVien;
        private GYMDataSet_NhanVienTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốĐiệnThoạiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chứcVụDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caLàmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyBĐDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lươngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quêQuánDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDelDataGridViewCheckBoxColumn;
    }
}
