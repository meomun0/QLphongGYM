using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLphongGYM.Layout
{
    public partial class NhanVien : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;

        public NhanVien()
        {
            InitializeComponent();
            DisplayData();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex=1;
            DisplayData();
            cmbFilter.SelectedIndex = 1;
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.HeaderText = "Sửa";
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataNhanVien.Columns.Add(delbut);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataNhanVien.Columns.Add(delbut2);
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if(UserInfo.privilege=="high")
                adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN]", con);
            else
            {
                this.dataNhanVien.Columns[10].Visible = false;
                adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN] WHERE IsDel=0", con);
            }
            adapt.Fill(dt);
            dataNhanVien.DataSource = dt;
            con.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataNhanVien.DataSource = dt;
            con.Close();
        }

        private void txtInp_Leave(object sender, EventArgs e)
        {
            if (txtInp.Text.Length == 0)
            {
                txtInp.Text = "Nhập N.dung tìm";
                txtInp.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtInp_Enter(object sender, EventArgs e)
        {
            if(txtInp.Text== "Nhập N.dung tìm")
            {
                txtInp.Text = "";
                txtInp.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(12) && e.RowIndex != -1)
            {
                con.Open();
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    string del = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (UserInfo.userName == "admin")
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ toàn bộ thông tin của khách hàng: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_NHANVIEN '" + del + "',N'','',N'','',N'',N'','','',N'',N'Delete'", con);
                            KHCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ khách hàng: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_NHANVIEN '" + del + "',N'','',N'','',N'',N'','','',N'',N'Hide'", con);
                            KHCmd.ExecuteNonQuery();
                        }
                    }
                }
                con.Close();
                DisplayData();
            }
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
            {
                con.Open();
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    if ((MessageBox.Show("Bạn có thể cập nhật các thông tin, ngoại trừ Hạn Thẻ. Để cập nhật Hạn thẻ: Khách hàng -> Gia hạn thẻ.", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        SubClasses.GetNVData.UpdateModeOn = true;
                        SubClasses.GetNVData.maNV = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                        SubClasses.GetNVData.tenNV = dataNhanVien.Rows[e.RowIndex].Cells[1].Value.ToString();
                        SubClasses.GetNVData.NS = Convert.ToDateTime(dataNhanVien.Rows[e.RowIndex].Cells[2].Value.ToString());
                        SubClasses.GetNVData.GT = dataNhanVien.Rows[e.RowIndex].Cells[3].Value.ToString();
                        SubClasses.GetNVData.SDT = dataNhanVien.Rows[e.RowIndex].Cells[4].Value.ToString();
                        SubClasses.GetNVData.chucVu = dataNhanVien.Rows[e.RowIndex].Cells[5].Value.ToString();
                        SubClasses.GetNVData.caLam = dataNhanVien.Rows[e.RowIndex].Cells[6].Value.ToString();
                        SubClasses.GetNVData.ngayBD = Convert.ToDateTime(dataNhanVien.Rows[e.RowIndex].Cells[7].Value.ToString());
                        SubClasses.GetNVData.luong = dataNhanVien.Rows[e.RowIndex].Cells[8].Value.ToString();
                        SubClasses.GetNVData.que = dataNhanVien.Rows[e.RowIndex].Cells[9].Value.ToString();

                        SubForms.ThemNV themNV = new SubForms.ThemNV();
                        themNV.ShowDialog();
                        con.Close();
                        if (SubClasses.GetNVData.UpdateModeOn == false) DisplayData();
                    }
                }
                con.Close();
            }
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
            {
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    if (dataNhanVien.Rows[e.RowIndex].Cells[10].Value.ToString() == "True" && UserInfo.privilege == "high")
                    {
                        con.Open();
                        if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            string maNV = dataNhanVien.Rows[e.RowIndex].Cells[0].Value.ToString();
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_NHANVIEN '" + maNV + "',N'','',N'','',N'',N'','','',N'',N'Show'", con);
                            KHCmd.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                    }
                }
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubForms.ThemNV themNV = new SubForms.ThemNV();
            themNV.ShowDialog();
            con.Close();
            if (SubClasses.GetNVData.UpdateModeOn == false) DisplayData();
        }
    }
}
