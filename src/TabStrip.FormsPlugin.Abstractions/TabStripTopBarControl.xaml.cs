using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.FormsPlugin.Abstractions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabStripTopBarControl : ContentView
	{
		public TabStripTopBarControl()
		{
			InitializeComponent ();
		}

        protected override void OnBindingContextChanged()
        {
            var context = (TabStripControlModel)BindingContext;
            if (context?.Tabs == null) return;

            var grid = new Grid();
            for (int index = 0; index < context.Tabs.Count; index++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
                var view = new ContentView
                {
                    Content = context.Tabs[index].Header.Item1,
                    BindingContext = context.Tabs[index].Header.Item2
                };
                
                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Command = context.SlideToTab;
                tapGestureRecognizer.CommandParameter = Convert.ToString(index);
                view.GestureRecognizers.Add(tapGestureRecognizer);

                grid.Children.Add(view, index, 0);
            }

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(2) });

            var boxView = new BoxView
            {
                HeightRequest = 2,
                BackgroundColor = new Color(0, 0, 0),
                HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true)
            };
            grid.Children.Add(boxView, context.TabPosition, 1);
            boxView.SetBinding(Grid.ColumnProperty, new Binding("TabPosition"));

            Content = grid;
        }
    }
}