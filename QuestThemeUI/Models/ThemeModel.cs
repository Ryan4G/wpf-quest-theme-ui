using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace QuestThemeUI.Models
{
    public class ThemeModel : BindableBase
    {
        private string _themePicture;
        private string _themeTitle;

        public ThemeModel()
        {

        }

        public string ThemePicture { get { return _themePicture; } set { SetProperty(ref _themePicture, value); } }
        public string ThemeTitle { get { return _themeTitle; } set { SetProperty(ref _themeTitle, value); } }
    }
}
