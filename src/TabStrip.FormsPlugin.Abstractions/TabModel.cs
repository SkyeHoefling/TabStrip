using System;
using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    public class TabModel
    {
        public Tuple<View, object> Header { get; set; }
        
        public Tuple<View, object> View { get; set; }
    }
}
