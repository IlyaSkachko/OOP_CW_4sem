   M S B A M L   `   `   `  ����D  @RentalCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:RentalCar.View.UserControls.NavUserControl.Client1RentalCar.View.UserControls.NavUserControl.Client  5      9!clr-namespace:RentalCar.ViewModelRentalCar.ViewModel  5      @    :RentalCar.View.UserControls.NavUserControl.Client.OtherNav   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:RentalCar.View.UserControls.NavUserControl.Client     5      7	viewModel!clr-namespace:RentalCar.ViewModel     5      $
��1100��5	        � 	Resources  5
         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  SearchField �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonTemplate1 ��Name��%6  &	        &	 #     &	 F     &	 i     7   7  7  '�� �    &	     &	 $    &	 G    &	 j    &	 �    &		 �    &	
 �    &	 �    7  7  7  7  7  7 	 7 
 �� 5      $ 	#FFABAdB3��64   �� 5      $ 	#FF7EB4EA��67   �� 5      $ 	#FF569DE5��63   �� 5      " ��6    .�5   
   ��  � ��# � ��6'   �� 5   
    � ��8   6(   �� 5   
    � ��# � ��6'   �� 5   
    � ��$ 1q�6,   �� 5   
    �@ TabNavigation$
 None=�6=   �� 5   
    � ��$
 Left=�67   �� 5   
    �@�FocusVisualStyle 6-   Z� �� 5   
    �@J�	AllowDrop$
 true��6&   �� 5   
    �@��PanningMode$ VerticalFirst=�65   �� 5   
    �@��IsFlicksEnabled$ False��63   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� $ border��6   $ 10��6-   #��z��6?   #��z��6i   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6'   $|�false��6A   $��Hidden=�6S   $��Hidden=�6z   5      
 5      P� 5        � {�$ false��67   . �5!      �� $ border��68    �@J�Opacity$
 0.56Q�6L   5"      P� 5#       �@J�IsMouseOver$
 true��69   . �5$      �� $ border��6<   8   � ��6P   5%      P� 5&       �@J�IsKeyboardFocused$
 true��6?   . �5'      �� $ border��6<   8   � ��6P   5(      5*      5,       5-   
   ]� 5.       5/      �� 50      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6O   �� 51       �@��IsSelectionActive$ false��6=   ./�53      ��  �@��SelectionBrush# � /�63   54      56      �� 57      " ��6   .�58   
   ��  �@�Cursor$
 Hand��6#   59      �� 5:      $ 	#FFBEE6FD��6:   �� 5;      $ 	#FF3C7FB1��66   �� 5<      $ 	#FFC4E5F6��68   �� 5=      $ 	#FF2C628B��64   �� 5>      $ 	#FFF4F4F4��69   �� 5?      $ 	#FFADB2B5��65   �� 5@      $ 	#FF838383��69   �� 5A      " ��6.   .R�5B   
   �� $ border��6   #��z��6!   #��z��6K   $ 5��6w   #��z��6�   $
 true��6�   ._�5C      �� $ contentPresenter��6   $|�False��69   #��z��6K   #��z��6�   $
��True��6�   # z 6�   #��z��6  5D      
 5E   
   P� 5F       �@��IsDefaulted$
 true��64   . �5G      �� $ border��60   # � ��6D    � ��5H      P� 5I       �@J�IsMouseOver$
 true��6-   . �5J      �� $ border��6/   8    � ��6C   �� 5K      $ border��60   8   � ��6D   5L      P� 5M       � ��$
 true��6+   . �5N      �� $ border��6/   8   � ��6C   �� 5O      $ border��60   8   � ��6D   5P      P� 5Q       � {�$ false��6+   . �5R      �� $ border��6/   8   � ��6C   �� 5S      $ border��60   8   � ��6D   �� 5T      $ contentPresenter��6;   8   � ��6Y   5U      5W      5X       � DataContext 5Y      *   $RentalCar.ViewModel.ProfileViewModel  5Z   
   .��5\      �  � ColumnDefinitions 5]   
   �� 5^      �� 5_      .+�5b   
   �� -   5         ��Name$
 Logo��5b      $��0��6   $Y��SC:\Users\ilyas\Documents\UNIVER\CourseWork\RentalCar\RentalCar\Images\LogoLight.png��6.   $
��Left=�6�   $��	0,10,0,10q�6�   $	��194��6�   �� 5c   
   $��0��6   $��Главная��6I   $	��100��6[   $��40��6g   $��25(�6s   $��	130 0 0 0q�6�   
������ 
������ ��6!   �� *OpenMainPageCommand+6�   �� 5d   
   #���  6   $��70��6e   $��1��6p   $��	0 0 20 10q�6�   
������ ���#222$��1q�6�   $��Right=�6�   ��6>   �� *OpenProfileCommand+.��5e      �� $��60��6   $��50��6    ��5f      �� 5g       �� 	UriSource$V PC:\Users\ilyas\Documents\UNIVER\CourseWork\RentalCar\RentalCar\Images\avatar.png?�6"   5i      5j      5k      5l      