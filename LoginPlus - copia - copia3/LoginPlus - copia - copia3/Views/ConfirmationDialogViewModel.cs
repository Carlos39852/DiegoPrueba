using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Login.Clases;

namespace Login.Views
{
    public class ConfirmationDialogViewModel
    {

        public ICommand ConfirmCommand { get; }
        public ICommand CloseCommand { get; }

        public event Action<bool> Closed;

        public ConfirmationDialogViewModel()
        {
            ConfirmCommand = new RelayCommand(OnConfirm);
            CloseCommand = new RelayCommand(OnClose);
        }

        private void OnConfirm()
        {
            Closed?.Invoke(true);
        }

        private void OnClose()
        {
            Closed?.Invoke(false);
        }

    }
}
