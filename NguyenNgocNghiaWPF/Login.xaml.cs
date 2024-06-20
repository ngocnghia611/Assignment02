using NguyenNgocNghiaWPF.Models;
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

namespace NguyenNgocNghiaWPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        private readonly string adminEmail = "admin@FUMiniHotelSystem.com";
        private readonly string adminPassword = "@@abc123@@";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            if (email == adminEmail && password == adminPassword)
            {
                Admin admin = new Admin();
                admin.Show();
                this.Close();
            }
            else
            {
                using (var context = new FuminiHotelManagementContext())
                {
                    var customer = context.Customers
                        .FirstOrDefault(c => c.EmailAddress == email && c.Password == password);

                    if (customer != null)
                    {
                        MCustomer mCustomer = new MCustomer(customer.CustomerId);
                        mCustomer.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Email or password is incorrect. Please try again!", "Login failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
