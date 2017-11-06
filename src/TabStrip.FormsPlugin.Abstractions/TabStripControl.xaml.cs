using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.FormsPlugin.Abstractions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabStripControl : ContentView
    {
        public TabStripControlModel ViewModel { get; set; }
        public TabStripControl()
        {
            InitializeComponent();
            Position = 0;

            ViewModel = new TabStripControlModel();
        }

        public static readonly BindableProperty LeftArrowProperty = BindableProperty.Create(
            "LeftArrow",
            typeof(ImageSource),
            typeof(TabStripControl),
            ImageSource.FromResource("TabStrip.FormsPlugin.Abstractions.left_arrow.png", Assembly.GetExecutingAssembly()),
            BindingMode.Default);

        public ImageSource LeftArrow
        {
            get { return (ImageSource)GetValue(LeftArrowProperty); }
            set { SetValue(LeftArrowProperty, value); }
        }

        public static readonly BindableProperty RightArrowProperty = BindableProperty.Create(
            "RightArrow",
            typeof(ImageSource),
            typeof(TabStripControl),
            ImageSource.FromResource("TabStrip.FormsPlugin.Abstractions.right_arrow.png", Assembly.GetExecutingAssembly()),
            BindingMode.Default);

        public ImageSource RightArrow
        {
            get { return (ImageSource)GetValue(RightArrowProperty); }
            set { SetValue(RightArrowProperty, value); }
        }

        public static readonly BindableProperty PositionProperty = BindableProperty.Create(
            "Position",
            typeof(int),
            typeof(TabStripControl),
            0,
            BindingMode.TwoWay,
            null,
            OnPositionChanged);

        private static void OnPositionChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (TabStripControl)bindable;
            if (control != null)
            {
                control.ViewModel.TabPosition = (int)newValue;
            }
        }

        public int Position
        {
            get { return (int)GetValue(PositionProperty); }
            set { SetValue(PositionProperty, value); }
        }

        public static readonly BindableProperty ItemsSourceProperty = BindableProperty.Create(
            "ItemsSource",
            typeof(IEnumerable),
            typeof(TabStripControl),
            null,
            propertyChanged: OnItemsSourceChanged);

        private static void OnItemsSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (TabStripControl)bindable;

            if (control != null)
            {
                var tabs = (IEnumerable<TabModel>)newValue;
                control.Carousel.ItemTemplate = new TabViewSelector(tabs);
                control.ViewModel.Tabs = new ObservableCollection<TabModel>(tabs);
            }
        }

        public IEnumerable ItemsSource
        {
            get { return (IEnumerable)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }
    }
}