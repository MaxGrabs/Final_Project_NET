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
            
        }

        private void btnAddContact_Click(object sender, RoutedEventArgs e)
        {
            AddWindow aw = new AddWindow();
            aw.ShowDialog();
        }

        private void btnShowContact_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnEditContact_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteContact_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

