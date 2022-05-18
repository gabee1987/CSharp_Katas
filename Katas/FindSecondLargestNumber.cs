using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas
{
    internal class FindSecondLargestNumber
    {
        // Find the second largest number in a collection

        /// <summary>
        /// 
        /// </summary>
        public static void FindSecondLargestNumber_1( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#1 Solution" );
            Console.ForegroundColor = ConsoleColor.White;


            #region Logic
            var numbersToCheck = ParseStringToCollection( stringToCheck );
            if ( numbersToCheck == null )
                return;

            long largestNumber        = 0;
            long secondLargestNumber  = 0;
            long[] cleanedNumberArray = numbersToCheck.Distinct().ToArray();

            if( cleanedNumberArray == null )
                return;

            for ( int i = 0; i < cleanedNumberArray.Count(); i++ )
            {
                if ( cleanedNumberArray[i] > largestNumber )
                {
                    secondLargestNumber = largestNumber;
                    largestNumber       = cleanedNumberArray[i];
                }

                else if( cleanedNumberArray[i] > secondLargestNumber )
                    secondLargestNumber = cleanedNumberArray[i];
            }

            var result = secondLargestNumber;
            #endregion

            PrintSolutionResult( new string( string.Join( "", cleanedNumberArray ) ), result.ToString() );
        }

        public static void FindSecondLargestNumber_2( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#2 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            var numbersToCheck = ParseStringToCollection( stringToCheck ).ToList();
            if ( numbersToCheck == null )
                return;

            numbersToCheck.Sort();
            var distinctNumbers = numbersToCheck.Distinct().ToList();
            long result         = 0;
            var counter         = 0;
            long tempNumber     = 0;

            for ( int i = distinctNumbers.Count() - 1; i > 0; i-- )
            {
                counter++;
                tempNumber = distinctNumbers[i];
                if ( counter == 2 )
                    result = distinctNumbers[i];

            }
            #endregion

            PrintSolutionResult( new string( string.Join( "", numbersToCheck ) ), result.ToString() );
        }

        public static void FindSecondLargestNumber_3( string stringToCheck )
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#3 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            var numbersToCheck = ParseStringToCollection( stringToCheck ).ToList();
            long largest       = long.MinValue;
            long second        = long.MinValue;
            long result        = 0;

            foreach ( long elment in numbersToCheck.Distinct() )
            {
                if ( elment > largest )
                {
                    second  = largest;
                    largest = elment;
                }
                else if ( elment > second )
                {
                    second = elment;
                }
            }

            result = second;
            #endregion

            PrintSolutionResult( new string( string.Join( "", numbersToCheck ) ), result.ToString() );
        }

        public static void FindSecondLargestNumber_4( string stringToCheck )
        {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#4 Solution" );
            Console.ForegroundColor = ConsoleColor.White;

            #region Logic
            var numbersToCheck = ParseStringToCollection( stringToCheck ).ToList();

            List<long> cleanedNumberArray = numbersToCheck.Distinct().ToList();
            cleanedNumberArray.Sort();
            cleanedNumberArray.Reverse();

            var result = cleanedNumberArray[1];
            #endregion

            PrintSolutionResult( new string( string.Join( "", numbersToCheck ) ), result.ToString() );
        }



        private static long[] ParseStringToCollection( string stringToParse )
        {
            List<long> result = new List<long>();

            for( int i = 0; i < stringToParse.Length; i++ )
            {
                if ( Char.IsDigit( stringToParse[i] ) )
                    result.Add( Convert.ToInt64( stringToParse[i].ToString() ) );
            }

            return result.ToArray();
        }

        private static void PrintSolutionResult( string stringToCheck, string result )
        {
            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Second Largest number -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
        }
    }
}
