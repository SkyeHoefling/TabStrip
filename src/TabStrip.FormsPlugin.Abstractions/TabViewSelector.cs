using System.Collections.Generic;
using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    internal class TabViewSelector : DataTemplateSelector
    {
        private readonly IDictionary<View, DataTemplate> _templates;

        public TabViewSelector(IEnumerable<TabModel> tabs)
        {
            _templates = new Dictionary<View, DataTemplate>();
            foreach (var item in tabs)
                _templates.Add(item.Header.View, new DataTemplate(() => 
                    new ContentView
                    {
                        Content = item.View.View,
                        BindingContext = item.View.BindingContext
                    }));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {            
            var tab = (TabModel)item;
            return _templates[tab.Header.View];
        }
    }
}
