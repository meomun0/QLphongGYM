namespace QLphongGYM.Layout
{
    partial class Khach
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
            this.dataGVKh = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gYMDataSet_Khach = new QLphongGYM.GYMDataSet_Khach();
            this.kHÁCHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHÁCHTableAdapter = new QLphongGYM.GYMDataSet_KhachTableAdapters.KHÁCHTableAdapter();
            this.mãKháchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.họTênDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốĐiệnThoạiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.địaChỉDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyĐăngKýDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanTheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_Khach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHÁCHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVKh
            // 
            this.dataGVKh.AllowUserToAddRows = false;
            this.dataGVKh.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGVKh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVKh.AutoGenerateColumns = false;
            this.dataGVKh.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGVKh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVKh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVKh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGVKh.ColumnHeadersHeight = 25;
            this.dataGVKh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãKháchDataGridViewTextBoxColumn,
            this.họTênDataGridViewTextBoxColumn,
            this.gTDataGridViewTextBoxColumn,
            this.nSDataGridViewTextBoxColumn,
            this.sốĐiệnThoạiDataGridViewTextBoxColumn,
            this.địaChỉDataGridViewTextBoxColumn,
            this.ngàyĐăngKýDataGridViewTextBoxColumn,
            this.hanTheDataGridViewTextBoxColumn,
            this.isDelDataGridViewCheckBoxColumn});
            this.dataGVKh.DataSource = this.kHÁCHBindingSource;
            this.dataGVKh.DoubleBuffered = true;
            this.dataGVKh.EnableHeadersVisualStyles = false;
            this.dataGVKh.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGVKh.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGVKh.Location = new System.Drawing.Point(57, 61);
            this.dataGVKh.Name = "dataGVKh";
            this.dataGVKh.ReadOnly = true;
            this.dataGVKh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGVKh.Size = new System.Drawing.Size(928, 384);
            this.dataGVKh.TabIndex = 0;
            this.dataGVKh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVKh_CellClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "         Tìm kiếm";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = null;
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 0;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 90D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(765, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(107, 35);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "         Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã khách",
            "Họ tên",
            "Số điên thoại",
            "Địa chỉ"});
            this.cmbFilter.Location = new System.Drawing.Point(513, 19);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 107;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(639, 19);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 106;
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
            this.btnReload.Location = new System.Drawing.Point(878, 12);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(107, 35);
            this.btnReload.TabIndex = 118;
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
            this.btnInsert.Location = new System.Drawing.Point(57, 12);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(107, 35);
            this.btnInsert.TabIndex = 117;
            this.btnInsert.Text = "             Thêm";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // gYMDataSet_Khach
            // 
            this.gYMDataSet_Khach.DataSetName = "GYMDataSet_Khach";
            this.gYMDataSet_Khach.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHÁCHBindingSource
            // 
            this.kHÁCHBindingSource.DataMember = "KHÁCH";
            this.kHÁCHBindingSource.DataSource = this.gYMDataSet_Khach;
            // 
            // kHÁCHTableAdapter
            // 
            this.kHÁCHTableAdapter.ClearBeforeFill = true;
            // 
            // mãKháchDataGridViewTextBoxColumn
            // 
            this.mãKháchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãKháchDataGridViewTextBoxColumn.DataPropertyName = "Mã khách";
            this.mãKháchDataGridViewTextBoxColumn.HeaderText = "Mã khách";
            this.mãKháchDataGridViewTextBoxColumn.Name = "mãKháchDataGridViewTextBoxColumn";
            this.mãKháchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // họTênDataGridViewTextBoxColumn
            // 
            this.họTênDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.họTênDataGridViewTextBoxColumn.DataPropertyName = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.HeaderText = "Họ tên";
            this.họTênDataGridViewTextBoxColumn.Name = "họTênDataGridViewTextBoxColumn";
            this.họTênDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "GT";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            this.gTDataGridViewTextBoxColumn.ReadOnly = true;
            this.gTDataGridViewTextBoxColumn.Width = 35;
            // 
            // nSDataGridViewTextBoxColumn
            // 
            this.nSDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nSDataGridViewTextBoxColumn.DataPropertyName = "NS";
            this.nSDataGridViewTextBoxColumn.HeaderText = "NS";
            this.nSDataGridViewTextBoxColumn.Name = "nSDataGridViewTextBoxColumn";
            this.nSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốĐiệnThoạiDataGridViewTextBoxColumn
            // 
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.DataPropertyName = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.Name = "sốĐiệnThoạiDataGridViewTextBoxColumn";
            this.sốĐiệnThoạiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // địaChỉDataGridViewTextBoxColumn
            // 
            this.địaChỉDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.địaChỉDataGridViewTextBoxColumn.DataPropertyName = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.HeaderText = "Địa chỉ";
            this.địaChỉDataGridViewTextBoxColumn.Name = "địaChỉDataGridViewTextBoxColumn";
            this.địaChỉDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngàyĐăngKýDataGridViewTextBoxColumn
            // 
            this.ngàyĐăngKýDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngàyĐăngKýDataGridViewTextBoxColumn.DataPropertyName = "Ngày đăng ký";
            this.ngàyĐăngKýDataGridViewTextBoxColumn.HeaderText = "Ngày đăng ký";
            this.ngàyĐăngKýDataGridViewTextBoxColumn.Name = "ngàyĐăngKýDataGridViewTextBoxColumn";
            this.ngàyĐăngKýDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hanTheDataGridViewTextBoxColumn
            // 
            this.hanTheDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hanTheDataGridViewTextBoxColumn.DataPropertyName = "HanThe";
            this.hanTheDataGridViewTextBoxColumn.HeaderText = "Hạn Thẻ";
            this.hanTheDataGridViewTextBoxColumn.Name = "hanTheDataGridViewTextBoxColumn";
            this.hanTheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDelDataGridViewCheckBoxColumn
            // 
            this.isDelDataGridViewCheckBoxColumn.DataPropertyName = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.HeaderText = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.Name = "isDelDataGridViewCheckBoxColumn";
            this.isDelDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDelDataGridViewCheckBoxColumn.Width = 35;
            // 
            // Khach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGVKh);
            this.Name = "Khach";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.Khach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVKh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_Khach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHÁCHBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGVKh;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãKháchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn họTênDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốĐiệnThoạiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn địaChỉDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyĐăngKýDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanTheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDelDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource kHÁCHBindingSource;
        private GYMDataSet_Khach gYMDataSet_Khach;
        private GYMDataSet_KhachTableAdapters.KHÁCHTableAdapter kHÁCHTableAdapter;
    }
}
