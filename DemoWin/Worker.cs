using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DemoWin
{
    public class Worker : Person
    {
        private string hireTimes;
        private string job;
        private string workingDay;
        private string workingTime;
        private string hireCost;
        private string experience;
        private string describe;

        public Worker(string id, string name, string sex, string phone, string address, string cccd, string date, string email, string acNumber, string surplus) : base(id, name, sex, phone, address, cccd, date, email, acNumber, surplus)
        {
        }
        public Worker(string id, string job, string workingDay, string workingTime,
            string hireCost, string experience, string describe) : base(id)
        {
            this.job = job;
            this.workingDay = workingDay;
            this.workingTime = workingTime;
            this.hireCost = hireCost;
            this.experience = experience;
            this.describe = describe;
        }

        public string HireTimes { get => hireTimes; set => hireTimes = value; }
        public string Job { get => job; set => job = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingTime { get => workingTime; set => workingTime = value; }
        public string HireCost { get => hireCost; set => hireCost = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Describe { get => describe; set => describe = value; }
        public static class GlobalVariables
        {
            public static int Id = 3;
        }
        public static void checkNullDangViec(Worker newWorker)
        {
            foreach (var property in newWorker.GetType().GetProperties())
            {
                if (property.GetValue(newWorker) == null)
                {
                    MessageBox.Show($"Thuộc tính {property.Name} không được để trống !!!");
                    return;
                }
            }
        }
        
    }
}
