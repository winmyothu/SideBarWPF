using MMDictionary.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MMDictionary.ViewModel
{
    class NavigationVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand HomeCommand { get; set; }
        public ICommand AboutCommand { get; set; }

        private void Home(object obj)=> CurrentView = new HomeVM();
        private void About(object obj)=> CurrentView = new AboutVM();

        public NavigationVM()
        {
            HomeCommand = new RelayCommand(Home);
            AboutCommand = new RelayCommand(About);

            //Startup Page
            CurrentView = new HomeVM();
        }
    }
}
