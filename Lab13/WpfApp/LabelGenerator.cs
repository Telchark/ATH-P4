using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
