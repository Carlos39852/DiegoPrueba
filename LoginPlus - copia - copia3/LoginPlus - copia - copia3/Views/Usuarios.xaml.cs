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
using BCrypt.Net;
using Login.Clases;


namespace Login.Views
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Page
    {
        private readonly Context _context;
        public Usuarios(Context context)
        {
            InitializeComponent();
            _context = context; 
            //CargarUsuariosConRoles();
            CargarRoles();
            CargarEstados();
            CargarUsuariosActivos();
        }
        //VARIABLE DE ESTADO
        bool Agregando = false, Editando = false, Elimanar = false;

        int usuarioId = 0;//almacenar el ID del usuario 

        #region Metodo de dgUsuarios para poder seleccionar
        private void dgUsuarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgUsuarios.SelectedItem != null)
            {

                var usuarioSeleccionado = (Usuario)dgUsuarios.SelectedItem;
                txtNombre.Text = usuarioSeleccionado.Nombre_Usuario;
                txtClave.Password = string.Empty;

                btnEliminar.Visibility = Visibility.Visible; // Muestra el botón eliminar
                
            }
            else
            {
                btnEliminar.Visibility = Visibility.Collapsed; // Oculta el botón si no hay selección
            }
        }


        #endregion
        #region Metodos, Cargar,Insertar,Eliminar,Actulizar y hashear contras
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);


        }
       

        private void CargarUsuariosActivos() 
        {
            var usuariosActivos = _context.Usuarios
                .Where(u => u.Activo ==true)
                .Include(u=> u.Rol)
                .ToList();
            dgUsuarios.ItemsSource= usuariosActivos;
        }

        private void CargarRoles() 
        {

            var roles = _context.Roles.ToList();
            cmbRol.ItemsSource = roles;
        
        }

        private void InsertarUsuarios() 
        {
            string hashPassword = HashPassword(txtClave.Password);

            var nuevoUsuario = new Usuario
            {
                Nombre_Usuario = txtNombre.Text,
                Contraseña = hashPassword,
                RolID = (int)cmbRol.SelectedValue,
                Activo = ((int)cmbEstado.SelectedValue) == 1,
                Fecha_registro = DateTime.Now

            };

            _context.Usuarios.Add(nuevoUsuario);
            _context.SaveChanges();
            CargarUsuariosActivos();
            LimpiarObjetos();
        }

        private void ActualizarUsuario(Usuario usuario)
        {
            usuario.Nombre_Usuario = txtNombre.Text;
            if(!string.IsNullOrWhiteSpace(txtClave.Password))
            {
                usuario.Contraseña = HashPassword(txtClave.Password);
            }
                btnGuardar.Visibility = Visibility.Visible;
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();

            MessageBox.Show("Usuario actualizado correctamente");
        }
        #endregion

        #region Metodo para comboBox Estado
        private void CargarEstados()
        {
            List<EstadoUsuario> estados = new List<EstadoUsuario>
            {
                new EstadoUsuario { Valor = 1, Descripcion = "Activo" },
          
              };

            cmbEstado.ItemsSource = estados;
            cmbEstado.DisplayMemberPath = "Descripcion";  // Muestra el campo Descripcion en el ComboBox
            cmbEstado.SelectedValuePath = "Valor";        // Guarda el campo Valor en la propiedad seleccionada
        }

        #endregion

        #region Eventos de botonoes
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            //HABILITAR OBJETOS 
            HabilitarObjetos(true);

            //LIMPIAR OBJETOS
            LimpiarObjetos();
            
            //ESTABLECER EL ESTADO 
            Agregando = true;
            Editando = false;
            Elimanar = false;
           


            //CONFIGURAR TOOLBAR 
            ControlToolBar();

            //ENVIAR EL ENFOQUE AL TXTNOMBRE
            txtNombre.Focus();
      
        }


        //Metodo para verificar las contras cuando se esta editando
        bool ValidarFormularioEditar()
        {
            
            bool estado = true;
            string mensaje = string.Empty;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                estado = false;
                mensaje += "Nombre\n";
            }

            if (string.IsNullOrEmpty(txtClave.Password))
            {
                estado = false;
                mensaje += "Contraseña\n";
            }
            if (string.IsNullOrEmpty(txtConfirmacion.Password))
            {
                estado = false;
                mensaje += "Confirmacion contraseña\n";
            }
            if (txtClave.Password != txtConfirmacion.Password)
            {
                estado = false;
                mensaje += "Las contraseñas no coinciden\n";
            }
            // Mostrar el mensaje de error si hay algún problema
            if (!estado) // Mostrar el mensaje si 'estado' es false
            {
                MessageBox.Show("Debe completar o cumplir estos campos:\n" + mensaje,
                   "Validación de Formulario",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

            return estado;

        }
            private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {

            if (Editando && dgUsuarios.SelectedItem != null) // Verificar si estamos editando
            {
                var usuarioSeleccionado = (Usuario)dgUsuarios.SelectedItem;

                // Validar que no haya valores nulos
                if (usuarioSeleccionado != null && !string.IsNullOrWhiteSpace(txtNombre.Text) && ValidarFormularioEditar() )
                {
                    ActualizarUsuario(usuarioSeleccionado); // Actualizar usuario
                    Editando = false; // Cambiar estado
                   
                    HabilitarObjetos(false); // Deshabilitar campos
                    LimpiarObjetos(); // Limpiar formulario
                    CargarUsuariosActivos(); // Refrescar lista
                    Window_Loaded(sender,e);
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos necesarios.");
                }
            }
            else // Modo agregar
            {
                if (ValidarFormulario())
                {
                    InsertarUsuarios(); // Insertar nuevo usuario
                    Agregando = false;
                    HabilitarObjetos(false); // Deshabilitar campos
                    LimpiarObjetos(); // Limpiar formulario
                    CargarUsuariosActivos(); // Refrescar lista
                    MessageBox.Show("Usuario agregado correctamente");
                    Window_Loaded(sender, e);
                 
                }
                else
                {
                    
                }
            }

        }

        #region METODO PARA OCULTAR CMBROL Y ESTADO CUANDO SE ESTE EDITANDO
        private void OculatarCosas() 
        {
            cmbEstado.Visibility = Visibility.Collapsed;
            cmbRol.Visibility = Visibility.Collapsed;
            btnEliminar.Visibility = Visibility.Collapsed;
            btnNuevo.Visibility = Visibility.Collapsed;
            btnCancelar.Visibility = Visibility.Visible;
            btnGuardar.Visibility = Visibility.Visible;

        }

        #endregion
        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (dgUsuarios.SelectedItem != null) // Verifica que haya un usuario seleccionado
            {
                var usuarioSeleccionado = (Usuario)dgUsuarios.SelectedItem;

                // Llenar los campos con la información del usuario seleccionado
                txtNombre.Text = usuarioSeleccionado.Nombre_Usuario;
                txtClave.Password = string.Empty; // No mostrar la contraseña por seguridad
                OculatarCosas();
                //ControlToolBar();
                // Habilitar los campos para permitir edición
                HabilitarObjetos(true);

                // Cambiar el estado de edición
                Editando = true;
                Agregando = false;
                Elimanar = false;
                // Cambiar el texto del botón Guardar para indicar que se está en modo edición
               
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para editar.");
            }

            //LimpiarObjetos();
            //ValidarFormulario();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (dgUsuarios.SelectedItem != null)
            {
                var usuarioSeleccionado = (Usuario)dgUsuarios.SelectedItem;

                // Confirmar antes de eliminar
                var resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario {usuarioSeleccionado.Nombre_Usuario}?",
                    "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                if (resultado == MessageBoxResult.Yes)
                {
                    usuarioSeleccionado.Activo = false;
                    _context.Usuarios.Update(usuarioSeleccionado);
                    _context.SaveChanges();

                    CargarUsuariosActivos(); // Recargar la lista
                    MessageBox.Show($"Usuario {usuarioSeleccionado.Nombre_Usuario} eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            // PEDIR CONFIRMACION
            if (MessageBox.Show("¿Desea cancelar la operación?", "Confirmación", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                LimpiarObjetos();
                HabilitarObjetos(false);

                // ESTABLECER ESTADO DE EDITANDO EN FALSE
                Editando = false;
                Agregando = false;

                // CONFIGURAR EL TOOLBAR
                ControlToolBar();
            }
        }
        #endregion
        void HabilitarObjetos(bool accion)
        {
            UIElement[] controls = new UIElement[]
            {
        txtNombre,
        txtClave,
        txtConfirmacion,
        cmbRol,
        cmbEstado

       
            };

            foreach (var control in controls)
            {
                control.IsEnabled = accion;
            }
        }
        //METODO DE LIMPIEZA OBJETOS 
        void LimpiarObjetos()
        {
            txtNombre.Clear();
            txtClave.Clear();
            txtConfirmacion.Clear();
            cmbRol.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;

            cmbRol.Visibility = Visibility.Visible;
            cmbEstado.Visibility = Visibility.Visible;

            btnEliminar.Visibility = Visibility.Hidden;

         
            Editando = false;
            Agregando = false;
            Elimanar = false;

        }
        bool ValidarFormulario()
        {
            bool estado = true;
            string mensaje = string.Empty;

            // Validar los campos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                estado = false;
                mensaje += "Nombre\n";
            }
       
            if (string.IsNullOrEmpty(txtClave.Password))
            {
                estado = false;
                mensaje += "Contraseña\n";
            }
            if (string.IsNullOrEmpty(txtConfirmacion.Password))
            {
                estado = false;
                mensaje += "Confirmacion contraseña\n";
            }
            if(txtClave.Password != txtConfirmacion.Password)
            {
                estado = false;
                mensaje += "Las contraseñas no coinciden\n";
            }
            if(cmbRol.SelectedIndex==-1)
            {
                estado = false;
                mensaje += "Rol\n";
            }
            if (cmbEstado.SelectedIndex == -1) 
            {
                estado = false;
                mensaje += "Estado\n";
            }
          
            // Mostrar el mensaje de error si hay algún problema
            if (!estado) // Mostrar el mensaje si 'estado' es false
            {
                MessageBox.Show("Debe completar o cumplir estos campos:\n" + mensaje,
                   "Validación de Formulario",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error);
            }

            return estado;
        }


        //METODO PARA CPNTROLAR EL TOOLBAR
        #region METODO PARA CPNTROLAR EL TOOLBAR
        void ControlToolBar()
        {

            if (dgUsuarios.Items.Count == 0)
            {
                btnNuevo.Visibility = Visibility.Visible;
                btnGuardar.Visibility = Visibility.Collapsed;
                btnEditar.Visibility = Visibility.Collapsed;
                btnCancelar.Visibility = Visibility.Collapsed;
                btnEliminar.Visibility = Visibility.Collapsed;
            }
            else
            {
                //SI EL DATAGRID TIENE 1 REGISTRO 
                btnNuevo.Visibility = Visibility.Visible;
                btnGuardar.Visibility = Visibility.Collapsed;
                btnEditar.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Collapsed;
                btnEliminar.Visibility = Visibility.Collapsed;

            }

            if (Agregando || Editando == true)
            {
                //SI ESTOY AGG O EDITANDO UN REGISTRO 
                btnGuardar.Visibility = Visibility.Visible;
                btnCancelar.Visibility = Visibility.Visible;
                btnNuevo.Visibility = Visibility.Collapsed;
                btnEditar.Visibility = Visibility.Collapsed;
                btnEliminar.Visibility = Visibility.Collapsed;
            }
        }
        #endregion
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //DESHABILITAR USUARIOS
            HabilitarObjetos(false);
            Editando = false;
            Elimanar = false;
            Agregando = false;
            //MOSTRAR USUARIOS
            //............/
            //HABILITAR BOTONES
            ControlToolBar();
        }


    }
}
