using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using MongoDB.Driver;

namespace _3DPrint
{
    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Window
    {
        public NewCustomer()
        {
            InitializeComponent();
        }


    private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            IMongoDatabase db = dbClient.GetDatabase("testdb");

            var customer = db.GetCollection<BsonDocument>("customer");

            var doc = new BsonDocument
            {
                {"name", newCustomer_name.Text},
                {"address", newCustomer_address.Text},
                {"zip", newCustomer_city.Text},
                {"city", newCustomer_city.Text},
                {"mail", newCustomer_mail.Text},
                {"phone", newCustomer_phone.Text}
                //{"orders", 34621}
            };

            customer.InsertOne(doc);
        }
    }
}