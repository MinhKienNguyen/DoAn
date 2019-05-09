using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Unity
{
    public class ConfigServerSQL
    {
        /// <summary>
        /// GetServerName -- lấy tên server
        /// </summary>
        /// <returns></returns>
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable dataTable = instance.GetDataSources();
            return dataTable;
        }

        /// <summary>
        /// GetDatabaseName -- lấy tên database theo các thông số truyền vào
        /// </summary>
        /// <param name="server"></param>
        /// <param name="userd"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public List<string> GetDatabaseName(string server, string userd, string pass)
        {
            List<string> _list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT name FORM sys.databases", "Data Source" + server + ";Initial Catalog=" + "master" + ";User ID=" + userd + ";pwd=" + pass + "");
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        _list.Add(row[col].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return _list;
        }

        /// <summary>
        /// ChangeConnectionString -- lưu chuỗi cấu hình vào config
        /// </summary>
        /// <param name="cbServer"></param>
        /// <param name="txtUser"></param>
        /// <param name="txtPass"></param>
        /// <param name="cbData"></param>
        public void ChangeConnectionString(string cbServer, string txtUser, string txtPass, string cbData)
        {
            GUI.Properties.Settings.Default.ConnectDB = "Data Source" + cbServer.ToString() + ";Initial Catalog=" + cbData.ToString() + ";User ID=" + txtUser.ToString() + ";pwd=" + txtPass.ToString() + "";
            Properties.Settings.Default.Save();
        }

        public List<string> GetMaNhomNguoiDung(string pTenDangNhap)
        {
            List<string> kq = new List<string>();
            DataTable dt = new DataTable();//truyền table chưa mã nhóm người dùng vào dt, truyền tên đăng nhập lấy ra mã nhóm người dùng
            //duyệt dt lấy mã nhóm
            //kq= manhom
            return kq;
        }

        public DataTable GetDataManHinh(string pMaNhom)
        {
            DataTable dt = new DataTable();
            //lấy mã màng hình, có quyền theo mã nhóm người dùng
            return dt;
        }
    }
}
