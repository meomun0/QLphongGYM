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
    public partial class NhanVien : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
        SqlCommand KHCmd;
        SqlDataAdapter adapt;

        public NhanVien()
        {
            InitializeComponent();
            txtInp.ForeColor = SystemColors.GrayText;
            txtInp.Text = "Nhập N.dung tìm";
            this.txtInp.Leave += new System.EventHandler(this.txtInp_Leave);
            this.txtInp.Enter += new System.EventHandler(this.txtInp_Enter);
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            this.nHANVIENTableAdapter.Fill(this.gYMDataSet_NhanVien.NHANVIEN);
            cmbFilter.SelectedIndex=1;
        }
        
        private void dataGVKh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            con.Open();
            if (dataNhanVien.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataNhanVien.CurrentCell != null && dataNhanVien.CurrentCell.Value != null)
                {
                    txtMaNV.Text = dataNhanVien.CurrentCell.Value.ToString();
                    KHCmd = new SqlCommand("select * from dbo.NHANVIEN where [Mã NV]='" + txtMaNV.Text + "'", con);
                    SqlDataReader dtaKh = KHCmd.ExecuteReader();
                    if (dtaKh.Read() == true)
                    {
                        txtHoTen.Text = dtaKh["Tên"].ToString();
                        txtNS.Text = dtaKh["NS"].ToString();
                        txtGT.Text = dtaKh["GT"].ToString();
                        txtSDT.Text = dtaKh["Số điện thoại"].ToString();
                        txtChucVu.Text = dtaKh["Chức vụ"].ToString();
                        txtCaLam.Text = dtaKh["Ca Làm"].ToString();
                        txtNBD.Text = dtaKh["Ngày BĐ"].ToString();
                        txtLuong.Text = dtaKh["Lương"].ToString();
                        txtQueQuan.Text = dtaKh["Quê quán"].ToString();
                    }
                }
            }
            con.Close();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN]", con);
            adapt.Fill(dt);
            dataNhanVien.DataSource = dt;
            con.Close();
        }

        private void BtnNVUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            KHCmd = new SqlCommand("update dbo.[NHANVIEN] set " +
                "[Tên] =N'" + txtHoTen.Text + "', NS='" + txtNS.Text + "', GT ='" + txtGT.Text + "', [Số điện thoại] ='" + txtSDT.Text + "', [Chức vụ] =N'" + txtChucVu.Text + "', [Ca làm]=N'" + txtCaLam.Text + "', [Ngày BĐ]='" + txtNBD.Text + "'" + "', [Lương]='" + txtLuong.Text + "', [Quê quán]='" + txtQueQuan.Text + "'" +
                " where [Mã NV] = '" + txtMaNV.Text + "'", con);
            KHCmd.ExecuteNonQuery();
            MessageBox.Show("Cập nhật thành công ");
            con.Close();
            DisplayData();
        }

        private void btnKhDelete_Click(object sender, EventArgs e)
        {


        }

        private void btnKhInsert_Click(object sender, EventArgs e)
        {
            con.Open();
            KHCmd = new SqlCommand("select * from dbo.[NHANVIEN] where [Mã NV]='" + txtMaNV.Text + "'", con);
            SqlDataReader dtaKh = KHCmd.ExecuteReader();
            if (dtaKh.Read() == true)
            {
                MessageBox.Show("Đã tồn tại mã nhân viên:" + txtMaNV);
                con.Close();
            }
            else
            {
                con.Close();
                con.Open();
                KHCmd = new SqlCommand("INSERT INTO dbo.[NHANVIEN] VALUES  ( '" + txtMaNV.Text + "' ,N'" + txtHoTen.Text +
                    "' ,'" + txtNS.Text + "' ,N'" + txtGT.Text + "' ,'" + txtSDT.Text + "' ,N'" + txtChucVu.Text + 
                    "' ,'" + txtCaLam.Text + "' ,'" + txtNBD.Text + "','" + txtLuong.Text + "','" + txtQueQuan.Text + "')", con);
                KHCmd.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công ");
                con.Close();
                DisplayData();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[NHANVIEN] where [" + cmbFilter.Text + "] like N'%" + txtInp.Text + "%'", con);
            adapt.Fill(dt);
            dataNhanVien.DataSource = dt;
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
            if(txtInp.Text== "Nhập N.dung tìm")
            {
                txtInp.Text = "";
                txtInp.ForeColor = SystemColors.WindowText;
            }
        }
    }
}
