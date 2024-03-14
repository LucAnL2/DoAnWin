using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string HireTimes { get => hireTimes; set => hireTimes = value; }
        public string Job { get => job; set => job = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingTime { get => workingTime; set => workingTime = value; }
        public string HireCost { get => hireCost; set => hireCost = value; }
        public string Experience { get => experience; set => experience = value; }
        public string Describe { get => describe; set => describe = value; }
    }
}
