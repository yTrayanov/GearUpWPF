   M S B A M L   `   `   `  ����E  AClientSide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ClientSide.Views.AuthClientSide.Views.Auth  5      E'clr-namespace:ClientSide.Views.ProductsClientSide.Views.Products  5      A%clr-namespace:ClientSide.Views.OrdersClientSide.Views.Orders  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   NavigationListBoxStyles  �� 
TargetType �� Triggers �� Binding �� Value �� Property  NavigationAnonymous �� Value ^� 
Conditions �� Binding �� Value  NavigationUser  NavigationAdmin  NavigationTriggers%    ClientSide.Views.Auth.LoginView	 �� ElementName
 �� Path(   "ClientSide.Views.Auth.RegisterView"   ClientSide.Views.Auth.Logout1   +ClientSide.Views.Products.CreateProductView/   )ClientSide.Views.Products.AllProductsView(   "ClientSide.Views.Products.CartView(   "ClientSide.Views.Orders.UserOrders�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      ,auth#clr-namespace:ClientSide.Views.Auth  5      4products'clr-namespace:ClientSide.Views.Products  5      0orders%clr-namespace:ClientSide.Views.Orders  5      %@  &	        7  7  7  &	 �    �� 5      "  ��6,    5	   
   �� 5
       6   �� *
IsLogged+	 False67   .a�5      ��  � ��8   60   5      ^� 5       5      �� 5       6    �� *
IsLogged+ True6=   �� 5       6    �� *	IsAdmin+	 False6<   .0�5      ��  � ��8  60   5      ^� 5       5      �� 5       6    �� *
IsLogged+ True6=   �� 5       6    �� *	IsAdmin+ True6<   .0�5      ��  � ��8  60   5      5      �� 5      "  ��6'    5   
   �� 5        6   �� *
IsLogged+	 False67   .a�5!      ��  � �� 5"      �� 5#      .R�5$         5%      5'      5(      �� 5)       6   �� $	 
Navigation��$
 SelectedItem�	 Login6X   .a�5*      ��  � �� 5+      �� 5,      .R�5-         5.      50      51      �� 53       6   �� $	 
Navigation��$
 SelectedItem� Register6X   .a�54      ��  � �� 55      �� 56      .R�57        58      5:      5;      �� 5=       6   �� $	 
Navigation��$
 SelectedItem�
 Logout6X   .a�5>      ��  �@ Logout$
 True��67   5?      �� 5A       6   �� $	 
Navigation��$
 SelectedItem� CreateProduct6X   .a�5B      ��  � �� 5C      �� 5D      .R�5E        5F      5H      5I      �� 5K       6   �� $	 
Navigation��$
 SelectedItem� Products6X   .a�5L      ��  � �� 5M      �� 5N      .R�5O        5P      5R      5S      �� 5U       6   �� $	 
Navigation��$
 SelectedItem� Shop6X   .a�5V      ��  � �� 5W      �� 5X      .R�5Y        5Z      5\      5]      �� 5_       6   �� $	 
Navigation��$
 SelectedItem� Cart6X   .a�5`      ��  � �� 5a      �� 5b      .R�5c        5d      5f      5g      �� 5i       6   �� $	 
Navigation��$
 SelectedItem�
 Orders6X   .a�5j      ��  � �� 5k      �� 5l      .R�5m        5n      5p      5q      5u      5v      