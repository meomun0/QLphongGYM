namespace QLphongGYM.Layout
{
    partial class TBiCuaGoi
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
            this.dataTBicuaGoi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.gYMDataSet_TBGT = new QLphongGYM.DATA.GYMDataSet_TBGT();
            this.tBiGoiTapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBi_GoiTapTableAdapter = new QLphongGYM.DATA.GYMDataSet_TBGTTableAdapters.TBi_GoiTapTableAdapter();
            this.mãGóiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãThiếtBịDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenGoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThietBiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTBicuaGoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_TBGT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBiGoiTapBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTBicuaGoi
            // 
            this.dataTBicuaGoi.AllowUserToAddRows = false;
            this.dataTBicuaGoi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataTBicuaGoi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTBicuaGoi.AutoGenerateColumns = false;
            this.dataTBicuaGoi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataTBicuaGoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTBicuaGoi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTBicuaGoi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTBicuaGoi.ColumnHeadersHeight = 25;
            this.dataTBicuaGoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãGóiDataGridViewTextBoxColumn,
            this.mãThiếtBịDataGridViewTextBoxColumn,
            this.tenGoiDataGridViewTextBoxColumn,
            this.tenThietBiDataGridViewTextBoxColumn});
            this.dataTBicuaGoi.DataSource = this.tBiGoiTapBindingSource;
            this.dataTBicuaGoi.DoubleBuffered = true;
            this.dataTBicuaGoi.EnableHeadersVisualStyles = false;
            this.dataTBicuaGoi.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataTBicuaGoi.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataTBicuaGoi.Location = new System.Drawing.Point(59, 22);
            this.dataTBicuaGoi.Name = "dataTBicuaGoi";
            this.dataTBicuaGoi.ReadOnly = true;
            this.dataTBicuaGoi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataTBicuaGoi.Size = new System.Drawing.Size(556, 444);
            this.dataTBicuaGoi.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(742, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Tìm kiếm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(742, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Tìm theo";
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(827, 136);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(120, 35);
            this.bunifuFlatButton4.TabIndex = 72;
            this.bunifuFlatButton4.Text = "         Tìm kiếm";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã gói",
            "Mã thiết bị",
            "TenGoi",
            "TenThietBi"});
            this.cmbFilter.Location = new System.Drawing.Point(827, 79);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 111;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(827, 40);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 110;
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            // 
            // gYMDataSet_TBGT
            // 
            this.gYMDataSet_TBGT.DataSetName = "GYMDataSet_TBGT";
            this.gYMDataSet_TBGT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBiGoiTapBindingSource
            // 
            this.tBiGoiTapBindingSource.DataMember = "TBi_GoiTap";
            this.tBiGoiTapBindingSource.DataSource = this.gYMDataSet_TBGT;
            // 
            // tBi_GoiTapTableAdapter
            // 
            this.tBi_GoiTapTableAdapter.ClearBeforeFill = true;
            // 
            // mãGóiDataGridViewTextBoxColumn
            // 
            this.mãGóiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãGóiDataGridViewTextBoxColumn.DataPropertyName = "Mã gói";
            this.mãGóiDataGridViewTextBoxColumn.HeaderText = "Mã gói";
            this.mãGóiDataGridViewTextBoxColumn.Name = "mãGóiDataGridViewTextBoxColumn";
            this.mãGóiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãThiếtBịDataGridViewTextBoxColumn
            // 
            this.mãThiếtBịDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãThiếtBịDataGridViewTextBoxColumn.DataPropertyName = "Mã thiết bị";
            this.mãThiếtBịDataGridViewTextBoxColumn.HeaderText = "Mã thiết bị";
            this.mãThiếtBịDataGridViewTextBoxColumn.Name = "mãThiếtBịDataGridViewTextBoxColumn";
            this.mãThiếtBịDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenGoiDataGridViewTextBoxColumn
            // 
            this.tenGoiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenGoiDataGridViewTextBoxColumn.DataPropertyName = "TenGoi";
            this.tenGoiDataGridViewTextBoxColumn.HeaderText = "Tên gói";
            this.tenGoiDataGridViewTextBoxColumn.Name = "tenGoiDataGridViewTextBoxColumn";
            this.tenGoiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenThietBiDataGridViewTextBoxColumn
            // 
            this.tenThietBiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenThietBiDataGridViewTextBoxColumn.DataPropertyName = "TenThietBi";
            this.tenThietBiDataGridViewTextBoxColumn.HeaderText = "Tên thiết bị";
            this.tenThietBiDataGridViewTextBoxColumn.Name = "tenThietBiDataGridViewTextBoxColumn";
            this.tenThietBiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TBiCuaGoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.dataTBicuaGoi);
            this.Name = "TBiCuaGoi";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.TBiCuaGoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTBicuaGoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_TBGT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBiGoiTapBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataTBicuaGoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private System.Windows.Forms.BindingSource tBiGoiTapBindingSource;
        private DATA.GYMDataSet_TBGT gYMDataSet_TBGT;
        private DATA.GYMDataSet_TBGTTableAdapters.TBi_GoiTapTableAdapter tBi_GoiTapTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGóiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãThiếtBịDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenGoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThietBiDataGridViewTextBoxColumn;
    }
}
