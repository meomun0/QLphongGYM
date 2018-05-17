using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLphongGYM.Layout
{
    public partial class ThongKe : UserControl
    {
        public string day1 = (DateTime.Now.Day).ToString();
        public string month1 = (DateTime.Now.Month).ToString();
        public string year1 = (DateTime.Now.Year).ToString();
        ThongkE tk = new ThongkE();
        public ThongKe()
        {
            InitializeComponent();
            day.Text = day1;
            month.Text = month1;
            year.Text = year1;
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            GoiTapDangHD.Text= "HĐ " + tk.getDta("SELECT COUNT([Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE CAST(GETDATE() AS DATE) BETWEEN [Ngày bắt đầu] AND [Ngày kết thúc]");
            GoiTapChuaHD.Text = "Sắp HĐ " + tk.getDta("SELECT COUNT([Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE [Ngày bắt đầu] > CAST(GETDATE() AS DATE)");
            DungCu.Text= "Đang SD: "+tk.getDta("SELECT COUNT([Mã dụng cụ]) FROM dbo.DUNGCU WHERE KhuVucSD !='Trong kho'");

            string firstDay = tk.getDta("SELECT DATEADD(month, DATEDIFF(month, 0, GETDATE()), 0) AS StartOfMonth");
            string lastDay = tk.getDta("SELECT DATEADD(month, ((YEAR(GETDATE()) - 1900) * 12) + MONTH(GETDATE()), -1)");

            string thu = tk.getDta("SELECT SUM( [Số lượng tiền]) FROM dbo.THU WHERE[Thời gian] BETWEEN '" + firstDay + "' AND '" + lastDay + "'"); ;
            string chi = tk.getDta("SELECT SUM( [Số tiền]) FROM dbo.CHI WHERE [Thời gian] BETWEEN '" + firstDay + "' AND '" + lastDay + "'");
            ThuNhap2.Text = thu;
            Chi.Text = chi;
            double tienthu = Convert.ToDouble(thu);
            double tienchi = Convert.ToDouble(chi);
            double tong = tienchi + tienthu;
            thunhap.Text = tong.ToString();
            Aerobic.Text= tk.getDta("SELECT COUNT( [Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE [Ngày bắt đầu] > CAST(GETDATE() AS DATE) AND [Tên gói tập]='Aerobic'");
            zumba.Text= tk.getDta("SELECT COUNT( [Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE [Ngày bắt đầu] > CAST(GETDATE() AS DATE) AND [Tên gói tập]='Zumba'");
            Rieng.Text = tk.getDta("SELECT COUNT( [Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE [Ngày bắt đầu] > CAST(GETDATE() AS DATE) AND [Tên gói tập]='KEM RIENG'");
            Thuong.Text = tk.getDta("SELECT COUNT( [Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE [Ngày bắt đầu] > CAST(GETDATE() AS DATE) AND [Tên gói tập]='Lớp thường'");
            VIP.Text = tk.getDta("SELECT COUNT( [Mã gói tập]) FROM dbo.[GÓI TẬP] WHERE [Ngày bắt đầu] > CAST(GETDATE() AS DATE) AND [Tên gói tập]='Lớp VIP'");
            conhan.Text = tk.getDta("SELECT COUNT([Mã khách]) FROM dbo.KHÁCH WHERE HanThe > CAST(GETDATE() AS DATE)");
            hethan.Text = tk.getDta("SELECT COUNT([Mã khách]) FROM dbo.KHÁCH WHERE HanThe < CAST(GETDATE() AS DATE)");
            tongkhach.Text = tk.getDta("SELECT COUNT([Mã khách]) FROM dbo.KHÁCH");
        }

    }
}
