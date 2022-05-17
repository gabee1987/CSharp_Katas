using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    internal static class VowelsCount
    {
        // Count the vowels in a string

        /// <summary>
        /// #1. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void VowelCounter_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int result = 0;
            var tempArray = stringToCheck.ToLower().ToCharArray();
            for ( int i = 0; i < tempArray.Length; i++ )
            {
                if( vowels.Contains( tempArray[i] ) )
                    result++;
            }
            #endregion

            Console.WriteLine( $"String -> {stringToCheck}" );
            Console.Write( "Counted vowels -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #2. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void VowelCounter_2( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#2 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            int result = 0;
            var tempArray = stringToCheck.ToLower().ToCharArray();
            for ( int i = 0; i < tempArray.Length; i++ )
            {
                if ( tempArray[i] == 'a' || tempArray[i] == 'e' || tempArray[i] == 'i' || tempArray[i] == 'o' || tempArray[i] == 'u' )
                    result++;
            }
            #endregion

            Console.WriteLine( $"String -> {stringToCheck}" );
            Console.Write( "Counted vowels -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }

        /// <summary>
        /// #3. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void VowelCounter_3( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#3 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int result = 0;
            result = stringToCheck.ToLower().Count( c => vowels.Contains( c ) );
            #endregion

            Console.WriteLine( $"String -> {stringToCheck}" );
            Console.Write( "Counted vowels -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
