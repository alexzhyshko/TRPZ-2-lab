   M S B A M L   `   `   `  ����B  >TaxiWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:TaxiWPFTaxiWPF  5   	       TaxiWPF.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:TaxiWPF     5   	     � Title$  RegisterWindow��5   	   $	��450��6    $	��800��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��1��6   $��1��6$   $��Register��61   $��0 0 0 20q�6A   $��Center=�6S   $��38(�6p   $��Segoe UI Light)�6~   $��4��6�   �� 5   
   $��2��6   $��2��6$   $��0 0 0 20q�61   $��2��6C   $��
Username: ��6W   $��Center=�6i   $��28(�6�   $��Segoe UI Light)�6�   �� 5   
   -   5         ��Name$ usernameText��5      $��4��6(   $��2��68   $	��150��6E   $��0 0 0 20q�6Q   $��30��6c   $��Center=�6o   $��Center=�6�   �� 5   
   $��2��6   $��3��6$   $��0 0 0 20q�61   $��2��6C   $��
Password: ��6W   $��Center=�6i   $��28(�6�   $��Segoe UI Light)�6�   G� 5   
   -   5         G�Name$ passwordText��5      $��4��6,   $��3��6<   $	��150��6I   $��30��6U   $��Center=�6a   $��Center=�6�   �� 5   
   -   5         ��Name$ submitButton��5      $��4��6'   $��4��67   
������ $	��150��6^   $��30��6j   $��Center=�6w   $��Center=�6�   $��Sign up��6�   $��Segoe UI Light)�6�   $��20(�6�   6�   �� 5!   
   -   5        $ goToRegisterButton��5!      $��1��6-   $��5��6=   
������ $	��150��6d   $��30��6p   $��Center=�6}   $��Center=�6�   $��Log in��6�   $��Segoe UI Light)�6�   $��14(�6�   6�   �� 5$   
   -   5         ��Name$ errMsg��5$      $��3��6$   $��5��64   $��2��6A   $��Center=�6U   $��16(�6r   $��Segoe UI Light)�6�   
���  ��$��20��6�   5%      5&      