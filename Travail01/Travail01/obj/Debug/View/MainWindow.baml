   M S B A M L   `   `   `  ����D  @Travail01, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:Travail01.View.MyUserControlsTravail01.View.MyUserControls  5   	   %clr-namespace:Travail01	Travail01  5   	       Travail01.View.MainWindow   5   	   >MyUserControls+clr-namespace:Travail01.View.MyUserControls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Travail01     5   	   $	��450��5   .   $	��800��6;     � Icon$,  &/Travail01;component/Images/douai1.ico��5	   	    � Title 5   	   �� *TiltleOfMainWindow+.��5      �  � RowDefinitions 5   
   �� 5      $��80 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   -   'Travail01.View.MyUserControls.hautPage1  $��0��6#   $��0��60   � 5   
   $��1��6   $��0��6    5      �� 5      $
��auto �6    �� 5       $��* �6     � ColumnDefinitions 5"      �� 5#      $��* �6#   .+�5'      o� $��0��6   $��0��6    .@�5*      m� $��
Stagiaires��6   $��50��6/   $	��190��6;   $��16(�6G   $
��Bold"�6U   .@�5+      m� -   5         m�Name$ goNvStagiaire��5+      $��Nouveau��66   $��50��6H   $	��190��6T   $��16(�6`   $
��Bold"�6n    m� Command$! NavigationCommands.GoToPage��6�   m� 5,      -   5        $ goModifSupprimStagiaire��5,      $��Modifie/Supprime��6@   $��50��6[   $	��230��6g   $��16(�6s   $
��Bold"�6�   $! NavigationCommands.GoToPage��6�   5.      m� 50      $��Entreprises��6   $��50��60   $	��190��6<   $��16(�6H   $
��Bold"�6V   .@�51      m� -   5        $ goNvEntreprise��51      $��Nouvelle��67   $��50��6J   $	��190��6V   $��16(�6b   $
��Bold"�6p   $! NavigationCommands.GoToPage��6�   m� 52      -   5        $ goModifSupprimEntreprise��52      $��Modifie/Supprime��6A   $��50��6\   $	��230��6h   $��16(�6t   $
��Bold"�6�   $! NavigationCommands.GoToPage��6�   54      m� 56      -   5        $ goGestionStage��56      $��Stages / Entreprises��63   $��50��6Q   $	��190��6]   $��16(�6i   $
��Bold"�6w   $! NavigationCommands.GoToPage��6�   5:      m� 5<      $��Paramètres��6   $��50��6/   $	��190��6;   $��16(�6G   $
��Bold"�6U   .@�5=      m� $��Qualification��6   $��50��67   $	��190��6C   $��16(�6O   $
��Bold"�6]   .@�5>      m� -   5        $ 
goNvQualif��5>   #   $��Nouvelle Qualification��67   $��50��6Z   $	��260��6f   $��16(�6r   $
��Bold"�6�   $! NavigationCommands.GoToPage��6�   m� 5?      -   5        $ goModifSupprimQualif��5?   #   $��Modifie/Supprime��6A   $��50��6^   $	��230��6j   $��16(�6v   $
��Bold"�6�   $! NavigationCommands.GoToPage��6�   5@      m� 5B      $
��Pole��6   $��50��6.   $	��190��6:   $��16(�6F   $
��Bold"�6T   .@�5C      m� -   5        $ goNvPole��5C   #   $��Nouveau Pole��66   $��50��6M   $	��190��6Y   $��16(�6e   $
��Bold"�6s   $! NavigationCommands.GoToPage��6�   m� 5D      -	   5        $ goModifSupprimPole��5D   #   $��Modifie/Supprime��6@   $��50��6[   $	��230��6g   $��16(�6s   $
��Bold"�6�   $! NavigationCommands.GoToPage��6�   5E      m� 5F      $��	Formation��6   $��50��63   $	��190��6?   $��16(�6K   $
��Bold"�6Y   .@�5G      m� -
   5        $ goNvFormation��5G   #   $��Nouvelle Formation��6:   $��50��6W   $	��240��6c   $��16(�6o   $
��Bold"�6}   $! NavigationCommands.GoToPage��6�   m� 5H      -   5        $ goModifSupprimFormation��5H   #   $��Modifie/Supprime��6D   $��50��6_   $	��230��6k   $��16(�6w   $
��Bold"�6�   $! NavigationCommands.GoToPage��6�   5I      m� 5J      -   5        $ goCalendrierStage��5J      $��Calendrier Stage��6:   $��50��6U   $	��210��6a   $��16(�6m   $
��Bold"�6{   $! NavigationCommands.GoToPage��6�   5K      5L      � 5O      -   5         �Name$ 	grContent��5O      $��1��6&   $��0��63   ���	#FFF5E2E2.+�5P      �� .��5R      �� $2��,/Travail01;component/Images/Edmond_labbe.jpg��6    5S      5T      5U      � 5^   
   $��2��6   $��0��6   ���	#FFFB7777 5_      �� 5`      $��* �6     5b      �� 5c      $��* �6#   �� 5d      $	��400 �6#   .+�5h      �� .��5i      � $��0��6   $��0��6$   .+�5j      �  5k      �� 5l      $��* �6,    5n      �� 5o      $	��150 �6/   �� 5p      $��* �6/   .+�5r      �� $��0��6"   $��0��6/   $��25��6?   $	��150��6K   $��Etat de la connexion :��6X   $��14(�6v   $
��Bold"�6�   $��Center=�6�   $
��Left=�6�   �� 5s      $��0��6"   $��1��6/   $��25��6?   $	��150��6K   $��14(�6�   $
��Bold"�6�   $��Center=�6�   $��Center=�6�   ��6X   ��  �� Path$ InfoConnexion� �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�6�   5t      5u      5v      � 5y      $��0��6   $��1��6     5z      �� 5{      $	��100 �6'   �� 5|      $	��100 �6'   �� 5}      $	��100 �6'   �� 5~      $
��100* �6'   .+�5�      �� -   5        
 ��Name$
 btQuit��5�      $��Quitter��6)   $��0��6<   $��3��6I   $��50��6Y   $	��100��6e   $
��Bold"�6q   $��20(�6�   $��Center=�6�   $��Center=�6�    ^� ShowDuration$
 2500��5�       ^� HorizontalOffset$ 50��5�       ^� VerticalOffset$ 10��5�      ���	#FFEA7575��5�   �   �� *btQuitterClick+ � ToolTip 5�      �� 5�      .+�5�      �� $,��&/Travail01;component/Images/danger.png��6$   �� 5�      $��14(�6(   
���  ��$
��Bold"�6G   ATTENTION Vous etes sur ?6t   5�      5�      �� 5�      -   5        $
 btSupprimer��5�      $��Suprimer��6.   $��0��6A   $��2��6N   $��50��6^   $	��100��6j   $
��Bold"�6v   $��16(�6�   $��Center=�6�   $��Center=�6�   ���	#FFADCDAA��6�   �� *btSuprimerClick+6�   �� 5�      -   5        $
 btModif��5�      $��Modifier��6,   $��0��6?   $��1��6L   $��50��6\   $	��100��6h   $
��Bold"�6t   $��16(�6�   $��Center=�6�   $��Center=�6�   ���	#FFADCDAA��6�   �� *btModifierClick+6�   �� 5�      -   5        $
 	btNouveau��5�      $��Nouveau��6,   $��0��6?   $��0��6L   $��50��6\   $	��100��6h   $
��Bold"�6t   $��16(�6�   $��Center=�6�   $��Center=�6�   ���	#FFADCDAA��6�   �� *btNouveauClick+6�   5�      5�      5�       J� CommandBindings 5�      )  #System.Windows.Input.CommandBinding  5�   
   -   5           Command$! NavigationCommands.GoToPage��5�      5�      5�      