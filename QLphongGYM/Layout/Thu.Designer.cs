namespace QLphongGYM.Layout
{
    partial class Thu
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
            this.dataThu = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.mãThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãKháchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênGóiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngTiềnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thờiGianDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.môTảDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngườiDuyệtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isDelDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tHUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gYMDataSet_Thu = new QLphongGYM.GYMDataSet_Thu();
            this.btnInsert = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtMaThu = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtSLTien = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtNgThucHien = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txtMota = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.txtMaGoi = new System.Windows.Forms.ComboBox();
            this.txtMaKhach = new System.Windows.Forms.ComboBox();
            this.txtThoiGian = new System.Windows.Forms.DateTimePicker();
            this.tHUTableAdapter = new QLphongGYM.GYMDataSet_ThuTableAdapters.THUTableAdapter();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGiaHanThe = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_Thu)).BeginInit();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataThu
            // 
            this.dataThu.AllowUserToAddRows = false;
            this.dataThu.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataThu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataThu.AutoGenerateColumns = false;
            this.dataThu.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataThu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataThu.ColumnHeadersHeight = 25;
            this.dataThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãThuDataGridViewTextBoxColumn,
            this.mãKháchDataGridViewTextBoxColumn,
            this.tênGóiDataGridViewTextBoxColumn,
            this.sốLượngTiềnDataGridViewTextBoxColumn,
            this.thờiGianDataGridViewTextBoxColumn,
            this.môTảDataGridViewTextBoxColumn,
            this.ngườiDuyệtDataGridViewTextBoxColumn,
            this.isDelDataGridViewCheckBoxColumn});
            this.dataThu.DataSource = this.tHUBindingSource;
            this.dataThu.DoubleBuffered = true;
            this.dataThu.EnableHeadersVisualStyles = false;
            this.dataThu.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataThu.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataThu.Location = new System.Drawing.Point(57, 61);
            this.dataThu.Name = "dataThu";
            this.dataThu.ReadOnly = true;
            this.dataThu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataThu.Size = new System.Drawing.Size(928, 335);
            this.dataThu.TabIndex = 0;
            this.dataThu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThu_CellClick);
            // 
            // mãThuDataGridViewTextBoxColumn
            // 
            this.mãThuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãThuDataGridViewTextBoxColumn.DataPropertyName = "Mã thu";
            this.mãThuDataGridViewTextBoxColumn.HeaderText = "Mã thu";
            this.mãThuDataGridViewTextBoxColumn.Name = "mãThuDataGridViewTextBoxColumn";
            this.mãThuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãKháchDataGridViewTextBoxColumn
            // 
            this.mãKháchDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãKháchDataGridViewTextBoxColumn.DataPropertyName = "Mã khách";
            this.mãKháchDataGridViewTextBoxColumn.HeaderText = "Mã khách";
            this.mãKháchDataGridViewTextBoxColumn.Name = "mãKháchDataGridViewTextBoxColumn";
            this.mãKháchDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênGóiDataGridViewTextBoxColumn
            // 
            this.tênGóiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tênGóiDataGridViewTextBoxColumn.DataPropertyName = "Tên gói";
            this.tênGóiDataGridViewTextBoxColumn.HeaderText = "Mã gói";
            this.tênGóiDataGridViewTextBoxColumn.Name = "tênGóiDataGridViewTextBoxColumn";
            this.tênGóiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sốLượngTiềnDataGridViewTextBoxColumn
            // 
            this.sốLượngTiềnDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sốLượngTiềnDataGridViewTextBoxColumn.DataPropertyName = "Số lượng tiền";
            this.sốLượngTiềnDataGridViewTextBoxColumn.HeaderText = "Số lượng tiền";
            this.sốLượngTiềnDataGridViewTextBoxColumn.Name = "sốLượngTiềnDataGridViewTextBoxColumn";
            this.sốLượngTiềnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thờiGianDataGridViewTextBoxColumn
            // 
            this.thờiGianDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thờiGianDataGridViewTextBoxColumn.DataPropertyName = "Thời gian";
            this.thờiGianDataGridViewTextBoxColumn.HeaderText = "Thời gian";
            this.thờiGianDataGridViewTextBoxColumn.Name = "thờiGianDataGridViewTextBoxColumn";
            this.thờiGianDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // môTảDataGridViewTextBoxColumn
            // 
            this.môTảDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.môTảDataGridViewTextBoxColumn.DataPropertyName = "Mô tả";
            this.môTảDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.môTảDataGridViewTextBoxColumn.Name = "môTảDataGridViewTextBoxColumn";
            this.môTảDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngườiDuyệtDataGridViewTextBoxColumn
            // 
            this.ngườiDuyệtDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngườiDuyệtDataGridViewTextBoxColumn.DataPropertyName = "Người duyệt";
            this.ngườiDuyệtDataGridViewTextBoxColumn.HeaderText = "Người duyệt";
            this.ngườiDuyệtDataGridViewTextBoxColumn.Name = "ngườiDuyệtDataGridViewTextBoxColumn";
            this.ngườiDuyệtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isDelDataGridViewCheckBoxColumn
            // 
            this.isDelDataGridViewCheckBoxColumn.DataPropertyName = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.HeaderText = "IsDel";
            this.isDelDataGridViewCheckBoxColumn.Name = "isDelDataGridViewCheckBoxColumn";
            this.isDelDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isDelDataGridViewCheckBoxColumn.Width = 40;
            // 
            // tHUBindingSource
            // 
            this.tHUBindingSource.DataMember = "THU";
            this.tHUBindingSource.DataSource = this.gYMDataSet_Thu;
            // 
            // gYMDataSet_Thu
            // 
            this.gYMDataSet_Thu.DataSetName = "GYMDataSet_Thu";
            this.gYMDataSet_Thu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btnInsert.Location = new System.Drawing.Point(57, 13);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInsert.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnInsert.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInsert.selected = false;
            this.btnInsert.Size = new System.Drawing.Size(107, 35);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "             Thêm";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsert.Textcolor = System.Drawing.Color.White;
            this.btnInsert.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(765, 13);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(107, 35);
            this.bunifuFlatButton4.TabIndex = 4;
            this.bunifuFlatButton4.Text = "         Tìm kiếm";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtMaThu
            // 
            this.txtMaThu.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMaThu.Location = new System.Drawing.Point(17, 20);
            this.txtMaThu.Name = "txtMaThu";
            this.txtMaThu.Size = new System.Drawing.Size(132, 20);
            this.txtMaThu.TabIndex = 6;
            // 
            // txtSLTien
            // 
            this.txtSLTien.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtSLTien.Location = new System.Drawing.Point(431, 20);
            this.txtSLTien.Name = "txtSLTien";
            this.txtSLTien.Size = new System.Drawing.Size(122, 20);
            this.txtSLTien.TabIndex = 10;
            // 
            // txtNgThucHien
            // 
            this.txtNgThucHien.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtNgThucHien.Location = new System.Drawing.Point(832, 20);
            this.txtNgThucHien.Name = "txtNgThucHien";
            this.txtNgThucHien.Size = new System.Drawing.Size(113, 20);
            this.txtNgThucHien.TabIndex = 12;
            // 
            // txtMota
            // 
            this.txtMota.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMota.Location = new System.Drawing.Point(687, 20);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(139, 20);
            this.txtMota.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã khách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tên gói";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số lượng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Thời gian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(688, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mô tả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(829, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Người thực hiện";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã thu",
            "Mã khách",
            "Tên gói",
            "Số lượng tiền",
            "Mô tả",
            "Người duyệt"});
            this.cmbFilter.Location = new System.Drawing.Point(513, 19);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 113;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(639, 19);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 112;
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "             Lưu";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(765, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(107, 35);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "             Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnReload.Location = new System.Drawing.Point(878, 13);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(107, 35);
            this.btnReload.TabIndex = 115;
            this.btnReload.Text = "          Tải lại";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.txtMaGoi);
            this.panelContent.Controls.Add(this.txtMaKhach);
            this.panelContent.Controls.Add(this.txtThoiGian);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.txtMaThu);
            this.panelContent.Controls.Add(this.txtSLTien);
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.txtNgThucHien);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.txtMota);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label1);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Location = new System.Drawing.Point(37, 402);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(948, 45);
            this.panelContent.TabIndex = 116;
            // 
            // txtMaGoi
            // 
            this.txtMaGoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaGoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMaGoi.FormattingEnabled = true;
            this.txtMaGoi.Location = new System.Drawing.Point(293, 19);
            this.txtMaGoi.Name = "txtMaGoi";
            this.txtMaGoi.Size = new System.Drawing.Size(132, 21);
            this.txtMaGoi.TabIndex = 117;
            this.txtMaGoi.SelectedValueChanged += new System.EventHandler(this.MaGoi_Change);
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMaKhach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtMaKhach.FormattingEnabled = true;
            this.txtMaKhach.Location = new System.Drawing.Point(155, 20);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.Size = new System.Drawing.Size(132, 21);
            this.txtMaKhach.TabIndex = 22;
            this.txtMaKhach.SelectedValueChanged += new System.EventHandler(this.MaKhach_Change);
            this.txtMaKhach.Leave += new System.EventHandler(this.MaKhach_Leave);
            // 
            // txtThoiGian
            // 
            this.txtThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtThoiGian.Location = new System.Drawing.Point(559, 19);
            this.txtThoiGian.Name = "txtThoiGian";
            this.txtThoiGian.Size = new System.Drawing.Size(122, 20);
            this.txtThoiGian.TabIndex = 21;
            // 
            // tHUTableAdapter
            // 
            this.tHUTableAdapter.ClearBeforeFill = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "          Huỷ bỏ";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(878, 453);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(107, 35);
            this.btnCancel.TabIndex = 117;
            this.btnCancel.Text = "          Huỷ bỏ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGiaHanThe
            // 
            this.btnGiaHanThe.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiaHanThe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiaHanThe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGiaHanThe.BorderRadius = 0;
            this.btnGiaHanThe.ButtonText = "Lịch sử gia hạn";
            this.btnGiaHanThe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiaHanThe.DisabledColor = System.Drawing.Color.Gray;
            this.btnGiaHanThe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGiaHanThe.Iconimage = null;
            this.btnGiaHanThe.Iconimage_right = null;
            this.btnGiaHanThe.Iconimage_right_Selected = null;
            this.btnGiaHanThe.Iconimage_Selected = null;
            this.btnGiaHanThe.IconMarginLeft = 0;
            this.btnGiaHanThe.IconMarginRight = 0;
            this.btnGiaHanThe.IconRightVisible = true;
            this.btnGiaHanThe.IconRightZoom = 0D;
            this.btnGiaHanThe.IconVisible = true;
            this.btnGiaHanThe.IconZoom = 90D;
            this.btnGiaHanThe.IsTab = false;
            this.btnGiaHanThe.Location = new System.Drawing.Point(170, 13);
            this.btnGiaHanThe.Name = "btnGiaHanThe";
            this.btnGiaHanThe.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnGiaHanThe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnGiaHanThe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGiaHanThe.selected = false;
            this.btnGiaHanThe.Size = new System.Drawing.Size(107, 35);
            this.btnGiaHanThe.TabIndex = 120;
            this.btnGiaHanThe.Text = "Lịch sử gia hạn";
            this.btnGiaHanThe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGiaHanThe.Textcolor = System.Drawing.Color.White;
            this.btnGiaHanThe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaHanThe.Click += new System.EventHandler(this.btnGiaHanThe_Click);
            // 
            // Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGiaHanThe);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.dataThu);
            this.Name = "Thu";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.Thu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_Thu)).EndInit();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataThu;
        private Bunifu.Framework.UI.BunifuFlatButton btnInsert;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMaThu;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtSLTien;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtNgThucHien;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.DateTimePicker txtThoiGian;
        private System.Windows.Forms.ComboBox txtMaKhach;
        private System.Windows.Forms.ComboBox txtMaGoi;
        private System.Windows.Forms.BindingSource tHUBindingSource;
        private GYMDataSet_Thu gYMDataSet_Thu;
        private GYMDataSet_ThuTableAdapters.THUTableAdapter tHUTableAdapter;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãKháchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênGóiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngTiềnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thờiGianDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn môTảDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngườiDuyệtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isDelDataGridViewCheckBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton btnGiaHanThe;
    }
}
