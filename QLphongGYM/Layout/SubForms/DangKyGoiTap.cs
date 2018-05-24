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
    public partial class DangKyGoiTap : Form
    {
        public DangKyGoiTap()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdDKG;
        string mathu,makhach, magoi,mota;
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

        private bool isExist(string makhach, string magoi)
        {
            con.Open();
            cmdDKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] WHERE [Mã khách]='" + makhach + "'", con);
            SqlDataReader dta = cmdDKG.ExecuteReader();
            if (dta.Read() == false)
            {
                con.Close();
                MessageBox.Show("Khách hàng " + makhach + " không tồn tại.");
                return false;
            }
            else
            {
                con.Close();
                con.Open();
                cmdDKG = new SqlCommand("SELECT * FROM dbo.[GÓI TẬP] WHERE [Mã gói tập]='" + magoi + "'", con);
                SqlDataReader dta2 = cmdDKG.ExecuteReader();
                if ((dta2.Read() == true && dta2.GetValue(0).ToString() != ""))
                {
                    return true;
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Gói tập " + magoi + " không tồn tại.");
                    return false;
                }
            }
        }

        private void SuggestID()
        {
            SqlDataReader dta;
            int num;
            string MaThu = string.Empty, str;
            con.Close();
            con.Open();
            cmdDKG = new SqlCommand("SELECT MAX([Mã thu]) as max FROM dbo.THU where [Mã thu] like 'M_18%'", con);
            dta = cmdDKG.ExecuteReader();
            if (dta.Read() == true && dta.GetValue(0).ToString() != "")
            {
                MaThu = (dta["max"].ToString()).Substring(2);
                str = (dta["max"].ToString()).Substring(0, 2);
                num = Convert.ToInt32(MaThu);
                num++;
                mathu = str + num;
            }
            else
            {
                mathu = "M_180000";
            }
            con.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DangKyGoiTap_Load(object sender, EventArgs e)
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
        }

        private void cmbKhach_SelectedValueChanged(object sender, EventArgs e)
        {
            makhach = cmbKhach.Text;
            int len = makhach.Length;
            int vt = makhach.IndexOf("(");
            makhach = makhach.Substring(vt + 1, len - vt - 2);
            cmbTenGoi.ResetText();
            txtGia.Text = string.Empty;
        }

        private void cmbKhach_Leave(object sender, EventArgs e)
        {
            if (cmbKhach.Text != "")
            {
                cmbTenGoi.Items.Clear();
                cmbTenGoi.ResetText();
                txtGia.Text = string.Empty;
                con.Close();
                con.Open();
                cmdDKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] where [Mã khách]='" + makhach + "'", con);
                SqlDataReader dtathu = cmdDKG.ExecuteReader();
                if (dtathu.Read() == true)
                {
                    con.Close();
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT [Tên gói tập]+'('+[Mã gói tập]+')' AS ma FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] NOT IN(" +
                                                "SELECT [Mã gói tập] FROM dbo.KHACH_GOI WHERE[Mã khách hàng] = '" + makhach + "')", con);
                    adapt.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        cmbTenGoi.Items.Add((string)row["ma"]);
                    }
                }
                else
                {
                    cmbKhach.ResetText();
                    MessageBox.Show("Mã khách không hợp lệ");
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Nhập mã khách trước");
            }
        }

        private void cmbTenGoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (makhach != "")
            {
                SqlDataReader dta;
                con.Close();
                con.Open();
                cmdDKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] where [Mã khách]='" + makhach + "'", con);
                dta = cmdDKG.ExecuteReader();
                if (dta.Read() == true)
                {
                    magoi = cmbTenGoi.Text;
                    int len = magoi.Length;
                    int vt = magoi.IndexOf("(");
                    magoi = magoi.Substring(vt + 1, len - vt - 2);
                    con.Close();
                    con.Open();
                    cmdDKG = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] where [Mã gói tập]='" + magoi + "'", con);
                    dta = cmdDKG.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        int vitri = (dta["Giá"].ToString()).IndexOf(".");
                        string SLTien = (dta["Giá"].ToString()).Substring(0, vitri);
                        txtGia.Text = SLTien;
                    }
                    //Thêm mô tả
                    string mg, tengoi, mk, tenkhach;
                    mg = cmbTenGoi.Text;
                    tengoi = mg.Substring(0, vt);
                    mk = cmbKhach.Text;
                    vt = mk.IndexOf("(");
                    tenkhach = mk.Substring(0, vt);
                    mota = "Khách hàng " + tenkhach + " đóng tiền gói tập " + tengoi;
                    //Thêm thời gian
                    con.Close();
                    con.Open();
                    cmdDKG = new SqlCommand("SELECT [Ngày bắt đầu],[Ngày kết thúc] FROM dbo.[GÓI TẬP] where [Mã gói tập]='" + magoi + "'", con);
                    dta = cmdDKG.ExecuteReader();
                    if (dta.Read() == true)
                    {
                        DPngayBD.Value = Convert.ToDateTime(dta["Ngày bắt đầu"].ToString());
                        DPngayKT.Value = Convert.ToDateTime(dta["Ngày kết thúc"].ToString());
                        con.Close();
                    }
                }
                else
                {
                    con.Close();
                    cmbKhach.ResetText();
                    MessageBox.Show("Mã khách không hợp lệ");
                }
            }
            else
            {
                cmbKhach.ResetText();
                MessageBox.Show("Nhập mã khách trước");
            }
        }

        private void cmbTenGoi_Enter(object sender, EventArgs e)
        {
            if (makhach != "")
            {
                con.Open();
                cmdDKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] where [Mã khách]='" + makhach + "'", con);
                SqlDataReader dta = cmdDKG.ExecuteReader();
                if (dta.Read() == false)
                {
                    cmbKhach.ResetText();
                    con.Close();
                    MessageBox.Show("Mã khách không hợp lệ");
                }
            }
            else
            {
                cmbKhach.ResetText();
                con.Close();
                MessageBox.Show("Nhập mã khách trước");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isExist(makhach, magoi))
            {
                SuggestID();
                con.Open();
                cmdDKG = new SqlCommand("EXECUTE dbo.ThanhToan_GoiTap '"+mathu+"','"+makhach+"','"+magoi+"','"+txtGia.Text+"',N'"+mota+"','"+UserInfo.ID+"'", con);
                cmdDKG.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thành công");
                cmbKhach.ResetText();
                cmbTenGoi.ResetText();
                txtGia.ResetText();
                makhach = string.Empty;
                magoi = string.Empty;
            }
        }

        private void btnSaveAndPrint_Click(object sender, EventArgs e)
        {
            SqlDataReader dta;
            if (isExist(makhach, magoi) && Regex.IsMatch(txtGia.Text, @"^\d+$"))
            {
                SuggestID();
                con.Open();
                cmdDKG = new SqlCommand("EXECUTE dbo.ThanhToan_GoiTap '" + mathu + "','" + makhach + "','" + magoi + "','" + txtGia.Text + "',N'" + mota + "','" + UserInfo.ID + "'", con);
                cmdDKG.ExecuteNonQuery();
                
                Report.dataTHU.mathu = mathu;
                Report.dataTHU.makhach = makhach;
                Report.dataTHU.sotien = txtGia.Text;
                Report.dataTHU.noidung = mota;
                cmdDKG = new SqlCommand("SELECT [Số điện thoại],[Địa chỉ] FROM dbo.KHÁCH WHERE [Mã khách] = '"+makhach+"'", con);
                dta = cmdDKG.ExecuteReader();
                if (dta.Read() == true)
                {
                    Report.dataTHU.sdt = dta["Số điện thoại"].ToString();
                    Report.dataTHU.diachi = dta["Địa chỉ"].ToString();
                }
                Report.dataTHU.longdate = DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.ToShortDateString();
                Report.dataTHU.shortdate = DateTime.Now.ToShortDateString();
                con.Close();
                cmbKhach.ResetText();
                cmbTenGoi.ResetText();
                txtGia.ResetText();
                makhach = string.Empty;
                magoi = string.Empty;
                Report.RptThu formRp = new Report.RptThu();
                formRp.ShowDialog();
            }
        }
    }
}
