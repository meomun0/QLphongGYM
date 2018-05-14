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
    public partial class GiaHanThe : Form
    {
        public GiaHanThe()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;
        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                // add the drop shadow flag for automatically drawing 
                // a drop shadow around the form 
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void GiaHanThe_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Họ tên]+'('+[Mã khách]+')' AS 'makhach' FROM dbo.KHÁCH", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                cmbKhach.Items.Add((string)row["makhach"]);
            }
            con.Close();
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select [Mã gói tập] from dbo.[GÓI TẬP]", con);
            adapt.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                //cmbMaGoi.Items.Add((string)row["Mã gói tập"]);
            }
            con.Close();
        }
    }
}
