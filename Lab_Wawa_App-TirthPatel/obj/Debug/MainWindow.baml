   M S B A M L   `   `   `  ����R  NLab_Wawa_App-TirthPatel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lab_Wawa_App_TirthPatelLab_Wawa_App_TirthPatel  5   	   (    "Lab_Wawa_App_TirthPatel.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lab_Wawa_App_TirthPatel     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStartupLocation$ Manual=�65   
 � Top$	 300��6T    � Left$	 600��6^   ���	#FFE2E2CD � 
ResizeMode$ NoResize=�6�   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� -   5         ��Name$ imgOrder��5      $��scriptroll.png��6"   $
��Fill=�6:   $��856,-35,-304,-57q�6I    J� RenderTransformOrigin$ 0.5,0.5&�6c   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -0.096Q�6$   �� 5      T� 5      	 T� X$	 -0.443Q�6)   5      5      �� 5   
   -   5        
 ��Name$
 txtOrder��5      $
��Left=�6$   $��
893,99,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $�� ��6g   $	��Top=�6o   $	��177��6�   $	��325��6�    �� 
IsReadOnly . .��6�   ��5      �� 5      .��5   "   5      �� 5!   
   -   5         ��Name$ 
btnHoagies��5!      $
��Left=�6%   $��
218,99,0,0q�6@   $	��Top=�6T   $	��140��6l   $	��187��6y   
������ .��5"      �� .+�5#      �� $��hoagies.png��6   $	��112��6-   $	��168��6:   $
��Fill=�6F   �� 5$      $��Hoagies and Sandwiches��6   $��Center=�6:   5%      5'      �� 5)   
   -   5        $ btnSoupsAndSides��5)      $
��Left=�6+   $��326,260,0,0q�6F   $	��Top=�6[   $	��140��6s   $	��187��6�   
������ $ 0.5,0.5&�6�   .��5*      �� .+�5+      �� $��Soupandsides.png��6   $	��115��62   $	��177��6?   $
��Fill=�6K   $��Right=�6Z   �� 5,      $��Soup and Sides��6   $��Center=�62   5-      5/      �� 51   
   -   5        $ btnBeverages��51      $
��Left=�6'   $��
439,98,0,0q�6B   $	��Top=�6V   $	��140��6n   $	��187��6{   
������ .��52      �� .+�53      �� $��beverages.png��6   $	��112��6/   $	��149��6<   $
��Fill=�6H   �� 54      $��	Beverages��6   $��Center=�6-   55      56      �� 57   
   -   5         ��Name$ 
lblHeading��57      $��Pick an Item��6$   $
��Left=�6;   $��
330,30,0,0q�6V   $	��Top=�6j   $	��180��6�   $��Center=�6�   $��Center=�6�   $��22(�6�   $
��Bold"�6�   �� 58   
   $
��Left=�6   $��40��6+   $	��Top=�67   $	��100��6O   $
��Fill=�6[   $��wawa.png��6j   $��	10,10,0,0q�6|   �� 5:   
   -   5        $ lblOrder��5:      $��
Your Order��6"   $
��Left=�67   $��
944,71,0,0q�6R   $	��Top=�6f   $
��Bold"�6~   $��95��6�   �� 5;   
   -   5        $ btnCheckout��5;      $��Checkout��6&   $
��Left=�69   $��563,371,0,0q�6T   $	��Top=�6i   $��32��6�   $��94��6�   6�   5>      5?      