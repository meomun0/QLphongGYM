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
using System.Text.RegularExpressions;

namespace QLphongGYM.Layout
{
    public partial class Thu : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlDataAdapter adapt;
        SqlCommand cmdKG;
        SqlDataReader dta;
        string makhach, magoi,SLtien;

        public Thu()
        {
            InitializeComponent();
            //water mark tim kiem textbox
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
            }

        private void Thu_Load(object sender, EventArgs e)
        {
            DisplayData();

            cmbFilter.SelectedIndex = 1;
            txtNgThucHien.Text = UserInfo.ID;
            //add Delete Icon
            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.HeaderText = "Xoá";
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataThu.Columns.Add(delbut2);
            //
            btnSave.Visible = false;
            btnCancel.Visible = false;
            panelContent.Visible = false;
            txtMaThu.Enabled = false;
            txtNgThucHien.Enabled = false;

            con.Open();
            DataTable dt2 = new DataTable();
            adapt = new SqlDataAdapter("SELECT [Họ tên]+'('+[Mã khách]+')' AS 'makhach' FROM dbo.KHÁCH", con);
            adapt.Fill(dt2);
            foreach (DataRow row in dt2.Rows)
            {
                txtMaKhach.Items.Add((string)row["makhach"]);
            }
            con.Close();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.userName == "admin")
            {
                adapt = new SqlDataAdapter("select * from dbo.[THU]", con);
            }
            else
            {
                this.dataThu.Columns[7].Visible = false;
                adapt = new SqlDataAdapter("select * from dbo.[THU] where IsDel = 0 ", con);
            }
            adapt.Fill(dt);
            dataThu.DataSource = dt;
            con.Close();
        }
        #region
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
        #endregion
        //Tách mã khách
        private void MaKhach_Change(object sender, EventArgs e)
        {
            makhach = txtMaKhach.Text;
            int len = makhach.Length;
            int vt = makhach.IndexOf("(");
            makhach = makhach.Substring(vt + 1, len - vt - 2);//Tách mã khách chỉ còn mã không còn tên 
            txtMaGoi.ResetText();
            txtSLTien.Text = string.Empty;
        }
        //Load các gói tập của khách đã chọn vào textbox gói tập
        private void MaKhach_Leave(object sender, EventArgs e)
        {
            if (txtMaKhach.Text != "")
            {
                txtMaGoi.Items.Clear();
                txtMaGoi.ResetText();
                txtSLTien.Text = string.Empty;
                con.Open();
                cmdKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] where [Mã khách]='" + makhach + "'", con);
                SqlDataReader dtathu = cmdKG.ExecuteReader();
                if (dtathu.Read() == true)
                {
                    con.Close();
                    con.Open();
                    DataTable dt = new DataTable();
                    adapt = new SqlDataAdapter("SELECT [Tên gói tập]+'('+[Mã gói tập]+')' AS ma FROM dbo.[GÓI TẬP] WHERE [Mã gói tập] IN(" +
                                                "SELECT [Mã gói tập] FROM dbo.KHACH_GOI WHERE[Mã khách hàng] = '" + makhach + "'AND [ThanhToan(Y/N)]=0)", con);
                    adapt.Fill(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        txtMaGoi.Items.Add((string)row["ma"]);
                    }
                }
                else
                {
                    txtMaKhach.ResetText();
                    con.Close();
                    MessageBox.Show("Mã khách không hợp lệ");
                }
                txtMaGoi.Items.Add("Gia hạn thẻ(GH_0001)");
                con.Close();
            }
            else
            {
                MessageBox.Show("Nhập mã khách trước");
            }
        }
        //HIện tiền ; tách mã gói tập; thêm mô tả
        private void MaGoi_Change(object sender, EventArgs e)
        {
            if (makhach != "")
            {
                con.Open();
                cmdKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] where [Mã khách]='" + makhach + "'", con);
                SqlDataReader dta = cmdKG.ExecuteReader();
                if (dta.Read() == true)
                {
                    magoi = txtMaGoi.Text;
                    int len = magoi.Length;
                    int vt = magoi.IndexOf("(");
                    magoi = magoi.Substring(vt + 1, len - vt - 2);
                    con.Close();
                    con.Open();
                    cmdKG = new SqlCommand("SELECT [Giá] FROM dbo.[GÓI TẬP] where [Mã gói tập]='" + magoi + "'", con);
                    SqlDataReader dtathu = cmdKG.ExecuteReader();
                    if (dtathu.Read() == true)
                    {
                        int vitri = (dtathu["Giá"].ToString()).IndexOf(".");
                        SLtien = (dtathu["Giá"].ToString()).Substring(0, vitri);
                        txtSLTien.Text = SLtien;
                    }
                    con.Close();
                    //Thêm mô tả
                    string mg, tengoi, mk, tenkhach;
                    mg = txtMaGoi.Text;
                    tengoi = mg.Substring(0, vt);
                    mk = txtMaKhach.Text;
                    vt = mk.IndexOf("(");
                    tenkhach = mk.Substring(0, vt);
                    if (magoi == "GH_0001")
                    {
                        txtMota.Text = "Khách hàng " + tenkhach + " gia hạn thẻ ";
                        SuggestID(magoi);
                    }
                    else
                    {
                        txtMota.Text = "Khách hàng " + tenkhach + " đóng tiền gói tập " + tengoi;
                        SuggestID(magoi);
                    }
                }
                else
                {
                    txtMaKhach.ResetText();
                    con.Close();
                    MessageBox.Show("Mã khách không hợp lệ");
                }
            }
            else
            {
                txtMaKhach.ResetText();
                con.Close();
                MessageBox.Show("Nhập mã khách trước");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[THU] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%' and IsDel=0", con);
            adapt.Fill(dt);
            dataThu.DataSource = dt;
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            panelContent.Visible = true;
            btnSave.Visible = true;
            btnInsert.Visible = false;
            btnCancel.Visible = true;
            txtThoiGian.Text = DateTime.Now.ToString();
            txtMaThu.Text = string.Empty;
            txtMaGoi.ResetText();
            txtMaGoi.Items.Clear();
            txtMaKhach.ResetText();
            txtMota.Text = string.Empty;
            txtSLTien.Text = string.Empty;
            btnPrint.Visible = false;
        }

        private bool isExist(string makhach, string magoi)
        {
            con.Open();
            cmdKG = new SqlCommand("SELECT * FROM dbo.[KHÁCH] WHERE [Mã khách]='" + makhach + "'", con);
            SqlDataReader dta = cmdKG.ExecuteReader();
            if (dta.Read() == false)
            {
                con.Close();
                MessageBox.Show("Khách hàng "+makhach+" không tồn tại.");
                return false;
            }
            else
            {
                con.Close();
                con.Open();
                cmdKG = new SqlCommand("SELECT * FROM dbo.[GÓI TẬP] WHERE [Mã gói tập]='" + magoi + "'", con);
                SqlDataReader dta2 = cmdKG.ExecuteReader();
                if ((dta2.Read() == true && dta2.GetValue(0).ToString() != "") || magoi=="GH_0001")
                {
                    con.Close();
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

        private void SuggestID(string type)
        {
            int num;
            string MaThu = string.Empty, str;
            if(type== "GH_0001")
            {
                con.Open();
                cmdKG = new SqlCommand("SELECT MAX([Mã thu]) as max FROM dbo.THU where [Mã thu] like 'GH_18%'", con);
                dta = cmdKG.ExecuteReader();
                if (dta.Read() == true && dta.GetValue(0).ToString() != "")
                {
                    MaThu = (dta["max"].ToString()).Substring(3);
                    str = (dta["max"].ToString()).Substring(0, 3);
                    num = Convert.ToInt32(MaThu);
                    num++;
                    txtMaThu.Text = str + num;
                }
                else
                {
                    txtMaThu.Text = "GH_180000";
                }
                con.Close();
            }
            else
            {
                con.Open();
                cmdKG = new SqlCommand("SELECT MAX([Mã thu]) as max FROM dbo.THU where [Mã thu] like 'M_18%'", con);
                dta = cmdKG.ExecuteReader();
                if (dta.Read() == true && dta.GetValue(0).ToString() != "")
                {
                    MaThu = (dta["max"].ToString()).Substring(2);
                    str = (dta["max"].ToString()).Substring(0, 2);
                    num = Convert.ToInt32(MaThu);
                    num++;
                    txtMaThu.Text = str + num;
                }
                else
                {
                    txtMaThu.Text = "M_180000";
                }
                con.Close();
            } 
        }

        private void dataThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string test = dataThu.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (dataThu.CurrentCell != null && dataThu.CurrentCell.Value != null)
            {
                Report.dataTHU.mathu = dataThu.Rows[e.RowIndex].Cells[0].Value.ToString();
                Report.dataTHU.makhach = dataThu.Rows[e.RowIndex].Cells[1].Value.ToString();
                Report.dataTHU.sotien = dataThu.Rows[e.RowIndex].Cells[3].Value.ToString();
                Report.dataTHU.noidung = dataThu.Rows[e.RowIndex].Cells[5].Value.ToString();
                con.Close();
                con.Open();
                cmdKG = new SqlCommand("SELECT [Số điện thoại],[Địa chỉ] FROM dbo.KHÁCH WHERE [Mã khách] = '" + Report.dataTHU.makhach + "'", con);
                dta = cmdKG.ExecuteReader();
                if (dta.Read() == true)
                {
                    Report.dataTHU.sdt = dta["Số điện thoại"].ToString();
                    Report.dataTHU.diachi = dta["Địa chỉ"].ToString();
                }
                con.Close();
                Report.dataTHU.longdate = DateTime.Now.ToString();
                Report.dataTHU.shortdate= dataThu.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            if (dataThu.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                if (dataThu.CurrentCell != null && dataThu.CurrentCell.Value != null)
                {
                    con.Open();
                    string del = dataThu.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (UserInfo.userName == "admin")
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ thu chi: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            cmdKG = new SqlCommand("DELETE FROM dbo.THU WHERE [Mã thu]='" + del + "'", con);
                            cmdKG.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ thu chi: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            cmdKG = new SqlCommand("UPDATE dbo.THU SET IsDel = 1 WHERE [Mã thu] ='" + del + "'", con);
                            cmdKG.ExecuteNonQuery();
                        }
                    }
                    con.Close();
                    DisplayData();
                }
            }
            
            if (dataThu.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataThu.CurrentCell != null && dataThu.CurrentCell.Value != null)
                {
                    if (dataThu.Rows[e.RowIndex].Cells[7].Value.ToString() == "True" && UserInfo.privilege == "high")
                    {
                        if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            con.Open();
                            string maThu = dataThu.Rows[e.RowIndex].Cells[0].Value.ToString();
                            cmdKG = new SqlCommand("UPDATE dbo.THU SET IsDel = 0 WHERE [Mã thu] ='" + maThu + "'", con);
                            cmdKG.ExecuteNonQuery();
                            con.Close();
                            DisplayData();
                        }
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSLTien.Text != "" && isExist(makhach, magoi) && Regex.IsMatch(txtSLTien.Text, @"^\d+$"))
            {
                if (MessageBox.Show("Xác nhận thêm thu tiền gói tập: " + magoi + " của khách: " + makhach, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Close();
                    con.Open();
                    cmdKG = new SqlCommand("EXECUTE [dbo].[ID_Thu] '" +txtMaThu.Text+ "','" + makhach + "','" + magoi + "','" + txtSLTien.Text + "','" + UserInfo.ID + "',N'" + txtMota.Text + "','Insert'", con);
                    cmdKG.ExecuteNonQuery();
                    con.Close();
                    DisplayData();

                    if (magoi != "GH_0001")
                    {
                        con.Open();
                        cmdKG = new SqlCommand("update dbo.[KHACH_GOI] set " +
                        "[ThanhToan(Y/N)] ='1' where [Mã khách hàng] = '" + makhach + "' and [Mã gói tập]='" + magoi + "'", con);
                        cmdKG.ExecuteNonQuery();
                        con.Close();
                    }

                    txtMaGoi.ResetText();
                    txtMaGoi.Items.Clear();
                    txtMaKhach.ResetText();
                    txtMota.Text = string.Empty;
                    txtSLTien.Text = string.Empty;
                    if (MessageBox.Show("Thêm nữa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        panelContent.Visible = false;
                        btnSave.Enabled = false;
                        btnInsert.Visible = true;
                        btnCancel.Visible = false;
                        btnPrint.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền các thông tin còn trống hoặc nhập đúng định dang số lượng tiền (Số)");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaGoi.ResetText();
            txtMaGoi.Items.Clear();
            txtMaKhach.ResetText();
            txtMota.Text = string.Empty;
            txtSLTien.Text = string.Empty;
            panelContent.Visible = false;
            btnSave.Visible = false;
            btnInsert.Visible = true;
            btnCancel.Visible = false;
            btnPrint.Visible = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Report.RptThu formRp = new Report.RptThu();
            formRp.ShowDialog();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnGiaHanThe_Click(object sender, EventArgs e)
        {
            SubForms.LichSuGiaHanThe giaHanThe = new SubForms.LichSuGiaHanThe();
            giaHanThe.ShowDialog();
            DisplayData();
        }
    }
}