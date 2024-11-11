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

using BCrypt.Net;
using System.Data;
using System.Data.SqlClient;
using Login.ClasesDB;
using Login.Views;
using Microsoft.EntityFrameworkCore;

namespace Login
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Context _context;
        public MainWindow( Context context)
        {
            InitializeComponent();
            _context = context;
        }

        // Constructor sin parámetros (para que App.xaml funcione)
        public MainWindow() : this(new Context())  // Crear un nuevo contexto aquí si es necesario
        {
        }
        private bool VerificarPassword(string enteredPassword, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombreUsuario = txtCorreo.Text;
                string contra = txtPassword.Password;

                // Buscar el usuario en la base de datos
                var usuario = _context.Usuarios
                    .Where(u => u.Nombre_Usuario == nombreUsuario)
                    .FirstOrDefault();

                if (usuario != null)
                {
                    // Verificar la contraseña
                    if (VerificarPassword(contra, usuario.Contraseña))
                    {
                        var rol = _context.Roles
                            .Where(r => r.RolID == usuario.RolID)
                            .FirstOrDefault();

                        var permisos = _context.PermisoRol
                            .Where(pr => pr.RolID == rol.RolID)
                            .Select(pr => pr.Permiso.Descripcion)
                            .ToList();

                        if (rol.Nombre_rol == "Admin")
                        {
                            MessageBox.Show($"Bienvenido Admin, Tienes los siguientes permisos:\n{string.Join("\n", permisos)}");
                            var windowSistema = new WindowSistema();
                            windowSistema.Show();
                            this.Close(); // Cierra la ventana de login (MainWindow)
                        }
                        else if (rol.Nombre_rol == "Vendedor")
                        {
                            MessageBox.Show($"Bienvenido Vendedor, Tienes los siguientes permisos:\n{string.Join("\n", permisos)}");
                            // Aquí podrías abrir otra ventana, o simplemente no hacer nada
                        }
                        else
                        {
                            MessageBox.Show("Rol no reconocido.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("¿Desea salir de la aplicación?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
             {
                Application.Current.Shutdown();
            }
        }

        private void btnCliente_Click(object sender, RoutedEventArgs e)
        {
            var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
            LoginCliente fmr = new LoginCliente(context);
            fmr.Show();
            this.Close();
        }
    }

}


