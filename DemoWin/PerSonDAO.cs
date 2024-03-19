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
            string sqlStr = string.Format("SELECT *FROM DangViec");
            return connect.Load(sqlStr);
        }
        public Person PostWork(Person newPerson)
        {
            //newDangviec.checkNullDangViec(newDangviec);
            if (newPerson.Role == "Người dùng")
            {
                // Tạo một số ngẫu nhiên có 3 chữ số sau
                Random random = new Random();
                int randomNumber = random.Next(100, 1000);

                // Gán giá trị cho thuộc tính Id
                newPerson.Id = (100 * 1000 + randomNumber).ToString();
                string sqlStr = string.Format("INSERT INTO NguoiDung (ID, Ten, Email, TenTaiKoan, MatKhau) " +
                     "VALUES ('{0}', '{1}','{2}','{3}','{4}')", newPerson.Id, newPerson.Name, newPerson.Email
                     , newPerson.Account, newPerson.Pass);
                connect.ThucThi(sqlStr, "Thêm công việc thành công", newPerson);
            }
            else
            {
                // Tạo một số ngẫu nhiên có 3 chữ số sau
                Random random = new Random();
                int randomNumber = random.Next(100, 1000);

                // Gán giá trị cho thuộc tính Id
                newPerson.Id = ( 200 * 1000 + randomNumber).ToString();
                string sqlStr = string.Format("INSERT INTO Woker (ID, Ten, Email, TenTaiKoan, MatKhau) " +
                     "VALUES ('{0}', '{1}','{2}','{3}','{4}')", newPerson.Id, newPerson.Name, newPerson.Email
                     , newPerson.Account, newPerson.Pass);
                connect.ThucThi(sqlStr, "Thêm công việc thành công", newPerson);
            }
            return newPerson;
        }
    }
}
