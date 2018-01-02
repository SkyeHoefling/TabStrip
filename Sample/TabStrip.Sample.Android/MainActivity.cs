using Android.App;
using Android.Content.PM;
using Android.OS;
using TabStrip.FormsPlugin.Android;

namespace TabStrip.Sample.Droid
{
    [Activity (Label = "TabStrip.Sample", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate (bundle);

            TabStripRenderer.Init();
            global::Xamarin.Forms.Forms.Init (this, bundle);
            
			LoadApplication (new TabStrip.Sample.App ());
		}
	}
}

