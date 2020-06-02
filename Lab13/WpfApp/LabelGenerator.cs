using System.Windows;
using System.Windows.Controls;

namespace WpfApp
{
    class LabelGenerator : IControlGenerator
    {

        public FrameworkElement Generate()
        {
            return new Label()
            {
                Content = "Example"
            };
        }
    }
}
