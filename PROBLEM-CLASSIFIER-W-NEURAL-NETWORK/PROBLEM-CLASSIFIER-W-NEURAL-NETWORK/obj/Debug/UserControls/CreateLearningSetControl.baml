   M S B A M L   `   `   `  ����^  ZPROBLEM-CLASSIFIER-W-NEURAL-NETWORK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls0PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls  5      O    IPROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls.CreateLearningSetControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls     5      .��5	      �    DarkBackgroundBrush#���   6     � RowDefinitions  5
   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��3* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��1* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��Create Learning Set��6   $��0��6.   $��0��6;   $��3��6K   $��Center=�6_   $��Center=�6z     LightForegroundBrush#���  6�   $
��Bold"�6�   $��22(�6�   �� 5   
   $��From folder:��6   $��Right=�6'   $��Center=�6C   $��1��6^   #���  6k   �� 5   
   -   5         ��Name$ tb_from��5      $��1��6#   $��1��60   $��30��6@   $��	10,5,10,5q�6O    �� 
IsReadOnly . 6b   �� 5   
   -   5         ��Name$ btn_fromBrowse��5      $	��...��6)   $��40��67   $��30��6B   $��1��6N   $��3��6[   $��Center=�6k   $
��Left=�6�   6�   �� 5   
   $��
To folder:��6   $��Right=�6%   $��Center=�6A   $��2��6\   #���  6i   �� 5   
   -   5        $ tb_to��5      $��2��6!   $��1��6.   $��30��6>   $��	10,5,10,5q�6M    . 6`   �� 5   
   -   5        $ btn_toBrowse��5      $	��...��6'   $��40��65   $��30��6@   $��2��6L   $��3��6Y   $��Center=�6i   $
��Left=�6�   6�   �� 5!   
   $��Label:��6   $��Right=�6!   $��Center=�6=   $��3��6X   #���  6e   �� 5"   
   -   5         ��Name$ cb_label��5"      $��3��6%   $��1��62   $��30��6B   $��	10,5,10,5q�6Q   �� 5$   
   -   5        $ 
btn_create��5$      $��Create��6%   $��4��66   $��3��6C   $	��100��6W   $��50��6c   6o   5%      5'      