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



        public List<Contact> ReadContacts(Contact contact)
        {
            List<Contact> contacts = new List<Contact>();
            using (var con = new SqlConnection((@"data=localhost\SQLEXPRESS;database=Sales;Trusted_Connection=True")))
            {
                using (var cm = new SqlCommand("Select * from Contacts", con))
                {
                    con.Open();

                    using (var sdr = cm.ExecuteReader())
                    {
                        while (sdr.HasRows)
                        {
                            object Name = sdr["Name"];
                            object Age = sdr["Age"];
                            object Number = sdr["Number"];

                            contacts.Add(new Contact((String)Name, (int)Age, (string)Number));
                        }
                    }
                }
            }
            return contacts;
        }



        public List<Contact> UpdateContacts(Contact contact)
        {



            return null;
        }

        public void deleteContact(string name)
        {
            var con = new SqlConnection(@"data source=localhost\SQLEXPRESS;database = CONTACTS;Trusted_Connection=True");

            SqlCommand cm = new SqlCommand("DELETE FROM People WHERE Name = @name", con);

            cm.Parameters.AddWithValue("@name", name);

            con.Open();
            int i = cm.ExecuteNonQuery();

            if (i != 0)
            {
                Console.WriteLine("Contact deleted successfully");
            }
            else
            {
                Console.WriteLine("Error deleting contact");
            }
            con.Close();
        }



        

    }
}

