using System;
using System.Windows;
using System.Windows.Controls;
using Login; // Agregar esto si MainWindow está en el espacio de nombres Login
using Login.ClasesDB;
using Login.Views;
using System.Windows.Input;
using System.Linq;
using Microsoft.Xaml.Behaviors.Media;
using System.Text;




namespace Login.Views
{
    /// <summary>
    /// Lógica de interacción para AggCliente.xaml
    /// </summary>
    public partial class AggCliente : Window
    {
        private readonly Context _context;
        public AggCliente(Context context)
        {
            InitializeComponent();
            _context = context;
            // Suscribir eventos d
            txtNombre.TextChanged += ValidateForm;
            txtEmail.TextChanged += ValidateForm;
            txtClave.PasswordChanged += ValidateForm;
            txtConfirmacion.PasswordChanged += ValidateForm;
            comboDepartamento.SelectionChanged += ValidateForm; // 
            comboMunicipio.SelectionChanged += ValidateForm;   
            txtTarjeta.TextChanged += ValidateForm;
            CargarDepartamentos();
        }

        #region Metodos para mostrar Departamentos y municipios, metodo para insertar clientes
        private void CargarDepartamentos()
        {
            var departamentos = _context.Departamentos.ToList();
            comboDepartamento.ItemsSource = departamentos;
            comboDepartamento.DisplayMemberPath = "Depar";
            comboDepartamento.SelectedValuePath = "DepartamentosID";
        
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);


        }
        public  bool ValidarTarjeta( string numeroTarjeta)
        {

            numeroTarjeta = numeroTarjeta.Replace(" ", "").Trim();

            // Validar que la cadena solo contenga dígitos
            if (!numeroTarjeta.All(char.IsDigit))
            {
                throw new FormatException("El número de tarjeta contiene caracteres no válidos.");
            }

            int suma = 0;
            bool esSegundoDígito = false;

            for (int i = numeroTarjeta.Length - 1; i >= 0; i--)
            {
                int digito = int.Parse(numeroTarjeta[i].ToString());

                if (esSegundoDígito)
                {
                    digito *= 2;
                    if (digito > 9)
                    {
                        digito -= 9;
                    }
                }

                suma += digito;
                esSegundoDígito = !esSegundoDígito;
            }

            return (suma % 10 == 0);


        }

        private int InsertarDireccion()
        {
            // Validar que los ComboBox y el TextBox no estén vacíos
            if (comboDepartamento.SelectedValue != null && comboMunicipio.SelectedValue != null && !string.IsNullOrEmpty(txtCalle.Text))
            {
                int departamentoId = (int)comboDepartamento.SelectedValue;
                int municipioId = (int)comboMunicipio.SelectedValue;
                string calle = txtCalle.Text.Trim();

                // Crear una nueva instancia de la clase Direccion
                var nuevaDireccion = new Direccion
                {
                    DepartamentosID = departamentoId,
                    MunicipioID = municipioId,
                    Calle = calle
                };

                // Agregar y guardar la nueva dirección en la base de datos
                _context.Direccion.Add(nuevaDireccion);
                _context.SaveChanges();

                // Retornar el ID de la nueva dirección
                return nuevaDireccion.DireccionID;
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos de la dirección.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return -1; // Devuelve -1 en caso de que la validación falle
            }
        }

        public int GuardarTarjetaCredito(string numeroTarjeta, string cvv, string fechaExpiracion)
        {
            if (ValidarTarjeta(numeroTarjeta))
            {
                var nuevaTarjeta = new TarjetaCredito
                {
                    Num_Tarjeta = numeroTarjeta,
                    CVC = cvv,
                    Fecha_Vencimiento = DateTime.Parse(fechaExpiracion)

                };

                _context.Tarjetas_Credito.Add(nuevaTarjeta);
                _context.SaveChanges();
                MessageBox.Show("Tarjeta guardada exitosamente");
                return nuevaTarjeta.TarjetaID;

            }
            else
            {
                MessageBox.Show("Numero de tarjeta invalido. Verifique los datos e intente nuevamente.");
                return -1;
            }
     
        }

        private void insertarCliente()
        {
            string hashPassword = HashPassword(txtClave.Password);
            string numeroTarjeta = txtTarjeta.Text;
            string cvv = txtCVV.Text;
            string fechaExpiracion = $"{txtYear.Text}/{txtMonth.Text}";
            int tarjetaID = GuardarTarjetaCredito(numeroTarjeta, cvv, fechaExpiracion);

            if (tarjetaID != -1)
            {
                int direccionID = InsertarDireccion();
                if (direccionID != -1)
                {
                    string nombre = txtNombre.Text;
                    string email = txtEmail.Text;
                    string contra = hashPassword;
                    string telefono = txtTelefono.Text;

                    var nuevoCliente = new Cliente
                    {
                        Nombre_cliente = nombre,
                        Email = email,
                        Contraseña = contra,
                        Telefono = telefono,
                        DireccionID = direccionID, // Usar el ID de la dirección insertada
                        TarjetaID = tarjetaID
                    };

                    _context.Clientes.Add(nuevoCliente);
                    _context.SaveChanges();
                    MessageBox.Show("Cliente registrado exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar la dirección.");
                }
            }
            else
            {
                MessageBox.Show("Error al guardar el cliente debido a la tarjeta inválida.");
            }
        }

        #endregion

        #region metodos para validar correo y datos 
        private bool ValidarDatos()
        {
            bool esValido = true;
            StringBuilder mensajeError = new StringBuilder();

            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                esValido = false;
                mensajeError.AppendLine("El nombre no puede estar vacío.");
            }

            if (string.IsNullOrEmpty(txtEmail.Text) || !EsCorreoValido(txtEmail.Text))
            {
                esValido = false;
                mensajeError.AppendLine("Ingrese un correo electrónico válido.");
            }

            if (string.IsNullOrEmpty(txtTarjeta.Text))
            {
                esValido = false;
                mensajeError.AppendLine("El número de tarjeta no puede estar vacío.");
            }
            if (string.IsNullOrEmpty(txtCVV.Text))
            {
                esValido = false;
                mensajeError.AppendLine("El numero de seguridad no puede estar vacio");
            }

            if (string.IsNullOrEmpty(txtYear.Text))
            {
                esValido = false;
                mensajeError.AppendLine("El año no puede estar vacio");
            }

            if(string.IsNullOrEmpty(txtMonth.Text))
            {
                esValido = false;
                mensajeError.AppendLine("El mes no puede estar vacio");

            }

            if (!esValido)
            {
                MessageBox.Show("Errores de validación:\n" + mensajeError.ToString(), "Validación de datos", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return esValido;
        }

        #region limpiar Datos
        private void LimpiarObjetosClientes()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtClave.Clear();
            txtConfirmacion.Clear();
            comboDepartamento.SelectedIndex = -1;
            comboMunicipio.SelectedIndex = -1;
            txtCalle.Clear();
            txtTarjeta.Clear();
            txtCVV.Clear();
            txtYear.Clear();
            txtMonth.Clear();
            txtTelefono.Clear();
        }


        #endregion

        // Método para validar formato de correo electrónico
        private bool EsCorreoValido(string correo)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(correo);
                return addr.Address == correo;
            }
            catch
            {
                return false;
            }
        }




        #endregion
        private void ValidateForm(object sender, RoutedEventArgs e)
        {
            // Asegúrate de que 'sender' es un TextBox antes de acceder a su propiedad Text
            if (sender is TextBox txtBox)
            {
                BtnRegistar.IsEnabled =
                    !string.IsNullOrWhiteSpace(txtNombre.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(txtClave.Password) &&
                    !string.IsNullOrWhiteSpace(txtConfirmacion.Password) &&
                    !string.IsNullOrWhiteSpace(comboDepartamento.Text) &&
                    !string.IsNullOrWhiteSpace(comboMunicipio.Text) &&
                    !string.IsNullOrWhiteSpace(txtTarjeta.Text) &&
                    comboDepartamento.SelectedItem != null &&
                    comboMunicipio.SelectedItem != null;
            }
        }






        #region botones y txt para la vista del usuario
        private void BtnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            // Verificar si las contraseñas coinciden antes de proceder
            if (txtClave.Password != txtConfirmacion.Password)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if (ValidarDatos())
            {
                
                insertarCliente();
                LimpiarObjetosClientes();
                MessageBox.Show("Registro exitoso", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                LoginCliente loginCliente = new LoginCliente(context);
                loginCliente.Show();
                this.Close();

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("¿Seguro quieres cancelar el registro?", "Confirmación", MessageBoxButton.OKCancel , MessageBoxImage.Question);

            if (result == MessageBoxResult.OK)
            {
                var context = new Context(new Microsoft.EntityFrameworkCore.DbContextOptions<Context>());
                LoginCliente frm = new LoginCliente(context);
                frm.Show();

                // Cerrar la ventana actual (AggCliente)
                this.Close();
            }
            else
            {
                
            }
        }

        private void txtTarjeta_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            // Solo permitir números
            e.Handled = !char.IsDigit(e.Text, 0);
        }

        private void txtTarjeta_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Obtener el texto actual sin espacios
            string input = txtTarjeta.Text.Replace(" ", "");

            // Formatear el texto para agregar espacios cada 4 dígitos
            if (input.Length > 0)
            {
                input = string.Join(" ", Enumerable.Range(0, (input.Length + 3) / 4)
                                                     .Select(i => input.Substring(i * 4, Math.Min(4, input.Length - i * 4))));
            }

            // Asignar el texto formateado
            txtTarjeta.Text = input;

            // Mover el cursor al final del texto
            txtTarjeta.SelectionStart = txtTarjeta.Text.Length;
        }

        private void txtCVV_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir solo números
            e.Handled = !char.IsDigit(e.Text, 0);  // Si no es un dígito, cancela la entrada
        }

        private void txtYear_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir solo números
            e.Handled = !char.IsDigit(e.Text, 0);  // Si no es un dígito, cancela la entrada
        }

        private void txtMonth_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Permitir solo números
            e.Handled = !char.IsDigit(e.Text, 0);  // Si no es un dígito, cancela la entrada
        }
        #endregion 
        #region MetodoPara seleccionar el departamento y que muestre los municipios
        private void comboDepartamentoEvent(object sender, SelectionChangedEventArgs e)
        {
            if (comboDepartamento.SelectedValue != null)
            {
             

                int departamentoId;
                if (int.TryParse(comboDepartamento.SelectedValue.ToString(), out departamentoId))
                {
           

                    var municipios = _context.Municipios
                        .Where(m => m.DepartamentosID == departamentoId)
                        .ToList();
                    comboMunicipio.ItemsSource = municipios;
                    comboMunicipio.DisplayMemberPath = "NombreMunicipio";
                    comboMunicipio.SelectedValuePath = "MunicipioID";
                }
                else
                {
                   
                }
            }
            else
            {
               
            }
            #endregion

        }
    }
}
