   M S B A M L   `   `   `  ����K  GUshakovAviaSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UshakovAviaSalesUshakovAviaSales  5   	   !    UshakovAviaSales.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UshakovAviaSales     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  	AviaSales��5	   	   $	��800��6   $
��1080��6(   $
��1000��65   $
��1080��6F   $
��1080��5
   	   $
��1080��6    � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � AllowsTransparency . ��5   	   Z� .��5      � ���#D2D9EB � RowDefinitions 5   
   �� 5      $	��125 �6   �� 5      $��5* �6   .+�5   
   �� -   5         ��Name$ dragBar��5      $��0��5       �� CornerRadius$ 0, 0, 25, 25��6   ���#2423396M   �� 5   
   $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� $ Vertical=�6   $��100 10 0 20q�60   .+�5      �� -   5         ��Name$ 	flightBtn��5   *   $��0 0 0 0q�6    !  MaterialDesignFlatMidBgButton#��[  5      $��60��5      $��90��6%   $��Center=�5      $��Center=�5      
������ 
������ +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 10��5    1   .��5$      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        
  Name$
 
flightIcon��5%      $
��Left=�5$   *      Kind$ Flight=�5%   )   $��45��5&      $��60��6    
�������5'      5(      �� 5*      $��Center=�5+      $��22(�5,      $��Flights��5-       �� TextAlignment$ Center=�5.      
�������5/      51      �� 52      $ Vertical=�6   $��160 10 0 20q�60   .+�53      �� -   5        $ 	searchBtn��53   *   $��0 0 0 0q�6   #��[  54      $��60��55      $��90��6%   $��Center=�56      $��Center=�57      
������ 
������ $	 10��59   1   .��5=        -   5        $
 
searchIcon��5>      $
��Left=�5=   .   $ Magnify=�5>   )   $��45��5?      $��60��6    
�������5@      5A      �� 5C      $��Center=�5D      $��22(�5E      $��Hotels��5F      $ Center=�5G   )   
�������5I      5K      �� 5L      $ Vertical=�6   $��160 10 0 20q�60   .+�5M      �� -   5        $ notificationsBtn��5M   *   $��0 0 0 0q�6   #��[  5N      $��60��5O      $��90��6%   $��Center=�5P      $��Center=�5Q      $	 10��5R   1   
������ 
������ .��5W        -   5        $
 notificationsIcon��5X      $
��Left=�5W   .   $ Notifications=�5X   0   $��40��5Y      $��60��6    
�������5Z      5[      �� 5\      $��Center=�5]      $��22(�5^      $��Notifications��5_      $ Center=�5`   )   
�������5b      5d      �� 5e      $ Vertical=�6   $��160 10 0 20q�60   .+�5f      �� -   5        $ 
accountBtn��5f   *   $��0 0 0 0q�6   #��[  5g      $	 10��5h   1   $��60��5j      $��90��6%   $��Center=�5k      $��Center=�5l      
������ 
������ .��5p        -	   5        $
 profileIcon��5q      $
��Left=�5p   .   $ Account=�5q   *   $��45��5r      $��60��6    
�������5s      5t      �� 5u      $��Center=�5v      $��22(�5w      $��Profile��5x      $ Center=�5y   )   
�������5{      5}      5~      � 5   
   $��1��6   .+�5�      �� .��5�       � -
   5          �Name$ 	MainFrame��5�      $��1��5�        � NavigationUIVisibility$ Hidden=�5�      ��. 5�      5�      5�      5�      5�      