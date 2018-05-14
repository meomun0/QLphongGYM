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
    public partial class DungCu : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        public DungCu()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void DungCu_Load(object sender, EventArgs e)
        {
            DisplayData();
            cmbFilter.SelectedIndex = 1;
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.HeaderText = "Sửa";
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDungCu.Columns.Add(delbut);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataDungCu.Columns.Add(delbut2);
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.userName == "admin")
            {
                adapt = new SqlDataAdapter("select * from dbo.[DUNGCU]", con);
            }
            else
            {
                this.dataDungCu.Columns[7].Visible = false;
                adapt = new SqlDataAdapter("select * from dbo.[DUNGCU] where IsDel = 0 ", con);
            }
            adapt.Fill(dt);
            dataDungCu.DataSource = dt;
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
            if (txtInp.Text == "Nhập N.dung tìm")
            {
                txtInp.Text = "";
                txtInp.ForeColor = SystemColors.WindowText;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[DUNGCU] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataDungCu.DataSource = dt;
            con.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubForms.ThemDungCu themDC = new SubForms.ThemDungCu();
            themDC.ShowDialog();
            DisplayData();
        }

        private void dataDungCu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDungCu.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                con.Open();
                if (dataDungCu.CurrentCell != null && dataDungCu.CurrentCell.Value != null)
                {
                    if (SubClasses.GetDataDC.UpdateModeOn == true)
                    {
                        MessageBox.Show("Bạn không thể thực hiện thao tác này");
                    }
                    else
                    {
                        string del = dataDungCu.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if (UserInfo.userName == "admin")
                        {
                            if ((MessageBox.Show("Xác nhận XOÁ toàn bộ thông tin của dụng cụ: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                KHCmd = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + del + "',N'','',N'','',N'',N'Delete'", con);
                                KHCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            if ((MessageBox.Show("Xác nhận XOÁ dụng cụ: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                KHCmd = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + del + "',N'','',N'','',N'',N'Hide'", con);
                                KHCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                con.Close();
                DisplayData();
            }
            if (dataDungCu.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                con.Open();
                if (dataDungCu.CurrentCell != null && dataDungCu.CurrentCell.Value != null)
                {
                    if ((MessageBox.Show("Xác nhận chỉnh sửa thông tin dụng cụ", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        SubClasses.GetDataDC.UpdateModeOn = true;
                        SubClasses.GetDataDC.maDC = dataDungCu.Rows[e.RowIndex].Cells[0].Value.ToString();
                        SubClasses.GetDataDC.tenDC = dataDungCu.Rows[e.RowIndex].Cells[1].Value.ToString();
                        SubClasses.GetDataDC.gia = dataDungCu.Rows[e.RowIndex].Cells[2].Value.ToString();
                        SubClasses.GetDataDC.tinhTrang = dataDungCu.Rows[e.RowIndex].Cells[3].Value.ToString();
                        SubClasses.GetDataDC.ngayMua = Convert.ToDateTime(dataDungCu.Rows[e.RowIndex].Cells[4].Value.ToString());
                        SubClasses.GetDataDC.ngaySD = Convert.ToDateTime(dataDungCu.Rows[e.RowIndex].Cells[5].Value.ToString());
                        SubClasses.GetDataDC.KVSD = dataDungCu.Rows[e.RowIndex].Cells[6].Value.ToString();

                        SubForms.ThemGoiTap themGOI = new SubForms.ThemGoiTap();
                        themGOI.ShowDialog();
                        if (SubClasses.GetDataDC.UpdateModeOn == false) DisplayData();
                    }
                }
                con.Close();
            }
            if (dataDungCu.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataDungCu.CurrentCell != null && dataDungCu.CurrentCell.Value != null)
                {
                    if (dataDungCu.Rows[e.RowIndex].Cells[7].Value.ToString() == "True" && UserInfo.privilege == "high")
                    {
                        if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            con.Open();
                            string maDC = dataDungCu.Rows[e.RowIndex].Cells[0].Value.ToString();
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + maDC + "',N'','',N'','',N'',N'Show'", con);
                            KHCmd.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                    }
                }
            }
        }
    }
}
