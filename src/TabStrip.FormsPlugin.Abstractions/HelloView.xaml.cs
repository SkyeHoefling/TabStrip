using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.FormsPlugin.Abstractions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloView : ContentView
	{
		public HelloView ()
		{
			InitializeComponent ();
		}
	}
}