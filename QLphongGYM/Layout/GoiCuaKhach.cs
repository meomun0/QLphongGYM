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
    public partial class GoiCuaKhach : UserControl
    {
        public GoiCuaKhach()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        private void GoiCuaKhach_Load(object sender, EventArgs e)
        {
            DisplayData();

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGoiKhach.Columns.Add(delbut2);

            cmbFilter.SelectedIndex = 0;
        }
        //water mark textbox tìm kiếm
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
            adapt = new SqlDataAdapter("select * from dbo.[KHACH_GOI] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataGoiKhach.DataSource = dt;
            con.Close();
        }

        private void AutoFill()
        {
            con.Open();
            cmdKG = new SqlCommand("EXECUTE dbo.insertHLVforKHACH_GOI", con);
            cmdKG.ExecuteNonQuery();
            cmdKG = new SqlCommand("EXECUTE dbo.insertDATEforKHACH_GOI", con);
            cmdKG.ExecuteNonQuery();
            con.Close();

        }

        private void DisplayData()
        {
            this.kHACH_GOITableAdapter.Fill(this.gYMDataSet_GoiCuaKhach.KHACH_GOI);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SubForms.DangKyGoiTap DKG = new SubForms.DangKyGoiTap();
            DKG.ShowDialog();
            DisplayData();
        }

        private void dataGoiKhach_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGoiKhach.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataGoiKhach.CurrentCell != null && dataGoiKhach.CurrentCell.Value != null)
                {
                    string mak = dataGoiKhach.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string mag = dataGoiKhach.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if ((MessageBox.Show("Xác nhận XOÁ gói tập " + mag + " của khách "+mak, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        con.Open();
                        cmdKG = new SqlCommand("EXECUTE [dbo].[IUD_KhachGoi] '" + mak + "','" + mag + "','Delete'", con);
                        cmdKG.ExecuteNonQuery();
                        con.Close();
                        DisplayData();
                    }
                }
            }
        }
    }
}