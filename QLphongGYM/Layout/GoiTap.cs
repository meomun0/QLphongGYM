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
    public partial class GoiTap : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;

        public GoiTap()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void GoiTap_Load(object sender, EventArgs e)
        {
            DisplayData();
            con.Open();
            KHCmd = new SqlCommand("EXECUTE  [dbo].[insertNumofcustomer] ", con);
            KHCmd.ExecuteNonQuery();
            con.Close();
            cmbFilter.SelectedIndex = 1;
            if (UserInfo.privilege == "normal" || UserInfo.privilege == "high")
            {
                btnInsert.Visible = true;
                DataGridViewImageColumn delbut = new DataGridViewImageColumn();
                delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
                delbut.Width = 35;
                delbut.HeaderText = "Sửa";
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGoiTap.Columns.Add(delbut);

                DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
                delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
                delbut2.Width = 35;
                delbut2.HeaderText = "Xoá";
                delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGoiTap.Columns.Add(delbut2);
            }
            else
            {
                btnInsert.Visible = false;
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.userName == "admin")
            {
                adapt = new SqlDataAdapter("select * from dbo.[GÓI TẬP]", con);
            }
            else
            {
                this.dataGoiTap.Columns[9].Visible = false;
                adapt = new SqlDataAdapter("select * from dbo.[GÓI TẬP] where IsDel = 0 ", con);
            }
            adapt.Fill(dt);
            dataGoiTap.DataSource = dt;
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
            adapt = new SqlDataAdapter("select * from dbo.[GÓI TẬP] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataGoiTap.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubForms.ThemGoiTap themGOI = new SubForms.ThemGoiTap();
            themGOI.ShowDialog();
            DisplayData();
        }

        private void dataThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGoiTap.CurrentCell.ColumnIndex.Equals(11) && e.RowIndex != -1)
            {
                con.Open();
                if (dataGoiTap.CurrentCell != null && dataGoiTap.CurrentCell.Value != null)
                {
                    if ( SubClasses.GetDataGoiTap.UpdateModeOn==true)
                    {
                        MessageBox.Show("Bạn không thể thực hiện thao tác này");
                    }
                    else
                    {
                        string del = dataGoiTap.Rows[e.RowIndex].Cells[0].Value.ToString();
                        if (UserInfo.userName == "admin")
                        {
                            if ((MessageBox.Show("Xác nhận XOÁ toàn bộ thông tin của gói tập: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                KHCmd = new SqlCommand("EXECUTE dbo.IUD_GOITAP '" + del + "',N'','','','',N'',N'',N'','',N'Delete'", con);
                                KHCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            if ((MessageBox.Show("Xác nhận XOÁ gói tập: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                KHCmd = new SqlCommand("EXECUTE dbo.IUD_GOITAP '" + del + "',N'','','','',N'',N'',N'','',N'Hide'", con);
                                KHCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                con.Close();
                DisplayData();
            }
            if (dataGoiTap.CurrentCell.ColumnIndex.Equals(10) && e.RowIndex != -1)
            {
                con.Open();
                if (dataGoiTap.CurrentCell != null && dataGoiTap.CurrentCell.Value != null)
                {
                    if ((MessageBox.Show("Bạn chỉ có thể chỉnh sửa các nội dung như: Ngày bắt đầu/kết thúc, Giá, Ca tập, Buổi tập, Khu vực tập. Bạn có muốn tiếp tục", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        SubClasses.GetDataGoiTap.UpdateModeOn = true;
                        SubClasses.GetDataGoiTap.maGoi = dataGoiTap.Rows[e.RowIndex].Cells[0].Value.ToString();
                        SubClasses.GetDataGoiTap.tenGoi = dataGoiTap.Rows[e.RowIndex].Cells[1].Value.ToString();
                        SubClasses.GetDataGoiTap.gia = dataGoiTap.Rows[e.RowIndex].Cells[2].Value.ToString();
                        SubClasses.GetDataGoiTap.ngayBD = Convert.ToDateTime(dataGoiTap.Rows[e.RowIndex].Cells[3].Value.ToString());
                        SubClasses.GetDataGoiTap.ngayKT = Convert.ToDateTime(dataGoiTap.Rows[e.RowIndex].Cells[4].Value.ToString());
                        SubClasses.GetDataGoiTap.buoi = dataGoiTap.Rows[e.RowIndex].Cells[5].Value.ToString();
                        SubClasses.GetDataGoiTap.ca = dataGoiTap.Rows[e.RowIndex].Cells[6].Value.ToString();
                        SubClasses.GetDataGoiTap.khuVuc = dataGoiTap.Rows[e.RowIndex].Cells[7].Value.ToString();
                        SubClasses.GetDataGoiTap.nguoiDK = dataGoiTap.Rows[e.RowIndex].Cells[8].Value.ToString();

                        SubForms.ThemGoiTap themGOI = new SubForms.ThemGoiTap();
                        themGOI.ShowDialog();
                        con.Close();
                        DisplayData();
                    }
                }
            }
            if (dataGoiTap.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                if (dataGoiTap.CurrentCell != null && dataGoiTap.CurrentCell.Value != null)
                {
                    if (dataGoiTap.Rows[e.RowIndex].Cells[9].Value.ToString() == "True" && UserInfo.privilege=="high")
                    {
                        if((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            con.Open();
                            string magoitap = dataGoiTap.Rows[e.RowIndex].Cells[0].Value.ToString();
                            KHCmd = new SqlCommand("EXECUTE dbo.IUD_GOITAP '" + magoitap + "',N'','','','',N'',N'',N'','',N'Show'", con);
                            KHCmd.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                    }
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
