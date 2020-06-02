using System.Windows;

namespace WpfApp
{
    public interface IControlGenerator
    {
        FrameworkElement Generate();
    }
}
