   M S B A M L   `   `   `  ����@  <Login, Version=0.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LoginLogin  5   	       Login.MainWindow   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Login     5   	     � WindowStyle$
  None=�5   	    � Title$ Identificación Usuario��5      $	��450��6'   $	��800��64    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�6   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ 	#FFE63070��6    � Offset$ 1Q�61   � 5      $ 	#FFFE8704��6   $ 0Q�61   5      .+�5   
   �� $	��390��6   $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   ���#100E175      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��assets/doc.png��6   $	��281��60   $	��200��6<   $��
10,80,10,0q�6I   $��UniformToFill=�6]   � 5      .+�5      �� -   5        
 ��Name$
 
btnCliente��5   U   $��0,20,0,0q�5      $	��180��6/   $��40��6;   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      $��2q�6;   ���#100E17���#100E17
������� � ToolTip$ Ingresar como Cliente��5   5   $��Ingresar Como Cliente��6�   5       �� 5!      $��Center=�6!   $��Bottom=�6>   $��2��6Y   $	��160��6d   $��10,0,9,8q�6p   ��5"      �� 5#      $	 0,0&�62   $	 1,1&�6C   .��5$   "   � $ 	#FFE63070��6/   $	 0.0Q�6A   � 5%   "   $ 	#FFFE8704��6/   $	 1.0Q�6A   5&      5(      5)      5.      �� 5/      $	��350��6   .+�50      �� $��20 40q�6   .+�51      �� $��
User Login��6    $��20q�62   
������� �� TextAlignment$ Center=�6Q   $��38(�6h   $��Great Vibes)�6v   6�   �� 52      $	 
Horizontal=�6!   $��10q�6:   .+�53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   
�������6U   �� 54      -   5         ��Name$ 	txtCorreo��54   "   $
��10 0q�65   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ingrese su Usuario:��6C   
�������$	��250��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD94448 � Cursor$  ��6�   55      �� 56      $	 
Horizontal=�6!   $��10q�6:   .+�57        $
 Lock=�62   $��25��6>   $��25��6I   
�������6U   G� 58      -   5         G�Name$ txtPassword��58   &   $
��10 0q�6;   $ ********��6I   
�������$	��250��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944486�   59      �� 5:      $	��140��6!   $��50��6-   $��10q�69   $��Center=�6E   .+�5;      �� -   5        $
 btnLogin��5=   A   $��0,10,0,0q�5;   !   $	��110��63   $��40��6?   $ 10��5<      $��2q�64   ���#D94448���#200E17
�������$ Ingresar��5=   .   $��Ingresar��6j   5>      �� 5?      $��Center=�6%   $	��Top=�6B   $��2��6Z   $��90��6e   $��	2,-10,0,0q�6p   ��5@      �� 5A   "   $	 0,0&�66   $	 1,1&�6G   .��5B   &   � $ 	#FFE63070��63   $	 0.0Q�6E   � 5C   &   $ 	#FFFE8704��63   $	 1.0Q�6E   5D   #   5F      5G      5H      5I      �� 5J      $	��100��6   .+�5K      �� -   5        $
 btnExit��5L      $��10 20q�5K      $ Close��5L      ��5K   (   Z� .��5M        $ Close=�6.   
�������$��30��6N   $��30��6Y   5N      5O      5P      5Q      5S      