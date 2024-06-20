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
    /// Interaction logic for UpdateCus.xaml
    /// </summary>
    public partial class UpdateCus : Window
    {
        private Customer _customer;
        public UpdateCus(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            PopulateFields();
        }

        private void PopulateFields()
        {
            if (_customer != null)
            {
                txtCustomerID.Text = _customer.CustomerId.ToString();
                txtFullName.Text = _customer.CustomerFullName;
                txtTelephone.Text = _customer.Telephone;
                txtEmailAddress.Text = _customer.EmailAddress;
                txtCustomerBirthday.SelectedDate = _customer.CustomerBirthday?.ToDateTime(new TimeOnly());
                txtCustomerStatus.Text = _customer.CustomerStatus.ToString();
                txtPassword.Password = _customer.Password;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtCustomerID.Text, out var customerId))
            {
                using (var context = new FuminiHotelManagementContext())
                {
                    var customer = context.Customers.FirstOrDefault(c => c.CustomerId == customerId);
                    if (customer != null)
                    {
                        customer.CustomerFullName = txtFullName.Text;
                        customer.Telephone = txtTelephone.Text;
                        customer.EmailAddress = txtEmailAddress.Text;
                        customer.CustomerBirthday = txtCustomerBirthday.SelectedDate.HasValue ? DateOnly.FromDateTime(txtCustomerBirthday.SelectedDate.Value) : null;
                        customer.CustomerStatus = byte.TryParse(txtCustomerStatus.Text, out var status) ? status : (byte?)null;
                        customer.Password = txtPassword.Password;

                        context.SaveChanges();
                        MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                ClearInputs();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Customer ID.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
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
