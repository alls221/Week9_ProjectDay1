using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week9_ProjectDay1
{
    public class Clients
    {
        string name = "Minnie Mouse";
        string phoneNum = "(407) 824-4321";
        string address = "3111 World Dr. Orlando, FL 32830";

        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }

        public Clients()
        {
            Name = name;
            PhoneNum = phoneNum;
            Address = address;
        }
        public string Header ()
        {
            string name = "Minnie Mouse";
            string phoneNum = "(407) 824-4321";
            string address = "3111 World Dr. Orlando, FL 32830";

            StringBuilder buildHeader = new StringBuilder();
            buildHeader.Append(name);
            buildHeader.Append("  ");
            buildHeader.Append(phoneNum);
            buildHeader.Append(" ");
            buildHeader.Append(address);

            return buildHeader.ToString();

        }
    }
}
