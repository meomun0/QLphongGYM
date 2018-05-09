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
    public partial class Chi : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdChi;
        SqlDataAdapter adapt;
        public Chi()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void Chi_Load(object sender, EventArgs e)
        {
            DisplayData();
            cmbFilter.SelectedIndex = 1;
            txtNgThucHien.Text = UserInfo.ID;

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataChi.Columns.Add(delbut2);
            txtNgThucHien.Enabled = false;
            txtThoiGian.Enabled = false;
            panel1.Visible = false;
            btnSave.Enabled = false;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.userName == "admin")
            {
                adapt = new SqlDataAdapter("select * from dbo.[CHI]", con);
            }
            else
            {
                adapt = new SqlDataAdapter("select * from dbo.[CHI] where IsDel = 0 ", con);
            }
            adapt.Fill(dt);
            dataChi.DataSource = dt;
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
            adapt = new SqlDataAdapter("select * from dbo.[CHI] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataChi.DataSource = dt;
            con.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnSave.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnSave.Enabled = true;
        }
        private void dataThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            if ((dataChi.CurrentCell.ColumnIndex.Equals(5) || dataChi.CurrentCell.ColumnIndex.Equals(6)) && e.RowIndex != -1)
            {
                if (dataChi.CurrentCell != null && dataChi.CurrentCell.Value != null)
                {
                    string del = dataChi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (UserInfo.userName == "admin")
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ thu chi: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            cmdChi = new SqlCommand("DELETE FROM dbo.CHI WHERE [Mã chi]='" + del + "'", con);
                            cmdChi.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ thu chi: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            cmdChi = new SqlCommand("UPDATE dbo.CHI SET IsDel = 1 WHERE [Mã chi] ='" + del + "'", con);
                            cmdChi.ExecuteNonQuery();
                        }
                    }
                }
            }
            con.Close();
            DisplayData();
        }
    }
}
