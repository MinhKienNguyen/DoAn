using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

using GiaoDien.Views;

namespace GiaoDien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string _TenDangNhap;

        public string TenDangNhap
        {
            get { return _TenDangNhap; }
            set { _TenDangNhap = value; }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không ?","Thông báo !", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void AddTab(XtraTabControl XtraTabCha, string TabNameAdd, UserControl UserControl)
        {
            // Khởi tạo 1 Tab Con (XtraTabPage)
            DevExpress.XtraTab.XtraTabPage TAbAdd = new DevExpress.XtraTab.XtraTabPage();
            // Đặt đại cái tên cho nó là TestTab (Đây là tên nhé)
            TAbAdd.Name = "Tab";
            // Tên của nó là đối số như đã nói ở trên
            TAbAdd.Text = TabNameAdd;
            // Add đối số UserControl vào Tab con vừa khởi tạo ở trên
            TAbAdd.Controls.Add(UserControl);
            // Dock cho nó tràn hết TAb con đó
            UserControl.Dock = DockStyle.Fill;
            // Quăng nó lên TAb Cha (XtraTabCha là đối số thứ nhất như đã nói ở trên)
            XtraTabCha.TabPages.Add(TAbAdd);
        }

        private void AddTabControl(UserControl userControl, string itemTabName)
        {
            bool isExists = false;
            foreach (XtraTabPage tabItem in xtraTabControl.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    xtraTabControl.SelectedTabPage = tabItem;
                }
            }
            if (isExists == false)
            {
                AddTab(xtraTabControl, itemTabName, userControl);
            }
        }

        /// <summary>
        /// xtraTabControl_CloseButtonClick -- sự kiện đóng tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControl.TabPages.RemoveAt(xtraTabControl.SelectedTabPageIndex);
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }

        /// <summary>
        /// xtraTabControl_ControlAdded -- sự kiện add tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void xtraTabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            xtraTabControl.SelectedTabPageIndex = xtraTabControl.TabPages.Count - 1;
        }

        /// <summary>
        /// btnnhanvien_ItemClick -- sự kiện load form nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnnhanvien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_NhanVien nv = new UC_NhanVien();
            AddTabControl(nv, "Thông tin nhân viên");
            
        }

        private void btItemMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_MangHinh mh = new UC_MangHinh();
            AddTabControl(mh,"Màng hình");
        }

        private void btnthemngdungvaonhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_NguoiDungNhomNguoiDung themnv = new UC_NguoiDungNhomNguoiDung();
            AddTabControl(themnv,"Người dùng nhóm người dùng");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            List<string> kq = new List<string>();
            
        }
    }
}
