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

        private void PhanCongHLV_Load(object sender, EventArgs e)
        {
            this.pHÂN_CÔNGTableAdapter.Fill(this.gYMDataSet_PhanCong.PHÂN_CÔNG);
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [Mã gói tập] from dbo.[GÓI TẬP]", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cmbMaGoi.Items.Add((string)row["Mã gói tập"]);
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

        private void btnGK_Delete_Click(object sender, EventArgs e)
        {
            con.Open();
            cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + txtMaHLV.Text + "','" + cmbMaGoi.Text + "','Select'", con);
            SqlDataReader KGdta = cmdKG.ExecuteReader();
            if (KGdta.Read() == true)
            {
                con.Close();
                con.Open();
                cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + txtMaHLV.Text + "','" + cmbMaGoi.Text + "','Delete'", con);
                cmdKG.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Xoá thành công");
                DisplayData();
            }
            else
            {
                MessageBox.Show("Không tồn tại Khách cùng với gói tập này.");
                con.Close();
            }
        }

        private void btnPK_Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + txtMaHLV.Text + "','" + cmbMaGoi.Text + "','Select'", con);
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
                cmdKG = new SqlCommand("EXECUTE [dbo].[ID_PhanCong] '" + txtMaHLV.Text + "','" + cmbMaGoi.Text + "','Insert'", con);
                cmdKG.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công");
                AutoFill();
                DisplayData();
            }
        }

        private void dataGoiKhach_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (dataPhanCong.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataPhanCong.CurrentCell != null && dataPhanCong.CurrentCell.Value != null)
                {
                    txtMaHLV.Text = dataPhanCong.CurrentCell.Value.ToString();
                    
                }
            }
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
    }
}
