   M S B A M L   `   `   `  ����D  @RentalCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RentalCar	RentalCar  5   	   9!clr-namespace:RentalCar.ViewModelRentalCar.ViewModel  5   	       RentalCar.ModalWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:RentalCar     5   	   7	viewModel!clr-namespace:RentalCar.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5   )    � Title$ Срок Аренды��5	   	   $	��300��6   $	��300��6*    � Icon$T NC:\Users\ilyas\Documents\UNIVER\CourseWork\RentalCar\RentalCar\Images\icon.png��5
       � 	Resources 5       �� 
TargetType �� Property �� Value��%  '��       '�� p     �� 5   
   " ��6   .�5      ��  � ��$ 18(�6)   �� 5       � ��$ Center=�64   5      �� 5   
   " ��6   .�5      ��  � ��$ Center=�69   �� 5       � ��$ Center=�64   �� 5       � ��$ 16(�6)   5      5       � DataContext 5      .   (RentalCar.ViewModel.ModalWindowViewModel  5   
   .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   (  "System.Windows.Controls.DatePicker  $��0��6   $��Center=�6@   $��0 30 0 0q�6]   $��18(�6o   $��0q�6}   
������ 	   SelectedDate	 6"   �� *Date+6�   �� 5    
   $��1��6   .+�5!      �� $*��$Введите срок аренды��6   �� 5"      $	��150��64   $��30��6@   $��20q�6L   ��6   �� *RentalPeriod+6L   5#      �� 5$   
   $��2��6   $��Оформить��6?   $��18(�6R   $��35��6`   
 � Cursor$

 Hand��6l   $	��150��6z   ���#09D397���#09D397
�������   AllBtns#���   6�   ��6   �� *OrderCommand+6�   5%      5&      