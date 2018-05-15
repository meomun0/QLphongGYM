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
    public partial class Chi : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand cmdChi;
        SqlDataAdapter adapt;
        string SugID;
        public Chi()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void Chi_Load(object sender, EventArgs e)
        {
            DisplayData();
            cmbFilter.SelectedIndex = 1;
            txtMaChi.Enabled = false;
            btnCancel.Enabled = false;
            con.Open();
            cmdChi = new SqlCommand("EXECUTE  [dbo].[insertEquipmentsPrice] 'NV_144706'", con);
            cmdChi.ExecuteNonQuery();
            con.Close();

            DataGridViewImageColumn delbut2 = new DataGridViewImageColumn();
            delbut2.Image = Image.FromFile(Environment.CurrentDirectory + @"\icons\delicon.png");
            delbut2.Width = 40;
            delbut2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataChi.Columns.Add(delbut2);
            txtNgThucHien.Enabled = false;
            txtThoiGian.Enabled = false;
            panel1.Visible = false;
            btnSave.Enabled = false;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            if (UserInfo.userName == "admin")
            {
                adapt = new SqlDataAdapter("select * from dbo.[CHI]", con);
            }
            else
            {
                this.dataChi.Columns[5].Visible = false;
                adapt = new SqlDataAdapter("select * from dbo.[CHI] where IsDel = 0 ", con);
            }
            adapt.Fill(dt);
            dataChi.DataSource = dt;
            con.Close();
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

        private void SuggestID()
        {
            int len, j, num;
            string MaKM = string.Empty, str;
            con.Close();
            con.Open();
            cmdChi = new SqlCommand("SELECT MAX([Mã chi]) as max FROM dbo.CHI where [Mã chi] like 'M_17%'", con);
            SqlDataReader dta = cmdChi.ExecuteReader();
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
                SugID = "M_170000";
            }
            txtMaChi.Text = SugID;
            con.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[CHI] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataChi.DataSource = dt;
            con.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            btnSave.Enabled = false;
            if (txtSLTien.Text != "" && txtNoiDung.Text!="")
            {
                if(Regex.IsMatch(txtSLTien.Text, @"^\d+$"))
                {
                    if (MessageBox.Show("Xác nhận thêm bản ghi", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        txtSLTien.Text = "-" + txtSLTien.Text;
                        con.Open();
                        cmdChi = new SqlCommand("EXECUTE  [dbo].[ID_Chi] '" + txtMaChi.Text + "','"+txtSLTien.Text+"',N'"+txtNoiDung.Text+"','"+UserInfo.ID+"','Insert'", con);
                        cmdChi.ExecuteNonQuery();
                        con.Close();
                        DisplayData();
                        SuggestID();
                        txtNoiDung.ResetText();
                        txtSLTien.ResetText();
                        if (MessageBox.Show("Thêm nữa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        {
                            panel1.Visible = false;
                            btnSave.Enabled = false;
                            btnInsert.Visible = true;
                            btnCancel.Visible = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng tiền phải là 1 số");
                }
            }
            else
                MessageBox.Show("Vui lòng điền các thông tin còn trống");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            panel1.Visible = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtNgThucHien.Text = UserInfo.ID;
            SuggestID();
            txtThoiGian.Value = DateTime.Now;
            txtSLTien.ResetText();
            txtNoiDung.ResetText();
        }

        private void dataThu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            if (dataChi.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataChi.CurrentCell != null && dataChi.CurrentCell.Value != null)
                {
                    string del = dataChi.Rows[e.RowIndex].Cells[0].Value.ToString();
                    if (UserInfo.userName == "admin")
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ thu chi: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            cmdChi = new SqlCommand("EXECUTE  [dbo].[ID_Chi] '"+del+"','','','','Delete'", con);
                            cmdChi.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        if ((MessageBox.Show("Xác nhận XOÁ thu chi: " + del, "Xác nhận XOÁ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                        {
                            cmdChi = new SqlCommand("EXECUTE  [dbo].[ID_Chi] '" + del + "','','','','Hide'", con);
                            cmdChi.ExecuteNonQuery();
                        }
                    }
                }
                if (dataChi.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)
                {
                    if (dataChi.CurrentCell != null && dataChi.CurrentCell.Value != null)
                    {
                        if (dataChi.Rows[e.RowIndex].Cells[10].Value.ToString() == "True" && UserInfo.privilege == "high")
                        {
                            con.Open();
                            if ((MessageBox.Show("Khôi phục dữ liệu bị ẩn", "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                            {
                                string maChi = dataChi.Rows[e.RowIndex].Cells[0].Value.ToString();
                                cmdChi = new SqlCommand("EXECUTE  [dbo].[ID_Chi] '" + maChi + "','','','','Show'", con);
                                cmdChi.ExecuteNonQuery();
                                con.Close();
                                DisplayData();
                            }
                        }
                    }
                }
            }
            con.Close();
            DisplayData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnSave.Enabled = false;
            btnInsert.Enabled = true;
            btnCancel.Enabled = false;
            SuggestID();
        }
    }
}
