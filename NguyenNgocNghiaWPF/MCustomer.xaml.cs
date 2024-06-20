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
    /// Interaction logic for MCustomer.xaml
    /// </summary>
    public partial class MCustomer : Window
    {
        private FuminiHotelManagementContext fuminiHotel;
        private int _customerID;
        public MCustomer(int customerID)
        {
            InitializeComponent();
            fuminiHotel = new FuminiHotelManagementContext();
            _customerID = customerID;
            LoadCustomerData();
            LoadBookingHistory();
        }
        private void LoadCustomerData()
        {
            var customer = fuminiHotel.Customers.FirstOrDefault(c => c.CustomerId == _customerID);
            if (customer != null)
            {
                var names = customer.CustomerFullName?.Split(' ');
                txtFName.Text = names?.FirstOrDefault();
                txtLName.Text = names?.LastOrDefault();
                txtEmail.Text = customer.EmailAddress;
                txtPhone.Text = customer.Telephone;
            }
        }

        private void LoadBookingHistory()
        {
            var bookingDetails = fuminiHotel.BookingDetails
                                            .Where(bd => bd.BookingReservation.CustomerId == _customerID)
                                            .Select(bd => new
                                            {
                                                BookingId = bd.BookingReservationId,
                                                RoomNumber = bd.Room.RoomNumber,
                                                CheckInDate = bd.StartDate,
                                                CheckOutDate = bd.EndDate,
                                                TotalAmount = bd.ActualPrice
                                            })
                                            .ToList();

            bookingDataGrid.ItemsSource = bookingDetails;
        }
        private void SaveProfile_Click(object sender, RoutedEventArgs e)
        {
            var customer = fuminiHotel.Customers.FirstOrDefault(c => c.CustomerId == _customerID);
            if (customer != null)
            {
                customer.CustomerFullName = $"{txtFName.Text} {txtLName.Text}";
                customer.EmailAddress = txtEmail.Text;
                customer.Telephone = txtPhone.Text;

                fuminiHotel.SaveChanges();
                MessageBox.Show("Profile saved successfully!");
            }
        }

    }
}
