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
    public partial class DungCu : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;
        public DungCu()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void DungCu_Load(object sender, EventArgs e)
        {
            this.dUNGCUTableAdapter.Fill(this.dungCu1.DUNGCU);
            cmbFilter.SelectedIndex = 1;
            ////////////////////
        //    DataGridViewImageColumn ic = new DataGridViewImageColumn();
        //    ic.HeaderText = "Img";
        //    ic.Image = null;
        //    ic.Name = "cImg";
        //    ic.Width = 100;
        //    dataDungCu.Columns.Add(ic);


        //    foreach (DataGridViewRow row in dataDungCu.Rows)
        //    {
        //        DataGridViewImageCell cell = row.Cells[1] as DataGridViewImageCell;
        //        cell.Value = (System.Drawing.Image)Properties.Resources.icons8_Trash_Can_52px;
        //    }
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
            adapt = new SqlDataAdapter("select * from dbo.[DUNGCU] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataDungCu.DataSource = dt;
            con.Close();
        }
    }
}
