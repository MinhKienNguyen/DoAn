using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace GiaoDien.Views
{
    public partial class UC_NguoiDungNhomNguoiDung : DevExpress.XtraEditors.XtraUserControl
    {
        //NhanvienModel _nhanvienModel = new NhanvienModel();
        //NguoiDungNhomNgDungModel _ngDungModel = new NguoiDungNhomNgDungModel();
        //private DataTable dtNgDNhomND = null;
        //private DataTable dtTaiKhoan = null;
        //public UC_NguoiDungNhomNguoiDung()
        //{
        //    InitializeComponent();
        //}

        //private void UC_NguoiDungNhomNguoiDung_Load(object sender, EventArgs e)
        //{
        //    LoadLookupDuty();
        //    LoadGridNhomND();
        //}

        //public void LoadLookupDuty()
        //{
        //    DataTable dtDuty = _nhanvienModel.GetComboboxDuty();
        //    lkNhomQuyen.Properties.DataSource = dtDuty.Copy();
        //    lkNhomQuyen.Properties.ValueMember = "MaNhom";
        //    lkNhomQuyen.Properties.DisplayMember = "TenNhom";
        //}

        //public void LoadGridNhomND()
        //{
        //    dtTaiKhoan = _ngDungModel.GetNhomND();
        //    gridControl1.DataSource = dtTaiKhoan.Copy();
        //}

        //public void LoadGridNgDNhomND()
        //{
        //    dtNgDNhomND = _ngDungModel.GetNgDNhomND(lkNhomQuyen.EditValue.ToString());
        //    grdNND.DataSource = dtNgDNhomND.Copy();
        //}

        //private void lkNhomQuyen_EditValueChanged(object sender, EventArgs e)
        //{
        //    LoadGridNgDNhomND();
        //}

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    DataRowView row = (DataRowView)gridView1.GetRow(gridView1.GetSelectedRows()[0]);
        //    foreach(DataRow dr in dtNgDNhomND.Rows)
        //    {
        //        if (dr["Username"] == row["Username"])
        //        {
        //            XtraMessageBox.Show(Commons.Exist, Commons.Notify, MessageBoxButtons.OK);
        //            return;
        //        }
        //    }

        //}
    }
}
