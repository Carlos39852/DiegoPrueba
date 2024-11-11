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
using System.Windows.Shapes;
using Login.Clases;
using Login.ClasesDB;

namespace Login.Views
{
    /// <summary>
    /// Lógica de interacción para AggProveedor.xaml
    /// </summary>
    public partial class AggProveedor : Window
    {
        private readonly Context _context;
        public AggProveedor(Context context)
        {
            InitializeComponent();
            _context = context; 
        }

        private void Cancelar(object sender, RoutedEventArgs e)
        {
            this.Close();

        }




        private void GuardarProveedor(object sender, RoutedEventArgs e)
        {
            using (var transaction = _context.Database.BeginTransaction())
            {

                // Crear y guardar el proveedor
                var nuevoProveedor = new Proveedor
                {
                    Nombre_proveedor = txtNombre.Text,
                    Telefono = int.Parse(txtTelefono.Text),
                    email = txtCorreo.Text
                };
                _context.Proveedores.Add(nuevoProveedor);
                _context.SaveChanges(); // Guardar para obtener el ProveedorID

                // Guardar los productos asociados
                foreach (var item in listaProductos)
                {
                    // Crear y guardar el producto-proveedor
                    var nuevoProductoProveedor = new ProductoProveedor
                    {
                        ProveedorID = nuevoProveedor.ProveedorID,
                        Nombre_Producto = item.NombreProducto
                    };
                    _context.ProductoProveedor.Add(nuevoProductoProveedor);
                    _context.SaveChanges(); // Guardar para obtener el ProductoProveedorID

                    // Crear el precio asociado y asignar el ProductoProveedorID correcto
                    var nuevoPrecio = new Precio
                    {
                        ProductoProveedorID = nuevoProductoProveedor.ProductoProveedorID, // ID válido
                        ProveedorID = nuevoProveedor.ProveedorID,
                        PrecioUnitario = item.PrecioUnitario
                    };
                    _context.Precios.Add(nuevoPrecio);
                }

                // Guardar los cambios finales
                _context.SaveChanges(); 

                // Confirmar la transacción
                transaction.Commit();

                    MessageBox.Show("Proveedor y productos guardados con éxito.");
                    listaProductos.Clear(); // Limpiar la lista de productos después de guardar
                    DataGridProductos.ItemsSource = null;

                    // Cerrar la ventana después de guardar

                    this.Close();
                
             
            }
        }

        private List<ProductoTemporal> listaProductos = new List<ProductoTemporal>();


        private void AgregarProducto_Click(object sender, RoutedEventArgs e)
        {

            // Validación básica
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
            {
                MessageBox.Show("Ingrese el nombre del producto y el precio unitario.");
                return;
            }

            // Crear un objeto de producto temporal y agregarlo a la lista
            var productoTemp = new ProductoTemporal
            {
                NombreProducto = txtNombreProducto.Text,
                PrecioUnitario = decimal.Parse(txtPrecioProducto.Text)
            };
            listaProductos.Add(productoTemp);

            // Actualizar el DataGrid con la lista actualizada
            DataGridProductos.ItemsSource = null;
            DataGridProductos.ItemsSource = listaProductos;

            // Limpiar los campos de entrada
            txtNombreProducto.Clear();
            txtPrecioProducto.Clear();


        }

    }
}
