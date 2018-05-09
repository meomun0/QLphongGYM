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
        string makhach, magoi;

        private void GoiCuaKhach_Load(object sender, EventArgs e)
        {
            this.kHACH_GOITableAdapter.Fill(this.gYMDataSet_GoiCuaKhach.KHACH_GOI);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGoiKhach.Columns.Add(delbut2);

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [Mã gói tập] from dbo.[GÓI TẬP]", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txtMaGoi.Items.Add((string)row["Mã gói tập"]);
            }
            con.Close();

            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Họ tên]+'('+[Mã khách]+')' AS 'makhach' FROM dbo.KHÁCH", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                txtGK_MaK.Items.Add((string)row["makhach"]);
            }
            con.Close();
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

        private void MaKhach_Change(object sender, EventArgs e)
        {
            makhach = txtGK_MaK.Text;
            int len = makhach.Length;
            int vt = makhach.IndexOf("(");
            makhach = makhach.Substring(vt + 1, len - vt - 2);//Tách mã khách chỉ còn mã không còn tên 
            txtMaGoi.ResetText();
        }

        private void MaKhach_Leave(object sender, EventArgs e)
        {
            txtMaGoi.Items.Clear();
            txtMaGoi.ResetText();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Tên gói tập]+'('+[Mã gói tập]+')' AS ma FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] NOT IN(" +
                                        "SELECT[Mã gói tập] FROM dbo.KHACH_GOI WHERE[Mã khách hàng] = '" + makhach +"')", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                txtMaGoi.Items.Add((string)row["ma"]);
            }
            con.Close();
        }
        private void MaGoi_Change(object sender, EventArgs e)
        {
            magoi = txtMaGoi.Text;
            int len = magoi.Length;
            int vt = magoi.IndexOf("(");
            magoi = magoi.Substring(vt + 1, len - vt - 2);
        }

        private bool isExist(string makhach, string magoi)
        {
            con.Open();
            cmdKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] WHERE [Mã khách]='" + makhach + "'", con);
            SqlDataReader dta = cmdKG.ExecuteReader();
            if (dta.Read() == false)
            {
                con.Close();
                MessageBox.Show("Khách hàng " + makhach + " không tồn tại.");
                return false;
            }
            else
            {
                con.Close();
                con.Open();
                cmdKG = new SqlCommand("SELECT * FROM dbo.[GÓI TẬP] WHERE [Mã gói tập]='" + magoi + "'", con);
                SqlDataReader dta2 = cmdKG.ExecuteReader();
                if (dta2.Read() == false)
                {
                    con.Close();
                    MessageBox.Show("Gói tập " + magoi + " không tồn tại.");
                    return false;
                }
                else return true;
            }
        }

        private void btnGK_Insert_Click(object sender, EventArgs e)
        {
            if (isExist(makhach, magoi))
            {
                con.Open();
                cmdKG = new SqlCommand("EXECUTE [dbo].[IUD_KhachGoi] '" + txtGK_MaK.Text + "','" + txtMaGoi.Text + "','Select'", con);
                SqlDataReader KGdta = cmdKG.ExecuteReader();

                if (KGdta.Read() == true)
                {
                    con.Close();
                    MessageBox.Show("Đã tồn tại");
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE [dbo].[IUD_KhachGoi] '" + txtGK_MaK.Text + "','" + txtMaGoi.Text + "','Insert'", con);
                    cmdKG.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thêm thành công");
                    AutoFill();
                    DisplayData();
                }
            }  
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
