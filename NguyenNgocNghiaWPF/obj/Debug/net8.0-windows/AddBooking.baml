   M S B A M L   `   `   `  ����M  INguyenNgocNghiaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyenNgocNghiaWPFNguyenNgocNghiaWPF  5   	   #    NguyenNgocNghiaWPF.AddBooking   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyenNgocNghiaWPF     5   	     � Title$  
AddBooking��5   	   $	��460��6   $	��620��6)   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5       $��* �6   .+�5#   
   �� $��Booking Reservation��6   $��24(�6.   $
��Bold"�6<   $��0��6N   $��0��6[   $��2��6k   $��Center=�6   $��10q�6�   �� 5%   
   $��Reservation ID��6   $��1��6)   $��0��66   $��Center=�6F   $��10q�6a   �� 5&   
   -   5         ��Name$ txtReservationID��5&      $��1��6,   $��1��69   $��10q�6I   ${�False��6U   �� 5(   
   $��Customer ID��6   $��2��6&   $��0��63   $��Center=�6C   $��10q�6^   �� 5)   
   -   5        $ txtCustomerID��5)      $��2��6)   $��1��66   $��10q�6F   �� 5+   
   $��Booking Date��6   $��3��6'   $��0��64   $��Center=�6D   $��10q�6_   (  "System.Windows.Controls.DatePicker  5,   
   -   5          Name$ txtBookingDate��5,      $��3��6-   $��1��6:   $��10q�6J   �� 5.   
   $��Total Price��6   $��4��6&   $��0��63   $��Center=�6C   $��10q�6^   �� 5/   
   -   5        $ txtTotalPrice��5/      $��4��6)   $��1��66   $��10q�6F   �� 51   
   $��Booking Status��6   $��5��6)   $��0��66   $��Center=�6F   $��10q�6a   �� 52   
   -   5        $ txtBookingStatus��52      $��5��6,   $��1��69   $��10q�6I   �� 54   
   	 �� Orientation$	 
Horizontal=�6   $��Center=�6.   $��6��6K   $��0��6X   $��2��6h   $��10q�6|   .+�55      �� -   5        
 ��Name$
 btnAdd��55      $	��Add��6%   $	��100��63   ���	#FF0099FF
�������$��5q�6i   $��49��6u   6�   �� 56      -   5        $
 btnClose��56      $��Close��6'   $	��100��67   ���	#FFEF8F18
�������$��5q�6m   $��49��6�   57      58      59      