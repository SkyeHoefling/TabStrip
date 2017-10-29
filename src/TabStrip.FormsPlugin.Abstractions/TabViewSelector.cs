using System.Collections.Generic;
using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    public class TabViewSelector : DataTemplateSelector
    {
        private readonly IDictionary<string, DataTemplate> _templates;

        public TabViewSelector(IEnumerable<TabModel> tabs)
        {
            _templates = new Dictionary<string, DataTemplate>();
            foreach (var item in tabs)
                _templates.Add(item.Name, new DataTemplate(() => new ContentView { Content = item.View.Item1 }));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {            
            var tab = (TabModel)item;
            return _templates[tab.Name];
        }
    }
}
