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
    public partial class ThemNV : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdNV;
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
        public ThemNV()
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
            SubClasses.GetNVData.UpdateModeOn = false;
        }

        private void SuggestID()
        {
            int len, j, num;
            string MaKM = string.Empty, str;
            con.Close();
            con.Open();
            cmdNV = new SqlCommand("SELECT MAX([Mã NV]) as max FROM dbo.NHANVIEN", con);
            SqlDataReader dta = cmdNV.ExecuteReader();
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
                SugID = "NV_140000";
            }
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" || txtSDT.Text != "" || txtLuong.Text != "" || txtQueQuan.Text != "")
            {
                con.Open();
                cmdNV = new SqlCommand("EXECUTE dbo.IUD_NHANVIEN '" + txtMaNV.Text + "',N'"+txtTenNV.Text+"','"+DPNS.Value+"',N'"+cmbGT.selectedValue+
                    "','"+txtSDT.Text+"',N'"+cmbChucVu.selectedValue+"',N'"+cmbCaLam.selectedValue+"','" + DateTime.Now.ToShortDateString()+
                    "','"+txtLuong.Text+"',N'"+txtQueQuan.Text+"',N'Insert'", con);
                cmdNV.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm thành công");
                HideF();
            }
            else
                MessageBox.Show("Nhập thiếu");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" || txtSDT.Text != "" || txtLuong.Text != "" || txtQueQuan.Text != "")
            {
                con.Open();
                cmdNV = new SqlCommand("EXECUTE dbo.IUD_NHANVIEN '" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','" + DPNS.Value + "',N'" + cmbGT.selectedValue +
                    "','" + txtSDT.Text + "',N'" + cmbChucVu.selectedValue + "',N'" + cmbCaLam.selectedValue + "','" + DPNBD.Value.ToShortDateString() +
                    "','" + txtLuong.Text + "',N'" + txtQueQuan.Text + "',N'Update'", con);
                cmdNV.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Cập nhật thành công");
                HideF();
            }
            else
                MessageBox.Show("Nhập thiếu");
        }

        private void ThemNV_Load(object sender, EventArgs e)
        {
            SuggestID();
            if (SubClasses.GetNVData.UpdateModeOn == false)
            {
                txtMaNV.Text = SugID;
                DPNBD.Value = DateTime.Now;
                btnUpdate.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                txtMaNV.Text = SubClasses.GetNVData.maNV;
                txtTenNV.Text = SubClasses.GetNVData.tenNV;
                DPNS.Value = SubClasses.GetNVData.NS;
                if (SubClasses.GetNVData.GT == "Nam") cmbGT.selectedIndex = 0;
                else cmbGT.selectedIndex = 1;
                txtSDT.Text = SubClasses.GetNVData.SDT;
                if (SubClasses.GetNVData.chucVu == "HLV") cmbChucVu.selectedIndex = 0;
                else if (SubClasses.GetNVData.chucVu == "Bảo vệ") cmbChucVu.selectedIndex = 1;
                else if (SubClasses.GetNVData.chucVu == "Kế toán") cmbChucVu.selectedIndex = 2;
                else if (SubClasses.GetNVData.chucVu == "Quản lý") cmbChucVu.selectedIndex = 3;
                else cmbChucVu.selectedIndex = 4;
                if (SubClasses.GetNVData.caLam == "Cả ngày") cmbCaLam.selectedIndex = 0;
                else if (SubClasses.GetNVData.caLam == "Sáng + Chiều") cmbCaLam.selectedIndex = 1;
                else if (SubClasses.GetNVData.caLam == "Sáng") cmbCaLam.selectedIndex = 2;
                else if (SubClasses.GetNVData.caLam == "Chiều") cmbCaLam.selectedIndex = 3;
                else cmbCaLam.selectedIndex = 4;
                DPNBD.Value = SubClasses.GetNVData.ngayBD;
                txtLuong.Text = SubClasses.GetNVData.luong;
                txtQueQuan.Text = SubClasses.GetNVData.que;
            }
        }
    }
}
