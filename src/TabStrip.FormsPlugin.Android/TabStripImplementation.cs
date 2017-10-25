using TabStrip.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;
using TabStrip.FormsPlugin.Android;
using Xamarin.Forms.Platform.Android;
using AViews = Android.Views;

// Placeholder code for when we implement xamarin native
//[assembly: ExportRenderer(typeof(TabStrip.FormsPlugin.Abstractions.TabStripControl), typeof(TabStripRenderer))]
namespace TabStrip.FormsPlugin.Android
{
    /// <summary>
    /// TabStrip Renderer
    /// </summary>
    public class TabStripRenderer// :  ViewRenderer<TabStripControl, AViews.View>
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }
    }
}