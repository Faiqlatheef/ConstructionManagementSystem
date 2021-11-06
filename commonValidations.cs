using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AyuboDriveFinal
{
    class commonValidations
    {
        //Method for Name Valitation 
        public static Regex Valid_Name = StringOnly();
        public static Regex Valid_Number = NumberOnly();
        public static Regex Valid_Name_Limit = StringLimit();
        public static Regex Valid_Password = ValidPassword();
        public static Regex Valid_Email = EmailOnly();
        public static Regex Valid_Nic = NicOnly();
        public static Regex Valid_Phoeno = PhonenoOnly();

        private static Regex StringOnly()
        {
            string StringAndNumber_Pattern = "^[a-zA-Z]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }
        private static Regex StringLimit()
        {
            string StringLimit_Pattern = "^[a-zA-Z]{3}";

            return new Regex(StringLimit_Pattern, RegexOptions.IgnoreCase);
        }

        //Method for password validation 
        private static Regex ValidPassword()
        {
            string Password_Pattern = "(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$";

            return new Regex(Password_Pattern, RegexOptions.IgnoreCase);
        }

        private static Regex NumberOnly()
        {
            string StringAndNumber_Pattern = "^[0-9]";

            return new Regex(StringAndNumber_Pattern, RegexOptions.IgnoreCase);
        }

        private static Regex EmailOnly()
        {
            string Email_Pattern = @"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                        + "@"
                                        + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            return new Regex(Email_Pattern, RegexOptions.IgnoreCase);
        }

        private static Regex NicOnly()
        {
            string nic_Pattern = @"^\d{2}(?:[0-35-8]\d\d(?<!(?:000|500|36[7-9]|3[7-9]\d|86[7-9]|8[7-9]\d)))\d{4}(?:[vVxX])$";

            return new Regex(nic_Pattern, RegexOptions.IgnoreCase);
        }

        private static Regex PhonenoOnly()
        {
            string phoneno_pattern = @"^(?:7|0|)[0-9]{9,10}$";

            return new Regex(phoneno_pattern, RegexOptions.IgnoreCase);
        }
    }
}
