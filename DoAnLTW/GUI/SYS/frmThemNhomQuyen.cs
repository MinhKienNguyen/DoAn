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
    public partial class frmThemNhomQuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmThemNhomQuyen()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmThemNhomQuyen_Load(object sender, EventArgs e)
        {
            dtGridNCC.Rows.Add("Q01", "Nhập hàng", "Đặng Như Huy", "Quản Lý");
            dtGridNCC.Rows.Add("Q02", "Nhập hàng", "Nguyễn Minh Kiên", "Quản Lý");
        }
    }
}