using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DemoWin
{
    internal class UserDAO
    {
        Connection connect = new Connection();
        public void PostWork(User newDangviec)
        {
            //newDangviec = new Worker(newDangviec.Id, newDangviec.Job, newDangviec.WorkingDay, newDangviec.WorkingTime, newDangviec.HireCost, newDangviec.Experience, newDangviec.Describe);

            if (User.checkNullUserDangViec(newDangviec) == true)
            {
                string sqlStr = string.Format("INSERT INTO NguoiDungDangViec (ID, ViTri, Luong, DiaChi, YeuCau, NgayLam, GioLam, MoTa, TrangThai) " +
                        "VALUES (N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}', N'{8}')", newDangviec.Id, newDangviec.Position, newDangviec.Salary
                        , newDangviec.Address, newDangviec.Require, newDangviec.WorkingDay, newDangviec.WorkingHour, newDangviec.Describe, newDangviec.Status);
                ///connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
                connect.ThucThi(sqlStr);
            }
            else
            {
                return;
            }
        }
        public void DeleteWork(User newDangviec)
        {
            string sqlStr = string.Format("DELETE FROM NguoiDungDangViec WHERE ID = '{0}' AND NgheNghiep = '{1}'", newDangviec.Id);
            connect.ThucThi(sqlStr);
        }
    }
}
