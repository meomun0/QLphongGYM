namespace QLphongGYM.Layout.SubForms
{
    partial class LichSuGiaHanThe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuGiaHanThe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label15 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.search = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Panel();
            this.gYMDataSet_LSuGiaHan = new QLphongGYM.DATA.GYMDataSet_LSuGiaHan();
            this.lSuGiaHanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lSuGiaHanTableAdapter = new QLphongGYM.DATA.GYMDataSet_LSuGiaHanTableAdapters.LSuGiaHanTableAdapter();
            this.maDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tGĐKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanTruocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hanSauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_LSuGiaHan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSuGiaHanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Cornsilk;
            this.label15.Location = new System.Drawing.Point(271, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(158, 22);
            this.label15.TabIndex = 46;
            this.label15.Text = "LỊCH SỬ GIA HẠN";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.White;
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Location = new System.Drawing.Point(658, 10);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(30, 30);
            this.Close.TabIndex = 0;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // minimize
            // 
            this.minimize.BackColor = System.Drawing.Color.White;
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Location = new System.Drawing.Point(622, 10);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 3;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.Close);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 98;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeight = 25;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDataGridViewTextBoxColumn,
            this.maKhachDataGridViewTextBoxColumn,
            this.tenKhachDataGridViewTextBoxColumn,
            this.tGĐKDataGridViewTextBoxColumn,
            this.hanTruocDataGridViewTextBoxColumn,
            this.hanSauDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.lSuGiaHanBindingSource;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(12, 132);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(676, 311);
            this.bunifuCustomDataGrid1.TabIndex = 100;
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
            this.cmbFilter.Location = new System.Drawing.Point(370, 80);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 121;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(496, 80);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 120;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search.BackgroundImage")));
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search.Location = new System.Drawing.Point(622, 76);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(30, 30);
            this.search.TabIndex = 122;
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.White;
            this.refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refresh.BackgroundImage")));
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Location = new System.Drawing.Point(658, 76);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(30, 30);
            this.refresh.TabIndex = 123;
            // 
            // gYMDataSet_LSuGiaHan
            // 
            this.gYMDataSet_LSuGiaHan.DataSetName = "GYMDataSet_LSuGiaHan";
            this.gYMDataSet_LSuGiaHan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lSuGiaHanBindingSource
            // 
            this.lSuGiaHanBindingSource.DataMember = "LSuGiaHan";
            this.lSuGiaHanBindingSource.DataSource = this.gYMDataSet_LSuGiaHan;
            // 
            // lSuGiaHanTableAdapter
            // 
            this.lSuGiaHanTableAdapter.ClearBeforeFill = true;
            // 
            // maDataGridViewTextBoxColumn
            // 
            this.maDataGridViewTextBoxColumn.DataPropertyName = "Ma";
            this.maDataGridViewTextBoxColumn.HeaderText = "STT";
            this.maDataGridViewTextBoxColumn.Name = "maDataGridViewTextBoxColumn";
            this.maDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDataGridViewTextBoxColumn.Width = 50;
            // 
            // maKhachDataGridViewTextBoxColumn
            // 
            this.maKhachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maKhachDataGridViewTextBoxColumn.DataPropertyName = "MaKhach";
            this.maKhachDataGridViewTextBoxColumn.HeaderText = "Mã Khách";
            this.maKhachDataGridViewTextBoxColumn.Name = "maKhachDataGridViewTextBoxColumn";
            this.maKhachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhachDataGridViewTextBoxColumn
            // 
            this.tenKhachDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKhachDataGridViewTextBoxColumn.DataPropertyName = "TenKhach";
            this.tenKhachDataGridViewTextBoxColumn.HeaderText = "Tên Khách";
            this.tenKhachDataGridViewTextBoxColumn.Name = "tenKhachDataGridViewTextBoxColumn";
            this.tenKhachDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tGĐKDataGridViewTextBoxColumn
            // 
            this.tGĐKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tGĐKDataGridViewTextBoxColumn.DataPropertyName = "TGĐK";
            this.tGĐKDataGridViewTextBoxColumn.HeaderText = "Ngày ĐK thẻ";
            this.tGĐKDataGridViewTextBoxColumn.Name = "tGĐKDataGridViewTextBoxColumn";
            this.tGĐKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hanTruocDataGridViewTextBoxColumn
            // 
            this.hanTruocDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hanTruocDataGridViewTextBoxColumn.DataPropertyName = "HanTruoc";
            this.hanTruocDataGridViewTextBoxColumn.HeaderText = "Hạn Cũ";
            this.hanTruocDataGridViewTextBoxColumn.Name = "hanTruocDataGridViewTextBoxColumn";
            this.hanTruocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hanSauDataGridViewTextBoxColumn
            // 
            this.hanSauDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hanSauDataGridViewTextBoxColumn.DataPropertyName = "HanSau";
            this.hanSauDataGridViewTextBoxColumn.HeaderText = "Hạn Mới";
            this.hanSauDataGridViewTextBoxColumn.Name = "hanSauDataGridViewTextBoxColumn";
            this.hanSauDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LichSuGiaHanThe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 455);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.search);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LichSuGiaHanThe";
            this.Text = "LichSuGiaHanThe";
            this.Load += new System.EventHandler(this.LichSuGiaHanThe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_LSuGiaHan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lSuGiaHanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Panel minimize;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private System.Windows.Forms.Panel search;
        private System.Windows.Forms.Panel refresh;
        private DATA.GYMDataSet_LSuGiaHan gYMDataSet_LSuGiaHan;
        private System.Windows.Forms.BindingSource lSuGiaHanBindingSource;
        private DATA.GYMDataSet_LSuGiaHanTableAdapters.LSuGiaHanTableAdapter lSuGiaHanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tGĐKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanTruocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hanSauDataGridViewTextBoxColumn;
    }
}