   M S B A M L   `   `   `  ����R  NLab_Wawa_App-TirthPatel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lab_Wawa_App_TirthPatelLab_Wawa_App_TirthPatel  5   	   2    ,Lab_Wawa_App_TirthPatel.HoagiesAndSandwiches   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lab_Wawa_App_TirthPatel     5   	     � Title$  HoagiesAndSandwiches��5   	   $	��450��6&   $	��800��63    � WindowStartupLocation$ Manual=�6@   
 � Top$	 300��6_    � Left$	 600��6i   ���	#FFE2E2CD � 
ResizeMode$ NoResize=�6�   .��5
      � .+�5   
   �� -   5         ��Name$ btnPrevious��5      $
��Left=�6&   $��
60,343,0,0q�6A   $	��Top=�6U   $��72��6m   .��5      �� .+�5      �� -   5         ��Name$ btnPrevious1��5      $��	back.png ��6.   $��54��6A   $��66��6M   $
��Fill=�6X   5      5      �� 5   
   -   5        $ btnPepperoni��5      $
��Left=�6'   $��
51,139,0,0q�6B   $	��Top=�6V   $	��143��6n   $	��167��6{   
������ .��5      �� .+�5      �� $��pepperoni.png��6   $	��119��6/   $	��149��6<   $
��Fill=�6H   �� 5      $��Pepperoni - $5.99��6   $��Center=�65   5      5      �� 5   
   -   5        $ 	btnTurkey��5      $
��Left=�6$   $��233,138,0,0q�6?   $	��Top=�6T   $	��143��6l   $	��168��6y   
������ .��5      �� .+�5      �� $��
turkey.png��6   $	��119��6,   $	��149��69   $
��Fill=�6E   �� 5      $��Turkey - $5.99��6   $��Center=�62   5       5!      �� 5#   
   -   5        $ 	btnVeggie��5#      $
��Left=�6$   $��419,140,0,0q�6?   $	��Top=�6T   $	��143��6l   $	��168��6y   
������ .��5$      �� .+�5%      �� $��
veggie.png��6   $	��115��6,   $	��149��69   $
��Fill=�6E   �� 5&      $��Veggie - $4.99��6   $��Center=�62   5'      5(      �� 51   
   -   5         ��Name$ 
lblHeading��51      $��Hoagies and Sandwiches��6$   $
��Left=�6E   $��
167,21,0,0q�6`   $	��Top=�6t   $	��300��6�   $��Center=�6�   $��Center=�6�   $��22(�6�   $
��Bold"�6�   �� 52   
   $
��Left=�6   $��40��6+   $	��Top=�67   $	��100��6O   $
��Fill=�6[   $��wawa.png��6j   $��	10,10,0,0q�6|   �� 54   
   -   5        $ imgOrder��54      $��scriptroll.png��6"   $
��Fill=�6:   $��559,-61,-24,-31q�6I    J� RenderTransformOrigin$ 0.5,0.5&�6b   z�55      V� 56      .~�57      �� �� 58      	 �� AngleX$	 -0.096Q�6$   �� 59      T� 5:      
 T� X$
 -0.443Q�6)   5;      5=      �� 5?   
   -   5         ��Name$ txtOrder��5?      " �� VerticalScrollBarVisibility$ Visible=�6%   $
��Left=�6K   $��
604,76,0,0q�6f    �� TextWrapping$
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��186��6�   $	��325��6�    �� 
IsReadOnly . .��6�   ��5@      �� 5A      .��5B   "   5C      �� 5E   
   -	   5        $ btnCheckout��5E      $��Checkout��6&   $
��Left=�69   $��449,362,0,0q�6T   $	��Top=�6i   $��32��6�   $��94��6�   6�   �� 5H   
   -
   5        $ lblOrder��5H      $��
Your Order��6"   $
��Left=�67   $��
664,45,0,0q�6R   $	��Top=�6f   $
��Bold"�6~   5I      5J      