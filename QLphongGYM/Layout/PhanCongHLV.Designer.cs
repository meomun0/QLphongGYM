﻿namespace QLphongGYM.Layout
{
    partial class PhanCongHLV
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
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataPhanCong = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cmbMaGoi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.txtInp = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbMaHLV = new System.Windows.Forms.ComboBox();
            this.gYMDataSet_PhanCong = new QLphongGYM.DATA.GYMDataSet_PhanCong();
            this.pHÂNCÔNGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHÂN_CÔNGTableAdapter = new QLphongGYM.DATA.GYMDataSet_PhanCongTableAdapters.PHÂN_CÔNGTableAdapter();
            this.mãHLVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãGóiTậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênGóiTậpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênHLVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanCong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_PhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHÂNCÔNGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "Tìm kiếm";
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
            this.bunifuFlatButton4.Location = new System.Drawing.Point(860, 134);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(120, 35);
            this.bunifuFlatButton4.TabIndex = 61;
            this.bunifuFlatButton4.Text = "Tìm kiếm";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton4.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mã gói tập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã HLV";
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Lưu";
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
            this.btnSave.Location = new System.Drawing.Point(80, 165);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(120, 35);
            this.btnSave.TabIndex = 50;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataPhanCong
            // 
            this.dataPhanCong.AllowUserToAddRows = false;
            this.dataPhanCong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataPhanCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPhanCong.AutoGenerateColumns = false;
            this.dataPhanCong.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPhanCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPhanCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataPhanCong.ColumnHeadersHeight = 25;
            this.dataPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãHLVDataGridViewTextBoxColumn,
            this.mãGóiTậpDataGridViewTextBoxColumn,
            this.tênGóiTậpDataGridViewTextBoxColumn,
            this.tênHLVDataGridViewTextBoxColumn});
            this.dataPhanCong.DataSource = this.pHÂNCÔNGBindingSource;
            this.dataPhanCong.DoubleBuffered = true;
            this.dataPhanCong.EnableHeadersVisualStyles = false;
            this.dataPhanCong.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataPhanCong.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.dataPhanCong.Location = new System.Drawing.Point(59, 61);
            this.dataPhanCong.Name = "dataPhanCong";
            this.dataPhanCong.ReadOnly = true;
            this.dataPhanCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataPhanCong.Size = new System.Drawing.Size(658, 436);
            this.dataPhanCong.TabIndex = 41;
            this.dataPhanCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGoiKhach_Click);
            // 
            // cmbMaGoi
            // 
            this.cmbMaGoi.FormattingEnabled = true;
            this.cmbMaGoi.Location = new System.Drawing.Point(80, 115);
            this.cmbMaGoi.Name = "cmbMaGoi";
            this.cmbMaGoi.Size = new System.Drawing.Size(120, 21);
            this.cmbMaGoi.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Tìm theo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(775, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Tìm kiếm";
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.ItemHeight = 13;
            this.cmbFilter.Items.AddRange(new object[] {
            "Mã HLV",
            "Mã gói tập",
            "Tên gói tập",
            "Tên HLV"});
            this.cmbFilter.Location = new System.Drawing.Point(860, 77);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(120, 21);
            this.cmbFilter.TabIndex = 109;
            // 
            // txtInp
            // 
            this.txtInp.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtInp.Location = new System.Drawing.Point(860, 38);
            this.txtInp.Multiline = true;
            this.txtInp.Name = "txtInp";
            this.txtInp.Size = new System.Drawing.Size(120, 21);
            this.txtInp.TabIndex = 108;
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.cmbMaHLV);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.cmbMaGoi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(780, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 281);
            this.panel3.TabIndex = 110;
            // 
            // cmbMaHLV
            // 
            this.cmbMaHLV.FormattingEnabled = true;
            this.cmbMaHLV.Location = new System.Drawing.Point(80, 71);
            this.cmbMaHLV.Name = "cmbMaHLV";
            this.cmbMaHLV.Size = new System.Drawing.Size(120, 21);
            this.cmbMaHLV.TabIndex = 64;
            this.cmbMaHLV.SelectedValueChanged += new System.EventHandler(this.cmbMaHLV_SelectedValueChanged);
            this.cmbMaHLV.Leave += new System.EventHandler(this.cmbMaHLV_Leave);
            // 
            // gYMDataSet_PhanCong
            // 
            this.gYMDataSet_PhanCong.DataSetName = "GYMDataSet_PhanCong";
            this.gYMDataSet_PhanCong.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHÂNCÔNGBindingSource
            // 
            this.pHÂNCÔNGBindingSource.DataMember = "PHÂN CÔNG";
            this.pHÂNCÔNGBindingSource.DataSource = this.gYMDataSet_PhanCong;
            // 
            // pHÂN_CÔNGTableAdapter
            // 
            this.pHÂN_CÔNGTableAdapter.ClearBeforeFill = true;
            // 
            // mãHLVDataGridViewTextBoxColumn
            // 
            this.mãHLVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãHLVDataGridViewTextBoxColumn.DataPropertyName = "Mã HLV";
            this.mãHLVDataGridViewTextBoxColumn.HeaderText = "Mã HLV";
            this.mãHLVDataGridViewTextBoxColumn.Name = "mãHLVDataGridViewTextBoxColumn";
            this.mãHLVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mãGóiTậpDataGridViewTextBoxColumn
            // 
            this.mãGóiTậpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãGóiTậpDataGridViewTextBoxColumn.DataPropertyName = "Mã gói tập";
            this.mãGóiTậpDataGridViewTextBoxColumn.HeaderText = "Mã gói tập";
            this.mãGóiTậpDataGridViewTextBoxColumn.Name = "mãGóiTậpDataGridViewTextBoxColumn";
            this.mãGóiTậpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênGóiTậpDataGridViewTextBoxColumn
            // 
            this.tênGóiTậpDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tênGóiTậpDataGridViewTextBoxColumn.DataPropertyName = "Tên gói tập";
            this.tênGóiTậpDataGridViewTextBoxColumn.HeaderText = "Tên gói tập";
            this.tênGóiTậpDataGridViewTextBoxColumn.Name = "tênGóiTậpDataGridViewTextBoxColumn";
            this.tênGóiTậpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênHLVDataGridViewTextBoxColumn
            // 
            this.tênHLVDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tênHLVDataGridViewTextBoxColumn.DataPropertyName = "Tên HLV";
            this.tênHLVDataGridViewTextBoxColumn.HeaderText = "Tên HLV";
            this.tênHLVDataGridViewTextBoxColumn.Name = "tênHLVDataGridViewTextBoxColumn";
            this.tênHLVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PhanCongHLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.txtInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bunifuFlatButton4);
            this.Controls.Add(this.dataPhanCong);
            this.Name = "PhanCongHLV";
            this.Size = new System.Drawing.Size(1042, 501);
            this.Load += new System.EventHandler(this.PhanCongHLV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataPhanCong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gYMDataSet_PhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHÂNCÔNGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataPhanCong;
        private System.Windows.Forms.ComboBox cmbMaGoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbFilter;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtInp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbMaHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãHLVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãGóiTậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênGóiTậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênHLVDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pHÂNCÔNGBindingSource;
        private DATA.GYMDataSet_PhanCong gYMDataSet_PhanCong;
        private DATA.GYMDataSet_PhanCongTableAdapters.PHÂN_CÔNGTableAdapter pHÂN_CÔNGTableAdapter;
    }
}
