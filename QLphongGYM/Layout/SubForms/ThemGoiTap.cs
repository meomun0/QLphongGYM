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
    public partial class ThemGoiTap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdGT;
        string genID;
        public ThemGoiTap()
        {
            InitializeComponent();
        }
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

        private void ThemGoiTap_Load(object sender, EventArgs e)
        {
            txtMaGoi.Enabled = false;
            btnUpdate.Visible = false;
            if (SubClasses.GetDataGoiTap.UpdateModeOn == true)
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                cmbTenGoi.Enabled = false;

                cmbTenGoi.Text = SubClasses.GetDataGoiTap.tenGoi;
                DPngayBD.Value = SubClasses.GetDataGoiTap.ngayBD;
                DPngayKT.Value = SubClasses.GetDataGoiTap.ngayKT;
                txtGia.Text = SubClasses.GetDataGoiTap.gia;
                txtMaGoi.Text = SubClasses.GetDataGoiTap.maGoi;

                if (SubClasses.GetDataGoiTap.ca == "Sáng") cmbCaTap.selectedIndex = 0;
                else if (SubClasses.GetDataGoiTap.ca == "Chiều") cmbCaTap.selectedIndex = 1;
                else if (SubClasses.GetDataGoiTap.ca == "Tối") cmbCaTap.selectedIndex = 2;
                else cmbCaTap.selectedIndex = 3;

                if (SubClasses.GetDataGoiTap.khuVuc == "Public studio") cmbKhuVuc.selectedIndex = 0;
                else if (SubClasses.GetDataGoiTap.khuVuc == "Body and Mind studio") cmbKhuVuc.selectedIndex = 2;
                else cmbKhuVuc.selectedIndex = 1;

                CK2.Checked = false; CK3.Checked = false; CK4.Checked = false; CK5.Checked = false; CK6.Checked = false; CK7.Checked = false; CKCN.Checked = false;
                string buoitap = SubClasses.GetDataGoiTap.buoi;
                int len = buoitap.Length;
                for (int i = 0; i < len; i += 3)
                {
                    string day = buoitap.Substring(i, 2);
                    if (day == "T2") CK2.Checked = true;
                    if (day == "T3") CK3.Checked = true;
                    if (day == "T4") CK4.Checked = true;
                    if (day == "T5") CK5.Checked = true;
                    if (day == "T6") CK6.Checked = true;
                    if (day == "T7") CK7.Checked = true;
                    if (day == "CN") CKCN.Checked = true;
                }
            }
        }
        //kiều anh 8
        //thu giang 7.5
        //hồng 
        //hải 8
        #region
        private void cmbPhanLoai_Leave(object sender, EventArgs e)
        {
            string type = cmbTenGoi.Text;
            con.Open();
            
            if(type == "Lớp thường")
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_T%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = dta["max"].ToString();
                    if (temp != "")
                    {
                        temp = (dta["max"].ToString()).Substring(5);
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "GYM_T" + num;
                        con.Close();
                        con.Open();
                        cmdGT = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_T%' ", con);
                        SqlDataReader dta2 = cmdGT.ExecuteReader();
                        if (dta2.Read())
                        {
                            txtGia.Text = dta2["Giá"].ToString();
                        }
                    }
                    else
                    {
                        genID = "GYM_T1";
                        txtGia.Text = "";
                    }
                    txtMaGoi.Text = genID;
                    con.Close();
                }
            }
            else if (type == "Lớp VIP")
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_V%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = dta["max"].ToString();
                    if (temp != "")
                    {
                        temp = (dta["max"].ToString()).Substring(5);
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "GYM_V" + num;
                        con.Close();
                        con.Open();
                        cmdGT = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_V%' ", con);
                        SqlDataReader dta2 = cmdGT.ExecuteReader();
                        if (dta2.Read())
                        {
                            txtGia.Text = dta2["Giá"].ToString();
                        }
                    }
                    else
                    {
                        genID = "GYM_V1";
                        txtGia.Text = "";
                    }
                    txtMaGoi.Text = genID;
                    con.Close();
                    
                }
            }
            else if (type == "Gói kèm riêng")
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_R%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = dta["max"].ToString();
                    if (temp != "")
                    {
                        temp = (dta["max"].ToString()).Substring(5);
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "GYM_R" + num;
                        con.Close();
                        con.Open();
                        cmdGT = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_R%' ", con);
                        SqlDataReader dta2 = cmdGT.ExecuteReader();
                        if (dta2.Read())
                        {
                            txtGia.Text = dta2["Giá"].ToString();
                        }
                    }
                    else
                    {
                        genID = "GYM_R1";
                        txtGia.Text = "";
                    }
                    txtMaGoi.Text = genID;
                    con.Close();
                }
            }
            else if (type=="Zumba")
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_Z%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = dta["max"].ToString();
                    if (temp != "")
                    {
                        temp = (dta["max"].ToString()).Substring(5);
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "GYM_Z" + num;
                        con.Close();
                        con.Open();
                        cmdGT = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_Z%' ", con);
                        SqlDataReader dta2 = cmdGT.ExecuteReader();
                        if (dta2.Read())
                        {
                            txtGia.Text = dta2["Giá"].ToString();
                        }
                    }
                    else
                    {
                        genID = "GYM_Z1";
                        txtGia.Text = "";
                    }
                    con.Close();
                    txtMaGoi.Text = genID;
                }
            }
            else if (type=="Aerobic")
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'Aerobic_%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = dta["max"].ToString();
                    if (temp != "")
                    {
                        temp = (dta["max"].ToString()).Substring(8);
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "Aerobic_" + num;
                        con.Close();
                        con.Open();
                        cmdGT = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'Aerobic%' ", con);
                        SqlDataReader dta2 = cmdGT.ExecuteReader();
                        if (dta2.Read())
                        {
                            txtGia.Text = dta2["Giá"].ToString();
                        }
                    }
                    else
                    {
                        genID = "Aerobic_1";
                        txtGia.Text = "";
                    }
                    txtMaGoi.Text = genID;
                    con.Close();
                }
            }
            else if (type == "Yoga")
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'Yoga_%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = dta["max"].ToString();
                    if (temp != "")
                    {
                        temp = (dta["max"].ToString()).Substring(8);
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "Yoga_" + num;
                        con.Close();
                        con.Open();
                        cmdGT = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'Yoga_%' ", con);
                        SqlDataReader dta2 = cmdGT.ExecuteReader();
                        if (dta2.Read())
                        {
                            txtGia.Text = dta2["Giá"].ToString();
                        }
                    }
                    else
                    {
                        genID = "Yoga_1";
                        txtGia.Text = "";
                    }
                    txtMaGoi.Text = genID;
                    con.Close();
                }
            }
            else
            {
                cmdGT = new SqlCommand("SELECT MAX([Mã gói tập]) as max FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] LIKE 'GYM_K%' ", con);
                SqlDataReader dta = cmdGT.ExecuteReader();
                if (dta.Read())
                {
                    string temp;
                    int num;
                    temp = (dta["max"].ToString()).Substring(5);
                    if (temp != "")
                    {
                        num = Convert.ToInt32(temp);
                        num++;
                        genID = "GYM_K" + num;
                    }
                    else genID = "GYM_K1";
                    con.Close();
                    txtMaGoi.Text = cmbTenGoi.Text;
                }
            }
        }
        #endregion
        private void HideF()
        {
            this.Hide();
            SubClasses.GetDataGoiTap.UpdateModeOn = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtMaGoi.Text!="" && txtGia.Text != "" && Regex.IsMatch(txtGia.Text, @"^\d+$"))
            {
                string buoitap = string.Empty;
                if (CK2.Checked == true) buoitap = buoitap + "T2 ";
                if (CK3.Checked == true) buoitap = buoitap + "T3 ";
                if (CK4.Checked == true) buoitap = buoitap + "T4 ";
                if (CK5.Checked == true) buoitap = buoitap + "T5 ";
                if (CK6.Checked == true) buoitap = buoitap + "T6 ";
                if (CK7.Checked == true) buoitap = buoitap + "T7 ";
                if (CKCN.Checked == true) buoitap = buoitap + "CN ";
                con.Open();
                cmdGT = new SqlCommand("EXECUTE dbo.IUD_GOITAP '" + txtMaGoi.Text + "',N'" + cmbTenGoi.Text + "','" + txtGia.Text +
                    "','" + DPngayBD.Value.ToShortDateString() + "','" + DPngayKT.Value.ToShortDateString() + "',N'" + buoitap +
                    "',N'" + cmbCaTap.selectedValue + "',N'" + cmbKhuVuc.selectedValue + "','0',N'Insert'", con);
                cmdGT.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công");
                txtMaGoi.ResetText();
                cmbTenGoi.ResetText();
                txtGia.ResetText();
                HideF();
            }
            else
                MessageBox.Show("Nhập thiếu hoặc gói tập không là 1 số");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string buoitap = string.Empty;
            if (CK2.Checked == true) buoitap = buoitap + "T2 ";
            if (CK3.Checked == true) buoitap = buoitap + "T3 ";
            if (CK4.Checked == true) buoitap = buoitap + "T4 ";
            if (CK5.Checked == true) buoitap = buoitap + "T5 ";
            if (CK6.Checked == true) buoitap = buoitap + "T6 ";
            if (CK7.Checked == true) buoitap = buoitap + "T7 ";
            if (CKCN.Checked == true) buoitap = buoitap + "CN ";
            con.Close();
            con.Open();
            cmdGT = new SqlCommand("EXECUTE dbo.IUD_GOITAP '" + txtMaGoi.Text + "',N'" + cmbTenGoi.Text + "','" + txtGia.Text +
                    "','" + DPngayBD.Value.ToShortDateString() + "','" + DPngayKT.Value.ToShortDateString() + "',N'" + buoitap +
                    "',N'" + cmbCaTap.selectedValue + "',N'" + cmbKhuVuc.selectedValue + "','0',N'Update'", con);
            cmdGT.ExecuteNonQuery();
            HideF();
        }
    }
}
