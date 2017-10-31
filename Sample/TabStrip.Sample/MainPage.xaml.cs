using Xamarin.Forms;
using TabStrip.FormsPlugin.Abstractions;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace TabStrip.Sample
{
    public partial class MainPage : ContentPage
	{
        public class Context
        {
            public Context()
            {                
                Data = new ObservableCollection<TabModel>(new[]
                {
                    new TabModel
                    {
                        Name = "Tab 1",
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = "Tab 2",
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = "Tab 3",
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = "Tab 4",
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = "Tab 5",
                        View = (new HelloView(), new HelloPageModel())
                    }
                });
                Position = 2;
                Title = "This is a test title";
            }

            public string Title { get; set; }
            public int Position { get; set; }
            public ObservableCollection<TabModel> Data { get; set; }            
        }

		public MainPage()
		{
			InitializeComponent();
            BindingContext = new Context();
        }
	}
}
