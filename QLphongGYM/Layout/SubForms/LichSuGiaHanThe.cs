using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLphongGYM.Layout.SubForms
{
    public partial class LichSuGiaHanThe : Form
    {
        public LichSuGiaHanThe()
        {
            InitializeComponent();
        }

        private void LichSuGiaHanThe_Load(object sender, EventArgs e)
        {
            this.expirationHistoryTableAdapter.Fill(this.gYMDataSet_LSGiaHan.expirationHistory);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
