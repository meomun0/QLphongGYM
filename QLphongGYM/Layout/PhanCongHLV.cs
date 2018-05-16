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
    public partial class PhanCongHLV : UserControl
    {
        public PhanCongHLV()
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
        string maHLV, magoi;

        private void PhanCongHLV_Load(object sender, EventArgs e)
        {
            this.pHÂN_CÔNGTableAdapter.Fill(this.gYMDataSet_PhanCong.PHÂN_CÔNG);

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataPhanCong.Columns.Add(delbut2);

            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [Mã gói tập] from dbo.[GÓI TẬP]", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbMaGoi.Items.Add((string)row["Mã gói tập"]);
            }
            con.Close();
            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Tên]+'('+[Mã NV]+')' AS 'maHLV' FROM dbo.NHANVIEN WHERE [Chức vụ]='HLV'", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                cmbMaHLV.Items.Add((string)row["maHLV"]);
            }
            con.Close();
            cmbFilter.SelectedIndex = 2;
            if(UserInfo.privilege == "normal" || UserInfo.privilege == "high")
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void AutoFill()
        {
            con.Open();
            cmdKG = new SqlCommand("EXECUTE dbo.insertTENofPhanCong", con);
            cmdKG.ExecuteNonQuery();
            con.Close();

        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[PHÂN CÔNG]", con);
            adapt.Fill(dt);
            dataPhanCong.DataSource = dt;
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
            adapt = new SqlDataAdapter("select * from dbo.[PHÂN CÔNG] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataPhanCong.DataSource = dt;
            con.Close();
        }

        private void cmbMaHLV_SelectedValueChanged(object sender, EventArgs e)
        {
            cmbMaGoi.ResetText();
        }

        private void cmbMaHLV_Leave(object sender, EventArgs e)
        {
            maHLV = cmbMaHLV.Text;
            int len = maHLV.Length;
            int vt = maHLV.IndexOf("(");
            maHLV = maHLV.Substring(vt + 1, len - vt - 2);

            cmbMaGoi.Items.Clear();
            cmbMaGoi.ResetText();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Tên gói tập]+'('+[Mã gói tập]+')' AS ma FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] NOT IN(" +
                                        "SELECT [Mã gói tập] FROM dbo.[PHÂN CÔNG] WHERE [Mã HLV]= '" + maHLV + "')", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbMaGoi.Items.Add((string)row["ma"]);
            }
            con.Close();
        }

        private bool isExist()
        {
            maHLV = cmbMaHLV.Text;
            int len = maHLV.Length;
            int vt = maHLV.IndexOf("(");
            maHLV = maHLV.Substring(vt + 1, len - vt - 2);

            magoi = cmbMaGoi.Text;
            int len2 = magoi.Length;
            int vt2 = magoi.IndexOf("(");
            magoi = magoi.Substring(vt2 + 1, len2 - vt2 - 2);

            con.Open();
            cmdKG = new SqlCommand("SELECT * FROM dbo.[NHANVIEN] WHERE [Mã NV]='" + maHLV + "'", con);
            SqlDataReader dta = cmdKG.ExecuteReader();
            if (dta.Read() == true && dta.GetValue(0).ToString() != "")
            {
                con.Close();
                con.Open();
                cmdKG = new SqlCommand("SELECT * FROM dbo.[GÓI TẬP] WHERE [Mã gói tập]='" + magoi + "'", con);
                SqlDataReader dta2 = cmdKG.ExecuteReader();
                if (dta2.Read() == false)
                {
                    MessageBox.Show("Gói tập " + magoi + " không tồn tại.");
                    return false;
                }
                else
                {
                    con.Close();
                    return true;
                }
            }
            else
            {
                con.Close();
                MessageBox.Show("HLV " + maHLV + " không tồn tại.");
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isExist())
            {
                con.Open();
                cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + maHLV + "','" + magoi + "','Select'", con);
                SqlDataReader KGdta = cmdKG.ExecuteReader();
                if (KGdta.Read() == true && KGdta.GetValue(0).ToString() != "")
                {
                    con.Close();
                    MessageBox.Show("Đã tồn tại");
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + maHLV + "','" + magoi + "','Insert'", con);
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
            if (dataPhanCong.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                if (dataPhanCong.CurrentCell != null && dataPhanCong.CurrentCell.Value != null)
                {
                    string mak = dataPhanCong.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string mag = dataPhanCong.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if ((MessageBox.Show("Xác nhận XOÁ gói tập " + mag + " của khách " + mak, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                    {
                        con.Open();
                        cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + mak + "','" + mag + "','Delete'", con);
                        cmdKG.ExecuteNonQuery();
                        con.Close();
                        DisplayData();
                    }
                }
            }
        }
    }
}
