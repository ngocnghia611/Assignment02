using Microsoft.EntityFrameworkCore;
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
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        private FuminiHotelManagementContext fuminiHotel;
        public Admin()
        {
            InitializeComponent();
            fuminiHotel = new FuminiHotelManagementContext();
            LoadCustomers();
            LoadRooms();
            LoadBookings();
        }

        private void LoadCustomers()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var customers = context.Customers.ToList();
                customerDataGrid.ItemsSource = customers;
            }
        }

        public void LoadRooms()
        {
            using (var context = new FuminiHotelManagementContext())
            {
                List<RoomInformation> rooms = fuminiHotel.RoomInformations.ToList();
                roomDataGrid.ItemsSource = rooms;
            }
                
        }

        private void LoadBookings()
        {
            List<BookingReservation> bookings = fuminiHotel.BookingReservations.ToList();
            bookingDataGrid.ItemsSource = bookings;
        }


        private void CustomerSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CustomerDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
            AddCus addCus = new AddCus();
            addCus.Closed += (s, args) => LoadCustomers();  
            addCus.Show();

        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (customerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                UpdateCus updateCus = new UpdateCus(selectedCustomer);
                updateCus.Closed += (s, args) => LoadCustomers();
                updateCus.Show();
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (customerDataGrid.SelectedItem is Customer selectedCustomer)
            {
                var result = MessageBox.Show($"Are you sure you want to delete {selectedCustomer.CustomerFullName}?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    using (var context = new FuminiHotelManagementContext())
                    {
                        context.Customers.Remove(selectedCustomer);
                        context.SaveChanges();
                    }
                    LoadCustomers();
                }
            }
        }

        private void RoomSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RoomDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddRoom_Click(object sender, RoutedEventArgs e)
        {
            AddRooms addRooms = new AddRooms();
            addRooms.Closed += (s, args) => LoadRooms();
            addRooms.Show();
        }

        private void EditRoom_Click(object sender, RoutedEventArgs e)
        {
            if (roomDataGrid.SelectedItem is RoomInformation selectedRoom)
            {
                UpdateRooms updateRooms = new UpdateRooms(selectedRoom);
                LoadRooms();
                updateRooms.Show();
            }
            else
            {
                MessageBox.Show("Please select a room to edit.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteRoom_Click(object sender, RoutedEventArgs e)
        {
            if (roomDataGrid.SelectedItem is RoomInformation selectedRoom)
            {
                var result = MessageBox.Show($"Are you sure you want to delete room {selectedRoom.RoomNumber}?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    using (var context = new FuminiHotelManagementContext())
                    {
                        context.RoomInformations.Remove(selectedRoom);
                        context.SaveChanges();
                    }
                    LoadRooms();
                }
            }
        }

        private void BookingSearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BookingDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void AddBooking_Click(object sender, RoutedEventArgs e)
        {
            AddBooking addBooking = new AddBooking();
            addBooking.Closed += (s, args) => LoadBookings();
            addBooking.Show();
        }

        private void EditBooking_Click(object sender, RoutedEventArgs e)
        {
            if (bookingDataGrid.SelectedItem is BookingReservation selectedBooking)
            {
                UpdateBooking updateBooking = new UpdateBooking(selectedBooking);
                updateBooking.Closed += (s, args) => LoadBookings();
                updateBooking.Show();
            }
            else
            {
                MessageBox.Show("Please select a booking to edit.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteBooking_Click(object sender, RoutedEventArgs e)
        {
            if (bookingDataGrid.SelectedItem is BookingReservation selectedBooking)
            {
                var result = MessageBox.Show($"Are you sure you want to delete booking {selectedBooking.BookingReservationId}?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    using (var context = new FuminiHotelManagementContext())
                    {
                        context.BookingReservations.Remove(selectedBooking);
                        context.SaveChanges();
                    }
                    LoadBookings();
                }
            }
        }

        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
