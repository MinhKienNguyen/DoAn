using GUI.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien.Views
{
    public partial class CauHinhServer : Form
    {
        ConfigServerSQL _configServerSql = new ConfigServerSQL();
        public CauHinhServer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// cbServer_DropDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbServer_DropDown(object sender, EventArgs e)
        {
            //1 table getservername chứa các server
            DataTable dt = _configServerSql.GetServerName();
            if (dt == null || dt.Rows.Count <= 0)
                return;
            cbServer.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                foreach (DataColumn col in dt.Columns)
                {
                    cbServer.Items.Add(row.ItemArray[0].ToString() + @"\" + row.ItemArray[1].ToString());
                }
            }
        }

        /// <summary>
        /// CheckBeforSearchNameDB -- ktra nhập server, user, pass chưa
        /// </summary>
        /// <returns></returns>
        public bool CheckBeforSearchNameDB()
        {
            if (cbServer.Text == string.Empty)
            {
                MessageBox.Show("Nhập server");
                cbServer.Focus();
                return false;
            }
            if (txtLogin.Text == string.Empty)
            {
                MessageBox.Show("Nhập UserName");
                txtLogin.Focus();
                return false;
            }
            if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("Nhập Pass");
                txtPass.Focus();
                return false;
            }
            return true;

        }

        /// <summary>
        /// cbData_DropDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbData_DropDown(object sender, EventArgs e)
        {
            if (CheckBeforSearchNameDB())
            {
                cbData.Items.Clear();
                List<string> _list = _configServerSql.GetDatabaseName(cbServer.Text, txtLogin.Text, txtPass.Text);
                if (_list == null)
                {
                    MessageBox.Show("Thông tin cấu hình chưa chính xác");
                    return;
                }
                foreach (string item in _list)
                {
                    cbData.Items.Add(item);
                }
            }
        }
    }
}
