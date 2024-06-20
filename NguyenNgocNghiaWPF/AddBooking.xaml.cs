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
    /// Interaction logic for AddBooking.xaml
    /// </summary>
    public partial class AddBooking : Window
    {
        public AddBooking()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var reservation = new BookingReservation
                {
                    CustomerId = int.Parse(txtCustomerID.Text),
                    BookingDate = txtBookingDate.SelectedDate.HasValue ? DateOnly.FromDateTime(txtBookingDate.SelectedDate.Value) : null,
                    TotalPrice = decimal.Parse(txtTotalPrice.Text),
                    BookingStatus = byte.Parse(txtBookingStatus.Text)
                };

                context.BookingReservations.Add(reservation);
                context.SaveChanges();
                MessageBox.Show("Booking added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            ClearInputs();
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ClearInputs()
        {
            txtReservationID.Text = string.Empty;
            txtBookingDate.Text = string.Empty;
            txtTotalPrice.Text = string.Empty;
            txtCustomerID.Text = string.Empty;
            txtBookingStatus.Text = string.Empty;
        }
    }
}
