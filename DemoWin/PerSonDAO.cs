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
            string sqlStr = string.Format("SELECT ID, Ten, Email, TenTaiKhoan, MatKhau, NhapLaiMatKhau, VaiTro FROM NguoiDung2");
            return connect.Load(sqlStr);
        }
        public void DangKi(Person newPerson)
        {
            if(Person.checkNullDangKi(newPerson))
            {
                if (newPerson.Role == "Người dùng")
                {
                    string sqlStr = string.Format("INSERT INTO NguoiDung2 (ID, Ten, Email, TenTaiKhoan, MatKhau,NhapLaiMatKhau,VaiTro) " +
                         "VALUES  (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", newPerson.Id, newPerson.Name, newPerson.Email
                         , newPerson.Account, newPerson.Pass, newPerson.ConfirmPassword, newPerson.Role);
                    connect.ThucThi(sqlStr, "Đăng kí thành công", newPerson);
                }
                else
                {
                    string sqlStr = string.Format("INSERT INTO Worker (ID, Ten, Email, TenTaiKhoan, MatKhau,NhapLaiMatKhau,VaiTro) " +
                         "VALUES  (N'{0}', N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}')", newPerson.Id, newPerson.Name, newPerson.Email
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
