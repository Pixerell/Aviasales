   M S B A M L   `   `   `  ����K  GUshakovAviaSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UshakovAviaSales.MyWindowsUshakovAviaSales.MyWindows  5   	   +    %UshakovAviaSales.MyWindows.CustomMbox   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UshakovAviaSales.MyWindows     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  MessageBoxWindow��5      $	��240��6&   $	��500��63   $	��240��6?   $	��500��6O   $	��300��6^   $	��600��6n    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�6.   
������� � 
ResizeMode$ 	CanResize=�5
   	    � Topmost .  � ShowInTaskbar .   � AllowsTransparency .    MaterialDesignBody#���   5   	   $��Regular"�5   	   $��10(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignFont#���  5   	   .��5      �� ���#242339$��3q�6#   ._�5      � 	 � ColumnDefinitions	 5   
   �� 5      $
��200* �6   �� 5      $
��300* �6   
 � RowDefinitions
 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   #  MaterialDesignThemes.Wpf.Card  -   5          Name$ 
cardHeader��5       $��0��6!   $��10q�5!      $��0q�6   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6%   ���#242339 ! PrimaryHueDarkForegroundBrush#���  5"   "   $y�Visible=�5#      $��2��6"   .��5%      � .+�5&      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ notifsicationsIcon��5'      $
��Left=�5&   *      Kind$ QuestionMark=�5'   1   $��25��5(      $��25��6    
�������5)      �� 5*      -   5         ��Name$ txtTitle��5*      $��0 0 0 0q�6.   $��Center=�6?   $��Stretch=�5+         MaterialDesignTitleTextBlock#���  5,      $��20(�5-      Message Title6:   5/      51      �� 52   
   $��Right=�6   $��0,0,10,0q�62   $��Center=�53      $��1��61   .+�54      �� -   5         ��Name$ btnClose��54      $��25��55      $��25��6    
�������  PrimaryHueDarkBrush#���  56       * &MaterialDesignFloatingActionDarkButton#��[ 57      .��58        $ Close=�6*   59      5:      � 5;   
   $��1��6   $��2��6   .+�5<      � $��20q�6   
 5=      �� 5>      $��4* �6$   �� 5?      $��2* �6$   .+�5B      � $��0��6   
 5C      �� 5D      $
��auto �6(   �� 5E      $��* �6(   .+�5I      �� -   5         ��Name$ 
txtMessage��5I   "    �� TextWrapping$
 Wrap=�66   $��Center=�6J    �� 
IsReadOnly . $��0��6y   $��5q�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$  ��6�   $��18(�6�    % !MaterialDesignFloatingHintTextBox#��[ 6�   5K      � 5L      $��50��6   $��1��6#   $��0 0 0 5q�60   	 5M      �� 5N      $��* �6+   �� 5O      $
��auto �6+   �� 5P      $
��auto �6+   �� 5Q      $��* �6+   .+�5T      �� -   5        $ btnOk��5T      $��1��6@     MaterialDesignRaisedButton#��[ 6P   ���#242339$��5 5 5 5q�6�   $	��100��6�   $��OK��6�    � ToolTip$ Ok��6�   �� 5U      -   5        $ 	btnCancel��5U      $��2��6H   #��[ 6X   ���#242339$��5 5 5 5q�6�   $	��100��6�   $��Cancel��6�   $ Cancel��6�   �� 5V      -   5        $ btnYes��5V      $��1��6B   #��[ 6R   ���#242339$��5 5 5 5q�6�   $	��100��6�   $	��Yes��6�   $	 Yes��6�   �� 5W      -	   5        $ btnNo��5W      $��2��6@   #��[ 6P   ���#242339$��5 5 5 5q�6�   $	��100��6�   $��No��6�   $ No��6�   5X      5Z      5[      5\      5]      5_      