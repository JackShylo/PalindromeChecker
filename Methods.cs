using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public class Methods
    {
        public Boolean CheckIfPalindrome(string tempText)
        {
            // Remove Puncuation and Whitespace
            tempText = Regex.Replace(tempText, @"[^\w]", "");
            // Convert Text To Lowercase
            tempText = tempText.ToLower();

            // Define ReverseText
            char[] ReverseText = tempText.ToCharArray();
            Array.Reverse(ReverseText);

            // See if forward text matches ReverseText
            if (tempText == new string(ReverseText))
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
