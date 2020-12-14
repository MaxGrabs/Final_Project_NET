using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_NET
{
    public class Contact
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string phoneNumber { get; set; }


        public Contact(string name, int age, string phoneN)
        {
            this.Name = name;
            this.Age = age;
            this.phoneNumber = phoneN;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Name);
            sb.Append(" ");
            sb.Append(this.Age);
            sb.Append(" ");
            sb.Append(this.phoneNumber);
            sb.Append(" ");
            
            return sb.ToString();
        }

    }
}
