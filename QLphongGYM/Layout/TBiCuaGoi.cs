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
    public partial class TBiCuaGoi : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;

        public TBiCuaGoi()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void TBiCuaGoi_Load(object sender, EventArgs e)
        {
            DisplayData();
            cmbFilter.SelectedIndex = 2;
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

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[Tbi_GoiTap]", con);
            adapt.Fill(dt);
            dataTBicuaGoi.DataSource = dt;
            con.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[TBi_GoiTap] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataTBicuaGoi.DataSource = dt;
            con.Close();
        }
    }
}
