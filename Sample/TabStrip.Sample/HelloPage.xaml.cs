using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.Sample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloPage : ContentPage
	{
		public HelloPage ()
		{
			InitializeComponent ();
            BindingContext = new HelloPageModel();
		}
	}
}