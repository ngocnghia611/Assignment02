   M S B A M L   `   `   `  ����M  INguyenNgocNghiaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyenNgocNghiaWPFNguyenNgocNghiaWPF  5   	   $    NguyenNgocNghiaWPF.UpdateRooms   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyenNgocNghiaWPF     5   	     � Title$  UpdateRooms��5   	   $	��500��6   $	��620��6*    � WindowStartupLocation$ CenterScreen=�66   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $��* �6   .+�5%   
   �� $��Room Information��6   $��24(�6+   $
��Bold"�69   $��0��6K   $��0��6X   $��2��6h   $��Center=�6|   $��10q�6�   �� 5'   
   $��Room ID��6   $��1��6"   $��0��6/   $��Center=�6?   $��10q�6Z   �� 5(   
   -   5         ��Name$ 	txtRoomID��5(      $��1��6%   $��1��62   $��10q�6B   ${�False��6N   �� 5*   
   $��Room Number��6   $��2��6&   $��0��63   $��Center=�6C   $��10q�6^   �� 5+   
   -   5        $ txtRoomNumber��5+      $��2��6)   $��1��66   $��10q�6F   �� 5-   
   $��Room Detail Description��6   $��3��62   $��0��6?   $��Center=�6O   $��10q�6j   �� 5.   
   -   5        $ txtRoomDetailDescription��5.      $��3��64   $��1��6A   $��10q�6Q   �� 50   
   $��Room Max Capacity��6   $��4��6,   $��0��69   $��Center=�6I   $��10q�6d   �� 51   
   -   5        $ txtRoomMaxCapacity��51      $��4��6.   $��1��6;   $��10q�6K   �� 53   
   $��Room Type ID��6   $��5��6'   $��0��64   $��Center=�6D   $��10q�6_   �� 54   
   -   5        $ txtRoomTypeID��54      $��5��6)   $��1��66   $��10q�6F   �� 56   
   $��Room Price Per Day��6   $��6��6-   $��0��6:   $��Center=�6J   $��10q�6e   �� 57   
   -   5        $ txtRoomPricePerDay��57      $��6��6.   $��1��6;   $��10q�6K   �� 59   
   $��Room Status��6   $��7��6&   $��0��63   $��Center=�6C   $��10q�6^   �� 5:   
   -   5        $ txtRoomStatus��5:      $��7��6)   $��1��66   $��10q�6F   �� 5<   
   	 �� Orientation$	 
Horizontal=�6   $��Center=�6.   $��8��6K   $��0��6X   $��2��6h   $��10q�6|   .+�5=      �� -   5        
 ��Name$
 	btnUpdate��5=      $��Update��6(   $	��100��69   ���	#FF0099FF
�������$��5q�6o   6z   �� 5>      -	   5        $
 btnClose��5>      $��Close��6'   $	��100��67   ���	#FFEF8F18
�������$��5q�6m   6x   5?      5@      5A      