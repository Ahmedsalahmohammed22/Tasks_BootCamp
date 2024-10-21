using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Event_Delegate
{
    internal class Club
    {
        public string ClubName { get; set; }
        public string Location { get; set; }
        public string MembershipType { get; set; }

        public Club(string clubName, string location, string membershipType)
        {
            ClubName = clubName;
            Location = location;
            MembershipType = membershipType;
        }
        public override string ToString()
        {
            return $"{ClubName} located in {Location} ({MembershipType} membership)";
        }
        public void Addinclub(Employee employee)
        {
            Console.WriteLine(employee);
            Console.WriteLine($"{employee.Name} added in {ClubName} at {Location} as a {MembershipType}");
        }
    }
}
