using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;
using System.Windows;

namespace Login.Views
{
    internal class CargandoHelp
    {

        public static void MostrarCargando(Window parentWindow, Action onFinish, int segundosEspera = 3)
        {
            // Crear y mostrar la ventana de carga
            Poup cargandoWindow = new Poup();
            cargandoWindow.Owner = parentWindow;
            cargandoWindow.Show();

            // Configuramos un temporizador para el retraso
            DispatcherTimer timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(segundosEspera)
            };

            // Evento que se dispara cuando el temporizador se activa
            timer.Tick += (s, args) =>
            {
                // Detenemos el temporizador
                timer.Stop();

                // Cerramos la ventana de carga
                cargandoWindow.Close();

                // Ejecutamos la acción que se pase como parámetro
                onFinish();
            };

            // Iniciamos el temporizador
            timer.Start();
        }
    }
}
