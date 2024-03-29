﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoWin
{
    public class Worker : Person
    {
        private string job;
        private string workingDay;
        private string workingTime;
        private string hireCost;
        private string experience;
        private string describe;
        private string hireTimes;
        private string avgRate;
        private string status;



        public Worker(string id, string name, string sex, string phone, string address,
            string cccd, string date, string email, string account, string pass)
            : base(id, name, sex, phone, address, cccd, date, email, account, pass)
        {
        }
        public Worker(string id, string job, string workingDay, string workingTime,
            string hireCost, string experience, string describe) : base(id)
        {
            Job = job;
            WorkingDay = workingDay;
            WorkingTime = workingTime;
            HireCost = hireCost;
            Experience = experience;
            Describe = describe;
        }
        public Worker(string id, string job)
        {
            Id = id;
            Job = job;
        }
        public Worker(string id, string name, string phone, string job) : base(id,name,phone) 
        { 
            Job = job;
        }

        public string Job { get => job; set => job = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingTime { get => workingTime; set => workingTime = value; }
        public string HireCost { get => hireCost; set => hireCost = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Describe { get => describe; set => describe = value; }
        public string HireTimes { get => hireTimes; set => hireTimes = value; }
        public string AvgRate { get => avgRate; set => avgRate = value; }
        public string Status { get => status; set => status = value; }

        //public static class GlobalVariables
        //{
        //    public static int Id = 3;
        //}
        //public static bool checkNullDangViec(Worker newDangviec)
        //{

        //    foreach (var property in newDangviec.GetType().GetProperties())
        //    {
        //        if (property.GetValue(newDangviec) == null)
        //        {
        //            MessageBox.Show($"Thuộc tính {property.Name} không được để trống !!!");
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        public static bool checkNullDangViec(Worker newWorker)
        {
            string[] propertiesToCheck = { "Id", "Job", "WorkingDay", "WorkingTime", "HireCost", "Experience", "Describe" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newWorker.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newWorker) == null || string.IsNullOrEmpty(property.GetValue(newWorker).ToString()))
                {
                    MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Experience")
                {
                    int experienceValue;
                    if (!int.TryParse(property.GetValue(newWorker).ToString(), out experienceValue))
                    {
                        MessageBox.Show($"Thuộc tính {property.Name} phải là một số nguyên !!!");
                        return false;
                    }
                }
            }
            return true;
        }


        public static bool checkNullInfo(Worker newWorker)
        {
            string[] propertiesToCheck = { "Id", "Name", "Sex", "Phone", "Address", "CCCD", "Date", "Email", "Account", "Pass" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newWorker.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newWorker) == null || string.IsNullOrEmpty(property.GetValue(newWorker).ToString()))
                {
                    MessageBox.Show("Vui lòng cập nhật đầy đủ thông tin để truy cập chức năng này !!!");
                    return true;
                }

            }
            return false;
        }
    }
}
