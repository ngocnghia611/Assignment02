   M S B A M L   `   `   `  ����M  INguyenNgocNghiaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:NguyenNgocNghiaWPFNguyenNgocNghiaWPF  5   	   "    NguyenNgocNghiaWPF.UpdateCus   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:NguyenNgocNghiaWPF     5   	     � Title$  	UpdateCus��5   	   $	��500��6   $	��620��6)   .��5	      � ��5
   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ #0099FF��6    � Offset$ 0Q�6/   � 5      $ 	#FF347BDA��6   $ 0.794Q�61   � 5      $ 	#FF60B1E7��6   $ 1Q�61   � 5      $ 	#FF596FDD��6   $ 0.309Q�61   � 5      $ 	#FF472FDE��6   $ 0.484Q�61   5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5    
   �� 5!      $
��Auto �6   �� 5"      $��* �6   .+�5%   
   �� $��Customer Management��6   $��24(�6.   $
��Bold"�6<   $��0��6N   $��0��6[   $��2��6k   $��Center=�6   $��10q�6�   �� 5'   
   $��Customer ID��6   $��1��6&   $��0��63   $��Center=�6C   $��10q�6^   �� 5(   
   -   5         ��Name$ txtCustomerID��5(      $��1��6)   $��1��66   $��10q�6F   ${�False��6R   �� 5*   
   $��	Full Name��6   $��2��6$   $��0��61   $��Center=�6A   $��10q�6\   �� 5+   
   -   5        $ txtFullName��5+      $��2��6'   $��1��64   $��10q�6D   �� 5-   
   $��	Telephone��6   $��3��6$   $��0��61   $��Center=�6A   $��10q�6\   �� 5.   
   -   5        $ txtTelephone��5.      $��3��6(   $��1��65   $��10q�6E   �� 50   
   $��Email Address��6   $��4��6(   $��0��65   $��Center=�6E   $��10q�6`   �� 51   
   -   5        $ txtEmailAddress��51      $��4��6+   $��1��68   $��10q�6H   �� 53   
   $��Customer Birthday��6   $��5��6,   $��0��69   $��Center=�6I   $��10q�6d   (  "System.Windows.Controls.DatePicker  54   
   -   5          Name$ txtCustomerBirthday��54      $��5��62   $��1��6?   $��10q�6O   �� 56   
   $��Customer Status��6   $��6��6*   $��0��67   $��Center=�6G   $��10q�6b   �� 57   
   -   5        $ txtCustomerStatus��57      $��6��6-   $��1��6:   $��10q�6J   �� 59   
   $��Password��6   $��7��6#   $��0��60   $��Center=�6@   $��10q�6[   G� 5:   
   -   5        	 G�Name$	 txtPassword��5:      $��7��6+   $��1��68   $��10q�6H   �� 5<   
   
 �� Orientation$
 
Horizontal=�6   $��Center=�6.   $��8��6K   $��0��6X   $��2��6h   $��10q�6|   .+�5=      �� -   5         ��Name$ 	btnUpdate��5=      $��Update��6(   $	��100��69   ���	#FF0099FF
�������$��5q�6o   6z   �� 5>      -	   5        $ btnClose��5>      $��Close��6'   $	��100��67   ���	#FFEF8F18
�������$��5q�6m   6x   5?      5@      5A      