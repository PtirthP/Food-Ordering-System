   M S B A M L   `   `   `  ����R  NLab_Wawa_App-TirthPatel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lab_Wawa_App_TirthPatelLab_Wawa_App_TirthPatel  5   	   #    Lab_Wawa_App_TirthPatel.Soups   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lab_Wawa_App_TirthPatel     5   	     � Title$  Soups��5   	    � 
ResizeMode$ NoResize=�6   $	��450��6-   $	��800��6:    � WindowStartupLocation$ Manual=�6F   
 � Top$	 300��6e    � Left$	 600��6o   ���	#FFE2E2CD.��5	      � .+�5
   
   �� -   5         ��Name$ 
lblHeading��5
      $��Soups & Sides��6$   $
��Left=�6@   $��
174,21,0,0q�6[   $	��Top=�6o   $	��300��6�   $��Center=�6�   $��Center=�6�   $��22(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ btnCheckout��5      $��Checkout��6&   $
��Left=�69   $��459,380,0,0q�6T   $	��Top=�6i   $��32��6�   $��94��6�   6�   �� 5   
   -   5        $ btnChickenCornChowder��5      $
��Left=�60   $��
158,73,0,0q�6K   $	��Top=�6_   $	��143��6w   $	��167��6�   
������ .��5      �� .+�5      �� $��ChickenCornChowder.png��6   $	��119��68   $	��149��6E   $
��Fill=�6Q   �� 5      $"��Chicken Corn Chowder - $4.99��6   $��Center=�6@   5      5      �� 5   
   -   5        $ btnFrenchFries��5      $
��Left=�6)   $��357,220,0,0q�6D   $	��Top=�6Y   $	��143��6q   $	��168��6~   
������ .��5      �� .+�5      �� $��FrenchFries.png��6   $	��119��61   $	��149��6>   $
��Fill=�6J   �� 5      $��French Fries - $2.99��6   $��Center=�68   5      5      �� 5!   
   -   5        $ btnMacandCheese��5!      $
��Left=�6*   $��157,221,0,0q�6E   $	��Top=�6Z   $	��143��6r   $	��167��6   
������ .��5"      �� .+�5#      �� $��MacandCheese.png��6   $	��119��62   $	��149��6?   $
��Fill=�6K   �� 5$      $��Mac and Cheese - $3.99��6   $��Center=�6:   5%      5&      �� 5(   
   -   5        $ btnPrevious��5(      $
��Left=�6&   $��
60,343,0,0q�6A   $	��Top=�6U   $��72��6m   .��5)      �� .+�5*      �� -   5         ��Name$ btnPrevious1��5*      $��	back.png ��6.   $��54��6A   $��66��6M   $
��Fill=�6X   5+      5,      �� 5/   
   -   5        $ btnChickenTortilla��5/      $
��Left=�6-   $��
357,74,0,0q�6H   $	��Top=�6\   $	��143��6t   $	��168��6�   
������ .��50      �� .+�51      �� $��ChickenTortilla.png��6   $	��119��65   $	��149��6B   $
��Fill=�6N   �� 52      $��Chicken Tortilla - $4.99��6   $��Center=�6<   53      54      �� 59   
   $
��Left=�6   $��40��6+   $	��Top=�67   $	��100��6O   $
��Fill=�6[   $��wawa.png��6j   $��	10,10,0,0q�6|   �� 5;   
   -	   5        $ imgOrder��5;      $��scriptroll.png��6"   $
��Fill=�6:   $��559,-61,-24,-31q�6I    J� RenderTransformOrigin$ 0.5,0.5&�6b   z�5<      V� 5=      .~�5>      �� �� 5?      	 �� AngleX$	 -0.096Q�6$   �� 5@      T� 5A      
 T� X$
 -0.443Q�6)   5B      5D      �� 5F   
   -
   5         ��Name$ txtOrder��5F      " �� VerticalScrollBarVisibility$ Visible=�6%   $
��Left=�6K   $��
601,73,0,0q�6f    �� TextWrapping$
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��189��6�   $	��325��6�    �� 
IsReadOnly . .��6�   ��5G      �� 5H      .��5I   "   5J      �� 5K   
   -   5        $ lblOrder��5K      $��
Your Order��6"   $
��Left=�67   $��
664,45,0,0q�6R   $	��Top=�6f   $
��Bold"�6~   5M      5N      