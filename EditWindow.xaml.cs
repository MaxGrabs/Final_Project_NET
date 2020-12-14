using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Final_Project_NET
{

    public partial class EditWindow : Window
    {
        Contact contact;
        public EditWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            addName.Text = ContactManager.viewContact(contact.Name)[0];
            addAge.Text = ContactManager.viewContact(contact.Name)[1];
            addPhoneNumber.Text = ContactManager.viewContact(contact.Name)[2];
        }

        private void EditBinding_Click(object sender, RoutedEventArgs e)
        {
            String oldName;
            String Name;
            int age;
            String PhoneNumber;
            oldName = contact.Name;
            Name = addName.Text;
            PhoneNumber = addPhoneNumber.Text;
            age = int.Parse(addAge.Text);
            ContactManager.updateContact(oldName, Name, age, PhoneNumber);

            this.Close();
        }

        private void CancelBinding_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
