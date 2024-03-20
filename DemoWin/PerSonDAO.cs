using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWin
{
    public class PerSonDAO
    {
        Connection connect = new Connection();
        public DataTable load()
        {
            string sqlStr = string.Format("SELECT ID, Ten, Email, TenTaiKhoan, MatKhau, NhapLaiMatKhau, VaiTro FROM Worker");
            return connect.Load(sqlStr);
        }
        public void DangKi(Person newPerson)
        {
            if(Person.checkNullDangKi(newPerson))
            {
                if (newPerson.Role == "Người dùng")
                {
                    string sqlStr = string.Format("INSERT INTO NguoiDung2 (ID, Ten, Email, TenTaiKhoan, MatKhau,NhapLaiMatKhau,VaiTro) " +
                         "VALUES  ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", newPerson.Id, newPerson.Name, newPerson.Email
                         , newPerson.Account, newPerson.Pass, newPerson.ConfirmPassword, newPerson.Role);
                    connect.ThucThi(sqlStr, "Đăng kí thành công", newPerson);
                }
                else
                {
                    string sqlStr = string.Format("INSERT INTO Worker (ID, Ten, Email, TenTaiKhoan, MatKhau,NhapLaiMatKhau,VaiTro) " +
                         "VALUES  ('{0}', '{1}','{2}','{3}','{4}','{5}','{6}')", newPerson.Id, newPerson.Name, newPerson.Email
                         , newPerson.Account, newPerson.Pass, newPerson.ConfirmPassword, newPerson.Role);
                    connect.ThucThi(sqlStr, "Đăng kí thành công", newPerson);
                }
            }
            else
            {
                return;

            }
        }
    }
}
