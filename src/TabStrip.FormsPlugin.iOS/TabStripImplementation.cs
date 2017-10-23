using TabStrip.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using TabStrip.FormsPlugin.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabStrip.FormsPlugin.Abstractions.TabStripControl), typeof(TabStripRenderer))]
namespace TabStrip.FormsPlugin.iOS
{
    /// <summary>
    /// TabStrip Renderer
    /// </summary>
    public class TabStripRenderer //: TRender (replace with renderer type
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}
