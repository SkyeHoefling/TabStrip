using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TabStrip.Sample
{
    public class HelloPageModel : PageModelBase
    {

    }

    public class MainPageModel : PageModelBase
    {
        public MainPageModel()
        {
            Tabs = new ObservableCollection<PageModelBase>
            {
                new HelloPageModel(),
                new HelloPageModel(),
                new HelloPageModel()
            };
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
        public ObservableCollection<PageModelBase> Tabs { get; set; }

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
