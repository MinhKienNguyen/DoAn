using DevExpress.XtraEditors;
using GUI.DoMain;
using GUI.Models;
using GUI.Unity;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class UC_NhanVien : DevExpress.XtraEditors.XtraUserControl
    {
        NhanvienModel _nhanvienModel = new NhanvienModel();
        UnityClass _unityClass = new UnityClass();
        private DataTable dtEmployess = null;
        public UC_NhanVien()
        {
            InitializeComponent();
            LoadComboboxDuty();
            txtMaNV.Text = EmployessCde();
        }

        /// <summary>
        /// btnChon_Click -- chọn hình ảnh để lưu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChon_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = Commons.FilterImage;
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgChonAnh.ImageLocation = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// LoadGridEmployess -- Load dữ liệu nhân viên lên gridview nhân viên
        /// </summary>
        public void LoadGridEmployess()
        {
            DataTable dt = _nhanvienModel.GetEmployees(txtEmployessName.Text);
            this.dtEmployess = dt.Copy();
            grdNhanVien.DataSource = dtEmployess;
        }

        /// <summary>
        /// EmployessCde -- lấy mã nhân viên tự tăng
        /// </summary>
        /// <returns></returns>
        public string EmployessCde()
        {
            string strCode = string.Empty;
            for (int i = 0; i < i + 1; i++)
            {
                int dtCout = _nhanvienModel.GetEmployessCde("NV0000" + i).Rows.Count;
                if (dtCout == 0)
                {
                    strCode = "NV0000" + i;
                    break;
                }
            }
            return strCode;
        }

        /// <summary>
        /// LoadComboboxDuty -- Load combobox chức vụ
        /// </summary>
        public void LoadComboboxDuty()
        {
            DataTable dtDuty = _nhanvienModel.GetComboboxDuty();
            lkuChucVu.Properties.DataSource = dtDuty.Copy();
            lkuChucVu.Properties.DisplayMember = "TenNhom";
            lkuChucVu.Properties.ValueMember = "MaNhom";
        }

        /// <summary>
        /// btnLuu_Click -- thực hiện chức năng lưu nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(imgChonAnh.ImageLocation))
            {
                XtraMessageBox.Show(Commons.ChooseImage, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(txtUser.Text))
            {
                XtraMessageBox.Show(Commons.WriteUset, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                XtraMessageBox.Show(Commons.WritePass, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            DataTable dtCheckInsert;
            byte[] image = _unityClass.CoverFilltoByte(imgChonAnh.ImageLocation);
            if (rdoNam.Checked == true)
            {
                dtCheckInsert = _nhanvienModel.InsertEmployess(txtMaNV.Text, txtTenNV.Text, rdoNam.Text, txtDiaChi.Text, txtUser.Text, txtPass.Text, txtSDT.Text, image, lkuChucVu.EditValue.ToString());
            }
            else
            {
                dtCheckInsert = _nhanvienModel.InsertEmployess(txtMaNV.Text, txtTenNV.Text, rdoNu.Text, txtDiaChi.Text, txtUser.Text, txtPass.Text, txtSDT.Text, image, lkuChucVu.EditValue.ToString());
            }
            if (dtCheckInsert.Rows.Count > 0 && dtCheckInsert != null)
            {
                XtraMessageBox.Show(Commons.InsertFinish, Commons.Notify, MessageBoxButtons.OK);
                txtMaNV.Text = EmployessCde();
                LoadGridEmployess();
                return;
            }
            XtraMessageBox.Show(Commons.InsertError, Commons.Notify, MessageBoxButtons.OK);
        }

        /// <summary>
        /// btnThem_Click -- làm mới lại tất cả các control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.groupThongtinnhanvien.Controls)
            {
                if (item.GetType() == typeof(DevExpress.XtraEditors.TextEdit) || item.GetType() == typeof(LookUpEdit))
                {
                    item.Text = string.Empty;
                }
            }
            txtMaNV.Text = EmployessCde();
            LoadComboboxDuty();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)tileViewNhanVien.GetRow(tileViewNhanVien.GetSelectedRows()[0]);
            int checkDelete = _nhanvienModel.DeleteEmployess(row[1].ToString());
            if (checkDelete != 1)
            {
                XtraMessageBox.Show(Commons.DeleteError, Commons.Notify, MessageBoxButtons.OK);
                return;
            }
            XtraMessageBox.Show(Commons.DeleteFinish, Commons.Notify, MessageBoxButtons.OK);
            LoadGridEmployess();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadGridEmployess();
        }

        private void tileViewNhanVien_ItemDoubleClick(object sender, DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs e)
        {
            DataRowView row = (DataRowView)tileViewNhanVien.GetRow(tileViewNhanVien.GetSelectedRows()[0]);
            txtMaNV.Text = row[1].ToString();
            txtTenNV.Text = row[2].ToString();
            txtSDT.Text = row[7].ToString();
            txtDiaChi.Text = row[4].ToString();
            txtUser.Text = row[5].ToString();
            txtPass.Text = row[6].ToString();
            if (row[3].ToString().Trim() == Set.Nam)
            {
                rdoNam.Checked = true;
                rdoNu.Checked = false;
            }
            else
            {
                rdoNam.Checked = false;
                rdoNu.Checked = true;
            }
            lkuChucVu.EditValue = row[9].ToString();
            DataTable dt = _nhanvienModel.GetImage(txtMaNV.Text);
            //BinaryFormatter bf = new BinaryFormatter();
            //MemoryStream ms = new MemoryStream();
            //bf.Serialize(ms, dt.Rows[0]["HinhAnhNV"]);
            byte[] arrpic = (new UnicodeEncoding()).GetBytes(dt.Rows[0]["HinhAnhNV"].ToString());
            imgChonAnh.Image = _unityClass.CovertBytetoImage(arrpic);
        }
    }
}
