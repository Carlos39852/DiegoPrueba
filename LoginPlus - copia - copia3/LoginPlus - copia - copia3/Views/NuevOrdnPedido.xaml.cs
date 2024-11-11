using Login.ClasesDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Login.Views
{
    /// <summary>
    /// Lógica de interacción para NuevOrdnPedido.xaml
    /// </summary>
    public partial class NuevOrdnPedido : Page
    {
        private readonly Context _context;
        
        public NuevOrdnPedido(Context context)
        {
            InitializeComponent();
            _context = context;
           
            CargarProveedores();
          
        }


        private void CargarProveedores()
        { 
            var Proveedores = _context.Proveedores.ToList();
            ComboBoxProveedor.ItemsSource = Proveedores;
            ComboBoxProveedor.DisplayMemberPath = "Nombre_proveedor";
            ComboBoxProveedor.SelectedValuePath = "ProveedorID";
        
        }


        private void GuardarOrden()
        {
            // Verifica que todos los campos necesarios estén llenos
             if (ComboBoxProveedor.SelectedValue == null || ComboBoxProducto.SelectedValue == null ||
                 string.IsNullOrWhiteSpace(TextBoxCantidad.Text) || DatePickerFecha.SelectedDate == null)
             {
                 MessageBox.Show("Por favor, complete todos los campos obligatorios antes de guardar la orden.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                 return;
             }

            try
            {
                // Obtiene los valores seleccionados y los datos de la interfaz
                int proveedorID = (int)ComboBoxProveedor.SelectedValue;
                // Verifica que un producto haya sido seleccionado
                if (ComboBoxProducto.SelectedValue == null)
                {
                    MessageBox.Show("No se ha seleccionado ningún producto. Por favor, seleccione un producto antes de continuar.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                int productoProveedorID = (int)ComboBoxProducto.SelectedValue;

                int cantidad = int.Parse(TextBoxCantidad.Text);
                bool esActivo = ComboBoxEstado.SelectedItem != null &&
                                ComboBoxEstado.SelectedItem.ToString().Contains("Activo");
                DateTime fechaPedido = DatePickerFecha.SelectedDate.Value;

                // Busca el registro de precio que coincida con el producto y proveedor
                var precioRegistro = _context.Precios
                    .Include(p => p.ProductoProveedor)
                    .FirstOrDefault(p => p.ProductoProveedorID == productoProveedorID && p.ProveedorID == proveedorID);

                if (precioRegistro == null)
                {
                    MessageBox.Show("No se encontró un precio válido para el producto seleccionado.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                decimal precioUnitario = precioRegistro.PrecioUnitario;

                // Calcula el monto total basándose en el precio unitario y la cantidad
                decimal montoTotal = precioUnitario * cantidad;

                // Crea una nueva instancia de OrdenPedido
                var nuevaOrden = new OrdenPedido
                {
                    ProveedorID = proveedorID,
                    ProductoProveedorID = productoProveedorID, // ProductoProveedorID asignado aquí
                    cantidad = cantidad,
                    fecha_pedido = fechaPedido,
                    precio_unitario = precioUnitario,
                    monto_total = montoTotal,
                    Activo = esActivo
                };

                // Agrega la nueva orden al contexto y guarda los cambios
                _context.OrdenPedidos.Add(nuevaOrden);
                _context.SaveChanges();

                MessageBox.Show("Orden guardada exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Limpia los campos después de guardar
                ComboBoxProveedor.SelectedIndex = -1;
                ComboBoxProducto.SelectedIndex = -1;
                ComboBoxEstado.SelectedIndex = -1;
                TextBoxCantidad.Clear();
                DatePickerFecha.SelectedDate = null;
                txtPrecioUnitario.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }



        private void BtnGuardarOrden_Click(object sender, RoutedEventArgs e)
        {
            GuardarOrden();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnAgregarProducto_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBoxProveedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxProveedor.SelectedValue != null)
            {
                int proveedorID = (int)ComboBoxProveedor.SelectedValue;
                
                CargarProductosPorProveedor(proveedorID);
            }
            else
            {
                
            }
        }
        
        private void CargarProductosPorProveedor(int proveedorID)
            {
            var productosConPrecios = _context.Precios
        .Include(p => p.ProductoProveedor)
        .Where(p => p.ProveedorID == proveedorID)
        .Select(p => new
        {
            ProductoProveedorID = p.ProductoProveedor.ProductoProveedorID, 
            Nombre_Producto = p.ProductoProveedor.Nombre_Producto,
            PrecioUnitario = p.PrecioUnitario
        })
        .ToList();

            ComboBoxProducto.ItemsSource = productosConPrecios;
            ComboBoxProducto.DisplayMemberPath = "Nombre_Producto";
            ComboBoxProducto.SelectedValuePath = "ProductoProveedorID";
        }
        

        private void ComboBoxProducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxProducto.SelectedItem != null)
            {
                var productoSeleccionado = (dynamic)ComboBoxProducto.SelectedItem;
               
               
            }
            else
            {
                
            }
        }
    }
}
