   M S B A M L   `   `   `  ����K  GUshakovAviaSales, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:UshakovAviaSales.MyWindowsUshakovAviaSales.MyWindows  5   	   C&clr-namespace:UshakovAviaSales.ClassesUshakovAviaSales.Classes  6@   .    (UshakovAviaSales.MyWindows.ClientsWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:UshakovAviaSales.MyWindows     5   	   9local1&clr-namespace:UshakovAviaSales.Classes     6@   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6v     � Title$  View All Clients��5   	   $	��800��6"   $
��1080��6/   $
��1080��6?   ���#D2D9EB � 	Resources 5
      -   'UshakovAviaSales.Classes.WidthConverter   myConverter��%   &	          5   
   6    5      .��5      � -   5         �Name$ clientsGrid��5       � ColumnDefinitions 5   
   �� 5      .+�5   
   � $��0��6   $��10q�6   
������  � RowDefinitions 5      �� 5      �� 5      $��8* �6    .+�5      � $��0��6   ���#242339.+�5      ��  �� Orientation$ 
Horizontal=�6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$ sortIcon��5         Kind$ EmojiManProfile=�6'   $��40��5      $��80��6    $
��Left=�5      $��Center=�5       $��20 0 0 0q�5!      
�������5"      �� 5#      -   5         ��Name$ 
txtClients��5'      $��Center=�5$      $��28(�5%      $��All Clients��5&      $��10 0 0 0q�5(      	 �� TextAlignment$	 Center=�5)      
�������5+      �� 5,      $��50 0 0 0q�6!   $ 
Horizontal=�63   .+�5-        -   5        $ 	sortIc1on��5.      $ Search=�6(   $��30��5/      $��40��6    $
��Left=�50      $��Center=�51      $��20 0 0 0q�52      
�������53      �� 54      -   5        
 ��Name$
 txtLogs��58      $��Center=�55      $��22(�56      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search by Email��57      $��10 0 0 0q�59      $	��250��5:       �� TextAlignment$ Center=�5;      
�������5>      �� 5?      -   5         ��Name$ 	ticketCmb��5?   #   $ Ticket Number��5A       � ToolTip$9 3Select a purchased ticket number, to get the client��5B   #   $	��150��5C      $��45��5D       " MaterialDesignOutlinedComboBox#��[ 5E   #   
�������$��10(�5G   #   $��50 0 0 0q�5H      5I      5J      �� 5L      -   5         ��Name$ 	goBackBtn��5M       ! MaterialDesignFlatMidBgButton#��[ 5O      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth0=�5P      
����������#242339$��45��5R      $	��140��6!   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��6-   $��Right=�5S      $��0 0 50 0q�5T      $��Center=�5U      $��18(�5V      $��Go back��6'    � Cursor$
 Hand��5W      5X      �� 5Z      -   5         ��Name$ LvAllClients��5Z   $   $��1��6   $��Disabled=�5[        MaterialDesignListView#��[ 5]      ��5a      �� 5b      .R�5c      �� 
����������#D2D9EB$��0q�5e   !   ��5c   !   ��  �� ElementName$ LvAllClients�� �� Path$ ActualWidth� �� 	Converter# [  ._�5g      � $��80��6#   $
��1080��6/    5h   "   �� 5i   &   $
��2.5* �67   �� 5j   &   $	��10* �67   �� 5k   &   $	��100 �67   .+�5m   "   �� $ 
Horizontal=�6-   $��0��6F   .+�5n   &     $ notificationsIcon��5q      $��10 0 0 0q�5o   %   $��2��5p   %   $ Account=�5q   0   $��40��5r      $��40��6    $��Center=�5s      $��Center=�5t      �� 5u   &   $��5 0 0 0q�60   $��Center=�6A   $��Center=�6]   $��22(�6z   $
��Bold"�5w      $	��№��5x      ���#2423395y      �� 5z   &   $��5 0 0 0q�60   $��Center=�6A   $��Center=�6]   $��28(�6z   $
��Bold"�5|      ���#242339��5}      �� *
idClient+ �� StringFormat$
 {0}:��5~      5�   #   � 5�   "   $��1��6'   $��0 0 0 0q�67    5�   &   �� 5�   *   �� 5�   *    5�   &   �� 5�   *   �� 5�   *   �� 5�   *   �� 5�   *   .+�5�   &   �� $ Vertical=�61   $��0��6H   $��2��6X   $��Center=�6i   .+�5�   *   �� $��1��64   $	��Top=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      $��
First name��5�      ���#2423395�      �� 5�   *   $��0��64   $��Center=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      ��5�      �� *	FirstName+5�   '   �� 5�   &   $ Vertical=�61   $��1��6H   $��2��6X   $��Center=�6i   .+�5�   *   �� $��1��64   $	��Top=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      $��Surname��5�      ���#2423395�      �� 5�   *   $��0��64   $��Center=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      ��5�      �� *
LastName+5�   '   �� 5�   &   $ Vertical=�61   $��2��6H   $��2��6X   $��Center=�6i   .+�5�   *   �� $��1��64   $	��Top=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      $��Email��5�      ���#2423395�      �� 5�   *   $��0��64   $��Center=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      ��5�      �� *Email+5�   '   �� 5�   &   $ Vertical=�61   $��3��6H   $��2��6X   $��Center=�6i   .+�5�   *   �� $��1��64   $	��Top=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      $��Login (If Exists)��5�      ���#2423395�      �� 5�   *   $��0��64   $��Center=�6D   $
��Left=�5�      $��14(�67   $��0 10 0 0q�5�      $��Medium"�5�      ��5�      �� *
User.Login+5�   '   5�   #     5�   "   $ notificationsdIcon��5�      $y�Hidden=�5�   ;   $��0 0 0 0q�5�   %   $��2��5�   %   $ CheckCircle=�5�   1   $��40��5�      $��40��6    $��Center=�5�      $��Center=�5�      5�      5�      5�      5�      5�      5�      5�      