   M S B A M L   `   `   `  ����D  @Travail01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Travail01.View.MyUserControlsTravail01.View.MyUserControls  5   	   /clr-namespace:Travail01.ViewTravail01.View  5   	   ,    &Travail01.View.EnregistreNvStagiaire02   5   	   >MyUserControls+clr-namespace:Travail01.View.MyUserControls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Travail01.View     5   	     � Title$  EnregistreNvStagiaire02��5   	   $	��450��6)   $	��800��66    � Icon$, &/Travail01;component/Images/douai1.ico��6B    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$% NavigationCommands.PreviousPage��5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��87* �6   �� 5       � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5#   
   -   'Travail01.View.MyUserControls.hautPage1  $��0��6#   $��0��60   $��2��6@   � 5&   
   -   5         �Name$ 	grContent��5&      $��1��6"   $��0��6/   ���	#FFF5E2E2$��2��6V    5'      �� 5(      $��* �6     5*      �� 5+      $	��450 �6#   �� 5,      $��* �6#   .+�50      � $��0��6   $��0��6    .+�51      1   +Travail01.View.MyUserControls.InfoStagiaire  $��
0,10,0,-10q�6/   52      � 55      $��0��6   $��1��6     56      �� 57      $��40 �6$   �� 58      $��* �6$    5:      �� 5;      $��* �6'   .+�5>      �� $��0��6   $��0��6%   $��	Formation��65   $
��Bold"�6I   $��14(�6[   $��Center=�6i   $��Center=�6�   �� 5?      $��1��6   $��0��6(   $��Center=�68   $��
51,26,51,0q�6U   $	��Top=�6i   $	��240��6�   $	��147��6�   .@�5@      �� $
��toto��6#   5A      5B      5C      � 5Q   
   $��2��6   $��0��6   ���	#FFFB7777 5R      �� 5S      $��* �6     5U      �� 5V      $��* �6#   �� 5W      $	��400 �6#   .+�5[      �� .��5\      � $��0��6   $��0��6$   .+�5]      �  5^      �� 5_      $��* �6,    5a      �� 5b      $	��150 �6/   �� 5c      $��* �6/   .+�5e      �� $��0��6"   $��0��6/   $��25��6?   $	��150��6K   $��État de la connexion :��6X   $��14(�6v   $
��Bold"�6�   $��Center=�6�   $
��Left=�6�   �� 5f      $��0��6"   $��1��6/   $��25��6?   $	��150��6K   $��14(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   ��6X   ��  �� Path$ InfoConnexion� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   5g      5h      5i      � 5l      $��0��6   $��1��6     5m      �� 5n      $	��100 �6'   �� 5o      $	��100 �6'   �� 5p      $	��100 �6'   �� 5q      $
��100* �6'   .+�5u      �� -   5        
 ��Name$
 btGoBack��5u      $��Go Back��6+   $��0��6=   $��3��6J   $��50��6Z   $	��100��6f   $
��Bold"�6r   $��16(�6�   $��Center=�6�   $��Center=�6�   $%��NavigationCommands.PreviousPage��6�   �� 5v      -   5        $
 btSupprimer��5v      $��	Supprimer��6.   $��0��6B   $��2��6O   $��50��6_   $	��100��6k   $
��Bold"�6w   $��16(�6�   $��Center=�6�   $��Center=�6�   ���	#FFADCDAA��6�   �� *btSuprimerClick+6�   �� 5w      -   5        $
 btModif��5w      $��Modifier��6,   $��0��6?   $��1��6L   $��50��6\   $	��100��6h   $
��Bold"�6t   $��16(�6�   $��Center=�6�   $��Center=�6�   ���	#FFADCDAA��6�   �� *btModifierClick+6�   �� 5x      -   5        $
 	btAjouter��5x      $��Ajouter��6,   $��0��6?   $��0��6L   $��50��6\   $	��100��6h   $
��Bold"�6t   $��16(�6�   $��Center=�6�   $��Center=�6�   ���	#FFADCDAA��6�   �� *btNouveauClick+6�   5y      5z      5�      5�      