using CarouselView.FormsPlugin.Abstractions;
using System;
using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    /// <summary>
    /// TabStrip Interface
    /// </summary>
    public class TabStripControl : CarouselViewControl
    {
        //example of custom property
        /// <summary>
        /// Thickness property of border
        /// </summary>
        //public static readonly BindableProperty BorderThicknessProperty =
        //  BindableProperty.Create<TabStripImage, int>(
        //    p => p.BorderThickness, 0);

        /// <summary>
        /// Border thickness of circle image
        /// </summary>
        //public int BorderThickness
        //{
        //  get { return (int)GetValue(BorderThicknessProperty); }
        //  set { SetValue(BorderThicknessProperty, value); }
        //}
    }
}
