using System;
using System.Collections;
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

        public static readonly BindableProperty PositionProperty = BindableProperty.Create("Position", typeof(int), typeof(TabStripControl), 0, BindingMode.TwoWay, null, OnPositionChanged);

        private static void OnPositionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (TabStripControl)bindable;
            if (control != null)
            {
                control.Position = (int)newValue;
            }
        }

        public int Position
        {
            get { return (int)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }
    }
}