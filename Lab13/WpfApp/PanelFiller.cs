using System.Windows.Controls;

namespace WpfApp
{
    public class PanelFiller : IPanelFiller
    {
        public IDataProvider _dataProvider { get; set; }
        public IControlGenerator _controlGenerator { get; private set; }

        public PanelFiller(IControlGenerator controlGenerator, IDataProvider data)
        {
            _controlGenerator = controlGenerator;
            _dataProvider = data;
        }

        public void Fill(Panel panel)
        {
            var numer = _dataProvider.GetData();
            for (int i = 0; i < numer; i++)
            {
                panel.Children.Add(_controlGenerator.Generate());
            }
        }
    }
}
