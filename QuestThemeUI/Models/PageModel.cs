using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.Models
{
    public class PageModel : BindableBase
    {
        private bool _showPrevious = false;
        private bool _showNext = true;
        private string _currentPagePath = "";
        private int _currentPageIndex = 0;
        private string _nextBtnContent = "NEXT"; 

        public bool ShowPrevious
        {
            get { return _showPrevious; }
            set {
                SetProperty(ref _showPrevious, value);
            }
        }

        public bool ShowNext
        {
            get { return _showNext; }
            set
            {
                SetProperty(ref _showNext, value);
            }
        }

        public string CurrentPagePath
        {
            get { return _currentPagePath; }
            set
            {
                SetProperty(ref _currentPagePath, value);
            }
        }

        public int CurrentPageIndex
        {
            get { return _currentPageIndex; }
            set
            {
                SetProperty(ref _currentPageIndex, value);
            }
        }

        public string NextBtnContent
        {
            get { return _nextBtnContent; }
            set
            {
                SetProperty(ref _nextBtnContent, value);
            }
        }
    }

}
