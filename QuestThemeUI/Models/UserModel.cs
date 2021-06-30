using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestThemeUI.Models
{
    public class UserModel : BindableBase
    {
        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _email = string.Empty;

        [Required(ErrorMessage = "Please enter your First Name")]
        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this)
                {
                    MemberName = nameof(FirstName)
                });

                SetProperty(ref _firstName, value);
            }
        }

        [Required(ErrorMessage = "Please enter your Last Name")]
        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this)
                {
                    MemberName = nameof(LastName)
                });

                SetProperty(ref _lastName, value);
            }
        }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@(?!.*\.\..*)[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$", ErrorMessage = "Please enter a valid email address")]
        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                Validator.ValidateProperty(value, new ValidationContext(this) { 
                    MemberName = nameof(Email)
                });

                SetProperty(ref _email, value);
            }
        }
    }
}
