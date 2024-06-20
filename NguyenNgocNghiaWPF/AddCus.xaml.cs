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
    /// Interaction logic for AddCus.xaml
    /// </summary>
    public partial class AddCus : Window
    {
        FuminiHotelManagementContext fuminiHotel = new FuminiHotelManagementContext();

        public AddCus()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer
            {
                CustomerFullName = txtFullName.Text,
                Telephone = txtTelephone.Text,
                EmailAddress = txtEmailAddress.Text,
                CustomerBirthday = txtCustomerBirthday.SelectedDate.HasValue ? DateOnly.FromDateTime(txtCustomerBirthday.SelectedDate.Value) : null,
                CustomerStatus = byte.TryParse(txtCustomerStatus.Text, out var status) ? status : (byte?)null,
                Password = txtPassword.Password
            };

            fuminiHotel.Customers.Add(customer);
            fuminiHotel.SaveChanges();

            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);

            ClearInputs();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtCustomerID.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtTelephone.Text = string.Empty;
            txtEmailAddress.Text = string.Empty;
            txtCustomerBirthday.SelectedDate = null;
            txtCustomerStatus.Text = string.Empty;
            txtPassword.Password = string.Empty;
        }

        
    }
}
