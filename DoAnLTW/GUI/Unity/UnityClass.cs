using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;

namespace GUI.Unity
{
    public class UnityClass
    {
        /// <summary>
        /// filldb
        /// </summary>
        /// <param name="name"></param>
        /// <param name="po"></param>
        /// <returns></returns>
        public DataTable filldb(String name, params object[] po)
        {
            DataTable dt = new DataTable();
            SqlConnection _sqlConne = new SqlConnection(Properties.Settings.Default.ConnectDB);
            if (_sqlConne.State == ConnectionState.Closed)
                _sqlConne.Open();
            SqlDataAdapter sda = new SqlDataAdapter(name, _sqlConne);
            sda.SelectCommand.CommandType = CommandType.StoredProcedure;
            SqlCommandBuilder.DeriveParameters(sda.SelectCommand);
            if (sda.SelectCommand.Parameters.Count - 1 != po.Length)
            {
                return null;
            }
            int i = 0;
            foreach (SqlParameter p in sda.SelectCommand.Parameters)
            {
                if (p.Direction == ParameterDirection.Input || p.Direction == ParameterDirection.InputOutput)
                {
                    p.Value = po[i++];
                }
            }
            sda.Fill(dt);
            if (_sqlConne.State == ConnectionState.Open)
                _sqlConne.Close();
            return dt;
        }

        /// <summary>
        /// CovertBytetoImage -- chuyển byte[] thành chuỗi hình ảnh
        /// </summary>
        /// <param name="photo"></param>
        /// <returns></returns>
        public Image CovertBytetoImage(byte[] photo)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(photo))
                {
                    Image image = Image.FromStream(ms);
                    return image;
                }
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// CoverFilltoByte -- chuyển chuỗi thành byte[]
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public byte[] CoverFilltoByte(string Path)
        {
            byte[] data = null;
            FileInfo info = new FileInfo(Path);
            long numByte = info.Length;
            FileStream fstream = new FileStream(Path, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            data = br.ReadBytes((int)numByte);
            return data;
        }
    }
}
