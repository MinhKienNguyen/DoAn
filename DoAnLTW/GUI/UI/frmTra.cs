using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GiaoDien.Views
{
    public partial class frmTra : DevExpress.XtraEditors.XtraForm
    {
        public frmTra()
        {
            InitializeComponent();
        }

        private void grpttthucp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmTra_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            thoigian.Text = now.ToString();
        }
    }
}