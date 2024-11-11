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
using System.Windows.Shapes;

namespace Login.Views
{
    /// <summary>
    /// Lógica de interacción para LoginCliente.xaml
    /// </summary>
    public partial class LoginCliente : Window
    {
        private readonly Context _context;
        public LoginCliente(Context context)
        {
            InitializeComponent();
            _context = context; 
        }

        private void btnRegistrarme_Click(object sender, RoutedEventArgs e)
        {
            var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
            AggCliente frm = new AggCliente(context);
            frm.Show();
            this.Close();
        }

        private void btnUsuario_Click(object sender, RoutedEventArgs e)
        {
            MainWindow fmr = new MainWindow();
            fmr.Show();
            this.Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
