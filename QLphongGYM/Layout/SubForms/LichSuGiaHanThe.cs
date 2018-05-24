using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLphongGYM.Layout.SubForms
{
    public partial class LichSuGiaHanThe : Form
    {
        public LichSuGiaHanThe()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdChi;
        SqlDataAdapter adapt;

        private void LichSuGiaHanThe_Load(object sender, EventArgs e)
        {
            this.lSuGiaHanTableAdapter.Fill(this.gYMDataSet_LSuGiaHan.LSuGiaHan);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void search_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[LSuGiaHan] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            this.lSuGiaHanTableAdapter.Fill(this.gYMDataSet_LSuGiaHan.LSuGiaHan);
        }
    }
}
