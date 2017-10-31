using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabStrip.Sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloView : ContentView
	{
		public HelloView ()
		{
			InitializeComponent ();
		}
	}

    public class HelloPageModel { }
}