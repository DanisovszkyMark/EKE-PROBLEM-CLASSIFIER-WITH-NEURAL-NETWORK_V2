   M S B A M L   `   `   `  ����^  ZPROBLEM-CLASSIFIER-W-NEURAL-NETWORK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls0PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls  5      E    ?PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls.TestingControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:PROBLEM_CLASSIFIER_W_NEURAL_NETWORK.UserControls     5      .��5	      �    DarkBackgroundBrush#���   6     � RowDefinitions  5
   
   �� 5      $��2* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��4* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��1* �6   �� 5      $
��0.5* �6   .+�5   
   �� $��Testing��6   $��0��6"   $��0��6/   $��3��6?   $��Center=�6S   $��Center=�6n     LightForegroundBrush#���  6�   $
��Bold"�6�   $��22(�6�   �� 5   
   $��Testing sets:��6   $��Right=�6(   $��Center=�6D   $��1��6_   #���  6l   �� 5   
   -   5         ��Name$ tb_testingSets��5      $��1��6*   $��1��67   $��30��6G   $��	10,5,10,5q�6V    �� 
IsReadOnly . 6i   �� 5   
   -   5         ��Name$ btn_testingSetsBrowse��5      $	��...��60   $��40��6>   $��30��6I   $��1��6U   $��3��6b   $��Center=�6r   $
��Left=�6�   6�   �� 5   
   $��NeuralNetwork��6   $��Right=�6(   $��Center=�6D   $��2��6_   #���  6l   �� 5   
   -   5        $ tb_neuralNetwork��5      $��2��6,   $��1��69   $��30��6I   $��	10,5,10,5q�6X    . 6k   �� 5    
   -   5        $ btn_neuralNetworkBrowse��5       $	��...��62   $��40��6@   $��30��6K   $��2��6W   $��3��6d   $��Center=�6t   $
��Left=�6�   6�   �� 5"   
   -   5        $ 	btn_start��5"      $��Start��6$   $��3��64   $��3��6A   $	��100��6U   $��50��6a   6m   �� 5$   
   -   5         ��Name$ rtb_log��5$      $��4��6'   $��3��64   $��30,10q�6H    . 6W   5%      5'      