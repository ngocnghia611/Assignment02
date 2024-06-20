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
    /// Interaction logic for UpdateBooking.xaml
    /// </summary>
    public partial class UpdateBooking : Window
    {
        private BookingReservation _reservation;
        public UpdateBooking(BookingReservation reservation)
        {
            InitializeComponent();
            _reservation = reservation;
        }

        private void PopulateFields()
        {
            txtReservationID.Text = _reservation.BookingReservationId.ToString();
            txtCustomerID.Text = _reservation.CustomerId.ToString();
            txtBookingDate.SelectedDate = _reservation.BookingDate?.ToDateTime(new TimeOnly(0, 0));
            txtTotalPrice.Text = _reservation.TotalPrice?.ToString() ?? string.Empty;
            txtBookingStatus.Text = _reservation.BookingStatus?.ToString() ?? string.Empty;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var reservationToUpdate = context.BookingReservations
                    .FirstOrDefault(br => br.BookingReservationId == _reservation.BookingReservationId);

                if (reservationToUpdate != null)
                {
                    reservationToUpdate.CustomerId = int.Parse(txtCustomerID.Text);
                    reservationToUpdate.BookingDate = txtBookingDate.SelectedDate.HasValue ? DateOnly.FromDateTime(txtBookingDate.SelectedDate.Value) : null;
                    reservationToUpdate.TotalPrice = decimal.Parse(txtTotalPrice.Text);
                    reservationToUpdate.BookingStatus = byte.Parse(txtBookingStatus.Text);

                    context.SaveChanges();
                    MessageBox.Show("Booking updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Booking not found!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
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
