using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eco
{
    public class UserInfo
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int Point { get; set; }
        public int UsedPoint { get; set; }

        public double Co2Saved { get; set; }   
        public double TreeCount { get; set; }

        public List<string> Coupons { get; set; } = new List<string>();
        public UserInfo(string name, string phoneNumber, int point, int usedPoint, double co2Saved = 0.0, double treeCount = 0.0)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Point = point;
            UsedPoint = usedPoint;
            Co2Saved = co2Saved;
            TreeCount = treeCount;
        }
    }
}
