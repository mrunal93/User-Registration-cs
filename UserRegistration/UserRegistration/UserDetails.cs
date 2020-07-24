using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserDetails
    {
        static string NAME_PATTERN = "^[A-Z][a-z]{3,}$";
        static string EMAIL_PATTERN= "^[a-z0-9]+([._+-][0-9a-z]+)@+[a-z0-9]+.[a-z]{2,4}([.][a-z]{2}$)";
        static string MOBILE_PATTER = "^[1-9]{2}[: :][0-9]{10}$";
        static string PASSWORD_PATTER = "^([A-Za-z0-9])*[!@#$%^&*]{1}([A-Za-z0-9])*$";
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

        public bool LastNameValidation(string lastName)
        {
            if (Regex.IsMatch(lastName, NAME_PATTERN))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool EmailValidation(string email)
        {
            if (Regex.IsMatch(email,EMAIL_PATTERN ))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MobileValidation(string mobile)
        {
            if (Regex.IsMatch(mobile, MOBILE_PATTER))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Password_Validation_Rule(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTER))
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
