using GUI.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Models
{
    public class NhanvienModel
    {
        NhanvienControllers _nhanvienControllers = new NhanvienControllers();

        /// <summary>
        /// GetEmployees -- tìm kiếm nhân viên theo tên nhân viên để load lên lưới
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName)
        {
            return _nhanvienControllers.GetEmployees(EmployessName);
        }

        /// <summary>
        /// GetEmployessCde -- lấy mã nhân viên để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return _nhanvienControllers.GetEmployessCde(EmployessCde.ToString());
        }

        /// <summary>
        /// GetComboboxDuty -- lấy thông tin chức vụ để load combobox chức vụ
        /// </summary>
        /// <returns></returns>
        public DataTable GetComboboxDuty()
        {
            return _nhanvienControllers.GetComboboxDuty();
        }

        /// <summary>
        /// InsertEmployess -- Insert thông tin nhân viên vào DB
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <param name="EmployessName"></param>
        /// <param name="Set"></param>
        /// <param name="Adress"></param>
        /// <param name="User"></param>
        /// <param name="Pass"></param>
        /// <param name="Phone"></param>
        /// <param name="Image"></param>
        /// <param name="DutyID"></param>
        /// <returns></returns>
        public DataTable InsertEmployess(string EmployessCde, string EmployessName, string Set, string Adress, string User, string Pass, string Phone, byte[] Image, string DutyID)
        {
            return _nhanvienControllers.InsertEmployess(EmployessCde, EmployessName, Set, Adress, User, Pass, Phone, Image, DutyID);
        }


        public int DeleteEmployess(string EmployessCde)
        {
            return _nhanvienControllers.DeleteEmployess(EmployessCde.ToString());
        }

        public DataTable GetImage(string EmployessCde)
        {
            return _nhanvienControllers.GetImage(EmployessCde.ToString());
        }
    }
}
