using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    public class TabModel
    {
        public (View View, object BindingContext) Header { get; set; }
        
        public (View View, object BindingContext) View { get; set; }
    }
}
