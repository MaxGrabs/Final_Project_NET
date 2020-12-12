using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_NET
{
    class ContactManager
    {
        public void newContact(string name, int age, string number)
        {
            var con = new SqlConnection(@"data source=localhost\SQLEXPRESS;database = Contacts;Trusted_Connection=True");
            SqlCommand cm = new SqlCommand("INSERT INTO Contacts" +
                "(Name, Age, Number) " +
                "VALUES(@name, @age, @num)", con);

            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@age", age);
            cm.Parameters.AddWithValue("@num", number);

            con.Open(); 
            int i = cm.ExecuteNonQuery();

            if (i != 0)
            {
                Console.WriteLine("Contact created successfully");
            }
            else
            { Console.WriteLine("Error creating contact"); }
            con.Close();
        }


    }
}
}
