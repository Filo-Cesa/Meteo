   M S B A M L   `   `   `  ����T  PCesarini.Filippo.4H.Meteo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:Cesarini.Filippo._4H.MeteoCesarini.Filippo._4H.Meteo  5   	   +    %Cesarini.Filippo._4H.Meteo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:Cesarini.Filippo._4H.Meteo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � 
������� � ColumnDefinitions 5
   
   �� 5      6!   �� 5      6!   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgdati��5   #   $��0��6      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ CITTA��6>      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6M   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Nome+6[     5      $ 	TEMP. MAX��6=   $	 100 6P    6%   �� *Max+6^     5      $ 
TEMP. MIN.��6=   $	 100 6Q    6%   �� *Min+6_     5      $ 
ESCURSIONE��6D   $	 100 6X    6%   �� *
Escursione+6f   5      �� 5   
    �� Orientation$ Vertical=�6   $��1��6,   $��Center=�6<   .+�5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader  $��20q�6#   $��40��6/   $	��200��6;   
����  �$��2q�6Z   .��5      �� -   5        	 ��Name$	 Citta��5      $��MAGGIORE ESCURSIONE��6+   
 �� TextAlignment$
 Center=�6F   5       �� 5"      -   5         ��Name$ cerca��5"   $   $��20(�6   $	��204��63   $��55��6?   
����  �$��2q�6^    �� TextAlignment$ Center=�6r   $
��0,25q�6�   �� 5#      -   5        $	��177��5#      $��50��6!   
���   �$��2q�6X   $��20q�6l   $��35(�6x   
����  �$��CERCA��6�     5%      $��40��6#   $	��356��6/   
����  �$��2q�6N   .��5'      �� -   5        $	 Ricerca��5'      5)      �� 5+      -   5        $	��320��5+   *   $��40��66   $��30q�6B   $��aggiungi una città��6N   
����� �$��20(�6}   5-      5.      5/      