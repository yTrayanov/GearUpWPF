   M S B A M L   `   `   `  ����E  AClientSide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:ClientSide.Views.ProductsClientSide.Views.Products  5      (    "ClientSide.Views.Products.CartView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:ClientSide.Views.Products     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5        $��
lbProducts��5       �� SelectionMode$ Extended=�6%   $
��Auto=�6>   $
��Auto=�6p   ��5      �� 5      .R�5      ]� $	��100��6    .+�5      �� $
��Left=�69   $	��100��6O   ��6    �� *Image+6O   �� 5      .+�5      �� ��6(   �� *Name+�� 5      ��6(   �� *Price+5      5      5      5      � 5   
   $��1��6   $��Center=�6!   .+�5      �� -   5        $��btnOrder��5      $��5q�6%   .��6G   Order6N   �� 5      -   5        $��	btnRemove��5      $��5q�6&   .��6I   Remove6Q   5      �� 5    
   -   5        $��
OrderPopup��5       $��3q�6#   
���   �$��Center=�6K   $��Center=�6f   $y�Hidden=�6�   ._�5!      �� $��10q�6   $��Center=�6%   $��Center=�6@   $	��300��6]   .+�5"      �� $
��Bold"�6   $��26(�6.   $��10q�6<    �� TextAlignment$ Center=�6H   Order Product6n   �� 5#      .+�5$      �� $��Adress��6   �� 5%      -   5        $��	tbAddress��5%      �� 5&      $��Addictional Info��6   �� 5'      -   5        $��tbAddictionalInfo��5'       �� AcceptsReturn$
 True��67   $	��100��6L   $
��Auto=�6Z   5(      �� 5)      -   5        $��btnPurchase��5)      $	��150��6,   $��15q�68   .��6^   
Purchase6h   �� 5*      -   5        $��	btnCancel��5*      $	��150��6*   $
��15,0q�66   .��6\   Cancel6d   5+      5,      5.      5/      