   M S B A M L   `   `   `  ����@  <Login, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Login.ViewsLogin.Views  5          Login.Views.GestionProduc   5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Login.Views     5        N� Title$  GestionProduc��5
      .��5      � 
�������.+�5   
   �� $��Gestión de Productos��6   $��24(�60   $��10q�6>   $	��Top=�5      $��Center=�6,   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridProductos��5      $��10,70,10,10q�6.      AutoGenerateColumns$ False��6C   
����������#2C3E50���#E5E7EB   RowBackground �#FAFAFA   AlternatingRowBackground �#F1F1F1   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6)      HeaderTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5   "   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Account=�6:   $��20��6I   $��20��6T   $��5q�6`   ���#2C3E506k   �� 5   "   $��Nombre��6,   $��Center=�6:   ���#2C3E506U   5      5      
   CellTemplate
 5      �� 5      .R�5       �� $��Center=�6I   ���#2C3E50��6(   �� *Nombre_Producto+6d   5!      5#        5&      $ 
Categoría��6)    5'      �� 5(      .R�5)      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5*   "     $		 Tag=�6:   $��20��6E   $��20��6P   $��5q�6\   ���#2C3E506g   �� 5+   "   $��
Categoría��6,   $��Center=�6=   ���#2C3E506X   5,      5-      
 5/      �� 50      .R�51      �� $��Center=�6C   ���#2C3E50��6(   �� *	Categoria+6^   52      54        57      $ Precio��6)    58      �� 59      .R�5:      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5;   "     $	 CurrencyUsd=�6:   $��20��6M   $��20��6X   $��5q�6d   ���#2C3E506o   �� 5<   "   $��Precio��6,   $��Center=�6:   ���#2C3E506U   5=      5>      
 5@      �� 5A      .R�5B      �� $��Center=�6H   ���#2C3E50��6(   �� *PrecioUnitario+6c   5C      5E        5H      $ Stock��6)    5I      �� 5J      .R�5K      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5L   "     $	 	Warehouse=�6:   $��20��6K   $��20��6V   $��5q�6b   ���#2C3E506m   �� 5M   "   $��Stock��6,   $��Center=�69   ���#2C3E506T   5N      5O      
 5Q      �� 5R      .R�5S      �� $��Center=�6F   ���#2C3E50��6(   �� *stock_actual+6a   5T      5V      5X      �� 5[   
   $ 
Horizontal=�6   $��Right=�6.   $��0,58,13,358q�6J   $��33��6_   $	��227��6k   .+�5`      �� 
����·�
���   �$��0,0,10,0q�6C   ��5a      �� 5b       �� 
TargetType" ��6      MaterialDesignFlatButton �� BasedOn# [  60   .�5c      ��  �� Property � �� �� Value
 ��ح�67   �� 5d       � ��
 �   �67    �� Triggers 5e      P� 5f       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5g   "   ��  � ��
 ����6?   �� 5h   "    � ��
 �����6?   5i      5k      .��5n      �� $ 
Horizontal=�6   .+�5o        $	 Pencil=�6.   $��20��6<   $��20��6G   
���   �6S   �� 5p      $��Editar��6    
���   �$��Center=�6A   $��10,0,0,0q�6\   5q      5r      �� 5s      -   5        
����·�
���   �$��0,0,10,0q�5s   B   ��5t      �� 5u      " ��6   # [  60   .�5v      ��  � ��
 ��ح�67   �� 5w       � ��
 �   �67    5x      P� 5y       �@J�IsMouseOver$
 True��6=   . �5z   "   ��  � ��
 ����6?   �� 5{   "    � ��
 �����6?   5|      5~      .��5�      �� $ 
Horizontal=�6   .+�5�        $
	 Plus=�6.   $��20��6:   $��20��6E   
���   �6Q   �� 5�      $��Agregar��6    
���   �$��Center=�6B   $��10,0,0,0q�6]   5�      5�      5�      5�      5�      