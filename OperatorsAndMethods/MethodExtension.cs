using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorsAndMethods
{
    public static class MethodExtension
    {
        public static string ReverseString(this string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
