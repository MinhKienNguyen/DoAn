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
    public partial class frmNhaCC : DevExpress.XtraEditors.XtraForm
    {
        public frmNhaCC()
        {
            InitializeComponent();
        }

        public void loadTieuDe()
        {
            lbChuoiChu.Text = "THÔNG TIN NHÀ CUNG CẤP";
            timer1.Enabled = true;
        }
        private void frmNhaCC_Load(object sender, EventArgs e)
        {
            dtGridNCC.Rows.Add("NCC01", "Công Ty TNHH SX TM DV Trường Nam", "0978550644", "63/12 Đỗ Nhuận, P. Sơn Kỳ, Q. Tân Phú, Tp. Hồ Chí Minh");
            dtGridNCC.Rows.Add("NCC02", "Công Ty TNHH Siêu Minh Mạnh", "62675818", "218/20 Phú Thọ Hòa, P. Phú Thọ Hòa, Q. Tân Phú, Tp. Hồ Chí Minh");
            dtGridNCC.Rows.Add("NCC03", "Công Ty May Đồng Phục - Thời Trang Việt Lê", "38106475", "458/132 Đường 3/2, P. 12, Q. 10, Tp. Hồ Chí Minh");
            dtGridNCC.Rows.Add("NCC04", "Công Ty TNHH Mỹ Anh", "33664755", "Km 18.5 QL 32, X. Đức Thượng, Hoài Đức, Hà Nội, Việt Nam");
            dtGridNCC.Rows.Add("NCC05", "Công Ty TNHH TM DV May Hà Gia", "0976314714", "565/1 Lê Văn Thọ, P. 14, Q. Gò Vấp, Tp. Hồ Chí Minh");
            loadTieuDe();
            DateTime now = DateTime.Now;
            thoigian.Text = now.ToString();

        }

        private void dtGridNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dtGridNCC.CurrentRow.Index;
            txtMaNCC.Text = dtGridNCC.Rows[vitri].Cells[0].Value.ToString();
            txtTenNCC.Text = dtGridNCC.Rows[vitri].Cells[1].Value.ToString();
            txtSDTNCC.Text = dtGridNCC.Rows[vitri].Cells[2].Value.ToString();
            txtDiaChiNCC.Text = dtGridNCC.Rows[vitri].Cells[3].Value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbChuoiChu.Location = new Point(lbChuoiChu.Location.X + 3, lbChuoiChu.Location.Y);
            if (lbChuoiChu.Location.X > pnlChu.Width)
            {
                lbChuoiChu.Location = new Point(pnlChu.Location.X, lbChuoiChu.Location.Y);
            }
        }
    }
}