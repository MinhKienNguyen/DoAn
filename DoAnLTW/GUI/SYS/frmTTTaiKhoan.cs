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
    public partial class frmTTTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public frmTTTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmTTTaiKhoan_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            thoigian.Text = now.ToString();
        }
    }
}