   M S B A M L   `   `   `  ����K  GUshakovAviaSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UshakovAviaSales.MyWindowsUshakovAviaSales.MyWindows  5   	   &     UshakovAviaSales.MyWindows.temp1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UshakovAviaSales.MyWindows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6@     � Title$  temp1��5   	   $	��450��6   $	��800��6$   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $��2* �6   �� 5      $	��200 �6    � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ notifsicationsIcon��5      $��3��5   "   $��0��63   $��Center=�6C      Kind$ Flight=�5   1   
����  �$��40��5      $��40��6    $��0 0 0 0q�5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��0,0,0,0q�6.   $��1��6?   $��0��6O   .+�5      �� $ 
Horizontal=�6   $��0 0 0 5q�62   .+�5      �� $��	Econom - ��6   $��DemiBold"�6-   �� 5      $��12(�69   $��0 0 0 0q�6G   $��DemiBold"�6X   ��6   �� *EconomPrice+6X   �� 5       $��DemiBold"�6   $65   5!      �� 5#      $ 
Horizontal=�6   $��10 0 0 5q�62   .+�5$      �� $��Buisinesess - ��6   $��DemiBold"�62   �� 5%      $��12(�6<   $��0 0 0 0q�6J   $��DemiBold"�6[   ��6   �� *BuisinessPrice+6[   �� 5&      -   5         ��Name$ txtDateCalculator��5&      $��DemiBold"�69   $6S   5'      5(      �� 5*   
   $��1��6   $��1��6!   $��0 0 10 0q�5,      ��5+      �� *DateOfFlight+5,      �� 5.   
   $ 
Horizontal=�6   $��1��6.   $��2��6;   .+�5/      �� $��0 0 0 0q�6<   ��6   �� *Company.Designator+6<   �� 50      $��0 0 0 0q�65   ��6   �� *PlaneNumber+65   51      �� 52   
   $ 
Horizontal=�6   $��1��6.   $��3��6;   .+�53      �� $��10 0 0 0q�6   ��54      �� *FlightTimeDurationInMinutes+�� 55      $��1 0 0 0q�6   $��Minutes��6)   57      �� 58   
   $��4��6   $��6��6$   $��3��68   $��1 0 0 0q�59   (   $��13(�5:   (   $
��Bold"�5;   (   ���#242339$��Center=�5=   (   $��Center=�5>   (   $��This Flight Is Canceled��5@   (   y�5?   )   �� *
isCanceled+    BooleanToVisibilityConverter �� 	Converter# [  5@   (   5F      5G      