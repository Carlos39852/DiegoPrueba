   M S B A M L   `   `   `  ����@  <Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Login.ViewsLogin.Views  5          Login.Views.GestionProduc   5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Login.Views     5        N� Title$  GestionProduc��5
      .��5      � 
�������.+�5   
   �� $��Gestión de Productos��6   $��24(�60   $��10q�6>   $	��Top=�5      $��Center=�6,   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridProductos��5      $��10,50,10,10q�6.      AutoGenerateColumns .  
����������#2C3E50���#E5E7EB   RowBackground �#FAFAFA   AlternatingRowBackground �#F1F1F1   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6)      HeaderTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5   "   '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 Account=�6:   $��20��6I   $��20��6T   $��5q�6`   ���#2C3E506k   �� 5   "   $��Nombre��6,   $��Center=�6:   ���#2C3E506U   5      5      
   CellTemplate
 5      �� 5       .R�5!      �� $��Center=�6@   ���#2C3E50��6(   �� *Nombre+6[   5"      5$        5'      $ 
Categoría��6)    5(      �� 5)      .R�5*      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5+   "     $		 Tag=�6:   $��20��6E   $��20��6P   $��5q�6\   ���#2C3E506g   �� 5,   "   $��
Categoría��6,   $��Center=�6=   ���#2C3E506X   5-      5.      
 50      �� 51      .R�52      �� $��Center=�6C   ���#2C3E50��6(   �� *	Categoria+6^   53      55        58      $ Precio��6)    59      �� 5:      .R�5;      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5<   "     $	 CurrencyUsd=�6:   $��20��6M   $��20��6X   $��5q�6d   ���#2C3E506o   �� 5=   "   $��Precio��6,   $��Center=�6:   ���#2C3E506U   5>      5?      
 5A      �� 5B      .R�5C      �� $��Center=�6@   ���#2C3E50��6(   �� *Precio+6[   5D      5F        5I      $ Stock��6)    5J      �� 5K      .R�5L      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5M   "     $	 	Warehouse=�6:   $��20��6K   $��20��6V   $��5q�6b   ���#2C3E506m   �� 5N   "   $��Stock��6,   $��Center=�69   ���#2C3E506T   5O      5P      
 5R      �� 5S      .R�5T      �� $��Center=�6?   ���#2C3E50��6(   �� *Stock+6Z   5U      5W      5Y      �� 5]   
   $ 
Horizontal=�6   $��Right=�6.   $��Bottom=�6J   $��10q�6e   .+�5^      �� $��Agregar Producto��6      MaterialDesignFlatButton#��[  60   
��� � �
�������$��0,0,10,0q�5_   ;   �� 5`      $��Eliminar Producto��6   #��[  61   
���  ��
�������5a   &   5b      5c      5d      