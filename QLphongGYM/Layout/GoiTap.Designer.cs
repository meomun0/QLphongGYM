namespace QLphongGYM.Layout
{
    partial class GoiTap
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
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataGoiTap = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mãGóiTậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênGóiTậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giáDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyBắtĐầuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyKếtThúcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buổiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuVucTapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốNgườiĐKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gÓITẬPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet_GoiTap = new QLphongGYM.GYMDataSet_GoiTap();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gÓI_TẬPTableAdapter = new QLphongGYM.GYMDataSet_GoiTapTableAdapters.GÓI_TẬPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGoiTap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gÓITẬPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_GoiTap)).BeginInit();
            this.SuspendLayout();
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
            this.btnSearch.Location = new System.Drawing.Point(768, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(107, 35);
            this.btnSearch.TabIndex = 89;
            this.btnSearch.Text = "         Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnInsert.Location = new System.Drawing.Point(59, 14);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(107, 35);
            this.btnInsert.TabIndex = 84;
            this.btnInsert.Text = "             Thêm";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dataGoiTap
            // 
            this.dataGoiTap.AllowUserToAddRows = false;
            this.dataGoiTap.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGoiTap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGoiTap.AutoGenerateColumns = false;
            this.dataGoiTap.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGoiTap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGoiTap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGoiTap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGoiTap.ColumnHeadersHeight = 25;
            this.dataGoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãGóiTậpDataGridViewTextBoxColumn,
            this.tênGóiTậpDataGridViewTextBoxColumn,
            this.giáDataGridViewTextBoxColumn,
            this.ngàyBắtĐầuDataGridViewTextBoxColumn,
            this.ngàyKếtThúcDataGridViewTextBoxColumn,
            this.buổiDataGridViewTextBoxColumn,
            this.caDataGridViewTextBoxColumn,
            this.khuVucTapDataGridViewTextBoxColumn,
            this.sốNgườiĐKDataGridViewTextBoxColumn,
            this.isDelDataGridViewCheckBoxColumn});
            this.dataGoiTap.DataSource = this.gÓITẬPBindingSource;
            this.dataGoiTap.DoubleBuffered = true;
            this.dataGoiTap.EnableHeadersVisualStyles = false;
            this.dataGoiTap.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGoiTap.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataGoiTap.Location = new System.Drawing.Point(59, 61);
            this.dataGoiTap.Name = "dataGoiTap";
            this.dataGoiTap.ReadOnly = true;
            this.dataGoiTap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGoiTap.Size = new System.Drawing.Size(928, 393);
            this.dataGoiTap.TabIndex = 82;
            this.dataGoiTap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThu_CellClick);
            // 
            // mãGóiTậpDataGridViewTextBoxColumn
            // 
            this.mãGóiTậpDataGridViewTextBoxColumn.DataPropertyName = "Mã gói tập";
            this.mãGóiTậpDataGridViewTextBoxColumn.HeaderText = "Mã gói tập";
            this.mãGóiTậpDataGridViewTextBoxColumn.Name = "mãGóiTậpDataGridViewTextBoxColumn";
            this.mãGóiTậpDataGridViewTextBoxColumn.ReadOnly = true;
            this.mãGóiTậpDataGridViewTextBoxColumn.Width = 80;
            // 
            // tênGóiTậpDataGridViewTextBoxColumn
            // 
            this.tênGóiTậpDataGridViewTextBoxColumn.DataPropertyName = "Tên gói tập";
            this.tênGóiTậpDataGridViewTextBoxColumn.HeaderText = "Tên gói tập";
            this.tênGóiTậpDataGridViewTextBoxColumn.Name = "tênGóiTậpDataGridViewTextBoxColumn";
            this.tênGóiTậpDataGridViewTextBoxColumn.ReadOnly = true;
            this.tênGóiTậpDataGridViewTextBoxColumn.Width = 85;
            // 
            // giáDataGridViewTextBoxColumn
            // 
            this.giáDataGridViewTextBoxColumn.DataPropertyName = "Giá";
            this.giáDataGridViewTextBoxColumn.HeaderText = "Giá";
            this.giáDataGridViewTextBoxColumn.Name = "giáDataGridViewTextBoxColumn";
            this.giáDataGridViewTextBoxColumn.ReadOnly = true;
            this.giáDataGridViewTextBoxColumn.Width = 80;
            // 
            // ngàyBắtĐầuDataGridViewTextBoxColumn
            // 
            this.ngàyBắtĐầuDataGridViewTextBoxColumn.DataPropertyName = "Ngày bắt đầu";
            this.ngàyBắtĐầuDataGridViewTextBoxColumn.HeaderText = "Ngày bắt đầu";
            this.ngàyBắtĐầuDataGridViewTextBoxColumn.Name = "ngàyBắtĐầuDataGridViewTextBoxColumn";
            this.ngàyBắtĐầuDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngàyBắtĐầuDataGridViewTextBoxColumn.Width = 90;
            // 
            // ngàyKếtThúcDataGridViewTextBoxColumn
            // 
            this.ngàyKếtThúcDataGridViewTextBoxColumn.DataPropertyName = "Ngày kết thúc";
            this.ngàyKếtThúcDataGridViewTextBoxColumn.HeaderText = "Ngày kết thúc";
            this.ngàyKếtThúcDataGridViewTextBoxColumn.Name = "ngàyKếtThúcDataGridViewTextBoxColumn";
            this.ngàyKếtThúcDataGridViewTextBoxColumn.ReadOnly = true;
            this.ngàyKếtThúcDataGridViewTextBoxColumn.Width = 90;
            // 
            // buổiDataGridViewTextBoxColumn
            // 
            this.buổiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buổiDataGridViewTextBoxColumn.DataPropertyName = "Buổi";
            this.buổiDataGridViewTextBoxColumn.HeaderText = "Buổi";
            this.buổiDataGridViewTextBoxColumn.Name = "buổiDataGridViewTextBoxColumn";
            this.buổiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caDataGridViewTextBoxColumn
            // 
            this.caDataGridViewTextBoxColumn.DataPropertyName = "Ca";
            this.caDataGridViewTextBoxColumn.HeaderText = "Ca";
            this.caDataGridViewTextBoxColumn.Name = "caDataGridViewTextBoxColumn";
            this.caDataGridViewTextBoxColumn.ReadOnly = true;
            this.caDataGridViewTextBoxColumn.Width = 80;
            // 
            // khuVucTapDataGridViewTextBoxColumn
            // 
            this.khuVucTapDataGridViewTextBoxColumn.DataPropertyName = "KhuVucTap";
            this.khuVucTapDataGridViewTextBoxColumn.HeaderText = "Khu Vục Tập";
            this.khuVucTapDataGridViewTextBoxColumn.Name = "khuVucTapDataGridViewTextBoxColumn";
            this.khuVucTapDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốNgườiĐKDataGridViewTextBoxColumn
            // 
            this.sốNgườiĐKDataGridViewTextBoxColumn.DataPropertyName = "Số người ĐK";
            this.sốNgườiĐKDataGridViewTextBoxColumn.HeaderText = "Người ĐK";
            this.sốNgườiĐKDataGridViewTextBoxColumn.Name = "sốNgườiĐKDataGridViewTextBoxColumn";
            this.sốNgườiĐKDataGridViewTextBoxColumn.ReadOnly = true;
            this.sốNgườiĐKDataGridViewTextBoxColumn.Width = 65;
            // 
            // isDelDataGridViewCheckBoxColumn
            // 
            this.isDelDataGridViewCheckBoxColumn.DataPropertyName = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.HeaderText = "Del";
            this.isDelDataGridViewCheckBoxColumn.Name = "isDelDataGridViewCheckBoxColumn";
            this.isDelDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDelDataGridViewCheckBoxColumn.Width = 30;
            // 
            // gÓITẬPBindingSource
            // 
            this.gÓITẬPBindingSource.DataMember = "GÓI TẬP";
            this.gÓITẬPBindingSource.DataSource = this.gYMDataSet_GoiTap;
            // 
            // gYMDataSet_GoiTap
            // 
            this.gYMDataSet_GoiTap.DataSetName = "GYMDataSet_GoiTap";
            this.gYMDataSet_GoiTap.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã gói tập",
            "Tên gói tập",
            "Giá",
            "Tình trạng",
            "Buổi",
            "Ca",
            "Số người ĐK"});
            this.cmbFilter.Location = new System.Drawing.Point(516, 23);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 105;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(642, 23);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 104;
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
            this.btnReload.Location = new System.Drawing.Point(881, 14);
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
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // gÓI_TẬPTableAdapter
            // 
            this.gÓI_TẬPTableAdapter.ClearBeforeFill = true;
            // 
            // GoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGoiTap);
            this.Name = "GoiTap";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.GoiTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGoiTap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gÓITẬPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_GoiTap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGoiTap;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private System.Windows.Forms.BindingSource gÓITẬPBindingSource;
        private GYMDataSet_GoiTap gYMDataSet_GoiTap;
        private GYMDataSet_GoiTapTableAdapters.GÓI_TẬPTableAdapter gÓI_TẬPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGóiTậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênGóiTậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giáDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyBắtĐầuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyKếtThúcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buổiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuVucTapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốNgườiĐKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDelDataGridViewCheckBoxColumn;
    }
}
