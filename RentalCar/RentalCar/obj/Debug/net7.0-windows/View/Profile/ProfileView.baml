   M S B A M L   `   `   `  ����D  @RentalCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:RentalCar.View.ProfileRentalCar.View.Profile  5      u?clr-namespace:RentalCar.View.UserControls.NavUserControl.Client1RentalCar.View.UserControls.NavUserControl.Client  5      1clr-namespace:RentalCar.ModelRentalCar.Model  5      9!clr-namespace:RentalCar.ViewModelRentalCar.ViewModel  5	      (    "RentalCar.View.Profile.ProfileView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:RentalCar.View.Profile     5      Onav?clr-namespace:RentalCar.View.UserControls.NavUserControl.Client     5      /modelclr-namespace:RentalCar.Model     5      7	viewModel!clr-namespace:RentalCar.ViewModel     5	        N� Title$  ProfileView��5       � 	Resources 5       �� 
TargetType �� Property �� Value   ListBox.Static.Background �� Color  ListBox.Static.Border  ListBox.Disabled.Background  ListBox.Disabled.Border  ListBoxStyle �� 
TargetType ��Name �� CornerRadius	 �� Padding
 J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName ]� 
Conditions �� Property �� Value��%A  '��       &	  H     &	 k     &	 �     &	 �     &	 �     7   7  7  7  �� 5   
   " ��6   .�5      ��  � ��$ 20(�6)   5      �� 5   
   $ 	#FFFFFFFF��6<   �� 5   
   $ 	#FFABADB3��68   �� 5   
   $ 	#FFFFFFFF��6>   �� 5   
   $ 	#FFD9D9D9��6:   �� 5   
   " ��6%   .�5      ��  � ��8   6+   �� 5       � ��8  6,   �� 5       � ��$ 1q�60   �� 5       � ��# � ��6+   �� 5       � ��$
 Auto=�6K   �� 5       � ��$
 Auto=�6I   �� 5       � ��$
 true��6>   �� 5       �@��PanningMode$
 Both=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � ��$ Center=�69   �� 5        � �� 5!      �� 5"      " ��6&   .R�5#      �� $ Bd��6!   $ 10��6-   #��z��6?   #��z��6i   #��z��6�   $	 1q�6�   $

 true��6�   ._�5$      �� $|�false��6+   #��z��6=   .��5%   "   �� #
 z
 61   5&      5'       5(      P� 5)       � {�$ false��6;   . �5*   "   �� $ Bd��6?   8   � ��6O   �� 5+   "   $ Bd��6@   8   � ��6P   5,      ]� 5-       5.   "   �� 5/   &    �@��
IsGrouping$
 true��6F   �� 50   &   " �@%�IsVirtualizingWhenGrouping$ false��6h   ./�52   "   ��  � ��$ false��6R   53      55      57      58      59       � DataContext 5:      *   $RentalCar.ViewModel.ProfileViewModel  5;   
   .��5=      �  � RowDefinitions 5>   
   �� 5?      $	��100��6   �� 5@      $	��335��6   �� 5A      .+�5C   
   @   :RentalCar.View.UserControls.NavUserControl.Client.OtherNav  $��0��6   $	��Top=�6$   $��	20 20 0 0q�6<   �� 5D   
   $��1��6   $��20q�6   $	 20 10q�6*   $��2q�6;   ���#09D397$ 10��6e   ._�5E      �� .+�5F      �� $��Информация��6   $��Center=�6.   $��25(�6K   �� 5G      $��Center=�62   $��0 30 0 0q�6O   ��6   �� *Name+6O   �� 5H      $��Center=�66   $��0 10 0 0q�6S   ��6   �� *
Passport+6S   �� 5I      $��Center=�68   $��0 10 0 0q�6U   ��6   �� *
CardNumber+6U   �� 5J      $��Center=�63   $��0 10 0 0q�6P   ��6   �� *Login+6P   �� 5K      $��
Выход��6@     AllBtns#���  6P   $��0 20 0 0q�6r    � Cursor$
 Hand��6�   ���#09D397
����������#09D397$	��100��6�   $��40��6�   $��18(�6�   ��6   �� *ExitAccountCommand+6�   5L      5M      �� 5N   
   $��2��6   #���  6@   $	��250��6g   $��10q�6t   $��20 40 20 10q�6�   $��2q�6�   ���#09D397
������ ��6   �� *
CarItems+��5O      �� 5P      .R�5Q      �  � ColumnDefinitions 5R      �� 5S      $	��300 �6/   �� 5T      $	��600 �6/   �� 5U      .+�5W      �� $��0��6    $��Center=�60   ��6K   ��  �� Path$ Image�6k   �� 5X      $��1��6%   $��20q�65   .+�5Y      �� ��6(   �� $ Model��� 5Z      $
��Wrap=�6J   $��	0 20 0 0 q�6^   ��6(   �� $ Description�6^   �� 5[      ��6(   �� $ Power��� 5\      ��6(   �� $ FuelConsumption��� 5]      ��6(   �� $ Capacity��� 5^      ��6(   �� $ CarBody��� 5_      ��6(   �� $ CarClass��� 5`      $��	0 20 0 0 q�6D   $��
ExtraBlack"�6W   ��6(   �� $ Price�6W   5a      �� 5b      $��2��6!   #���  61   $��Отменить��6z   $
 Hand��6�   $	��140��6�   $��35��6�   
�������$��Bottom=�6�   $��0 0 0 30q�6�   $��20(�6�   ���#09D397���#09D397��6S   �� *CancelOrderCommand+6  5c      5d      5f      5g      5h      