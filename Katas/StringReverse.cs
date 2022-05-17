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
        /// <param name="stringToReverse"></param>
        public static void ReverseString_1( string stringToReverse )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            string result = string.Empty;
            var charArray = stringToReverse.ToCharArray();
            Array.Reverse( charArray );
            result = new string( charArray );
            #endregion

            Console.WriteLine( $"Original string -> {stringToReverse}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #2. Solution
        /// </summary>
        /// <param name="stringToReverse"></param>
        public static void ReverseString_2( string stringToReverse )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#2 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            string result = String.Empty;
            var charArray = stringToReverse.ToCharArray();
            var len = stringToReverse.Length - 1;

            for ( int i = 0; i < len; i++, len-- )
            {
                charArray[i] ^= charArray[len];
                charArray[len] ^= charArray[i];
                charArray[i] ^= charArray[len];
            }
            result = new string( charArray );
            #endregion

            Console.WriteLine( $"Original string -> {stringToReverse}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #3. Solution
        /// </summary>
        /// <param name="stringToReverse"></param>
        public static void ReverseString_3( string stringToReverse )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#3 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            StringBuilder sb = new StringBuilder();
            for ( int i = stringToReverse.Length - 1; i >= 0; i-- )
            {
                sb.Append( stringToReverse[i] );
            }
            #endregion
            

            Console.WriteLine( $"Original string -> {stringToReverse}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( sb + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #4. Solution
        /// </summary>
        /// <param name="stringToReverse"></param>
        public static void ReverseString_4( string stringToReverse )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#4 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            string result = string.Empty;
            result = new string( stringToReverse.Reverse().ToArray() );
            #endregion


            Console.WriteLine( $"Original string -> {stringToReverse}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #5. Solution (Extension Method)
        /// </summary>
        /// <param name="stringToReverse"></param>
        public static string ReverseString_5( this string @stringToReverse )
        {
            #region Logic
            return new string( @stringToReverse.Reverse().ToArray() );
            #endregion
        }
    }
}
