using TabStrip.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using TabStrip.FormsPlugin.iOS;
using Xamarin.Forms.Platform.iOS;
using UIKit;

// Placeholder code for when we implement xamarin native
//[assembly: ExportRenderer(typeof(TabStrip.FormsPlugin.Abstractions.TabStripControl), typeof(TabStripRenderer))]
namespace TabStrip.FormsPlugin.iOS
{
    /// <summary>
    /// TabStrip Renderer
    /// </summary>
    public class TabStripRenderer //: ViewRenderer<TabStripControl, UIView>
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}
