using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLphongGYM.Report
{
    public partial class RptThu : Form
    {
        public RptThu()
        {
            InitializeComponent();
        }

        private void RptThu_Load(object sender, EventArgs e)
        {
            rpThu1.SetParameterValue("pIDReceipt", QLphongGYM.Report.dataTHU.mathu);
            rpThu1.SetParameterValue("pCustomer", QLphongGYM.Report.dataTHU.makhach);
            rpThu1.SetParameterValue("pAddress", QLphongGYM.Report.dataTHU.diachi);
            rpThu1.SetParameterValue("pPhone", QLphongGYM.Report.dataTHU.sdt);
            rpThu1.SetParameterValue("pContent", QLphongGYM.Report.dataTHU.noidung);
            rpThu1.SetParameterValue("pMoney", QLphongGYM.Report.dataTHU.sotien);
            rpThu1.SetParameterValue("pDate", Report.dataTHU.shortdate);
            rpThu1.SetParameterValue("pTime", Report.dataTHU.longdate);
            rpThu1.SetParameterValue("pSession", UserInfo.ID);
            viewReport.ReportSource = rpThu1;
            viewReport.Refresh();
        }
    }
}
