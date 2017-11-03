using System.Collections.ObjectModel;
using TabStrip.FormsPlugin.Abstractions;
using Xamarin.Forms;

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
                        Name = (new HeaderView(), new { Title = "Tab 1" }),
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = (new HeaderView(), new { Title = "Tab 2" }),
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = (new HeaderView(), new { Title = "Tab 3" }),
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = (new HeaderView(), new { Title = "Tab 4" }),
                        View = (new HelloView(), new HelloPageModel())
                    },
                    new TabModel
                    {
                        Name = (new HeaderView(), new { Title = "Tab 5" }),
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
