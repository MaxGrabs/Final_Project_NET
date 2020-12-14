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
    /// <summary>
    /// Interaction logic for ViewWindow.xaml
    /// </summary>
    public partial class ViewWindow : Window 
    {
        Contact contact;

        public ViewWindow(Contact contact)
        {
            InitializeComponent();
            this.contact = contact;
            DetailedView.Text = "Name : " + ContactManager.viewContact(contact.Name)[0] 
               + "\nAge : " + ContactManager.viewContact(contact.Name)[1]
               + "\nPhone Number : " + ContactManager.viewContact(contact.Name)[2]; 
        }

        private void OkayBinding_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }
    }
}
