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
    /// Interaction logic for UpdateRooms.xaml
    /// </summary>
    public partial class UpdateRooms : Window
    {
        private RoomInformation _room;
        public UpdateRooms(RoomInformation room)
        {
            InitializeComponent();
            _room = room;
            PopulateFields();
        }

        private void PopulateFields()
        {
            if (_room != null) {
                txtRoomID.Text = _room.RoomId.ToString();
                txtRoomNumber.Text = _room.RoomNumber;
                txtRoomDetailDescription.Text = _room.RoomDetailDescription;
                txtRoomMaxCapacity.Text = _room.RoomMaxCapacity?.ToString();
                txtRoomTypeID.Text = _room.RoomTypeId.ToString();
                txtRoomStatus.Text = _room.RoomStatus?.ToString();
                txtRoomPricePerDay.Text = _room.RoomPricePerDay?.ToString();
            }         
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new FuminiHotelManagementContext())
            {
                var room = context.RoomInformations.FirstOrDefault(r => r.RoomId == _room.RoomId);
                if (room != null)
                {
                    room.RoomNumber = txtRoomNumber.Text;
                    room.RoomDetailDescription = txtRoomDetailDescription.Text;
                    room.RoomMaxCapacity = int.TryParse(txtRoomMaxCapacity.Text, out var maxCapacity) ? maxCapacity : (int?)null;
                    room.RoomTypeId = int.Parse(txtRoomTypeID.Text);
                    room.RoomStatus = byte.TryParse(txtRoomStatus.Text, out var status) ? status : (byte?)null;
                    room.RoomPricePerDay = decimal.TryParse(txtRoomPricePerDay.Text, out var price) ? price : (decimal?)null;

                    context.SaveChanges();
                    MessageBox.Show("Room updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Room not found.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
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
