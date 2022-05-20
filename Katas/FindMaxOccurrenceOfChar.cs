using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    internal class FindMaxOccurrenceOfChar
    {
        // Find the maximum occurring character in a string

        public static void FindMaxOccurrenceOfChar_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            // aabb123a
            #region Logic
            char result          = ' ';
            int occurrenceOfChar = 0;
            Dictionary<char, int> charsAndOccurrences = new Dictionary<char, int>();

            for ( int i = 0; i < stringToCheck.Length; i++ )
            {
                if( !charsAndOccurrences.ContainsKey( stringToCheck[i] ) )
                    charsAndOccurrences.Add( stringToCheck[i], 1 );
                else
                    charsAndOccurrences[stringToCheck[i]]++;              
            }

            foreach ( var item in charsAndOccurrences )
            {
                if( occurrenceOfChar < item.Value )
                {
                    occurrenceOfChar = item.Value;
                    result = item.Key;
                }
            }

            #endregion

            PrintSolutionResult( stringToCheck, result.ToString(), occurrenceOfChar );
        }

        private static void PrintSolutionResult( string stringToCheck, string result, int occurrenceOfChar )
        {
            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Most occurred character -> " );
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( "Number of occurrence -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( occurrenceOfChar + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
