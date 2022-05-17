using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    internal static class PalindromeCheck
    {
        // Check if the string is palindrome (it can be read the same forwards as backwards. Ex: “eye”)

        /// <summary>
        /// #1. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void PalindromeCheck_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            bool isPalindrome = false;
            string result = new string( stringToCheck.ToLower().Reverse().ToArray() );
            if( !result.Equals( stringToCheck.ToLower() ) )
                isPalindrome = false;
            else
                isPalindrome = true;
            #endregion

            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            if( !isPalindrome )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( "No, this string is not a palindrome" );
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine( "Yes, this string is a palindrome" );
                Console.ForegroundColor = ConsoleColor.White;
            }          
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
