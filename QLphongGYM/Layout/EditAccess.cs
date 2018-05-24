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
    public partial class EditAccess : UserControl
    {
        public EditAccess()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand AccessCmd;
        SqlDataAdapter adapt;
        bool UpdateMode = false;

        private void EditAccess_Load(object sender, EventArgs e)
        {
            DisplayData();
            DataGridViewImageColumn delbut = new DataGridViewImageColumn();
            delbut.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\modified.png");
            delbut.Width = 35;
            delbut.HeaderText = "Sửa";
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataEditAccess.Columns.Add(delbut);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 35;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataEditAccess.Columns.Add(delbut2);
            btnUpdate.Enabled = false;
            btnCancel.Visible = false;

            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Tên]+'('+[Mã NV]+')' AS 'maHLV' FROM dbo.NHANVIEN WHERE [Chức vụ]='HLV'", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                cmbID.Items.Add((string)row["maHLV"]);
            }
            con.Close();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[Users]", con);
            adapt.Fill(dt);
            dataEditAccess.DataSource = dt;
            con.Close();
        }

        private void dataGoiKhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataEditAccess.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
            {
                con.Open();
                if (dataEditAccess.CurrentCell != null && dataEditAccess.CurrentCell.Value != null)
                {
                    string del = dataEditAccess.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (del == "admin")
                    {
                        MessageBox.Show("Không thể xóa Admin");
                    }
                    else if (UpdateMode==true)
                    {
                        MessageBox.Show("Không thể xóa khi đang sửa");
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ  thông tin của người dùng: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            AccessCmd = new SqlCommand("EXECUTE dbo.IUD_USERS '" + del + "',N'',N'','',N'Delete'", con);
                            AccessCmd.ExecuteNonQuery();
                        }
                    }
                }
                con.Close();
                DisplayData();
            }
            if (dataEditAccess.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                if (dataEditAccess.CurrentCell != null && dataEditAccess.CurrentCell.Value != null)
                {
                    string del = dataEditAccess.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (del == "admin")
                    {
                        MessageBox.Show("Không thể sửa Admin");
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận chỉnh sửa thông người dùng", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            UpdateMode = true;
                            btnUpdate.Enabled = true;
                            btnCancel.Visible = true;
                            btnSave.Enabled = false;
                            txtUserName.Text = dataEditAccess.Rows[e.RowIndex].Cells[0].Value.ToString();
                            txtTen.Text = dataEditAccess.Rows[e.RowIndex].Cells[1].Value.ToString();
                            cmbQuyen.Text = dataEditAccess.Rows[e.RowIndex].Cells[2].Value.ToString();
                            cmbID.Text = dataEditAccess.Rows[e.RowIndex].Cells[3].Value.ToString();
                        }
                    }
                }
                con.Close();
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text!="" && txtTen.Text != "" && cmbID.Text != "")
            {
                con.Open();
                AccessCmd = new SqlCommand("EXECUTE dbo.IUD_USERS '" + txtUserName.Text + "',N'" + txtTen.Text + "',N'" + cmbQuyen.Text + "','" + cmbID.Text + "',N'Select'", con);
                SqlDataReader dta = AccessCmd.ExecuteReader();
                if (dta.Read() == true && dta.GetValue(0).ToString() != "")
                {
                    MessageBox.Show("Tên người dùng tồn tại");
                    con.Close();
                }
                else
                {
                    con.Close();
                    con.Open();
                    AccessCmd = new SqlCommand("EXECUTE dbo.IUD_USERS '" + txtUserName.Text + "',N'" + txtTen.Text + "',N'" + cmbQuyen.Text + "','" + cmbID.Text + "',N'Insert'", con);
                    AccessCmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công thành công");
                    DisplayData();
                }
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtTen.Text != "" && cmbID.Text != "")
            {
                con.Open();
                AccessCmd = new SqlCommand("EXECUTE dbo.IUD_USERS '" + txtUserName.Text + "',N'" + txtTen.Text + "',N'" + cmbQuyen.Text + "','" + cmbID.Text + "',N'Update'", con);
                AccessCmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Sửa thành công");
                DisplayData();
                UpdateMode = false;
                cmbID.ResetText();
                txtTen.ResetText();
                txtUserName.ResetText();
                cmbQuyen.ResetText();
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnCancel.Visible = false;
            }
            else
            {
                MessageBox.Show("Không được để trống");
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateMode = false;
            cmbID.ResetText();
            txtTen.ResetText();
            txtUserName.ResetText();
            cmbQuyen.ResetText();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnCancel.Visible = false;
        }
    }
}
