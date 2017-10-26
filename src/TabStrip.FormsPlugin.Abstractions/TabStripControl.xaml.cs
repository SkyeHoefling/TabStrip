using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.FormsPlugin.Abstractions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabStripControl : ContentView
    {
        public TabStripControl(bool init) { }

        public TabStripControl()
        {
            InitializeComponent();
            BindingContext = new TabStripControlModel();
        }
    }
}