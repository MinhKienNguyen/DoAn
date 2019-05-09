using GUI.Unity;
using System.Data;

namespace GUI.Controllers
{
    public class NhanvienControllers
    {
        UnityClass _unity = new UnityClass();

        /// <summary>
        /// GetEmployees -- Tìm kiếm nhân viên theo tên nhân viên
        /// </summary>
        /// <param name="EmployessName"></param>
        /// <returns></returns>
        public DataTable GetEmployees(string EmployessName)
        {
            return _unity.filldb("HT_NhanVien_SearchData", EmployessName.ToString());
        }

        /// <summary>
        /// GetEmployessCde -- lấy mã nhân viên để ktra khóa chính khi thêm vào
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public DataTable GetEmployessCde(string EmployessCde)
        {
            return _unity.filldb("HT_NhanVien_GetEmployessCde", EmployessCde.ToString());
        }

        /// <summary>
        /// GetComboboxDuty -- lấy thông tin chức vụ để load combobox chức vụ
        /// </summary>
        /// <returns></returns>
        public DataTable GetComboboxDuty()
        {
            return _unity.filldb("QL_NhomNguoiDung_GetComboboxDuty");
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
            return _unity.filldb("HT_NhanVien_InsertEmployess", EmployessCde, EmployessName, Set, Adress, User, Pass, Phone, Image, DutyID);
        }

        /// <summary>
        /// DeleteEmployess -- xóa nhân viên
        /// </summary>
        /// <param name="EmployessCde"></param>
        /// <returns></returns>
        public int DeleteEmployess(string EmployessCde)
        {
            var result = _unity.filldb("HT_NhanVien_Delete", EmployessCde.ToString());
            if (result != null)
                return 1;
            return 0;
        }

        public DataTable GetImage(string EmployessCde)
        {
            var result = _unity.filldb("HT_NhanVien_GetImage", EmployessCde.ToString());
            return result;
        }
    }
}
