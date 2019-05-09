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
    public partial class frmKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            thoigian.Text = now.ToString();
            dtGridNCC.Rows.Add("KM01", "H01", "Áo thun nam có cổ, đen sọc trắng", "25%");
        }
    }
}