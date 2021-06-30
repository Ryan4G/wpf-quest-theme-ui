using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.Models
{
    public static class DataStorage
    {
        private static UserModel _userModel;

        private static AddressModel _addressModel;

        public static string Profession { get; set; }

        static DataStorage()
        {
            _userModel = new UserModel();

            _addressModel = new AddressModel();
        }

        public static UserModel GetUserModelInstance()
        {
            return _userModel;
        }

        public static AddressModel GetAddressModelInstance()
        {
            return _addressModel;
        }
    }
}
