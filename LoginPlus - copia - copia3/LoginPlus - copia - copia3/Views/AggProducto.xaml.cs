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
using System.Windows.Shapes;

namespace Login.Views
{
    /// <summary>
    /// Lógica de interacción para AggProducto.xaml
    /// </summary>
    public partial class AggProducto : Window
    {
        private readonly Context _context;
        public AggProducto(Context context)
        {
            InitializeComponent();
            _context = context;
            CargarProveedores();
        }

        private void CargarProveedores()
        {
            var Proveedores = _context.Proveedores.ToList();
            comboBoxProveedor.ItemsSource = Proveedores;
            comboBoxProveedor.DisplayMemberPath = "Nombre_proveedor";
            comboBoxProveedor.SelectedValuePath = "ProveedorID";

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

            comboBoxProductoProveedor.ItemsSource = productosConPrecios;
            comboBoxProductoProveedor.DisplayMemberPath = "Nombre_Producto";
            comboBoxProductoProveedor.SelectedValuePath = "ProductoProveedorID";
        }
        private void Cancelar_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void GuardarProducto_click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Verificar que todos los campos estén completos
                if (comboBoxProveedor.SelectedValue == null || comboBoxProductoProveedor.SelectedValue == null ||
                    string.IsNullOrWhiteSpace(txtCategoria.Text) || string.IsNullOrWhiteSpace(txtDescripcionCategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtStockActual.Text) || string.IsNullOrWhiteSpace(txtStockMinimo.Text) ||
                    datePickerFechaCaducidad.SelectedDate == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios antes de guardar el producto.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Obtener datos de los controles
                int proveedorID = (int)comboBoxProveedor.SelectedValue;
                int productoProveedorID = (int)comboBoxProductoProveedor.SelectedValue; // Usar ProductoProveedorID seleccionado
                string nombreCategoria = txtCategoria.Text;
                string descripcionCategoria = txtDescripcionCategoria.Text;
                int stockActual = int.Parse(txtStockActual.Text);
                int stockMinimo = int.Parse(txtStockMinimo.Text);
                DateTime fechaCaducidad = datePickerFechaCaducidad.SelectedDate.Value;


                // Verificar si la categoría ya existe
                var categoriaExistente = _context.Categorias.FirstOrDefault(c => c.Nombre_categoria == nombreCategoria);
                int categoriaID;

                if (categoriaExistente == null)
                {
                    // Crear una nueva categoría
                    var nuevaCategoria = new Categoria
                    {
                        Nombre_categoria = nombreCategoria,
                        Descripcion = descripcionCategoria
                    };

                    _context.Categorias.Add(nuevaCategoria);
                    _context.SaveChanges(); // Guardar para obtener el ID de la categoría

                    categoriaID = nuevaCategoria.CategoriaID;
                }
                else
                {
                    categoriaID = categoriaExistente.CategoriaID;
                }

                // Crear un nuevo producto
                var nuevoProducto = new Productos
                {
                    ProductoProveedorID = productoProveedorID, // Asignar el ProductoProveedorID
                    
                    CategoriaID = categoriaID,
                    stock_actual = stockActual,
                    stock_minimo = stockMinimo,
                    Fecha_caducidad = fechaCaducidad
                };

                _context.Productos.Add(nuevoProducto);
                _context.SaveChanges();

                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButton.OK, MessageBoxImage.Information);

                // Limpiar los campos después de guardar
                comboBoxProveedor.SelectedIndex = -1;
                comboBoxProductoProveedor.SelectedIndex = -1;
                txtCategoria.Clear();
                txtDescripcionCategoria.Clear();
                txtStockActual.Clear();
                txtStockMinimo.Clear();
                datePickerFechaCaducidad.SelectedDate = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void comboBoxProveedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxProveedor.SelectedValue != null)
            {
                int proveedorID = (int)comboBoxProveedor.SelectedValue;

                CargarProductosPorProveedor(proveedorID);
            }
            else
            {

            }
        }

        private void comboBoxProductoProveedor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBoxProductoProveedor.SelectedItem != null)
            {
                var productoSeleccionado = (dynamic)comboBoxProductoProveedor.SelectedItem;


            }
            else
            {

            }
        }
    }
}
