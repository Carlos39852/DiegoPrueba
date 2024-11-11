using Login.Views;
using System.Threading.Tasks;
using System.Windows;

namespace Login.Clases
{
    internal class Cargando
    {
        private Poup loadingWindow;

        public void ShowLoadingWindow()
        {
            if (loadingWindow == null)
            {
                loadingWindow = new Poup();
                loadingWindow.Show();
            }
        }

        public void CloseLoadingWindow()
        {
            if (loadingWindow != null)
            {
                loadingWindow.Close();
                loadingWindow = null; // Liberar referencia para que se pueda abrir de nuevo
            }
        }

        public async Task LoadAsync(Task task)
        {
            ShowLoadingWindow();
            await task; // Esperar a que la tarea se complete
            CloseLoadingWindow();
        }
    }
}
