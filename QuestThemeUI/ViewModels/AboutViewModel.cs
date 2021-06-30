using QuestThemeUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.ViewModels
{
    public class AboutViewModel : BindableBase
    {
        private UserModel _userModel;

        public AboutViewModel()
        {
            _userModel = DataStorage.GetUserModelInstance();
        }

        public UserModel UserModel
        {
            get
            {
                return _userModel;
            }

            set
            {
                SetProperty(ref _userModel, value);
            }
        }

    }
}
