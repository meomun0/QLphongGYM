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
    public partial class Khach : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;

        public Khach()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void Khach_Load(object sender, EventArgs e)
        {
            con.Open();
            KHCmd = new SqlCommand("EXECUTE dbo.Insert_HanThe", con);
            KHCmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            cmbFilter.SelectedIndex = 1;
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.HeaderText = "Sửa";
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVKh.Columns.Add(delbut);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGVKh.Columns.Add(delbut2);
        }

        private void dataGVKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGVKh.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
            {
                con.Open();
                if (dataGVKh.CurrentCell != null && dataGVKh.CurrentCell.Value != null)
                {
                    string del = dataGVKh.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (UserInfo.userName == "admin")
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ toàn bộ thông tin của khách hàng: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_KHACH '"+del+"',N'',N'','','',N'','','',N'Delete'", con);
                            KHCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ khách hàng: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_KHACH '" + del + "',N'',N'','','',N'','','',N'Hide'", con);
                            KHCmd.ExecuteNonQuery();
                        }
                    }
                }
                con.Close();
                DisplayData();
            }
            if (dataGVKh.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                con.Open();
                if (dataGVKh.CurrentCell != null && dataGVKh.CurrentCell.Value != null)
                {
                    if ((MessageBox.Show("Bạn có thể cập nhật các thông tin, ngoại trừ Hạn Thẻ. Để cập nhật Hạn thẻ: Khách hàng -> Gia hạn thẻ.", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        SubClasses.GetDataKhach.UpdateModeOn = true;
                        SubClasses.GetDataKhach.maKhach = dataGVKh.Rows[e.RowIndex].Cells[0].Value.ToString();
                        SubClasses.GetDataKhach.tenKhach = dataGVKh.Rows[e.RowIndex].Cells[1].Value.ToString();
                        SubClasses.GetDataKhach.GT = dataGVKh.Rows[e.RowIndex].Cells[2].Value.ToString();
                        SubClasses.GetDataKhach.NS = Convert.ToDateTime(dataGVKh.Rows[e.RowIndex].Cells[3].Value.ToString());
                        SubClasses.GetDataKhach.SDT = dataGVKh.Rows[e.RowIndex].Cells[4].Value.ToString();
                        SubClasses.GetDataKhach.diaChi = dataGVKh.Rows[e.RowIndex].Cells[5].Value.ToString();
                        SubClasses.GetDataKhach.ngayDK = Convert.ToDateTime(dataGVKh.Rows[e.RowIndex].Cells[6].Value.ToString());
                        SubClasses.GetDataKhach.hanThe = Convert.ToDateTime(dataGVKh.Rows[e.RowIndex].Cells[7].Value.ToString());

                        SubForms.ThemKhachHang themKHACH = new SubForms.ThemKhachHang();
                        themKHACH.ShowDialog();
                        con.Close();
                        if (SubClasses.GetDataKhach.UpdateModeOn == false) DisplayData();
                    }
                }
                con.Close();
            }
            if (dataGVKh.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                
                if (dataGVKh.CurrentCell != null && dataGVKh.CurrentCell.Value != null)
                {
                    if (dataGVKh.Rows[e.RowIndex].Cells[8].Value.ToString() == "True" && UserInfo.privilege == "high")
                    {
                        con.Open();
                        if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            string magoitap = dataGVKh.Rows[e.RowIndex].Cells[0].Value.ToString();
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_KHACH '" + magoitap + "',N'',N'','','',N'','','',N'Show'", con);
                            KHCmd.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                    }
                }
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.userName == "admin")
            {
                adapt = new SqlDataAdapter("select * from dbo.[KHÁCH]", con);
            }
            else
            {
                this.dataGVKh.Columns[8].Visible = false;
                adapt = new SqlDataAdapter("select * from dbo.[KHÁCH] where IsDel = 0 ", con);
            }
            adapt.Fill(dt);
            dataGVKh.DataSource = dt;
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
            adapt = new SqlDataAdapter("select * from dbo.[KHÁCH] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataGVKh.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubForms.ThemKhachHang themKHACH = new SubForms.ThemKhachHang();
            themKHACH.ShowDialog();
            DisplayData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}