using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLphongGYM.Layout.SubForms
{
    public partial class ThemDungCu : Form
    {
        public ThemDungCu()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdDC;
        string SugID;
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

        private void close_Click(object sender, EventArgs e)
        {
            SubClasses.GetDataGoiTap.UpdateModeOn = false;
            this.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void HideF()
        {
            this.Hide();
            SubClasses.GetDataDC.UpdateModeOn = false;
        }

        private void SuggestID()
        {
            int len, j, num;
            string MaKM = string.Empty, str;
            con.Close();
            con.Open();
            cmdDC = new SqlCommand("SELECT MAX([Mã NV]) as max FROM dbo.NHANVIEN WHERE [Mã NV] LIKE 'DC_16%'", con);
            SqlDataReader dta = cmdDC.ExecuteReader();
            if (dta.Read() == true)
            {
                MaKM = dta["max"].ToString();
                len = MaKM.Length;
                for (j = 0; j < len; j++)
                {
                    MaKM = (dta["max"].ToString()).Substring(j);
                    if (Regex.IsMatch(MaKM, @"^\d+$"))
                    {
                        break;
                    }
                }
                str = (dta["max"].ToString()).Substring(0, j);
                num = Convert.ToInt32(MaKM);
                num++;
                SugID = str + num;
            }
            else
            {
                SugID = "DC_160000";
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
