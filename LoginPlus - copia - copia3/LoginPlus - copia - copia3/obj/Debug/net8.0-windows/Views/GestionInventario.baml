   M S B A M L   `   `   `  ����@  <Login, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Login.ViewsLogin.Views  5      #    Login.Views.GestionInventario   5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Login.Views     5        N� Title$  GestionInventario��5
      .��5      � ���#F3F4F6.+�5   
   �� $��Gestión de Inventario��6   $��28(�61   $
��Bold"�6?   ���#34495E$��Center=�6f   $��0,20,0,0q�6�   �� 5   
   -   5         ��Name$ TabControlPrincipal��5      $��
20,80,20,0q�62   ���#FFFFFF���#2C3E50���#D1D5DB �� TabStripPlacement$	 Top=�5   +   $	��443��6C   $	��Top=�6P   .@�5      �� $��	Productos��6   $��10��6)   $��	-60,0,0,0q�64   .��5      �� $��10q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $	��Top=�6:   $��0,0,0,10q�6R   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Box=�62   $��30��6=   $��30��6H   ���#34495E6T   �� 5      $��Listado de Productos��6$   $��20(�6@   $��10,0,0,0q�6N   $��Center=�6`   ���#34495E6{   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ DataGridProductos��5         AutoGenerateColumns$ False��6:   
����������#2C3E50���#E5E7EB   RowBackground �#FAFAFA   AlternatingRowBackground �#F1F1F1$	��334��5   ]   	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nombre_Producto��65      HeaderTemplate 5   "   �� 5    &   .R�5!   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5"   .     $ Account=�6F   $��20��6U   $��20��6`   $��5q�6l   ���#2C3E506w   �� 5#   .   $��Nombre��68   $��Center=�6F   ���#2C3E506a   5$   +   5%   '      CellTemplate 5'   "   �� 5(   &   .R�5)   *   �� $��Center=�6U   ���#2C3E50��64   �� *Nombre_Producto+6p   5*   '   5,        5/      $
 
Categoría��65    50   "   �� 51   &   .R�52   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�53   .     $	 Tag=�6F   $��20��6Q   $��20��6\   $��5q�6h   ���#2C3E506s   �� 54   .   $��
Categoría��68   $��Center=�6I   ���#2C3E506d   55   +   56   '    58   "   �� 59   &   .R�5:   *   �� $��Center=�6O   ���#2C3E50��64   �� *	Categoria+6j   5;   '   5=        5@      $
 Precio��65    5A   "   �� 5B   &   .R�5C   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5D   .     $ CurrencyUsd=�6F   $��20��6Y   $��20��6d   $��5q�6p   ���#2C3E506{   �� 5E   .   $��Precio��68   $��Center=�6F   ���#2C3E506a   5F   +   5G   '    5I   "   �� 5J   &   .R�5K   *   �� $��Center=�6T   ���#2C3E50��64   �� *PrecioUnitario+6o   5L   '   5N        5Q      $
 Stock_actual��65    5R   "   �� 5S   &   .R�5T   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5U   .     $ 	Warehouse=�6F   $��20��6W   $��20��6b   $��5q�6n   ���#2C3E506y   �� 5V   .   $��Stock��68   $��Center=�6E   ���#2C3E506`   5W   +   5X   '    5Z   "   �� 5[   &   .R�5\   *   �� $��Center=�6R   ���#2C3E50��64   �� *stock_actual+6m   5]   '   5_      5a      5e      5f      �� 5i      -   5         ��Name$ TabItemStockMinimo��5i      $��Stock Mínimo��63   $	��125��6I   $��	-90,0,0,0q�6U   .��5j      �� $��10q�6   .+�5k      �� $ 
Horizontal=�6!   $	��Top=�6:   $��0,0,0,10q�6R   .+�5l        $ ClipboardList=�62   $��30��6G   $��30��6R   ���#34495E6^   �� 5m      $��Control de Stock Mínimo��6$   $��20(�6C   $��10,0,0,0q�6Q   $��Center=�6c   ���#34495E6~   5n        5o      -   5        $ DataGridStockMinimo��5o      $ False��6<   
����������#2C3E50���#E5E7EB �#FAFAFA �#F1F1F1$	��335��5p   p   	 5q        5s      $
 Producto��65    5t   "   �� 5u   &   .R�5v   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5w   .     $	 Box=�6F   $��20��6Q   $��20��6\   $��5q�6h   ���#2C3E506s   �� 5x   .   $��Producto��68   $��Center=�6H   ���#2C3E506c   5y   +   5z   '    5|   "   �� 5}   &   .R�5~   *   �� $��Center=�6U   ���#2C3E50��64   �� *Nombre_Producto+6p   5   '   5�        5�      $
 Stock Mínimo��65    5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5�   .     $ 	ArrowDown=�6F   $��20��6W   $��20��6b   $��5q�6n   ���#2C3E506y   �� 5�   .   $��Stock Mínimo��68   $��Center=�6L   ���#2C3E506g   5�   +   5�   '    5�   "   �� 5�   &   .R�5�   *   �� $��Center=�6R   ���#2C3E50��64   �� *stock_minimo+6m   5�   '   5�      5�      5�      5�      �� 5�      $��Proveedores��6   $	��125��6+   $��
-100,0,0,0q�67   .��5�      �� $��0,0,0,10q�6   $	��292��6/   $��Bottom=�6<   .+�5�      �� $ 
Horizontal=�6!   $��Right=�6:   $��0,40,0,0q�6V   $��33��6h   $	��350��6t   .+�5�      �� -   5        
����ح�
���   �$��	10,0,10,0q�5�   `   ��5�      �� 5�   "    �� 
TargetType" ��6(      MaterialDesignFlatButton �� BasedOn# [  6<   .�5�   &   ��  �� Property � �� �� Value
 ��ح�6C   �� 5�   &    � ��
 �   �6C    �� Triggers 5�   &   P� 5�   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   . �5�   .   ��  � ��
 �   �6K   �� 5�   .    � ��
 �����6K   5�   +   5�   #   .��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ 
PlusCircle=�6:   $��20��6L   $��20��6W   
���   �6c   �� 5�   "   $��Agregar��6,   
���   �$��Center=�6N   $��10,0,0,0q�6i   5�      5�      �� 5�      -   5        
����·�
���   �$��0,0,10,0q�5�   k   ��5�      �� 5�   "   " ��6(   # [  6<   .�5�   &   ��  � ��
 ��ح�6C   �� 5�   &    � ��
 �   �6C    5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   ��  � ��
 ����6K   �� 5�   .    � ��
 �����6K   5�   +   5�   #   .��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ Pencil=�6:   $��20��6H   $��20��6S   
���   �6_   �� 5�   "   $��Editar��6,   
���   �$��Center=�6M   $��10,0,0,0q�6h   5�      5�      �� 5�      -   5        $��BtnEliminar��5�   !   $
{�True��64   
����ح�
���   �$��0,0,10,0q�6�   ��5�      �� 5�   "   " ��6(   # [  6<   .�5�   &   ��  � ��
 ��ح�6C   �� 5�   &    � ��
 �   �6C    5�   &   P� 5�   *    �@J�IsMouseOver$
 True��6I   . �5�   .   ��  � ��
 �  ��6K   �� 5�   .    � ��
 �����6K   5�   +   5�   #   .��5�      �� $ 
Horizontal=�6)   .+�5�   "     $ Delete=�6:   $��20��6H   $��20��6S   
���   �6_   �� 5�   "   $��Eliminar��6,   
���   �$��Center=�6O   $��10,0,0,0q�6j   5�      5�      5�      �� 5�      $ 
Horizontal=�6!   $	��Top=�6:   $��
0,-30,0,10q�6R   .+�5�        $ Account=�62   $��30��6A   $��30��6L   ���#34495E6X   �� 5�      $��Proveedores��6$   $��20(�67   $��10,0,0,0q�6E   $��Center=�6W   ���#34495E6r   5�        5�      -   5        $ DataGridProveedores��5�      $ False��6<   
����������#2C3E50���#E5E7EB �#FAFAFA �#F1F1F1$	��209��5�   �   	 5�        5�      $
 Nombre��65    5�   "   �� 5�   &   .R�5�   *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5�   .     $ AccountCircle=�6F   $��20��6[   $��20��6f   $��5q�6r   ���#2C3E506}   �� 5�   .   $��Nombre��68   $��Center=�6F   ���#2C3E506a   5�   +   5�   '    5�   "   �� 5�   &   .R�5�   *   �� $��Center=�6V   ���#2C3E50��64   �� *Nombre_proveedor+6q   5�   '   5�        5      $
 	Teléfono��65    5  "   �� 5  &   .R�5  *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5  .     $ Phone=�6F   $��20��6S   $��20��6^   $��5q�6j   ���#2C3E506u   �� 5  .   $��	Teléfono��68   $��Center=�6H   ���#2C3E506c   5  +   5  '    5	  "   �� 5
  &   .R�5  *   �� $��Center=�6N   ���#2C3E50��64   �� *
Telefono+6i   5  '   5       5     $
 Correo��65    5  "   �� 5  &   .R�5  *   �� $ 
Horizontal=�65   $��Center=�6N   .+�5  .     $ Email=�6F   $��20��6S   $��20��6^   $��5q�6j   ���#2C3E506u   �� 5  .   $��Correo��68   $��Center=�6F   ���#2C3E506a   5  +   5  '    5  "   �� 5  &   .R�5  *   �� $��Center=�6K   ���#2C3E50��64   �� *email+6f   5  '   5     5(     5,     5.     �� 53     $��Solicitud de Medicamentos��6   $	��210��69   $��	-60,0,0,0q�6E   .��54     �� $��	0,10,0,18q�6   .+�55     �� $ 
Horizontal=�6!   $��Right=�6:   $��0,40,0,0q�6V   $��33��6h   $	��151��6t   .+�57     �� -	   5         ��Name$ btnRecibido��57  !   
����ح�
���   �$��	10,0,10,0q�6�   ��58     �� 59  "   " ��6(   # [  6<   .�5:  &   ��  � ��
 ��ح�6C   �� 5;  &    � ��
 �   �6C    5<  &   P� 5=  *    �@J�IsMouseOver$
 True��6I   . �5>  .   ��  � ��
 �   �6K   �� 5?  .    � ��
 �����6K   5@  +   5B  #   .��5E     �� $ 
Horizontal=�6)   .+�5F  "     $ Check=�6:   $��20��6G   $��20��6R   
���   �6^   �� 5G  "   $��Recibido��6,   
���   �$��Center=�6O   $��10,0,0,0q�6j   5H     5I     5K       5N     -
   5        $ DataGridMedicamentos��5N     $ False��6=   $��10,10,10,10q�6Y   $	��364��6n      SelectionMode$ Single=�6|   	 5O     0  *System.Windows.Controls.DataGridTextColumn  5Q        Width5  /System.Windows.Controls.DataGridLengthConverter$ * 61      
IsReadOnly$
 True��6^   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *ProductoNombre+
 5R  "   �� 5S  &   $ 
Horizontal=�61   .+�5T  *     $ Syringe=�6B   $��20��6Q   $��20��6\   $��Center=�6h   ���#2C3E506�   �� 5U  *   $��Producto��64   $��Center=�6D   $��5,0,0,0q�6_   5V  '   5X       5[     $ * 61   $
 True��6`    6;   �� *ProveedorNombre+
 5\  "   �� 5]  &   $ 
Horizontal=�61   .+�5^  *     $ Person=�6B   $��20��6P   $��20��6[   $��Center=�6g   ���#2C3E506�   �� 5_  *   $��	Proveedor��64   $��Center=�6E   $��5,0,0,0q�6`   5`  '   5b       5e     $ * 61   $
 True��6Y    6;   �� *
cantidad+
 5f  "   �� 5g  &   $ 
Horizontal=�61   .+�5h  *     $ Numeric=�6B   $��20��6Q   $��20��6\   $��Center=�6h   ���#2C3E506�   �� 5i  *   $��Cantidad��64   $��Center=�6D   $��5,0,0,0q�6_   5j  '   5l       5o     $ * 61   $
 True��6_    6;   �� *precio_unitario+
 5p  "   �� 5q  &   $ 
Horizontal=�61   .+�5r  *     $ Dollar=�6B   $��20��6P   $��20��6[   $��Center=�6g   ���#2C3E506�   �� 5s  *   $��Precio Unitario��64   $��Center=�6K   $��5,0,0,0q�6f   5t  '   5v       5y     $ * 61   $
 True��6[    6;   �� *monto_total+
 5z  "   �� 5{  &   $ 
Horizontal=�61   .+�5|  *     $ Finance=�6B   $��20��6Q   $��20��6\   $��Center=�6h   ���#2C3E506�   �� 5}  *   $��Total��64   $��Center=�6A   $��5,0,0,0q�6\   5~  '   5�       5�     $ * 61   $ False��6c    6;   �� *Activo+ �� Mode$ OneWay=�
 5�  "   �� 5�  &   $ 
Horizontal=�61   .+�5�  *     $ CheckCircle=�6B   $��20��6U   $��20��6`   $��Center=�6l   ���#2C3E506�   �� 5�  *   $��Activo��64   $��Center=�6B   $��5,0,0,0q�6]   5�  '   5�     5�     5�     5�     5�     5�     5�     