using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    internal class CountVariousCharacters
    {
        // Count a total number of alphabets, digits and special characters in a string

        private const string _alphabetsKey         = "alphabets";
        private const string _digitsKey            = "digits";
        private const string _specialcharactersKey = "specialcharacters";

        public static void CountVariousCharacters_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            Dictionary<string, char[]> result  = new Dictionary<string, char[]>();
            char[] alphabets                   = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            List<char> foundAlphabets          = new List<char>();
            List<char> foundDigits             = new List<char>();
            List<char> foundSpecialcharacters  = new List<char>();

            for ( int i = 0; i < stringToCheck.Length; i++ )
            {
                if ( alphabets.Contains( stringToCheck[i] ) )
                    foundAlphabets.Add( stringToCheck[i] );

                else if ( Char.IsDigit( stringToCheck[i] ) )
                    foundDigits.Add( stringToCheck[i] );

                else if ( stringToCheck[i] != ' ' )
                    foundSpecialcharacters.Add( stringToCheck[i] );
            }

            result.Add( _alphabetsKey, foundAlphabets.ToArray() );
            result.Add( _digitsKey, foundDigits.ToArray() );
            result.Add( _specialcharactersKey, foundSpecialcharacters.ToArray() );
            #endregion

            PrintSolutionResult( stringToCheck, result );
        }

        public static void CountVariousCharacters_2( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#2 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            Dictionary<string, char[]> result = new Dictionary<string, char[]>();
            List<char> foundAlphabets = new List<char>();
            List<char> foundDigits = new List<char>();
            List<char> foundSpecialcharacters = new List<char>();

            for ( int i = 0; i < stringToCheck.Length; i++ )
            {
                if ( System.Text.RegularExpressions.Regex.IsMatch( stringToCheck[i].ToString(), "[a-z]", System.Text.RegularExpressions.RegexOptions.IgnoreCase ) )
                    foundAlphabets.Add( stringToCheck[i] );

                else if ( Char.IsDigit( stringToCheck[i] ) )
                    foundDigits.Add( stringToCheck[i] );

                else if ( stringToCheck[i] != ' ' )
                    foundSpecialcharacters.Add( stringToCheck[i] );
            }

            result.Add( _alphabetsKey, foundAlphabets.ToArray() );
            result.Add( _digitsKey, foundDigits.ToArray() );
            result.Add( _specialcharactersKey, foundSpecialcharacters.ToArray() );
            #endregion

            PrintSolutionResult( stringToCheck, result );
        }

        private static void PrintSolutionResult( string stringToCheck, Dictionary<string, char[]> result )
        {
            Console.WriteLine( $"Original string -> {stringToCheck}" );

            Console.Write( $"Alphabets -> " );
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write( new String( result[_alphabetsKey] ) + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( $"Number of alphabets -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result[_alphabetsKey].Count() + "\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( $"Digits -> " );
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write( new String( result[_digitsKey] ) + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( $"Number of digits -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result[_digitsKey].Count() + "\n\n" );

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( $"Special characters -> " );
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write( new String( result[_specialcharactersKey] ) + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( $"Number of special characters -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result[_specialcharactersKey].Count() + "\n\n" );

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
