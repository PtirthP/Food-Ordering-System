   M S B A M L   `   `   `  ����R  NLab_Wawa_App-TirthPatel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Lab_Wawa_App_TirthPatelLab_Wawa_App_TirthPatel  5   	   '    !Lab_Wawa_App_TirthPatel.Beverages   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Lab_Wawa_App_TirthPatel     5   	     � Title$  	Beverages��5   	    � 
ResizeMode$ NoResize=�6   $	��450��61   $	��800��6>    � WindowStartupLocation$ Manual=�6K   
 � Top$	 300��6j    � Left$	 600��6t   ���	#FFE2E2CD.��5	      � .+�5
   
   �� -   5         ��Name$ 
lblHeading��5
      $��	Beverages��6$   $
��Left=�68   $��
182,21,0,0q�6S   $	��Top=�6g   $	��300��6   $��Center=�6�   $��Center=�6�   $��22(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ btnHotDrink��5      $
��Left=�6&   $��
72,128,0,0q�6A   $	��Top=�6U   $	��143��6m   $	��252��6z   
������ .��5      �� .+�5      �� $��hotdrinks.png��6   $	��119��6/   $	��245��6<   $
��Fill=�6H   �� 5      $��
Hot Drinks��6   $��Center=�6.   5      5      �� 5   
   -   5        $ btnColdDrink��5      $
��Left=�6'   $��338,127,0,0q�6B   $	��Top=�6W   $	��144��6o   $	��252��6|   
������ .��5      �� .+�5      �� $��Colddrinks.png��6   $	��119��60   $	��226��6=   $
��Fill=�6I   �� 5      $��Cold Drinks��6   $��Center=�6/   5      5      �� 5   
   -   5        $ btnPrevious��5      $
��Left=�6&   $��
60,343,0,0q�6A   $	��Top=�6U   $��72��6m   .��5      �� .+�5      �� -   5         ��Name$ btnPrevious1��5      $��	back.png ��6.   $��54��6A   $��66��6M   $
��Fill=�6X   5      5       �� 5'   
   $
��Left=�6   $��40��6+   $	��Top=�67   $	��100��6O   $
��Fill=�6[   $��wawa.png��6j   $��	10,10,0,0q�6|   �� 5)   
   -   5        $ imgOrder��5)      $��scriptroll.png��6"   $
��Fill=�6:   $��556,-61,-24,-31q�6I    J� RenderTransformOrigin$ 0.5,0.5&�6b   z�5*      V� 5+      .~�5,      �� �� 5-      	 �� AngleX$	 -0.096Q�6$   �� 5.      T� 5/      
 T� X$
 -0.443Q�6)   50      52      �� 54   
   -   5         ��Name$ txtOrder��54      " �� VerticalScrollBarVisibility$ Visible=�6%   $
��Left=�6K   $��
595,73,0,0q�6f    �� TextWrapping$
 Wrap=�6z   $�� ��6�   $	��Top=�6�   $	��195��6�   $	��325��6�    �� 
IsReadOnly . .��6�   ��55      �� 56      .��57   "   58      �� 5:   
   -   5        $ lblOrder��5:      $��
Your Order��6"   $
��Left=�67   $��
664,45,0,0q�6R   $	��Top=�6f   $
��Bold"�6~   5<      5=      