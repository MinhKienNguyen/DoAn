using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Models;
using DevExpress.XtraEditors;

namespace GiaoDien.Views
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        //BanHangModel _banHangModel = new BanHangModel();
        //private DataTable iGridDataSource = null;
        //public frmBanHang()
        //{
        //    InitializeComponent();
        //}



        ///// <summary>
        ///// frmBanHang_Load
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void frmBanHang_Load(object sender, EventArgs e)
        //{
        //    lbChuoiChu.Text = "THÔNG TIN BÁN HÀNG";
        //    timer1.Enabled = true;
        //    DateTime now = DateTime.Now;
        //    thoigian.Text = now.ToString();
        //    dataGridView1.Rows.Add("HD01", "H01", "Áo thun nam có cổ, đen sọc trắng", "L", "Đen sọc trắng", "2", "375,000", "750,000");
        //}

        ///// <summary>
        ///// timer1_Tick
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    lbChuoiChu.Location = new Point(lbChuoiChu.Location.X + 3, lbChuoiChu.Location.Y);
        //    if (lbChuoiChu.Location.X > pnlChu.Width)
        //    {
        //        lbChuoiChu.Location = new Point(pnlChu.Location.X, lbChuoiChu.Location.Y);
        //    }
        //}

        ///// <summary>
        ///// txtBarcode_Enter -- Quét barcode
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void txtBarcode_Enter(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataTable dtScan = _banHangModel.GetDataScanBarcode(txtBarcode.Text);
        //        if (dtScan == null || dtScan.Rows.Count <= 0)
        //        {
        //            XtraMessageBox.Show("Không tồn tại sản phẩm này");
        //            return;
        //        }
                
        //    }
        //    catch
        //    {

        //    }
            
        //}
    }
}