   M S B A M L   `   `   `  ����@  <Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Login.ViewsLogin.Views  5           Login.Views.NuevOrdnPedido   5      _ [MaterialDesignThemes.Wpf, Version=4.8.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Login.Views     5        N� Title$  Nueva Orden de Pedido��5
      .��5      � 
�������.+�5   
   �� $��Nueva Orden de Pedido��6   $��24(�61   $��10q�6?   $	��Top=�6K   $��Center=�6c   �� 5   
   $��20,42,20,228q�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��0, 10, 0, 0q�62   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Store=�6*   $��20��67   $��20��6B   $��Center=�6N   ���#2C3E506i   �� 5      $��
Proveedor:��6   $	��120��6.   $��Center=�6:   $��5,0,0,0q�6U   �� 5      -   5         ��Name$ ComboBoxProveedor��5      $	��300��66   $��30��6B   .@�5      �� $��Proveedor 1��6#   �� 5      $��Proveedor 2��6#   �� 5      $��Proveedor 3��6#   5      5      �� 5      $ 
Horizontal=�6   $��0, 10, 0, 0q�62   .+�5         $ Calendar=�6*   $��20��6:   $��20��6E   $��Center=�6Q   ���#2C3E506l   �� 5!      $��Fecha:��6   $	��120��6*   $��Center=�66   $��5,0,0,0q�6Q   (  "System.Windows.Controls.DatePicker  5"      -   5          Name$ DatePickerFecha��5"      $	��300��66   $��30��6B   5#      �� 5&      $ 
Horizontal=�6   $��0, 10, 0, 0q�62   .+�5'        $ Package=�6*   $��20��69   $��20��6D   $��Center=�6P   ���#2C3E506k   �� 5(      $��	Producto:��6   $	��120��6-   $��Center=�69   $��5,0,0,0q�6T   �� 5)      -   5        $ ComboBoxProducto��5)      $	��300��65   $��30��6A   .@�5+      �� $��
Producto 1��6#   �� 5,      $��
Producto 2��6#   �� 5-      $��
Producto 3��6#   5.      5/      �� 52      $ 
Horizontal=�6   $��0, 10, 0, 0q�62   .+�53        $ Numeric=�6*   $��20��69   $��20��6D   $��Center=�6P   ���#2C3E506k   �� 54      $��	Cantidad:��6   $	��120��6-   $��Center=�69   $��5,0,0,0q�6T   �� 55      -   5         ��Name$ TextBoxCantidad��55      $	��300��63   $��30��6?   56      �� 59      -   5           MaterialDesignFlatButton#��[  59      $	��150��6G   $��40��6S   $��10, 20, 0, 0q�6_   .��5:      �� $ 
Horizontal=�6   $��Center=�66   .+�5;        $
 Plus=�6.   $��20��6:   $��20��6E   $��5q�6Q   
�������6\   �� 5<      $��Agregar Producto��6    $��Center=�68   
�������6S   5=      5>      5?      �� 5A   
   $��20,218,20,59q�6   .+�5C      &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridProductos��5C         AutoGenerateColumns .  $��0,0,0,0q�6N      Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5F      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6)   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 63   �� *NombreProducto+   Header 5G      �� 5H      $ 
Horizontal=�6)   .+�5I   "     $ Package=�6:   $��20��6I   $��20��6T   $��Center=�6`   ���#2C3E506{   �� 5J   "   $��Producto��6,   $��Center=�6<   $��5,0,0,0q�6W   5K      5M        5P      $	 * 6)   
 63   �� *
Cantidad+ 5Q      �� 5R      $ 
Horizontal=�6)   .+�5S   "     $ Numeric=�6:   $��20��6I   $��20��6T   $��Center=�6`   ���#2C3E506{   �� 5T   "   $��Cantidad��6,   $��Center=�6<   $��5,0,0,0q�6W   5U      5W        5Z      $	 * 6)   
 63   �� *PrecioUnitario+ 5[      �� 5\      $ 
Horizontal=�6)   .+�5]   "     $
 Cash=�6:   $��20��6F   $��20��6Q   $��Center=�6]   ���#2C3E506x   �� 5^   "   $��Precio Unitario��6,   $��Center=�6C   $��5,0,0,0q�6^   5_      5a        5d      $	 * 6)   
 63   �� *Total+ 5e      �� 5f      $ 
Horizontal=�6)   .+�5g   "     $ CurrencyUsd=�6:   $��20��6M   $��20��6X   $��Center=�6d   ���#2C3E506   �� 5h   "   $��Total��6,   $��Center=�69   $��5,0,0,0q�6T   5i      5k      5m      5o      �� 5q   
   $ 
Horizontal=�6   $��Right=�6.   $��Bottom=�6J   $��0,0,0,0q�6e   .+�5s      �� -   5        #��[  5s      $	��150��6G   $��40��6S   $��10q�6_   .��5t      �� $ 
Horizontal=�6   $��Center=�66   .+�5u        $ ContentSave=�6.   $��20��6A   $��20��6L   $��5q�6X   
���   �6c   �� 5v      $��Guardar Orden��6    $��Center=�65   
���   �6P   5w      5x      �� 5{      -   5        #��[  5{      $	��150��6G   $��40��6S   $��10q�6_   .��5|      �� $ 
Horizontal=�6   $��Center=�66   .+�5}        $ Cancel=�6.   $��20��6<   $��20��6G   $��5q�6S   
���   �6^   �� 5~      $��Cancelar��6    $��Center=�60   
���   �6K   5      5�      5�      5�      5�      