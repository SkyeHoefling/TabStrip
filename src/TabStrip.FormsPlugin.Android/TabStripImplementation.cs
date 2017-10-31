using CarouselView.FormsPlugin.Android;
using TabStrip.FormsPlugin.Abstractions;

// commenting out renderer code while we work in Xamarin.Forms MVP
//[assembly: ExportRenderer(typeof(TabStrip.FormsPlugin.Abstractions.TabStripControl), typeof(TabStripRenderer))]
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
        public static void Init()
        {
            CarouselViewRenderer.Init();
            var dummy = new TabStripControl();
        }
    }
}