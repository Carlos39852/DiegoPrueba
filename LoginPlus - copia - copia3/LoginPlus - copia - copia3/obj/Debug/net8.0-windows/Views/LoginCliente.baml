   M S B A M L   `   `   `  ����@  <Login, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Login.ViewsLogin.Views  5   	       Login.Views.LoginCliente   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Login.Views     5   	     � Title$  Identificación Cliente��5	      $	��450��6+   $	��800��68    � 
ResizeMode$ NoResize=�5
       � WindowStartupLocation$ CenterScreen=�6    � WindowStyle$
 None=�6=   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ 	#FFE63070��6    � Offset$ 1Q�61   � 5      $ 	#FFFE8704��6   $ 0Q�61   5      .+�5   
   �� $	��390��6   $	��Top=�6    �� CornerRadius$ 	0 0 180 0��66   ���#110E175      �� 5   
   	 �� Orientation$	 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      �� $��/assets/doc.png��6   $	��281��61   $	��200��6=   $��
10,80,10,0q�6J   $��UniformToFill=�6^   � 5      .+�5      �� -   5        
 ��Name$
 
btnUsuario��5   T   $��0,20,0,0q�5      $	��180��6/   $��40��6;   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 10��5      $��2q�6;   ���#100E17���#100E17
������� � ToolTip$ Igresar como Usuario��5   5   $��Ingresar Como Usuario��6�   5      �� 5      $��Center=�6!   $��Bottom=�6>   $��2��6Y   $	��160��6d   $��10,0,9,8q�6p   ��5       �� 5!      $	 0,0&�62   $	 1,1&�6C   .��5"   "   � $ 	#FFE63070��6/   $	 0.0Q�6A   � 5#   "   $ 	#FFFE8704��6/   $	 1.0Q�6A   5$      5&      5'      5,      �� 5-      $	��350��6   .+�5.      �� $��20 40q�6   .+�5/      �� $��Login ��6    $��20q�6.   
������� �� TextAlignment$ Center=�6M   $��38(�6d   $��Great Vibes)�6r   6�   �� 50      $	 
Horizontal=�6!   $��10q�6:   .+�51      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�62   $��25��6>   $��25��6I   
�������6U   �� 52      -   5         ��Name$ 	txtCorreo��52   "   $
��10 0q�65   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Ingrese su Email:��6C   $ Correo��6v   
�������$	��250��6�   
������� �� 
CaretBrush �	#FFD94448 �� SelectionBrush �	#FFD94448 � Cursor$  ��6�   53      �� 54      $	 
Horizontal=�6!   $��10q�6:   .+�55        $
 Lock=�62   $��25��6>   $��25��6I   
�������6U   G� 56      -   5         G�Name$ txtPassword��56   &   $
��10 0q�6;   $ ********��6I   $ Contraseña��6s   
�������$	��250��6�   
������� G� 
CaretBrush �	#FFD94448 G� SelectionBrush �	#FFD944486�   57      �� 58      $	��400��6!   $��10q�6-   $��Center=�69   .+�5:      � .+�5>      �� -   5        $
 btnLogin��5@   Y   $��
-180,0,0,0q�5>   %   $	��110��69   $��40��6E   $ 10��5?      $��2q�6L   ���#D94448���#200E17
�������$ Ingresar��5@   F   $��Ingresar��6�   5A      �� 5B      $��Center=�6)   $��Bottom=�6F   $��2��6a   $��90��6l   $��
-170,0,9,8q�6w   ��5C   "   �� 5D   &   $	 0,0&�6:   $	 1,1&�6K   .��5E   *   � $ 	#FFE63070��67   $	 0.0Q�6I   � 5F   *   $ 	#FFFE8704��67   $	 1.0Q�6I   5G   '   5I      �� 5M      -   5        $
 btnRegistrarme��5O   [   $��	180,0,0,0q�5M   %   $	��110��68   $��40��6D   $ 10��5N      $��2q�6K   ���#D94448���#200E17
�������$ Registrarme��5O   E   $��Registrarme��6�   5P      �� 5Q      $��Center=�6)   $��Bottom=�6F   $��2��6a   $��90��6l   $��	190,0,9,8q�6w   ��5R   "   �� 5S   &   $	 0,0&�6:   $	 1,1&�6K   .��5T   *   � $ 	#FFE63070��67   $	 0.0Q�6I   � 5U   *   $ 	#FFFE8704��67   $	 1.0Q�6I   5V   '   5X      5Y      5a      5b      5c      �� 5d      $	��100��6   .+�5e      �� -   5        $
 btnExit��5f      $��10 20q�5e      $ Close��5f      ��5e   (   Z� .��5g        $ Close=�6.   
�������$��30��6N   $��30��6Y   5h      5i      5j      5k      5m      