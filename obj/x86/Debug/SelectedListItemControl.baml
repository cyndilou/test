   M S B A M L   `   `   `  ����M  ICustomComboBoxTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CustomComboBoxTestCustomComboBoxTest  5   K   U/clr-namespace:GoogleCalendarReminder.Converters!GoogleCalendarReminder.Converters  6�   0    *CustomComboBoxTest.SelectedListItemControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?CustomComboBoxTest clr-namespace:CustomComboBoxTest     6K   F
Converters/clr-namespace:GoogleCalendarReminder.Converters     6�   $
��Auto��5      $
��Auto��6     � 	Resources  5      7   1GoogleCalendarReminder.Converters.SnoozeConverter   SnoozeConverter��%   &	          5   
   6%   5	      .��5
      �� 
����  �$��1q�6     �� CornerRadius$ 3��64   ._�5   
   �  � RowDefinitions 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      $
��Auto �6#   ��5      �� 5       �� 
StartPoint$
 0, 0&�6&    �� EndPoint$	 0,1&�68    �� Opacity$ .5Q�6G   .��5      �  � Color$ Transparent��6#    � Offset$ 0Q�67   � 5      $
 Blue��6#   $ 1Q�60   5      .+�5      �� 	 �� Orientation$	 Vertical=�6   $��0��60   $��0��6@   $��2q�6M   .+�5      ]� ��.  $	��0,1q�62   .+�5      �� $��Meeting Subject Here��6    $
��Bold"�5       $��14(�6*   $
��Left=�5!      $	��5,0q�5"      �� 5#      $��	3 minutes��6    $��Center=�61   $	��5,0q�6L   $��Right=�6Y   �� 5$      $��Due in:��6    $��Center=�6/   $	��2,0q�6J   $��Right=�6W   5%      ]� 5'      ��.  $	��0,1q�62   .+�5(      �� $��Start time:��6    $	��2,0q�63   $
��Left=�6@   �� 5)      $��10/7/2011 9:30 AM��6    $	��5,0q�69   $
��Left=�6F   �� 5*      $��1 hour��6    $	��5,0q�6.   $��Right=�6;   �� 5+      $��	Duration:��6    $	��2,0q�61   $��Right=�6>   5,      �� 5.      $	 
Horizontal=�6   $	��0,1q�66   .+�5/      �� $��	Location:��6    $	��2,0q�61   �� 50      $
��Here��6    $	��5,0q�6,   51      53      ]� 55      ��.  $��2q�6.   $��1��69   $��0��6I   .+�56      �� $��Dismiss��6   $��2q�6+   $	��100��66   $��Bottom=�6B   �� 57      $��	Open Item��6   $��2q�6-   $	��100��68   $��Bottom=�6D   58      &    CustomComboBoxTest.SnoozeControl  5:      $��2q�6/   $��0��6:   $��1��6J   �� 5;      $��Snooze��6   $��2q�6&   $	��100��61   $��Center=�6=   $��1��6X   $��1��6h   5<      5=      5>      