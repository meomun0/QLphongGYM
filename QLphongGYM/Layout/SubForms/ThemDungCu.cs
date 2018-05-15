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

        private void ThemDC_Load(object sender, EventArgs e)
        {
            txtMaDC.Enabled = false;
            SuggestID();
            if (SubClasses.GetDataDC.UpdateModeOn == false)
            {
                txtMaDC.Text = SugID;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                txtMaDC.Text = SubClasses.GetDataDC.maDC;
                txtTenDC.Text = SubClasses.GetDataDC.tenDC;
                txtGia.Text = SubClasses.GetDataDC.gia;
                if (SubClasses.GetDataDC.KVSD == "Trong kho")
                    cmbKhuVuc.selectedIndex = 3;
                else if (SubClasses.GetDataDC.KVSD == "Body and Mind studio")
                    cmbKhuVuc.selectedIndex = 2;
                else if (SubClasses.GetDataDC.KVSD == "Private studio")
                    cmbKhuVuc.selectedIndex = 1;
                else
                    cmbKhuVuc.selectedIndex = 0;
                if (SubClasses.GetDataDC.tinhTrang == "Dự trữ")
                    cmbTinhTrang.selectedIndex = 3;
                else if (SubClasses.GetDataDC.tinhTrang == "Hỏng hóc")
                    cmbTinhTrang.selectedIndex = 2;
                else if (SubClasses.GetDataDC.tinhTrang == "Sửa chữa")
                    cmbTinhTrang.selectedIndex = 1;
                else
                    cmbTinhTrang.selectedIndex = 0;

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
            string MaDC = string.Empty, str;
            con.Close();
            con.Open();
            cmdDC = new SqlCommand("SELECT MAX([Mã dụng cụ]) as max FROM dbo.DUNGCU WHERE [Mã dụng cụ] LIKE 'DC_16%'", con);
            SqlDataReader dta = cmdDC.ExecuteReader();
            if (dta.Read() == true && dta.GetValue(0).ToString()!="")
            {
                MaDC = dta["max"].ToString();
                len = MaDC.Length;
                for (j = 0; j < len; j++)
                {
                    MaDC = (dta["max"].ToString()).Substring(j);
                    if (Regex.IsMatch(MaDC, @"^\d+$"))
                    {
                        break;
                    }
                }
                str = (dta["max"].ToString()).Substring(0, j);
                num = Convert.ToInt32(MaDC);
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
            if (txtMaDC.Text != "" && txtTenDC.Text != "" && txtGia.Text != "")
            {
                con.Open();
                if(cmbKhuVuc.selectedValue=="Trong kho")
                {
                    cmdDC = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + txtMaDC.Text + "',N'" + txtTenDC.Text + "','" + txtGia.Text + "',N'" + cmbTinhTrang.selectedValue +
                    "',NULL,N'" + cmbKhuVuc.selectedValue + "',N'Insert'", con);
                }
                else
                {
                    cmdDC = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + txtMaDC.Text + "',N'" + txtTenDC.Text + "','" + txtGia.Text + "',N'" + cmbTinhTrang.selectedValue +
                    "','"+DateTime.Now.ToShortDateString()+"',N'" + cmbKhuVuc.selectedValue + "',N'Insert'", con);
                }
                cmdDC.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công");
                HideF();
            }
            else
            {
                MessageBox.Show("Nhập thiếu");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            if (SubClasses.GetDataDC.ngaySD=="" && cmbKhuVuc.selectedValue=="Trong kho")
            {
                cmdDC = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + txtMaDC.Text + "',N'" + txtTenDC.Text + "','" + txtGia.Text + "',N'" + cmbTinhTrang.selectedValue +
                "',NULL,N'" + cmbKhuVuc.selectedValue + "',N'Update'", con);
            }
            else if(SubClasses.GetDataDC.ngaySD == "" && cmbKhuVuc.selectedValue != "Trong kho")
            {
                cmdDC = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + txtMaDC.Text + "',N'" + txtTenDC.Text + "','" + txtGia.Text + "',N'" + cmbTinhTrang.selectedValue +
                "','" + DateTime.Now.ToShortDateString() + "',N'" + cmbKhuVuc.selectedValue + "',N'Update'", con);
            }
            else
            {
                cmdDC = new SqlCommand("EXECUTE dbo.IUD_DUNGCU '" + txtMaDC.Text + "',N'" + txtTenDC.Text + "','" + txtGia.Text + "',N'" + cmbTinhTrang.selectedValue +
                "','" + Convert.ToDateTime(SubClasses.GetDataDC.ngaySD)+ "',N'" + cmbKhuVuc.selectedValue + "',N'Update'", con);
            }
            cmdDC.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sửa thành công");
            HideF();
        }
    }
}
