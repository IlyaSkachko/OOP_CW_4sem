   M S B A M L   `   `   `  ����D  @RentalCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:RentalCar	RentalCar  5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U<clr-namespace:System.Windows.Media;assembly=PresentationCoreSystem.Windows.Media 5          RentalCar.App   5      \ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      )localclr-namespace:RentalCar     5      Nfonts<clr-namespace:System.Windows.Media;assembly=PresentationCore     5        �� 	Resources  5         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBox.Static.Border1  TextBox.MouseOver.Border1  TextBox.Focus.Border1  PasswordBox �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value  FocusVisual �� StrokeDashArray  Button.Static.Background 	 Button.Static.Border 
 Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground  AllBtns ��Name  	DataField��%�  &	        &	 #     &	 F     &	 i     &	 �     &	 �     &	 �     7  7  7  &	 J    &	 �    &		      &	
 C    &	 f    &	 �    &	 �    &	 �    &	 �    &	     &	 8    7  7  7 	 7 
 7  7  7  7  7  7  &	 H    7   7  7  �� 5	   
   $ 	#FFABAdB3��68   �� 5
   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   $ 	#FFABAdB3��69   �� 5   
   $ 	#FF7EB4EA��6<   �� 5   
   $ 	#FF569DE5��68   �� 5   
   " G�6$   .�5      ��  �@G�PasswordChar$	 ●��6-   �� 5       � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop$
 true��6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled$ False��67   �� 5       � �� 5      �� 5      " G�6&   .R�5      �� $ border��6!   $ 5��61   #��z��6B   #��z��6l   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5       
 5!      P� 5"       � {�$ false��6;   . �5#   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5$      P� 5%       �@J�IsMouseOver$
 true��6=   . �5&   "   �� $ border��6@   8   � ��6T   5'      P� 5(       �@J�IsKeyboardFocused$
 true��6C   . �5)   "   �� $ border��6@   8   � ��6T   5*      5,      5.       5/      ]� 50       51      �� 52      + �@G�#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 53       �@G�IsSelectionActive$ false��6A   ./�55      ��  �@G�SelectionBrush# � /�67   56      58      �� 59   
   .�5:      ��  � �� 5;      �� 5<      .R�5=      �� $��2q�6$   $	 1 2R�6/   #��� ��6E   $
 true��6�   $��1��6�   5>      5@      5A      �� 5B   
   $ 	#FFDDDDDD��6;   �� 5C   
   $ 	#FF707070��67   �� 5D   
   $ 	#FFBEE6FD��6>   �� 5E   
   $ 	#FF3C7FB1��6:   �� 5F   
   $ 	#FFC4E5F6��6<   �� 5G   
   $ 	#FF2C628B��68   �� 5H   
   $ 	#FFF4F4F4��6=   �� 5I   
   $ 	#FFADB2B5��69   �� 5J   
   $ 	#FF838383��6=   �� 5K   
   " ��6    .�5L      ��  �@�FocusVisualStyle8   61   �� 5M       � ��8  6+   �� 5N       � ��8  6,   �� 5O       � ��# � ��6+   �� 5P       � ��$ 1q�60   �� 5Q       � ��$ Center=�6;   �� 5R       � ��$ Center=�69   �� 5S       � ��$ 1q�6(   �� 5T       � �� 5U      �� 5V      " ��6&   .R�5W      �� $ border��6!   $ 10��61   #��z��6C   #��z��6m   #��z��6�   $
 true��6�   ._�5X      �� $ contentPresenter��6/   $|�False��6I   #��z��6[   #��z��6�   $
��True��6�   # z 6�   #��z��6  5Y      
 5Z      P� 5[       �@��IsDefaulted$
 true��6=   . �5\   "   �� $ border��6@   # � ��6T    � ��5]      P� 5^       �@J�IsMouseOver$
 true��6=   . �5_   "   �� $ border��6?   8   � ��6S   �� 5`   "   $ border��6@   8   � ��6T   5a      P� 5b       � ��$
 true��6;   . �5c   "   �� $ border��6?   8   � ��6S   �� 5d   "   $ border��6@   8   � ��6T   5e      P� 5f       � {�$ false��6;   . �5g   "   �� $ border��6?   8   � ��6S   �� 5h   "   $ border��6@   8   � ��6T   �� 5i   "   $ contentPresenter��6K   8 	  � ��6i   5j      5l      5n      5o      �� 5p   
   " ��6"   .�5q      ��  � ��# � ��6+   �� 5r       � ��8   6,   �� 5s       � ��# � ��6+   �� 5t       � ��$ 1q�60   �� 5u       �@ TabNavigation$
 None=�6A   �� 5v       � ��$
 Left=�6;   �� 5w       �@�FocusVisualStyle 61   Z� �� 5x       �@J�	AllowDrop$
 true��6*   �� 5y       �@��PanningMode$ VerticalFirst=�69   �� 5z       �@��IsFlicksEnabled$ False��67   �� 5{       � �� 5|      �� 5}      " ��6&   .R�5~      �� $ border��6!   #��z��61   $ 5��6[   #��z��6l   #��z��6�   $
 True��6�   ._�5      �� $	 PART_ContentHost��6+   $|�false��6E   $��Hidden=�6W   $��Hidden=�6~   5�      
 5�      P� 5�       � {�$ false��6;   . �5�   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5�      P� 5�       �@J�IsMouseOver$
 true��6=   . �5�   "   �� $ border��6@   8   � ��6T   5�      P� 5�       �@J�IsKeyboardFocused$
 true��6C   . �5�   "   �� $ border��6@   8   � ��6T   5�      5�      5�       5�      ]� 5�       5�      �� 5�      + �@��#IsInactiveSelectionHighlightEnabled$
 true��6S   �� 5�       �@��IsSelectionActive$ false��6A   ./�5�      ��  �@��SelectionBrush# � /�67   5�      5�      5�      5�      