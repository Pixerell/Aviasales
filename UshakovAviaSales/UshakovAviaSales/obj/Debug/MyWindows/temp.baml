   M S B A M L   `   `   `  ����K  GUshakovAviaSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UshakovAviaSales.MyWindowsUshakovAviaSales.MyWindows  5   	   %    UshakovAviaSales.MyWindows.temp   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UshakovAviaSales.MyWindows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6@     � Title$
  temp��5   	   $	��450��6   $
��1000��6#   .��5	      � $	��100��6   $
��1000��6    � RowDefinitions 5
   
   �� 5      �� 5      $
��1.5* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��1��6    �� Orientation$ 
Horizontal=�6%   $	��top=�6>   $��Right=�6V   .+�5      �� $��0 0 20 0q�6   $��40��5   (   $��40��63   ��5   (   �� *Company.Image+5   3   5      �� 5   
   $ 
Horizontal=�6   $��0,0,0,0q�6.   $��0��6?   $
��Left=�5      $��Center=�60   $��0��6K   .+�5      �� $ 
Horizontal=�6   $��0 0 0 5q�62   .+�5      �� $��	Econom - ��6   $��DemiBold"�6-   �� 5      $��12(�69   $��0 0 0 0q�6G   $��DemiBold"�6X   ��6   �� *EconomPrice+6X   �� 5      $��DemiBold"�6   $65   5      �� 5      $ 
Horizontal=�6   $��10 0 0 5q�62   .+�5       �� $��Buisinesess - ��6   $��DemiBold"�62   �� 5!      $��12(�6<   $��0 0 0 0q�6J   $��DemiBold"�6[   ��6   �� *BuisinessPrice+6[   �� 5"      -   5         ��Name$ txtDateCalculator��5"      $��DemiBold"�69   $6S   5#      5$      �� 5'   
   $ 
Horizontal=�6   $��	20 0 20 0q�6.   $��1��6A   $��0��6N   $��Center=�6^   .+�5(      �� $ Vertical=�6   .+�5)      �� $��1��6   $��1��6)   $��0 0 0 0q�5+      ��5*      �� *DateOfFlight+5+      �� 5,      $��0 0 0 0q�6G   ��6   �� *Destination.City.CityName+6G   5-      5.      �� 50   
   $ 
Horizontal=�6   $��	20 0 20 0q�6.   $��1��6A   $��1��6N   $��Right=�6^   $��Center=�6z   .+�51      �� $ Vertical=�6   .+�53      �� $ 
Horizontal=�6   $��1��66   $��2��6C   .+�54      �� $��0 0 0 0q�6D   ��6    �� *Company.Designator+6D   �� 55      $��0 0 0 0q�6=   ��6    �� *PlaneNumber+6=   56      �� 58      $��4��6   $��6��6,   $��3��6@   $��1 0 0 0q�59   (   $��11(�5:   (   $��DemiBold"�5;   (   ���#242339$��Center=�5=   (   $��Center=�5>   (   $��This Flight Is Canceled��5@   (   y�5?   )   �� *
isCanceled+    BooleanToVisibilityConverter �� 	Converter# [  5@   (   5B      5C      � 5E   
   $��1��6   $��2��6   $��160 0 160 30q�60   .+�5F      �� 
�������$��1��6$   $��0 20 0 0q�6/   '  !MaterialDesignThemes.Wpf.PackIcon  5H      -   5          Name$ flightTakeOffIcon��5I      $��3��5H   &   $��0��67      Kind$ FlightTakeoff=�5I   0   ���#242339 J� Opacity$	 0.6Q�6Z   $��20��5J      $��30��6    $��0 0 0 0q�5K      $
��Left=�5L   &     5M      -   5        $ flightLandIcon��5N      $��3��5M   &   $��0��67   $ 
FlightLand=�5N   -   ���#242339$	 0.6Q�6T   $��20��5O      $��30��6    $��0 0 30 0q�5P      $��Right=�5Q   &   �� 5R      $ 
Horizontal=�6   $��Center=�62   $��Center=�6M   .+�5S      �� $��10 0 0 0q�6   ��5T      �� *FlightTimeDurationInMinutes+�� 5U      $��1 0 0 0q�6   $��Minutes��6-   5V      5X      5[      5\      