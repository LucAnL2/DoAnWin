using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWin
{
    internal class Worker
    {
        private string id;
        private string name;
        private string yearOld;
        private string sex;
        private string numberPhone;
        private string job;
        private string workingDay;
        private string workingTime;
        private string hireCost;
        private string address;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string YearOld { get => yearOld; set => yearOld = value; }
        public string Sex { get => sex; set => sex = value; }
        public string NumberPhone { get => numberPhone; set => numberPhone = value; }
        public string Job { get => job; set => job = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingTime { get => workingTime; set => workingTime = value; }
        public string HireCost { get => hireCost; set => hireCost = value; }
        public string Address { get => address; set => address = value; }

        public Worker() { }
        public Worker(string id, string name, string yearOld, string sex, string numberPhone, string job, string workingDay, string workingTime, string hireCost, string address)
        {
            Id = id;
            Name = name;
            YearOld = yearOld;
            Sex = sex;
            NumberPhone = numberPhone;
            Job = job;
            WorkingDay = workingDay;
            WorkingTime = workingTime;
            HireCost = hireCost;
            Address = address;
        }
    }
}
