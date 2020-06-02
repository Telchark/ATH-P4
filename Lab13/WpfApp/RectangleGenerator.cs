using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp
{
    public class RectangleGenerator : IControlGenerator
    {
        public FrameworkElement Generate()
        {
            return new Rectangle()
            {
                Width = 100,
                Height = 10,
                Fill = new SolidColorBrush(Colors.BlueViolet),
                Margin = new Thickness(1, 1, 1, 1)
            };

        }
    }
}
