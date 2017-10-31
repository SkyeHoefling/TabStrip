using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace TabStrip.FormsPlugin.Abstractions
{
    public class HelloPageModel : PageModelBase { }
    public class TabStripControlModel : PageModelBase
    {
        public TabStripControlModel()
        {
            Tabs = new ObservableCollection<TabModel>();
            TabPosition = 0;
            SlideTab = new Command<string>(OnSlideTab);
            SlideToTab = new Command<string>(OnSlideToTab);
        }

        public ICommand SlideTab { get; set; }
        public ICommand SlideToTab { get; set; }

        private bool _hasNext;
        public bool HasNext
        {
            get { return _hasNext; }
            set
            {
                _hasNext = value;
                RaisePropertyChanged(nameof(HasNext));
            }
        }

        private bool _hasPrevious;
        public bool HasPrevious
        {
            get { return _hasPrevious; }
            set
            {
                _hasPrevious = value;
                RaisePropertyChanged(nameof(HasPrevious));
            }
        }

        private ObservableCollection<TabModel> _tabs;
        public ObservableCollection<TabModel> Tabs
        {
            get { return _tabs; }
            set
            {
                _tabs = value;
                RaisePropertyChanged(nameof(Tabs));
            }
        }

        private int _tabPosition;
        public int TabPosition
        {
            get { return _tabPosition; }
            set
            {
                _tabPosition = value;
                HasPrevious = TabPosition > 0;
                HasNext = TabPosition < Tabs.Count - 1;
                RaisePropertyChanged(nameof(TabPosition));
            }
        }

        private void OnSlideTab(string direction)
        {
            var tabModifier = int.Parse(direction);
            TabPosition += tabModifier;
        }

        private void OnSlideToTab(string position)
        {
            TabPosition = int.Parse(position);
        }
    }
}
