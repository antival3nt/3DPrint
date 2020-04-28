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
using MongoDB.Driver;

namespace _3DPrint
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MongoUtils.MongoConnect();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewPrinter newPrinter = new NewPrinter();
            newPrinter.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            New_Filament new_Filament = new New_Filament();
            new_Filament.Show();
        }
    }
}
