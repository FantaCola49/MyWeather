   M S B A M L   `   `   `  ����G  CMyWeatherWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:MyWeatherWPF.Resources.PagesMyWeatherWPF.Resources.Pages  5      ,    &MyWeatherWPF.Resources.Pages.StartPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:MyWeatherWPF.Resources.Pages     5        N� Title$  	StartPage��5	      .��5      � .+�5   
   �� $��3��6   $��2��6%   ��5      �� 5       �� Opacity$
 0.75Q�6&    � SpreadMethod$ Reflect=�65    �� 
StartPoint$	 0,0&�6L    �� EndPoint$ 0,0.9&�6]   .��5      �  � Color$ #1bf2ce��6#    � Offset$ 0Q�63   � 5      $ White��6#   $ 1Q�61   5      5      �� 5   
   -   5        $	��Top=�5   $   $
��Left=�6<   $��25��6W   
������ .��5      �� $!��/Resources/Icons/UpDate.png��6   5      �� 5   
   -   5        $��MainTemp��5      $��Center=�6    $��Center=�6;   $��2��6X   $��68(�6i   $
��Bold"�6w   
�������$��Times New Roman)�6�   $��88��6�   $��78��6�   $��2��6�   �� 5   
   -   5        $��FeelsLikeLab��5      $��1��6%   $��
Feels like��62   $��Center=�6G   $��Center=�6b   
�������$��Times New Roman)�6�   $��19(�6�   $��32��6�   $��2��6�   �� 5   
   -   5        $��Descript��5      $��Bottom=�6    $��Center=�6;   $��Description��6X   $��1��6n   
�������$��Times New Roman)�6�   $��20(�6�   $��DemiBold"�6�   $��33��6�   $��2��6�   �� 5   
   -   5        $��MaxTemp��5      $��Max 19��6   $��2��60   $	��Top=�6=   $
��Left=�6U   
�������$��18(�6�   $��Times new roman)�6�   $��DemiBold"�6�   $��1��6�   $��9 0 0 0q�6�   �� 5   
   -   5        $��MinTemp��5      $��Min 19��6    $��2��61   $	��Top=�6>   $��Right=�6V   
�������$��18(�6�   $��Times new roman)�6�   $��DemiBold"�6�   $��0 0 9 0q�6�   �� 5   
   -   5        $��	City_Name��5      $��	City_Name��6!   $	��Top=�65   $��Center=�6M   
�������$��38(�6}   $��Times new roman)�6�   $��DemiBold"�6�   $��2��6�   � 5    
   -   5         �Name$ 
WrapPanel1��5       $��2��6(   $��2��69   $��Right=�6M   $	��Top=�6i   $	��158��6�   $	��130��6�   .+�5!      �� -	   5        $��Icon_ID��5!      $	��130��6#   $	��130��6/   5"      �� 5#   
   $��
Город��6   $��2��6"   $��2��6/   $��Bottom=�6C   .��5$      �  � ColumnDefinitions 5%      �� 5&      $��* �6'   �� 5'      $��* �6'   .+�5*      �� -
   5        $��CityID��5*      $��Center=�6)   $��5 0 5 0q�6D   $��1��6U   .@�5+      �� -   5        $��Moscow��5+   4   $��Moscow��6#   64   �� 5,      $��Ryazan��6#   
	 � Tag$	 500095��64   �� 5-      $��Saint Petersburg��6#   $	 498817��6>   �� 5.      $��
Shchelkovo��6#   $	 495344��68   �� 5/      $��Samara��6#   $	 499099��64   �� 50      $��
Khabarovsk��6#   $	 2022890��68   �� 51      $��Belgorod��6#   $	 578072��66   52      �� 53      -   5        $��
SearchCity��53      $��Type city name in English��6,   $��9 0 23 0q�6l   $��Center=�6~   ���	#FF808080$��Italic$�6�   �� 54      -   5        $��Search��54      $��18��6'   $��18��62   $��Center=�6>   $��Right=�6Y   .��55      �� $ ��/Resources/Icons/Loupe.png��6   56      57      58       5:   
   �� 5;      �� 5<      
 � RowDefinitions
 5?   
   �� 5@      $	��99* �6   �� 5A      $
��152* �6   �� 5B      $	��99* �6   5D      5E      