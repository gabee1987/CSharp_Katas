using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    internal static class FindLargestNumber
    {
        /// <summary>
        /// #1. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void FindLargestNumber_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            List<string> tempList = new List<string>();
            long parseNumber      = 0;
            string tempString     = string.Empty;

            #region Logic
            for ( int i = 0; i < stringToCheck.Length; i++ )
            {

                if ( long.TryParse( stringToCheck[i].ToString(), out parseNumber  ) )
                {
                    tempString += stringToCheck[i];
                }
                else
                {
                    if ( string.IsNullOrEmpty( tempString ) )
                        continue;

                    tempList.Add( tempString );
                    tempString = string.Empty;
                }
            }
            var result = tempList.Max( n => long.Parse( n ) );
            
            #endregion

            PrintSolutionResult( stringToCheck, result.ToString() );
        }

        /// <summary>
        /// #2. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void FindLargestNumber_2( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#2 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            List<long> numberList = new List<long>();
            string buffer       = string.Empty;

            #region Logic
            for ( int i = 0; i < stringToCheck.Length; i++ )
            {

                if ( Char.IsDigit( stringToCheck[i] ) )
                {
                    buffer += stringToCheck[i];
                }
                else
                {
                    if ( !string.IsNullOrEmpty( buffer ) )
                    {
                        numberList.Add( Convert.ToInt64( buffer ) );
                        buffer = string.Empty;
                    }
                }
            }

            long result = numberList.Max();
            #endregion

            PrintSolutionResult( stringToCheck, result.ToString() );
        }


        /// <summary>
        /// #3. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void FindLargestNumber_3( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#3 Solution" );
            Console.ForegroundColor = ConsoleColor.White;


            #region Logic
            List<long> numberList = new List<long>();
            long result           = 0;
            StringBuilder sb      = new StringBuilder();

            for ( int i = 0; i < stringToCheck.Length; i++ )
            {
                if( Char.IsDigit( stringToCheck[i] ) )
                {
                    sb.Append( stringToCheck[i] );
                }
                else
                {
                    if( sb.Length != 0 )
                    {
                        numberList.Add( Convert.ToInt64( sb.ToString() ) );
                        sb.Clear();
                    }
                }
            }

            foreach ( var number in numberList )
            {
                if ( number > result )
                    result = number;
            }
            #endregion

            PrintSolutionResult( stringToCheck, result.ToString() );
        }

        /// <summary>
        /// #4. Solution
        /// </summary>
        /// <param name="stringToCheck"></param>
        public static void FindLargestNumber_4( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#4 Solution" );
            Console.ForegroundColor = ConsoleColor.White;


            #region Logic
            long result     = 0;

            var stringNumberArray = System.Text.RegularExpressions.Regex.Split( stringToCheck, @"\D+" ); // Regular expression for numbers
            stringNumberArray     = stringNumberArray.Where( s => !string.IsNullOrEmpty( s.Trim() ) ).ToArray(); // Exclude the empty items
            long[] numberArray    = Array.ConvertAll( stringNumberArray, s => long.Parse( s ) );

            result = numberArray.Max();
            #endregion

            PrintSolutionResult( stringToCheck, result.ToString() );
        }

        private static void PrintSolutionResult( string stringToCheck, string result )
        {
            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Largest number -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
