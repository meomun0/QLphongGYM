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
            this.nHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet_NhanVien = new QLphongGYM.GYMDataSet_NhanVien();
            this.nHANVIENTableAdapter = new QLphongGYM.GYMDataSet_NhanVienTableAdapters.NHANVIENTableAdapter();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMaNV = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtHoTen = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtGT = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtSDT = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtChucVu = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNBD = new System.Windows.Forms.DateTimePicker();
            this.txtNS = new System.Windows.Forms.DateTimePicker();
            this.txtQueQuan = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtLuong = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtCaLam = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
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
            this.dataNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.quêQuánDataGridViewTextBoxColumn});
            this.dataNhanVien.DataSource = this.nHANVIENBindingSource;
            this.dataNhanVien.DoubleBuffered = true;
            this.dataNhanVien.EnableHeadersVisualStyles = false;
            this.dataNhanVien.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataNhanVien.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataNhanVien.Location = new System.Drawing.Point(0, 54);
            this.dataNhanVien.Name = "dataNhanVien";
            this.dataNhanVien.ReadOnly = true;
            this.dataNhanVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataNhanVien.Size = new System.Drawing.Size(1042, 329);
            this.dataNhanVien.TabIndex = 0;
            this.dataNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVKh_CellClick);
            // 
            // mãNVDataGridViewTextBoxColumn
            // 
            this.mãNVDataGridViewTextBoxColumn.DataPropertyName = "Mã NV";
            this.mãNVDataGridViewTextBoxColumn.HeaderText = "Mã NV";
            this.mãNVDataGridViewTextBoxColumn.Name = "mãNVDataGridViewTextBoxColumn";
            this.mãNVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênDataGridViewTextBoxColumn
            // 
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
            // 
            // gTDataGridViewTextBoxColumn
            // 
            this.gTDataGridViewTextBoxColumn.DataPropertyName = "GT";
            this.gTDataGridViewTextBoxColumn.HeaderText = "GT";
            this.gTDataGridViewTextBoxColumn.Name = "gTDataGridViewTextBoxColumn";
            this.gTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốĐiệnThoạiDataGridViewTextBoxColumn
            // 
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
            // 
            // caLàmDataGridViewTextBoxColumn
            // 
            this.caLàmDataGridViewTextBoxColumn.DataPropertyName = "Ca làm";
            this.caLàmDataGridViewTextBoxColumn.HeaderText = "Ca làm";
            this.caLàmDataGridViewTextBoxColumn.Name = "caLàmDataGridViewTextBoxColumn";
            this.caLàmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngàyBĐDataGridViewTextBoxColumn
            // 
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
            this.quêQuánDataGridViewTextBoxColumn.DataPropertyName = "Quê quán";
            this.quêQuánDataGridViewTextBoxColumn.HeaderText = "Quê quán";
            this.quêQuánDataGridViewTextBoxColumn.Name = "quêQuánDataGridViewTextBoxColumn";
            this.quêQuánDataGridViewTextBoxColumn.ReadOnly = true;
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
            // nHANVIENTableAdapter
            // 
            this.nHANVIENTableAdapter.ClearBeforeFill = true;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(772, 16);
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
            this.btnTimKiem.Location = new System.Drawing.Point(926, 10);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(816, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 61;
            this.label8.Text = "Lương";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(714, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Ngày bắt đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Chức vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Mã NV";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "             Xoá";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(646, 453);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(107, 35);
            this.bunifuFlatButton3.TabIndex = 53;
            this.bunifuFlatButton3.Text = "             Xoá";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnInsert.Location = new System.Drawing.Point(275, 453);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(107, 35);
            this.btnInsert.TabIndex = 51;
            this.btnInsert.Text = "             Thêm";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnKhInsert_Click);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMaNV.Location = new System.Drawing.Point(3, 417);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(91, 20);
            this.txtMaNV.TabIndex = 50;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtHoTen.Location = new System.Drawing.Point(105, 417);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(91, 20);
            this.txtHoTen.TabIndex = 49;
            // 
            // txtGT
            // 
            this.txtGT.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtGT.Location = new System.Drawing.Point(309, 417);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(91, 20);
            this.txtGT.TabIndex = 48;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSDT.Location = new System.Drawing.Point(411, 417);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(91, 20);
            this.txtSDT.TabIndex = 47;
            // 
            // txtChucVu
            // 
            this.txtChucVu.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtChucVu.Location = new System.Drawing.Point(513, 417);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(91, 20);
            this.txtChucVu.TabIndex = 46;
            // 
            // txtNBD
            // 
            this.txtNBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNBD.Location = new System.Drawing.Point(717, 417);
            this.txtNBD.Name = "txtNBD";
            this.txtNBD.Size = new System.Drawing.Size(91, 20);
            this.txtNBD.TabIndex = 44;
            // 
            // txtNS
            // 
            this.txtNS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtNS.Location = new System.Drawing.Point(207, 417);
            this.txtNS.Name = "txtNS";
            this.txtNS.Size = new System.Drawing.Size(91, 20);
            this.txtNS.TabIndex = 43;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtQueQuan.Location = new System.Drawing.Point(921, 416);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(91, 20);
            this.txtQueQuan.TabIndex = 62;
            // 
            // txtLuong
            // 
            this.txtLuong.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtLuong.Location = new System.Drawing.Point(819, 416);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(91, 20);
            this.txtLuong.TabIndex = 63;
            // 
            // txtCaLam
            // 
            this.txtCaLam.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCaLam.Location = new System.Drawing.Point(615, 416);
            this.txtCaLam.Name = "txtCaLam";
            this.txtCaLam.Size = new System.Drawing.Size(91, 20);
            this.txtCaLam.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(612, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 65;
            this.label9.Text = "Ca làm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(918, 394);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Quê quán";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.ButtonText = "          Cập nhật";
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.btnUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUpdate.Iconimage = null;
            this.btnUpdate.Iconimage_right = null;
            this.btnUpdate.Iconimage_right_Selected = null;
            this.btnUpdate.Iconimage_Selected = null;
            this.btnUpdate.IconMarginLeft = 0;
            this.btnUpdate.IconMarginRight = 0;
            this.btnUpdate.IconRightVisible = true;
            this.btnUpdate.IconRightZoom = 0D;
            this.btnUpdate.IconVisible = true;
            this.btnUpdate.IconZoom = 90D;
            this.btnUpdate.IsTab = false;
            this.btnUpdate.Location = new System.Drawing.Point(462, 453);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnUpdate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnUpdate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUpdate.selected = false;
            this.btnUpdate.Size = new System.Drawing.Size(107, 35);
            this.btnUpdate.TabIndex = 67;
            this.btnUpdate.Text = "          Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Textcolor = System.Drawing.Color.White;
            this.btnUpdate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Click += new System.EventHandler(this.BtnNVUpdate_Click);
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
            this.cmbFilter.Location = new System.Drawing.Point(615, 16);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 68;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCaLam);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuFlatButton3);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.txtNBD);
            this.Controls.Add(this.txtNS);
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
        private System.Windows.Forms.BindingSource nHANVIENBindingSource;
        private GYMDataSet_NhanVien gYMDataSet_NhanVien;
        private GYMDataSet_NhanVienTableAdapters.NHANVIENTableAdapter nHANVIENTableAdapter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMaNV;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtHoTen;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtGT;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSDT;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtChucVu;
        private System.Windows.Forms.DateTimePicker txtNBD;
        private System.Windows.Forms.DateTimePicker txtNS;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtQueQuan;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtLuong;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCaLam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
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
        private Bunifu.Framework.UI.BunifuFlatButton btnUpdate;
        private System.Windows.Forms.ComboBox cmbFilter;
    }
}
