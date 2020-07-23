using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserDetails
    {
        public static string NAME_PATTERN = "^[A-Z][a-z]{3,}$";
        public bool FirstNameValidation(string firstName)
        {
            if (Regex.IsMatch(firstName,NAME_PATTERN))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
