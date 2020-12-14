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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        
        public AddWindow()
        {
            InitializeComponent();
        }
        private void AddBinding_Click(object sender, RoutedEventArgs e)
        {
            String Name;
            int age;
            String PhoneNumber;
            

            Name = addName.Text;
            PhoneNumber = addPhoneNumber.Text;
            age = int.Parse(addAge.Text);
            ContactManager.newContact(Name, age, PhoneNumber);


            this.Close();
        }

        private void CancelBinding_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
