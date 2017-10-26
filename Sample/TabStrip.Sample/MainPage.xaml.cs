using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabStrip.Sample
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            var context = new
            {
                Tabs = new[] { "test", "test1" }
            };

            BindingContext = context;
		}
	}
}
