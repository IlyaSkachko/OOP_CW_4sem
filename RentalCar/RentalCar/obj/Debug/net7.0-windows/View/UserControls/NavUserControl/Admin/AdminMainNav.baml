   M S B A M L   `   `   `  ����D  @RentalCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:RentalCar.View.UserControls.NavUserControl.Admin0RentalCar.View.UserControls.NavUserControl.Admin  5      9!clr-namespace:RentalCar.ViewModelRentalCar.ViewModel  5      C    =RentalCar.View.UserControls.NavUserControl.Admin.AdminMainNav   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:RentalCar.View.UserControls.NavUserControl.Admin     5      7	viewModel!clr-namespace:RentalCar.ViewModel     5        � 	Resources  5
         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  SearchField �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  ButtonTemplate1 ��Name��%6  &	        &	 #     &	 F     &	 i     7   7  7  '�� �    &	     &	 $    &	 G    &	 j    &	 �    &		 �    &	
 �    &	 �    7  7  7  7  7  7 	 7 
 �� 5   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " ��6$   .�5      ��  � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop$
 true��6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $ border��6!   $ 10��61   #��z��6C   #��z��6m   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5      
 5      P� 5        � {�$ false��6;   . �5!   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5"      P� 5#       �@J�IsMouseOver$
 true��6=   . �5$   "   �� $ border��6@   8   � ��6T   5%      P� 5&       �@J�IsKeyboardFocused$
 true��6C   . �5'   "   �� $ border��6@   8   � ��6T   5(      5*      5,       5-      ]� 5.       5/      �� 50      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 51       �@��IsSelectionActive$ false��6A   ./�53      ��  �@��SelectionBrush# � /�67   54      56      �� 57   
   " ��6   .�58      ��  �@�Cursor$
 Hand��6'   59      �� 5:   
   $ 	#FFBEE6FD��6>   �� 5;   
   $ 	#FF3C7FB1��6:   �� 5<   
   $ 	#FFC4E5F6��6<   �� 5=   
   $ 	#FF2C628B��68   �� 5>   
   $ 	#FFF4F4F4��6=   �� 5?   
   $ 	#FFADB2B5��69   �� 5@   
   $ 	#FF838383��6=   �� 5A   
   " ��62   .R�5B      �� $ border��6   #��z��6%   #��z��6O   $ 5��6{   #��z��6�   $
 true��6�   ._�5C      �� $ contentPresenter��6#   $|�False��6=   #��z��6O   #��z��6�   $
��True��6�   # z 6�   #��z��6  5D      
 5E      P� 5F       �@��IsDefaulted$
 true��68   . �5G      �� $ border��64   # � ��6H    � ��5H      P� 5I       �@J�IsMouseOver$
 true��61   . �5J      �� $ border��63   8    � ��6G   �� 5K      $ border��64   8   � ��6H   5L      P� 5M       � ��$
 true��6/   . �5N      �� $ border��63   8   � ��6G   �� 5O      $ border��64   8   � ��6H   5P      P� 5Q       � {�$ false��6/   . �5R      �� $ border��63   8   � ��6G   �� 5S      $ border��64   8   � ��6H   �� 5T      $ contentPresenter��6?   8   � ��6]   5U      5W      5X      .��5Y      �  � ColumnDefinitions 5Z   
   �� 5[      �� 5\      .+�5^   
   �� -   5         ��Name$
 Logo��5^      $��0��6   $Y��SC:\Users\ilyas\Documents\UNIVER\CourseWork\RentalCar\RentalCar\Images\LogoLight.png��6.   $
��Left=�6�   $��	0,10,0,10q�6�   $	��194��6�   �� 5`   
   $��0��61   $��Добавить��6A   $��	120 0 0 0q�6U   $	��120��6h   $��35��6t   $��25(�6�   
������ 
������ ��6   �� *OpenAddPage+6�   �� 5a   
   $��0��6   $��Заявки��6!   $��	400 0 0 0q�6X   $	��100��6k   $��35��6w   $��25(�6�   
������ 
������ ��62   �� *OpenOrderCommand+6�   � 5b   
   $��1��6   $��Center=�6$   $��Right=�6?   $��0 0 30 0q�6[   .+�5c      �� -   5         ��Name$ SearchField��5c   &  #���  6   $��Center=�6Y   $��18(�6{   $��10 0 0 0q�6�   $��1��6�   $��35��6�   $	��250��6�   ���#09D397$��2q�6�   $��Bottom=�6�   $
��Left=�6  ��6<   �� *SearchField+6>  �� 5d      $��
Поиск��6   #���  6&   ���#09D397���#09D397
�������$��70��6�   $��30��6�   $��16(�6�   $��10 0 0 0q�6�   ��6S   �� *SearchModelCommand+6�   5e      5f      5g      