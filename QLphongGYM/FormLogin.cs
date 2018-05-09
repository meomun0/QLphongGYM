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

namespace QLphongGYM
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=MY-PC\SQLEXPRESS;Initial Catalog=GYM;Integrated Security=True");
            try
            {
                cn.Open();
                string tk = txtTaiKhoan.Text;
                string mk = txtMatKhau.Text;
                string sql = "select * from dbo.Users where UserName='" + tk + "' and Pass='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, cn);
                SqlDataReader dta = cmd.ExecuteReader(); //select ExecuteReader();  insert/delete ExecuteNonQuery
                if (dta.Read() == true)
                {
                    UserInfo.userName = tk;
                    UserInfo.fullName = dta["FullName"].ToString();
                    UserInfo.privilege = dta["Privilege"].ToString();
                    UserInfo.ID = dta["ID"].ToString();
                    this.Close();
                    cn.Close();
                }
                else
                {
                    MessageBox.Show("Tên đang nhập hoặc mật khẩu sai.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
