   M S B A M L   `   `   `  ����M  INguyenNgocNghiaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyenNgocNghiaWPFNguyenNgocNghiaWPF  5   	       NguyenNgocNghiaWPF.Admin   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyenNgocNghiaWPF     5   	     � Title$  Admin��5   	   $	��600��6   $	��800��6$   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5      .+�5   
   �� .@�5      �� $��	Customers��6   .��5      � $��10q�6    � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $��* �6(   �� 5      $
��Auto �6(    � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      $��* �6+   .+�5"      �� $��Search:��6   $��Center=�6.   $��0��6I   $��0��6V   �� 5#      -   5        $��CustomerSearchBox��5#      $	��200��5$      $��5q�5%      $��0��5&      $��1��5'      5(      &   System.Windows.Controls.DataGrid  5+      -   5        $��customerDataGrid��5+         AutoGenerateColumns$ False��5,      $��5q�5-      $��1��5.      $��2��5/         Columns 51      0  *System.Windows.Controls.DataGridTextColumn  52      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Customer ID��61   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6F   �� *
CustomerId+  53      $	 	Full Name��61   
 6D   �� *CustomerFullName+  54      $	 	Telephone��61   
 6D   �� *	Telephone+  55      $	 Email��61   
 6@   �� *EmailAddress+  56      $	 Status��61   
 6A   �� *CustomerStatus+  57      $	 Password��61   
 6C   �� *
Password+59      �� 5;       �� Orientation$ 
Horizontal=�6!   $��Center=�6:   $��2��6W   $��2��6d   $��5q�6x   .+�5<      �� -   5        $	��Add��5<   !   $��75��6/   $��5q�6:   ���	#FF0099FF
�������
�������6�   �� 5=      -   5        $��Update��5=   !   $��75��62   $��5q�6=   ���	#FF0099FF
�������
�������6�   �� 5>      -   5        $��Delete��5>   !   $��75��62   $��5q�6=   ���	#FF0099FF
�������
�������6�   5?      5@      5A      �� 5D      $��Rooms��6   .��5E      � $��10q�6    5F      �� 5G      $
��Auto �6(   �� 5H      $��* �6(   �� 5I      $
��Auto �6(    5K      �� 5L      $
��Auto �6+   �� 5M      $��* �6+   .+�5Q      �� $��Search:��6   $��Center=�6.   $��0��6I   $��0��6V   �� 5R      -   5        $��RoomSearchBox��5R      $	��200��5S      $��5q�5T      $��0��5U      $��1��5V      5W        5Z      -   5        $��roomDataGrid��5Z      $ False��5[      $��5q�5\      $��1��5]      $��2��5^       5`        5a      $	 Room ID��61   
 6B   �� *RoomId+  5b      $	 Room Number��61   
 6F   �� *
RoomNumber+  5c      $	 Description��61   
 6F   �� *RoomDetailDescription+  5d      $	 Max Capacity��61   
 6G   �� *RoomMaxCapacity+  5e      $	 Price Per Day��61   
 6H   �� *RoomPricePerDay+  5f      $	 Status��61   
 6A   �� *
RoomStatus+5h      �� 5j      $ 
Horizontal=�6!   $��Center=�6:   $��2��6W   $��2��6d   $��5q�6x   .+�5k      �� -   5        $	��Add��5k   !   $��75��6/   $��5q�6:   6E   �� 5l      -	   5        $��Update��5l   !   $��75��62   $��5q�6=   6H   �� 5m      -
   5        $��Delete��5m   !   $��75��62   $��5q�6=   6H   5n      5o      5p      �� 5s      $��Bookings��6   .��5t      � $��10q�6    5u      �� 5v      $
��Auto �6(   �� 5w      $��* �6(   �� 5x      $
��Auto �6(    5z      �� 5{      $
��Auto �6+   �� 5|      $	��47* �6+   �� 5}      $
��679* �6+   .+�5�      �� $��Search:��6   $��Center=�6.   $��0��6I   $��2��6Y   $��0,0,47,0q�6m   �� 5�      -   5        $��BookingSearchBox��5�      $	��200��5�      $��216,5,263,5q�5�      $��0��5�      $��2��5�      5�        5�      -   5        $��bookingDataGrid��5�      $ False��5�      $��5,5,5,5q�5�      $��1��5�      $��3��5�       5�        5�      $	 Reservation ID��61   
 6I   �� *BookingReservationId+  5�      $	 Customer ID��61   
 6F   �� *
CustomerId+  5�      $	 Booking Date��61   
 6G   �� *BookingDate+  5�      $	 Total Price��61   
 6F   �� *
TotalPrice+  5�      $	 Status��61   
 6A   �� *BookingStatus+5�      �� 5�      $ 
Horizontal=�6!   $
��Left=�6:   $��2��6U   $��	165,5,0,5q�6b   $��2��6u   .+�5�      �� -   5        $	��Add��5�   !   $��75��6/   $��5q�6:   6E   �� 5�      -   5        $��Update��5�   !   $��75��62   $��5q�6=   6H   �� 5�      -   5        $��Delete��5�   !   $��75��62   $��5q�6=   6H   5�      5�      5�      �� 5�      $��Reports��6   .��5�      � $��10q�6   .+�5�      �� $ Vertical=�6!   .+�5�      �� $ 
Horizontal=�6%   $��5q�6>   .+�5�      �� $��Start Date:��6(   $��Center=�6;   $��5q�6V   (  "System.Windows.Controls.DatePicker  5�      -   5        $��StartDatePicker��5�   )   $��5q�6@   5�      �� 5�      $ 
Horizontal=�6%   $��5q�6>   .+�5�      �� $��	End Date:��6(   $��Center=�69   $��5q�6T     5�      -   5        $��EndDatePicker��5�   )   $��5q�6>   5�      �� 5�      -   5        $��Generate Report��5�   !   $	��150��6;   $��5q�6d     5�      -   5        $��reportDataGrid��5�   #   $
 True��69   $��5q�6T   $	��360��6_   5�      5�      5�      5�      5�      5�      