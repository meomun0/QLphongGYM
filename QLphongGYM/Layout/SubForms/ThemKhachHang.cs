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
    public partial class ThemKhachHang : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdKH;
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
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            HideF();
        }

        private void HideF()
        {
            this.Hide();
            SubClasses.GetDataKhach.UpdateModeOn = false;
        }

        private void SuggestID()
        {
            int len, j, num;
            string MaKM = string.Empty, str;
            con.Close();
            con.Open();
            cmdKH = new SqlCommand("SELECT MAX([Mã khách]) as max FROM dbo.KHÁCH", con);
            SqlDataReader dta = cmdKH.ExecuteReader();
            if (dta.Read() == true && dta.GetValue(0).ToString() != "")
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
                SugID = "KH_150000";
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtSDT.Text!="")
            {
                con.Open();
                cmdKH = new SqlCommand("EXECUTE dbo.IUD_KHACH '" + txtMaKhach.Text + "',N'" + txtHoTen.Text + "',N'" + cmbGT.selectedValue + "','" + DPNS.Value.ToShortDateString() +
                    "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "','"+DateTime.Now.ToShortDateString()+"','"+ DateTime.Now.ToShortDateString() + "',N'Insert'", con);
                cmdKH.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công");
                HideF();
            }
            else
                MessageBox.Show("Nhập thiếu");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text != "" && txtSDT.Text != "" && txtSDT.Text != "")
            {
                con.Open();
                cmdKH = new SqlCommand("EXECUTE dbo.IUD_KHACH '" + txtMaKhach.Text + "',N'" + txtHoTen.Text + "',N'" + cmbGT.selectedValue + "','" + DPNS.Value.ToShortDateString() +
                    "','" + txtSDT.Text + "',N'" + txtDiaChi.Text + "','" + SubClasses.GetDataKhach.ngayDK + "','" + DPHanThe.Value.ToShortDateString() + "',N'Update'", con);
                cmdKH.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cập nhật thành công");
                HideF();
            }
            else
                MessageBox.Show("Nhập thiếu");
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            SuggestID();
            if (SubClasses.GetDataKhach.UpdateModeOn == false)
            {
                txtMaKhach.Text = SugID;
                btnUpdate.Visible = false;
                DPHanThe.Enabled = false;
                DPHanThe.Value = DateTime.Now;
            }
            else
            {
                DPHanThe.Value = SubClasses.GetDataKhach.hanThe;
                btnSave.Visible = false;
                txtMaKhach.Text = SubClasses.GetDataKhach.maKhach;
                txtHoTen.Text = SubClasses.GetDataKhach.tenKhach;
                DPNS.Value = SubClasses.GetDataKhach.NS;
                txtSDT.Text = SubClasses.GetDataKhach.SDT;
                txtDiaChi.Text = SubClasses.GetDataKhach.diaChi;
                if (SubClasses.GetDataKhach.GT == "Nam")
                    cmbGT.selectedIndex = 0;
                else
                    cmbGT.selectedIndex = 1;
            }
        }
    }
}
