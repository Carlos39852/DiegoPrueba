using Login.Clases;
using Login.ClasesDB;
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
    /// Lógica de interacción para WindowSistema.xaml
    /// </summary>
    public partial class WindowSistema : Window
    {
        
        public WindowSistema()
        {
            InitializeComponent();
            
        }

       

        private void BtnProductos_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si la página actual no es la página de gestión de inventario
            if (!(MainFrame.Content is GestionProduc))
            {
                // Solo muestra el popup si no estamos ya en la página de gestión de inventario
                CargandoHelp.MostrarCargando(this, () =>
                {
                    var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                    MainFrame.Navigate(new GestionProduc(context));
                });
            }

        }

        private void BtnStockMinimo_Click(object sender, RoutedEventArgs e)
        {
            // Crear una instancia de la página `GestionInventario`
            var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
            GestionInventario gestionInventarioPage = new GestionInventario(context);

            // Navegar a la página dentro del `Frame` llamado `MainFrame`

            // Seleccionar el `TabItemStockMinimo` después de la navegación
            gestionInventarioPage.Loaded += (s, args) =>
            {
                gestionInventarioPage.SelectStockMinimoTab();
            };
            CargandoHelp.MostrarCargando(this, () =>
            {
                MainFrame.Navigate(gestionInventarioPage);
            });
        }

        private void BtnCompras_Click(object sender, RoutedEventArgs e)
        {

            // Verifica si la página actual no es la página de gestión de inventario
            if (!(MainFrame.Content is GestionVentas))
            {
                // Solo muestra el popup si no estamos ya en la página de gestión de inventario
                CargandoHelp.MostrarCargando(this, () =>
                {
                    MainFrame.Navigate(new GestionVentas());
                });
            }
        }

        private void BtnProveedores_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si la página actual no es la página de gestión de inventario
            if (!(MainFrame.Content is GestionInventario))
            {
                // Solo muestra el popup si no estamos ya en la página de gestión de inventario
                CargandoHelp.MostrarCargando(this, () =>
                {
                    var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                    MainFrame.Navigate(new GestionInventario(context));
                });
            }
        }

       /* private void BtnOrdenesPedido_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si la página actual no es la página de gestión de inventario
            if (!(MainFrame.Content is OrdenesPedido))
            {
                // Solo muestra el popup si no estamos ya en la página de gestión de inventario
                CargandoHelp.MostrarCargando(this, () =>
                {
                    MainFrame.Navigate(new OrdenesPedido());
                });
            }
        }
       */
        private void BtnSolicitudMedicamentos_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si la página actual no es la página de gestión de inventario
            if (!(MainFrame.Content is NuevOrdnPedido))
            {
                // Solo muestra el popup si no estamos ya en la página de gestión de inventario
                CargandoHelp.MostrarCargando(this, () =>
                {
                    var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                    MainFrame.Navigate(new NuevOrdnPedido(context));
                });
            }
        }

        private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            // Verifica si la página actual no es la página de gestión de inventario
            if (!(MainFrame.Content is Usuarios))
            {
                // Solo muestra el popup si no estamos ya en la página de gestión de inventario
                CargandoHelp.MostrarCargando(this, () =>
                {
                    var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                    MainFrame.Navigate(new Usuarios(context));
                });
            }
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {

        }*/

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            var dialogo = new ConfirmationDialog();
            var viewModel = new ConfirmationDialogViewModel();
            dialogo.DataContext = viewModel;

            var window = new Window
            {
                Content = dialogo,
                WindowStartupLocation = WindowStartupLocation.CenterScreen,
                
                ResizeMode = ResizeMode.NoResize,
                Width = 400,
                Height = 200,
                Title = ""
            };

            viewModel.Closed += (confirmed) =>
            {
                if (confirmed)
                {
                    // Lógica para cerrar sesión
                    var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                    MainWindow mainWindow = new(context);
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    // Cancelar acción
                }

                // Cerrar el diálogo
                window.Close();
            };
            window.ShowDialog();
        }
    }
}
