   M S B A M L   `   `   `  ����H  DNetwork Tools, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Network_ToolsNetwork_Tools  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	       Network_Tools.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Network_Tools     5   	   9system&clr-namespace:System;assembly=mscorlib     5   	   U QMaterialDesignThemes.Wpf, Version=2.2.1.750, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5           MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	    � WindowStyle$
 None=�6;   $��412.321��6N   $	��600��6^    � 
ResizeMode$ NoResize=�6k   .��5      � .+�5   
   (  "MaterialDesignThemes.Wpf.ColorZone     Mode$ 
PrimaryMid=�6#   $��16q�65   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth3=�6B   $��0q�6s   $��52��6~   �� 5   
   -   5         ��Name$ closeWindow_Button��5      $��Right=�6-   $	��Top=�6I   $��30��6a   $��30��6m     MaterialDesignToolButton#���  6x   $��0,10,7,0q�6�    K� ZIndex$ 1��6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.2.1.750, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6&   $��20��63   $��20��6?   $��Center=�6J   $��Center=�6e   $��0q�6�   
�������6�   5      �� 5   
   -   5        $ minimizeWindow_Button��5      $��Right=�60   $	��Top=�6L   $��30��6d   $��30��6p   #���  6{   $��	0,15,33,0q�6�   $ 1��6�   .��5        $ WindowMinimize=�6&   $��15��6<   $��15��6H   $��Center=�6S   $��Center=�6n   $��0q�6�   
�������6�   5      �� 5   
   -   5        $ addIP_Button��5      $
��Left=�6'   $	��Top=�6B   $��35��6Z   $��35��6f    , (MaterialDesignFloatingActionAccentButton#���  6q   $��8,8,0,0q�6�   $ 1��6�   .��5        $
 Plus=�6&   $��20��62   $��20��6>   $��Stretch=�6I   $��Stretch=�6e   
�������6�   5      � 5   
   -   5        $��itemCanvas_Grid��5   !   $��0,59,0,0q�6   5       )  #MaterialDesignThemes.Wpf.DialogHost  5"   
   -   5        $��selectIP_DialogWindow��5"   3   	   IsOpen	 .  
   DialogContent
 5#      � 5$      .+�5%        $	��200��6/   $	��120��6;   .��5&      � $��5,5,0,0q�6   .+�5'      �� $	��Top=�6$   $
��Left=�6<   $��5,5,0,0q�6W   $��Roboto)�6h   .��6|   Enter an IP Address6�   �� 5(      -   5        $��dialogWindow_TextBox��5(   i   $��Center=�6&   $��
10,0,15,20q�6A   $��Roboto)�6U   6�   �� 5)      -   5        $��80��5)   %   $
��Save��60   $��Right=�6?   $��Bottom=�6[   $��0,0,5,5q�6v     MaterialDesignFlatButton#���  6�   6�   �� 5*      -	   5        $��80��5*   %   $��Cancel��60   $
��Left=�6A   $��Bottom=�6\   $��0,0,0,5q�6w   #���  6�   6�   5+      5,      5-      5/      �� 51   
   -
   5         ��Name$ notificationText_Label��51      $#��You don't have any Addresses!��60   $��Center=�6X   $��Center=�6u   $
��Auto��6�   $��Roboto)�6�   $��20(�6�   $��
0,91,0,476q�6�   
�������6�     52   
   -   5          Name$ notificationIcon_PackIcon��52   "   $ Webhook=�6E   $��Center=�6T   $��Center=�6q   $��80��6�   $��80��6�   $��0,143,0,377q�6�   
�������6�   54      55      