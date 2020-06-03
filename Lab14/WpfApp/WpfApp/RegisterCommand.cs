using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp
{
    public class RegisterCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        private RegistrationModelValidator _validator = new RegistrationModelValidator();

        public bool CanExecute(object parameter)
        {
            var model = parameter as RegistrationModel;
            if(model is null)
            {
                return false;
            }
            var result = _validator.Validate(model);
            model.Errors = string.Join(" ", result.Errors);
            return result.IsValid;
        }

        public void Execute(object parameter)
        {
            var model = parameter as RegistrationModel;
            MessageBox.Show($"Zarejestrowano użytkownika {model.Email}", "Rejestracja pomyślna.", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
