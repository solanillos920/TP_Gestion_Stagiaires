   M S B A M L   `   `   `  ����D  @Travail01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Travail01.View.MyUserControlsTravail01.View.MyUserControls  5   	   /clr-namespace:Travail01.ViewTravail01.View  5   	   ,    &Travail01.View.EnregistreNvStagiaire01   5   	   >MyUserControls+clr-namespace:Travail01.View.MyUserControls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Travail01.View     5   	     � Title$  EnregistreNvStagiaire��5   	   $	��450��6'   $	��800��64    � Icon$, &/Travail01;component/Images/douai1.ico��6@    J� CommandBindings 5
      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$% NavigationCommands.PreviousPage��5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   -   'Travail01.View.MyUserControls.hautPage1  $��0��6$   $��0��61   � 5"   
   -   5         �Name$ 	grContent��5"      $��1��6"   $��0��6/   ���	#FFF5E2E2 5#      �� 5$      $��* �6     � ColumnDefinitions 5&      �� 5'      $	��450 �6#   �� 5(      $��* �6#   .+�5.      � $��0��6   $��0��6     5/      �� 50      $��35 �6$   �� 51      $��35 �6$   �� 52      $��35 �6$   �� 53      $��35 �6$   �� 54      $��35 �6$   �� 55      $��35 �6$   �� 56      $��35 �6$    58      �� 59      $	��150 �6'   �� 5:      $	��295 �6'   .+�5=      �� $��0��6   $��0��6%   $��Nom :��65   $��30��6E   $	��138��6Q   $
��Bold"�6_   $��14(�6q   $
��Left=�6   $��Center=�6�   �� 5>      -   5         ��Name$ txtNomStagiaire��5>      $��0��63   $��1��6@   $��Dupond��6P   $��30��6_   $	��280��6k    � ToolTip$ Mettre TOTO��6x   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��14(�6�   �� 5@      $��1��6   $��0��6%   $��	Prénom :��65   $��30��6H   $	��138��6T   $
��Bold"�6`   $��14(�6s   $
��Left=�6�   $��Center=�6�   �� 5A      -   5        $ txtPrenomStagiaire��5A      $��1��66   $��1��6C   $
��Polo��6S   $��30��6a   $	��280��6m   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��14(�6�   �� 5C      $��2��6   $��0��6%   $��Date de naissance :��65   $��30��6S   $	��138��6_   $
��Bold"�6l   $��14(�6~   $
��Left=�6�   $	��Top=�6�   $��0,6,0,0q�6�   �� 5D      -   5        $ txtDtNaissanceStagiaire��5D      $��2��6;   $��1��6H   $��
12-45-1920��6X   $��30��6l   $	��280��6x   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��14(�6�   �� 5F      $��3��6   $��0��6%   $��N° sécurité Social :��65   $��30��6T   $	��138��6`   $
��Bold"�6o   $��14(�6�   $
��Left=�6�   $��Center=�6�   �� 5G      -   5        $ txtSecuStagiaire��5G      $��3��64   $��1��6A   $��30��6Q   $	��280��6]   $��1 45 89 56 123 456��6i   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��14(�6�   �� 5J      $��4��6   $��0��6%   $��	Adresse :��65   $��30��6J   $	��138��6V   $
��Bold"�6d   $��14(�6v   $
��Left=�6�   $��Center=�6�   �� 5K      -   5        $ txtAdresseStagiaire��5K      $��4��67   $��1��6D   $��30��6T   $	��280��6`   $��6 rue des cloches��6m   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��14(�6�   �� 5M      $��5��6   $��0��6%   $��Code Postal :��65   $��30��6M   $	��138��6Y   $
��Bold"�6g   $��14(�6y   $
��Left=�6�   $	��Top=�6�   $��0,6,0,0q�6�   �� 5N      -   5        $ txtCPStagiaire��5N      $��5��62   $��1��6?   $��59500��6O   $��30��6\   $	��280��6h   $��Center=�6u   $��Center=�6�   $
��Bold"�6�   $��14(�6�   �� 5P      $��6��6   $��0��6%   $��Ville :��65   $��30��6G   $	��138��6S   $
��Bold"�6`   $��14(�6r   $
��Left=�6�   $��Center=�6�   �� 5Q      -	   5        $ txtVilleStagiaire��5Q      $��6��65   $��1��6B   $��Douai��6R   $��30��6_   $	��280��6k   $��Center=�6x   $��Center=�6�   $
��Bold"�6�   $��14(�6�   5T      � 5[      $��0��6   $��1��6     5\      �� 5]      $��40 �6$   �� 5^      $��* �6$    5`      �� 5a      $��* �6'   .+�5d      �� $��0��6   $��0��6%   $��	Formation��65   $
��Bold"�6I   $��14(�6[   $��Center=�6i   $��Center=�6�   �� 5e      -
   5        	 ��Name$	 comboBoxFormation��5e      $��1��66   $��0��6C   $��Center=�6S   $��
51,26,51,0q�6p   $	��Top=�6�   $	��240��6�   $	��147��6�   5f      5h      � 5�   
   $��2��6   $��0��6   ���	#FFFB7777 5�      �� 5�      $��* �6     5�      �� 5�      $��* �6#   �� 5�      $	��400 �6#   .+�5�      �� .��5�      � $��0��6   $��0��6$   .+�5�      �  5�      �� 5�      $��* �6,    5�      �� 5�      $	��150 �6/   �� 5�      $��* �6/   .+�5�      �� $��0��6"   $��0��6/   $��25��6?   $	��150��6K   $��État de la connexion :��6X   $��14(�6v   $
��Bold"�6�   $��Center=�6�   $
��Left=�6�   �� 5�      $��0��6"   $��1��6/   $��25��6?   $	��150��6K   $��14(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   ��6X   �� 
 �� Path$
 InfoConnexion� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5�      5�      5�      � 5�      $��0��6   $��1��6     5�      �� 5�      $	��100 �6'   �� 5�      $	��100 �6'   �� 5�      $	��100 �6'   �� 5�      $
��100* �6'   .+�5�      �� -   5         ��Name$ btGoBack��5�      $��Go Back��6+   $��0��6>   $��3��6K   $��50��6[   $	��100��6g   $
��Bold"�6s   $��16(�6�   $��Center=�6�   $��Center=�6�   $%��NavigationCommands.PreviousPage��6�    ^� ShowDuration$
 2500��5�       ^� HorizontalOffset$ 50��5�       ^� VerticalOffset$ 10��5�       5�      �� 5�      .+�5�      �� $,��&/Travail01;component/Images/danger.png��6$   �� 5�      $��14(�6(   
���  ��$
��Bold"�6G   5�      5�      �� 5�      -   5        $ btSupprimer��5�      $��	Supprimer��6.   $��0��6B   $��2��6O   $��50��6_   $	��100��6k   $
��Bold"�6w   $��16(�6�   $��Center=�6�   $��Center=�6�   �� 5�      -   5        $ btModif��5�      $��Modifier��6,   $��0��6?   $��1��6L   $��50��6\   $	��100��6h   $
��Bold"�6t   $��16(�6�   $��Center=�6�   $��Center=�6�   �� 5�      -   5        $ 	btAjouter��5�      $��Ajouter��6,   $��0��6?   $��0��6L   $��50��6\   $	��100��6h   $
��Bold"�6t   $��16(�6�   $��Center=�6�   $��Center=�6�   6�   5�      5�      5�      5�      