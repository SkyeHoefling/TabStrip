using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.FormsPlugin.Abstractions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabStripControl : ContentView, INotifyPropertyChanged
    {
        public TabStripControl(bool init) { }

        public TabStripControl()
        {
            InitializeComponent();
            BindingContext = new TabStripControlModel();
        }

        public static readonly BindableProperty PositionProperty = BindableProperty.Create("Position", typeof(int), typeof(TabStripControl), 0, BindingMode.TwoWay, null, OnPositionChanged);

        private static void OnPositionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (TabStripControl)bindable;
            
            if (control != null)
            {                   
                (control.BindingContext as TabStripControlModel).TabPosition = (int)newValue;
            }
        }

        public int Position
        {
            get { return (int)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }
    }
}