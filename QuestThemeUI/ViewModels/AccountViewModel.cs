using QuestThemeUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.ViewModels
{
    public class AccountViewModell : BindableBase
    {
        private string _profession;

        public AccountViewModell()
        {
            _profession = DataStorage.Profession;
        }

        public string Profession
        {
            get
            {
                return _profession;
            }

            set
            {
                SetProperty(ref _profession, value);
            }
        }
    }
}
