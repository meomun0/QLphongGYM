using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLphongGYM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            panelTongquan.Controls.Add(new Layout.GoiTap());
        }


        private void btexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btThu_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.Thu());
        }

        private void btChi_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.Chi());
        }

        private void btkhachhang_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.Khach());
        }

        private void btDungCu_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.DungCu());
        }

        private void btGoiTap_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.GoiTap());
        }

        private void btKhachGoi_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.GoiCuaKhach());
        }

        private void btPhanCong_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.PhanCongHLV());
        }

        private void btThietBi_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.TBiCuaGoi());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.NhanVien());
        }

        private void TongQuan_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.GoiTap());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //    access.Enabled = false;
            //    logout.Enabled = false;
            //    btTongQuan.Enabled = false;
            //    btThu.Enabled = false;
            //    btChi.Enabled = false;
            //    btDungCu.Enabled = false;
            //    btkhachhang.Enabled = false;
            //    btKhachGoi.Enabled = false;
            //    btThietBi.Enabled = false;
            //    btNhanVien.Enabled = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            FormLogin formlogin = new FormLogin();
            formlogin.ShowDialog();
            if (UserInfo.privilege=="normal")
            {
                pictureBox1.Visible = true;
                Status.Text = "Xin chào: " + UserInfo.fullName + ", Username: " + UserInfo.userName + ", Quyền: " + UserInfo.privilege;
                pictureBox1.Image = Image.FromFile(@".\icons\hai1rs.png");
                login.Enabled = false;
                logout.Enabled = true;
                btTongQuan.Enabled = true;
                btThu.Enabled = true;
                btChi.Enabled = true;
                btDungCu.Enabled = true;
                btkhachhang.Enabled = true;
                btKhachGoi.Enabled = true;
                btThietBi.Enabled = true;
            }
            if (UserInfo.privilege == "high")
            {
                pictureBox1.Visible = true;
                Status.Text = "Xin chào: " + UserInfo.fullName + ", Username: " + UserInfo.userName + ", Quyền: " + UserInfo.privilege;
                pictureBox1.Image = Image.FromFile(@".\icons\hai3rs.PNG");
                login.Enabled = false;
                access.Enabled = true;
                logout.Enabled = true;
                btTongQuan.Enabled = true;
                btThu.Enabled = true;
                btChi.Enabled = true;
                btDungCu.Enabled = true;
                btkhachhang.Enabled = true;
                btKhachGoi.Enabled = true;
                btThietBi.Enabled = true;
                btNhanVien.Enabled = true;
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Status.Text = "Bạn chưa đăng nhập. Nhấp Login!!!";
                pictureBox1.Visible = false;
                login.Enabled = true;
                access.Enabled = false;
                logout.Enabled = false;
                btTongQuan.Enabled = false;
                btThu.Enabled = false;
                btChi.Enabled = false;
                btDungCu.Enabled = false;
                btkhachhang.Enabled = false;
                btKhachGoi.Enabled = false;
                btThietBi.Enabled = false;
                btNhanVien.Enabled = false;
            }
        }

        private void EditAccess_Click(object sender, EventArgs e)
        {
            panelTongquan.Controls.Clear();
            panelTongquan.Controls.Add(new Layout.EditAccess());
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0X2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Move_Form(Handle, e);
        }

        public static void Move_Form(IntPtr Handle, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
