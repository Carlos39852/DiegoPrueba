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
    /// Lógica de interacción para GestionInventario.xaml
    /// </summary>
    public partial class GestionInventario : Page
    {
        private readonly Context _context;
        public GestionInventario(Context context)
        {
            InitializeComponent();
            _context = context;
            //CargarProductos();
            CargarProveedores();
            //ProductosStockMinimo();
            MostrarOrdenes();
        }

        #region Metodos para cargar los productos, mostrar los productos en los DataGrid y mostras las ordenes 
        private void CargarProductos()
        {
            var productos = _context.Productos
        .Include(p => p.ProductoProveedor) // Incluye la entidad ProductoProveedor relacionada
        .Include(p => p.Categoria) // Incluye la entidad Categoria si es necesario
        .Select(p => new
        {
            Nombre_Producto = p.ProductoProveedor.Nombre_Producto,
            Categoria = p.Categoria.Nombre_categoria,
            PrecioUnitario = _context.Precios
                .Where(pr => pr.ProductoProveedorID == p.ProductoProveedorID)
                .Select(pr => pr.PrecioUnitario)
                .FirstOrDefault(), // Obtén el precio desde la tabla Precios
            stock_actual = p.stock_actual
        })
        .ToList();

            DataGridProductos.ItemsSource = productos;
        }
        private void ProductosStockMinimo()
        {
            var productos = _context.Productos
          .Include(p => p.ProductoProveedor)
          .Select(p => new
          {
              Nombre_Producto = p.ProductoProveedor.Nombre_Producto,
              p.stock_minimo
          })
          .ToList();
                    DataGridStockMinimo.ItemsSource = productos;


        }

        private void CargarProveedores()
        { 
            var proveedores = _context.Proveedores
                .Select(p=> new 
                {
                    p.Nombre_proveedor,
                    p.Telefono,
                    p.email



            })
            .ToList();
            DataGridProveedores.ItemsSource = proveedores;
        }


        private void MostrarOrdenes()
        {
            var ordenes = _context.OrdenPedidos
                
                .Include(p => p.ProductoProveedor) // Incluir la tabla intermedia
                .Include(o => o.Proveedor)
                .Select(o => new
                {
                    o.OrdenPedidosID,
                    o.fecha_pedido,
                    o.cantidad,
                    o.precio_unitario,
                    o.Activo,
                    o.ProductoProveedorID,
                    o.ProveedorID,
                    // Asignar los nombres directamente desde la tabla intermedia
                    ProductoNombre = o.ProductoProveedor.Nombre_Producto,
                    ProveedorNombre = o.Proveedor.Nombre_proveedor,
                    o.monto_total
                })
                .ToList();

            DataGridMedicamentos.ItemsSource = ordenes;
        }

        #endregion
        public void SelectStockMinimoTab()
    {
        // Suponiendo que tienes un TabControl llamado `MainTabControl`
        if (TabControlPrincipal != null)
        {
            TabControlPrincipal.SelectedItem = TabItemStockMinimo;
        }
    }
        private void DataGridProveedores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // habilitar el botón "Eliminar Proveedor" si hay un elemento seleccionado de la datagrd
            BtnEliminar.IsEnabled = DataGridProveedores.SelectedItem != null;



        }


        private void AggProveedor(object sender, RoutedEventArgs e)
        {
            var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
            AggProveedor proveedorForm = new AggProveedor(context);

            proveedorForm.Closed += (s, args) => CargarProveedores();
            proveedorForm.ShowDialog();  // Muestrar la ventana  para agregar datos de proveddor
        }

        private void EliminarProveedor_Click(object sender, RoutedEventArgs e)
        {
            var proveedorSeleccionado = DataGridProveedores.SelectedItem as Proveedor;
            if (proveedorSeleccionado != null)
            {
                // Eliminar el proveedor de la base de datos o lista
                // Hay hacen el código para eliminar el proveedor aquí

                // Actualizar la vista (por ejemplo, recargar los datos del DataGrid)

                MessageBox.Show("Proveedor eliminado exitosamente.");
            }
        }

        private void EditarProveedorClick(object sender, RoutedEventArgs e)
        {

        }

        private void btnMarcarRecibido_Click(object sender, RoutedEventArgs e)
        {
            if (DataGridMedicamentos.SelectedItem != null)
            {
                // Obtener el elemento seleccionado como un tipo anónimo
                var ordenSeleccionada = DataGridMedicamentos.SelectedItem;

                // Obtener el ID de la orden seleccionada
                int ordenId = (int)ordenSeleccionada.GetType().GetProperty("OrdenPedidosID").GetValue(ordenSeleccionada, null);

                // Buscar la orden real en la base de datos
                var ordenEnDb = _context.OrdenPedidos.FirstOrDefault(o => o.OrdenPedidosID == ordenId);
                if (ordenEnDb != null)
                {
                    // Cambiar el estado a recibido
                    ordenEnDb.Activo = false; // Cambiar a false para marcar como inactivo

                    // Guardar los cambios en la base de datos
                    _context.SaveChanges();

                    MessageBox.Show("Orden marcada como recibida.");

                    // Volver a cargar el DataGrid
                    MostrarOrdenes();
                }
                else
                {
                    MessageBox.Show("No se encontró la orden en la base de datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una orden.");
            }
        }

        private void DataGridMedicamentos_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            var ordenEditada = e.Row.Item as OrdenPedido;
            if (ordenEditada != null)
            {
                // Actualiza el estado de la orden en la base de datos
                var ordenEnDb = _context.OrdenPedidos.FirstOrDefault(o => o.OrdenPedidosID == ordenEditada.OrdenPedidosID);
                if (ordenEnDb != null)
                {
                    ordenEnDb.Activo = ordenEditada.Activo;
                    _context.SaveChanges();
                    MessageBox.Show("Estado actualizado en la base de datos.");
                }
            }
        }
    }
}
