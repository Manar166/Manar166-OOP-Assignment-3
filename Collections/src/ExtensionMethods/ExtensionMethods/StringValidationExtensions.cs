using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ExtensionMethods
{
    public static class StringValidationExtensions
    {
        public static bool IsValidEgyptianPhone(this string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            return Regex.IsMatch(phoneNumber, @"^(\+2)?(010|011|012|015)[0-9]{8}$");

        }
    }
}
