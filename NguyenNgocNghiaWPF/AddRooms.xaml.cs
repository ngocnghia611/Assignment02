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
    /// Interaction logic for AddRooms.xaml
    /// </summary>
    public partial class AddRooms : Window
    {
        public AddRooms()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var room = new RoomInformation
                {
                    RoomNumber = txtRoomNumber.Text,
                    RoomDetailDescription = txtRoomDetailDescription.Text,
                    RoomMaxCapacity = int.TryParse(txtRoomMaxCapacity.Text, out var maxCapacity) ? maxCapacity : (int?)null,
                    RoomTypeId = int.Parse(txtRoomTypeID.Text),
                    RoomStatus = byte.TryParse(txtRoomStatus.Text, out var status) ? status : (byte?)null,
                    RoomPricePerDay = decimal.TryParse(txtRoomPricePerDay.Text, out var price) ? price : (decimal?)null
                };

                context.RoomInformations.Add(room);
                context.SaveChanges();
                MessageBox.Show("Room added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
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
            txtRoomID.Text = string.Empty;
            txtRoomNumber.Text = string.Empty;
            txtRoomDetailDescription.Text = string.Empty;
            txtRoomMaxCapacity.Text = string.Empty;
            txtRoomTypeID.Text = string.Empty;
            txtRoomStatus.Text = string.Empty;
            txtRoomPricePerDay.Text = string.Empty;
        }
    }
}
