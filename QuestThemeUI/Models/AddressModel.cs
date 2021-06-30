using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.Models
{
    public class AddressModel : BindableBase
    {
        private string _country = string.Empty;
        private string _city = string.Empty;
        private string _streetName = string.Empty;
        private string _streetNumber = string.Empty;

        public string Country
        {
            get
            {
                return _country;
            }

            set
            {
                SetProperty(ref _country, value);
            }
        }

        public string City
        {
            get
            {
                return _city;
            }

            set
            {
                SetProperty(ref _city, value);
            }
        }

        public string StreetName
        {
            get
            {
                return _streetName;
            }

            set
            {
                SetProperty(ref _streetName, value);
            }
        }

        public string StreetNumber
        {
            get
            {
                return _streetNumber;
            }

            set
            {
                SetProperty(ref _streetNumber, value);
            }
        }
    }
}
