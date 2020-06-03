using System.Windows.Input;

namespace WpfApp
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            Registration = new RegistrationModel();
            RegisterCommand = new RegisterCommand();
        }
        public RegistrationModel Registration { get; set; }
        public ICommand RegisterCommand { get; set; }
    }
}
