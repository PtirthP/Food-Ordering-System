   M S B A M L   `   `   `  ����R  NLab_Wawa_App-TirthPatel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lab_Wawa_App_TirthPatelLab_Wawa_App_TirthPatel  5   	   &     Lab_Wawa_App_TirthPatel.Checkout   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lab_Wawa_App_TirthPatel     5   	     � Title$  Checkout��5   	    � 
ResizeMode$ NoResize=�6   $	��450��60   $	��800��6=    � WindowStartupLocation$ Manual=�6J   
 � Top$	 300��6i    � Left$	 600��6s   ���	#FFE2E2CD.��5	      � .+�5   
   �� $
��Left=�6   $��40��6+   $	��Top=�67   $	��100��6O   $
��Fill=�6[   $��wawa.png��6j   $��	10,10,0,0q�6|   �� 5   
   -   5         ��Name$ lblOrder��5      $��
Your Order��6"   $
��Left=�67   $��
234,46,0,0q�6R   $	��Top=�6f   $
��Bold"�6~   �� 5   
   -   5         ��Name$ btnComplete��5      $��Complete & Print Order��6&   $��89��6K   $��400,72,150,0q�6W   $	��Top=�6m   $��19(�6�   $
��Bold"�6�   ���	#FFACF7AC6�   �� 5   
   -   5        $ 	btnCancel��5      $��Cancel Order��6$   $��87��6;   $��400,188,150,0q�6G   $	��Top=�6^   $
��Bold"�6v   $��20(�6�   
�������6�   �� 5   
   -   5        $ 
btnAddItem��5      $��Add another item��6%   $��400,304,150,0q�6@   $	��Top=�6W   $��87��6o   ���	#FFEDDB9B$��20(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtOrder��5      " �� VerticalScrollBarVisibility$ Visible=�6%   	 �� TextWrapping$
	 Wrap=�6K   $��153,72,413,20q�6_   
 �� 
IsReadOnly
 . 6v   5      5      