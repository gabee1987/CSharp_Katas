using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    internal static class StringReverse
    {
        // Reverse a string

        /// <summary>
        /// #1. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void ReverseString_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            string result = string.Empty;
            var charArray = stringToCheck.ToCharArray();
            Array.Reverse( charArray );
            result = new string( charArray );
            #endregion

            PrintSolutionResult( stringToCheck, result );
        }

        /// <summary>
        /// #2. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void ReverseString_2( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#2 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            string result = String.Empty;
            var charArray = stringToCheck.ToCharArray();
            var len = stringToCheck.Length - 1;

            for ( int i = 0; i < len; i++, len-- )
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }
            result = new string( charArray );
            #endregion

            PrintSolutionResult( stringToCheck, result );
        }

        /// <summary>
        /// #3. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void ReverseString_3( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#3 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            StringBuilder sb = new StringBuilder();
            for ( int i = stringToCheck.Length - 1; i >= 0; i-- )
            {
                sb.Append( stringToCheck[i] );
            }
            #endregion
            

            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( sb + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #4. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void ReverseString_4( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#4 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            string result = string.Empty;
            result = new string( stringToCheck.Reverse().ToArray() );
            #endregion


            PrintSolutionResult( stringToCheck, result );
        }

        /// <summary>
        /// #5. Solution (Extension Method)
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static string ReverseString_5( this string stringToCheck )
        {
            #region Logic
            return new string( stringToCheck.Reverse().ToArray() );
            #endregion
        }

        private static void PrintSolutionResult( string stringToCheck, string result )
        {
            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
