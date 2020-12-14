using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Final_Project_NET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            
            //lvDataBinding.ItemSource = the new contacts we want to add to the window.
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < ContactManager.ReadContacts().Count; i++)
            {
                contacts.Add(ContactManager.ReadContacts()[i]);
            }
            ContactList.ItemsSource = contacts;
        }

        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            
            AddWindow aw = new AddWindow();

            aw.ShowDialog();
            if (aw.IsLoaded)
            {
                List<Contact> contacts = new List<Contact>();
                for (int i = 0; i < ContactManager.ReadContacts().Count; i++)
                {
                    contacts.Add(ContactManager.ReadContacts()[i]);
                }
                ContactList.ItemsSource = contacts;
            }
        }

        private void btnShowContact_Click(object sender, RoutedEventArgs e)
        {
            Contact selectContact = (Contact)ContactList.SelectedItem;
            if (selectContact != null)
            {
                
                ViewWindow vw = new ViewWindow(selectContact);

                vw.ShowDialog();

            }
        }

        private void btnEditContact_Click(object sender, RoutedEventArgs e)
        {
            Contact selectContact = (Contact)ContactList.SelectedItem;
            if(selectContact != null)
            {
                EditWindow ew = new EditWindow(selectContact);
                ew.ShowDialog();
            if (ew.IsLoaded)
            {
                List<Contact> contacts = new List<Contact>();
                for (int i = 0; i < ContactManager.ReadContacts().Count; i++)
                {
                    contacts.Add(ContactManager.ReadContacts()[i]);
                }
                ContactList.ItemsSource = contacts;
            }
            }
        }

        private void btnDeleteContact_Click(object sender, RoutedEventArgs e)
        {
           Contact selectContact = (Contact)ContactList.SelectedItem;
            if(selectContact != null)
            {
                ContactManager.deleteContact(selectContact.Name);
                List<Contact> contacts = new List<Contact>();
                for (int i = 0; i < ContactManager.ReadContacts().Count; i++)
                {
                    contacts.Add(ContactManager.ReadContacts()[i]);
                }
                ContactList.ItemsSource = contacts;
            }
        }

        private void btnSaveContact_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV(*.csv)|*.csv";
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < ContactManager.ReadContacts().Count; i++)
            {
                contacts.Add(ContactManager.ReadContacts()[i]);
            }
            string[] arr = new string[contacts.Count];
            for(int i=0; i<contacts.Count; i++)
            {
                arr[i] = contacts[i].Name + "," + contacts[i].Age + "," + contacts[i].phoneNumber;
            }
            
            if (saveFileDialog.ShowDialog()== true)
            {
                    File.WriteAllLines(saveFileDialog.FileName, arr); 
            }


        }
        

        private void btnLoadContact_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
          //  openFileDialog.Filter = "CSV(*.csv)|*csv";
            if (openFileDialog.ShowDialog() == true)
            {

                int count = ContactManager.ReadContacts().Count;
                for (int i = 0; i < count; i++)
                {
                    Contact contacting = new Contact(ContactManager.ReadContacts()[0].Name, ContactManager.ReadContacts()[0].Age, ContactManager.ReadContacts()[0].phoneNumber);
                    ContactManager.deleteContact(contacting.Name);
                }

                var lines = File.ReadLines(openFileDialog.FileName);

                foreach (string line in lines)
                {
                    string[] words = line.Split(',');
                    ContactManager.newContact(words[0], int.Parse(words[1]), words[2]);
                }
                List<Contact> contacts = new List<Contact>();
                for (int i = 0; i < ContactManager.ReadContacts().Count; i++)
                {
                    contacts.Add(ContactManager.ReadContacts()[i]);
                }
                ContactList.ItemsSource = contacts;
            }
        }
    }
}

