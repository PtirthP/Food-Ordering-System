   M S B A M L   `   `   `  ����R  NLab_Wawa_App-TirthPatel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lab_Wawa_App_TirthPatelLab_Wawa_App_TirthPatel  5   	   '    !Lab_Wawa_App_TirthPatel.ColdDrink   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lab_Wawa_App_TirthPatel     5   	     � Title$  	ColdDrink��5   	    � 
ResizeMode$ NoResize=�6   $	��450��61   $	��800��6>    � WindowStartupLocation$ Manual=�6K   
 � Top$	 300��6j    � Left$	 600��6t   ���	#FFE2E2CD.��5	      � .+�5   
   �� $
��Left=�6   $��40��6+   $	��Top=�67   $	��100��6O   $
��Fill=�6[   $��wawa.png��6j   $��	10,15,0,0q�6|   �� 5   
   -   5         ��Name$ 
lblHeading��5      $��Cold Drinks��6$   $
��Left=�6:   $��
244,26,0,0q�6U   $	��Top=�6i   $	��180��6�   $��Center=�6�   $��Center=�6�   $��22(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ imgOrder��5      $��scriptroll.png��6"   $
��Fill=�6:   $��552,-61,-24,-31q�6I    J� RenderTransformOrigin$ 0.5,0.5&�6b   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.096Q�6$   �� 5      T� 5      	 T� X$	 -0.443Q�6)   5      5      �� 5   
   -   5        $ lblOrder��5      $��
Your Order��6"   $
��Left=�67   $��
662,42,0,0q�6R   $	��Top=�6f   $
��Bold"�6~   �� 5   
   -   5        
 ��Name$
 txtOrder��5      " �� VerticalScrollBarVisibility$ Visible=�6%   $
��Left=�6K   $��
596,73,0,0q�6f    �� TextWrapping$
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��192��6�   $	��325��6�    �� 
IsReadOnly . .��6�   ��5      �� 5      .��5   "   5       �� 5"   
   -   5         ��Name$ btnPrevious��5"      $
��Left=�6&   $��
60,343,0,0q�6A   $	��Top=�6U   $��72��6m   .��5#      �� .+�5$      �� -   5        $ btnPrevious1��5$      $��	back.png ��6.   $��54��6A   $��66��6M   $
��Fill=�6X   5%      5&      �� 5+   
   -   5        $ btnCheckout��5+      $��Checkout��6&   $
��Left=�69   $��459,380,0,0q�6T   $	��Top=�6i   $��32��6�   $��94��6�   6�   �� 5-   
   -   5        $ btnCaramelEspresso��5-      $
��Left=�6-   $��
34,137,0,0q�6H   $	��Top=�6\   $	��158��6t   $	��167��6�   
������ .��5.      �� .+�5/      �� $��CaramelEspresso.png��6   $	��119��65   $	��149��6B   $
��Fill=�6N   �� 50      $��Caramel Espresso��6   $��Center=�64   �� 51      $��$4.99��6   $��Center=�6)   52      53      �� 56   
   -	   5        $ btnCreamFrozenCappuccino��56      $
��Left=�63   $��216,137,0,0q�6N   $	��Top=�6c   $	��158��6{   $	��182��6�   
������ .��57      �� .+�58      �� $��CreamFrozenCappuccino.png��6   $	��119��6;   $	��149��6H   $
��Fill=�6T   �� 59      $��Cream Frozen Cappuccino��6   $��Center=�6;   �� 5:      $��$4.99��6   $��Center=�6)   5;      5<      �� 5>   
   -
   5        $" btnCreamStrawberryCappuccino��5>      $
��Left=�67   $��403,142,0,0q�6R   $	��Top=�6g   $	��156��6   $	��174��6�   
������ .��5?      �� .+�5@      �� $#��CreamStrawberryCappuccino.png��6   $	��119��6?   $	��149��6L   $
��Fill=�6X   �� 5A      $!��Cream Strawberry Cappuccino��6   $��Center=�6?   �� 5B      $��$4.99��6   $��Center=�6)   5C      5D      5F      5G      