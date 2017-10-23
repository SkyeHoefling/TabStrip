using TabStrip.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using TabStrip.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(TabStrip.FormsPlugin.Abstractions.TabStripControl), typeof(TabStripRenderer))]
namespace TabStrip.FormsPlugin.Android
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