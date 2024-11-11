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
    /// Lógica de interacción para GestionProduc.xaml
    /// </summary>
    public partial class GestionProduc : Page
    {
        private readonly Context _context;
        public GestionProduc(Context context)
        {
            InitializeComponent();
            _context = context;
            CargarProductos();
        }
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

        private void EliminarProveedor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
            AggProducto proveedorForm = new AggProducto(context);
            proveedorForm.Show();
        }
    }
}
