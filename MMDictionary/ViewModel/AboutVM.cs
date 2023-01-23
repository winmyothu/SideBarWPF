using MMDictionary.Model;
using MMDictionary.Ultilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMDictionary.ViewModel
{
    class AboutVM : ViewModelBase
    {
        private readonly PageModel _pageModel;
        public string PageName
        {
            get { return _pageModel.PageName; }
            set { _pageModel.PageName = value; OnPropertyChanged(); }
        }

        public AboutVM()
        {
            _pageModel = new PageModel();
            PageName = "Welcome About Page";
        }
    }
}
