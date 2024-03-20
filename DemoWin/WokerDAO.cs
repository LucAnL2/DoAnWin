using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoWin
{
    public class WokerDAO
    {
        Connection connect = new Connection();
        public DataTable load()
        {
            string sqlStr = string.Format("SELECT *FROM DangViec");
            return connect.Load(sqlStr);
        }
        public void PostWork(Worker newDangviec)
        {
            //newDangviec = new Worker(newDangviec.Id, newDangviec.Job, newDangviec.WorkingDay, newDangviec.WorkingTime, newDangviec.HireCost, newDangviec.Experience, newDangviec.Describe);

            if (Worker.checkNullDangViec(newDangviec) == true)
            {
                string sqlStr = string.Format("INSERT INTO DangViec (ID, NgheNghiep, NgayLamViec, GioLam, GiaThue, NamKinhNghiem, MoTa) " +
                        "VALUES ('{0}', '{1}','{2}','{3}','{4}', '{5}','{6}')", newDangviec.Id, newDangviec.Job, newDangviec.WorkingDay
                        , newDangviec.WorkingTime, newDangviec.HireCost, newDangviec.Experience, newDangviec.Describe);
                connect.ThucThi(sqlStr, "Thêm công việc thành công", newDangviec);
            }
            else
            {
                return ;
            }    
        }
        public void DeleteWork(Worker newDangviec)
        {
            string sqlStr = string.Format("DELETE FROM DangViec WHERE NgheNghiep = '{0}'", newDangviec.Job);
            connect.ThucThi(sqlStr, "Xóa công việc thành công", newDangviec);
        }
        //public void RepairWork(Worker newDangviec)
        //{
        //    string sqlStr = string.Format("UPDATE GiangVien2 SET ID = '{0}', Ten = '{1}', GioiTinh = '{2}', DiaChi = '{3}', Cmnd = '{4}', NgaySinh = '{5}', DienThoai = '{6}', Email = '{7}' WHERE ID = '{0}'", newGiangVien.Id, newGiangVien.Ten, newGiangVien.GioiTinh, newGiangVien.DiaChi, newGiangVien.Cmnd, newGiangVien.NgaySinh, newGiangVien.DienThoai, newGiangVien.Email);
        //    connect.ThucThi(sqlStr, "sửa công việc thành công", newDangviec);
        //}
        public void updateInfo(Worker newInfo)
        {
            Person newperson = new Person(newInfo.Id, newInfo.Name, newInfo.Date, newInfo.Sex, 
                newInfo.Address, newInfo.Phone, newInfo.Email, newInfo.Cccd,newInfo.Account,newInfo.Pass);

            string sqlStr = string.Format("UPDATE Worker SET ID = '{0}', Ten = '{1}', NgaySinh = '{2}', GioiTinh = '{3}', " +
                "DiaChi = '{4}', SDT = '{5}', Email = '{6}', CCCD = '{7}', TenTaiKhoan = '{8}',MatKhau = '{9}' WHERE ID = '{0}'",
                newInfo.Id, newInfo.Name, newInfo.Date, newInfo.Sex,
                newInfo.Address, newInfo.Phone, newInfo.Email, newInfo.Cccd, newInfo.Account, newInfo.Pass);
            connect.ThucThi(sqlStr, "Sửa thông tin học sinh thành công", newperson);
        }
    }
}
