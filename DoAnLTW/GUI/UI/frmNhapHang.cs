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
    public partial class frmNhapHang : DevExpress.XtraEditors.XtraForm
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbChuoiChu.Location = new Point(lbChuoiChu.Location.X + 3, lbChuoiChu.Location.Y);
            if (lbChuoiChu.Location.X > pnlChu.Width)
            {
                lbChuoiChu.Location = new Point(pnlChu.Location.X, lbChuoiChu.Location.Y);
            }
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            lbChuoiChu.Text = "THÔNG TIN NHẬP HÀNG";
            timer1.Enabled = true;
        }
    }
}