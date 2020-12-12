using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_NET
{
    class Contact
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }


        public Contact(int age, string name, string phoneN)
        {
            this.Age = age;
            this.Name = name;
            this.phoneNumber = phoneN;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Age);
            sb.Append(" ");
            sb.Append(this.Name);
            sb.Append(" ");
            sb.Append(this.phoneNumber);
            sb.Append(" ");
            
            return sb.ToString();
        }

    }
}
