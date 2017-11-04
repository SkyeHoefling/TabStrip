using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    public class TabModel
    {
        public (View, object) Header { get; set; }

        private (View, object) _view;
        public (View, object) View
        {
            get { return _view; }
            set
            {
                _view = value;
                _view.Item1.BindingContext = _view.Item2;
            }
        }
    }
}
