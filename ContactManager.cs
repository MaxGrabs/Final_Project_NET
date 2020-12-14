using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_NET
{
     sealed class ContactManager
    {
        public static void  newContact(string name, int age, string number)
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

           
            con.Close();
        }

        public static String[] viewContact(string name)
        {
            var con = new SqlConnection(@"data source=localhost\SQLEXPRESS;database = Contacts;Trusted_Connection=True");

            SqlCommand cm = new SqlCommand("Select Name, Age, Number from Contacts WHERE Name = @name", con);

            cm.Parameters.AddWithValue("@name", name);

            con.Open();
            var sdr = cm.ExecuteReader();
                sdr.Read();
                string details = ("" + sdr["Name"]);
                string details2 = ("" + sdr["Age"]);
                string details3 = ("" + sdr["Number"]);
                string[] detailArr = { details, details2, details3 };
            sdr.Close();
            con.Close();
            return detailArr;
        }

        static public List<Contact> ReadContacts()
        {
            List<Contact> contacts = new List<Contact>();
            using (var con = new SqlConnection((@"data source=localhost\SQLEXPRESS;database = Contacts;Trusted_Connection=True")))
            {
                using (var cm = new SqlCommand("SELECT * FROM Contacts", con))
                {
                    con.Open();

                    using (var sdr = cm.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            object Name = sdr["Name"];
                            object Age = sdr["Age"];
                            object Number = sdr["Number"];

                            contacts.Add(new Contact((String)Name, (int)Age, (string)Number));
                        }
                        sdr.Close();
                    }
                }
            }
            return contacts;
        }


        public static void updateContact(string oldname, string name, int age, string number)
        {

            var con = new SqlConnection(@"data source=localhost\SQLEXPRESS;database = Contacts;Trusted_Connection=True");
            SqlCommand cm = new SqlCommand("UPDATE Contacts SET Name = @name, Age = @age, " +
                   "number = @num WHERE Name= @old", con);
            cm.Parameters.AddWithValue("@old", oldname);
            cm.Parameters.AddWithValue("@name", name);
            cm.Parameters.AddWithValue("@age", age);
            cm.Parameters.AddWithValue("@num", number);

            con.Open();
            cm.ExecuteNonQuery();

            con.Close();
        }

        public static void deleteContact(string name)
        {
            var con = new SqlConnection(@"data source=localhost\SQLEXPRESS;database = Contacts;Trusted_Connection=True");

            SqlCommand cm = new SqlCommand("DELETE FROM Contacts WHERE Name = @name", con);

            cm.Parameters.AddWithValue("@name", name);

            con.Open();
            int i = cm.ExecuteNonQuery();

            con.Close();
        }      
    }
}

