using QuestThemeUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.ViewModels
{
    public class AddressViewModel : BindableBase
    {
        private AddressModel _addressModel;

        private List<string> _countries;

        public AddressViewModel()
        {
            _addressModel = DataStorage.GetAddressModelInstance();
            _countries = new List<string>();

            Countries.Add("USA");
            Countries.Add("China");
            Countries.Add("Australia");
            Countries.Add("United Kingdom");
            Countries.Add("Romania");
            Countries.Add("Brazil");

            // When it's blank Get First fill in
            if (string.IsNullOrEmpty(_addressModel.Country))
            {
                AddressModel.Country = Countries.First();
            }
        }

        public AddressModel AddressModel
        {
            get
            {
                return _addressModel;
            }

            set
            {
                SetProperty(ref _addressModel, value);
            }
        }

        public List<string> Countries
        {
            get
            {
                return _countries;
            }

            set
            {
                SetProperty(ref _countries, value);
            }
        }
    }
}
