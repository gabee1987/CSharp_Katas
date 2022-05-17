using System;
using System.Linq;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsRunning = true;
            while ( IsRunning )
            {
                bool isValidInput = false;
                int menuId = 0;
                while ( !isValidInput )
                {
                    PrintMenu();
                    var input = Console.ReadLine().ToLower();
                    isValidInput = ErrorHandler( input, out menuId );
                }

                ExecuteChosenExercise( menuId );
                IsRunning = CheckIfWantToCountinue( IsRunning );
            }
        }

        #region Menu helper methods
        private static bool CheckIfWantToCountinue( bool IsRunning )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "Press ENTER if you would like to try another exercise! \n" );
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if ( keyInfo.Key != ConsoleKey.Enter )
                IsRunning = false;

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            return IsRunning;
        }

        private static string ReadStringInputForTheExercise()
        {
            Console.WriteLine( "Enter a word or sentence" );
            return Console.ReadLine().ToLower();
        }

        private static void ExecuteChosenExercise( int menuId )
        {
            string stringToManipulate = string.Empty;

            switch ( menuId )
            {
                case 0:
                    ReverseStringMethods( stringToManipulate );
                    VowelCountMethods( stringToManipulate );
                    break;
                case 1:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine( "Menu #1 selected. Reverse a string \n" );
                    Console.ForegroundColor = ConsoleColor.White;
                    stringToManipulate = ReadStringInputForTheExercise();
                    ReverseStringMethods( stringToManipulate );
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine( "Menu #2 selected. Count the vowels \n" );
                    Console.ForegroundColor = ConsoleColor.White;
                    stringToManipulate = ReadStringInputForTheExercise();
                    VowelCountMethods( stringToManipulate );
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine( "Menu #3 selected. Check if the string is a palindrome (it can be read the same forwards as backwards. Ex: “eye”) \n" );
                    Console.ForegroundColor = ConsoleColor.White;
                    stringToManipulate = ReadStringInputForTheExercise();
                    PalindromeCheckMethods( stringToManipulate );
                    break;
                default:
                    ReverseStringMethods( stringToManipulate );
                    VowelCountMethods( stringToManipulate );
                    break;
            }
        }

        private static void PrintMenu()
        {
            Console.WriteLine( "Choose which string exercise would you like to try by pressing the menu number \n" );

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write( "#1. " );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( "Reverse a string \n" );

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write( "#2. " );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( "Count the vowels in a string \n" );


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write( "#3. " );
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write( "Check if the string is a palindrome (it can be read the same forwards as backwards. Ex: “eye”) \n" );
        }

        private static bool ErrorHandler( string input, out int menuId )
        {
            if ( !int.TryParse( input, out menuId ) )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( "Wrong input! You must select a number from the menu!" );
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                return false;
            }
            int menuCount = 3;
            if ( menuId > menuCount )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine( "Wrong input! You must select a number from the menu numbers!" );
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                return false;
            }

            Console.WriteLine();
            return true;
        }
        #endregion

        private static void ReverseStringMethods( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "====================== Reverse a string" );
            Console.ForegroundColor = ConsoleColor.White;

            StringReverse.ReverseString_1( stringToCheck );
            StringReverse.ReverseString_2( stringToCheck );
            StringReverse.ReverseString_3( stringToCheck );
            StringReverse.ReverseString_4( stringToCheck );

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#5 Solution (Extension Method)" );
            Console.ForegroundColor = ConsoleColor.White;
            var result5 = stringToCheck.ReverseString_5();
            Console.WriteLine( $"Original string -> {stringToCheck}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result5 + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
            Console.WriteLine( "\n" );
        }

        private static void VowelCountMethods( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "====================== Count the vowels in a string" );
            Console.ForegroundColor = ConsoleColor.White;

            VowelsCount.VowelCounter_1( stringToCheck );
            VowelsCount.VowelCounter_2( stringToCheck );
            VowelsCount.VowelCounter_3( stringToCheck );
            VowelsCount.VowelCounter_4( stringToCheck );

            Console.WriteLine( "\n" );
        }

        private static void PalindromeCheckMethods( string stringToCheck )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "====================== Check if the string is a palindrome  (it can be read the same forwards as backwards. Ex: “eye”)" );
            Console.ForegroundColor = ConsoleColor.White;

            PalindromeCheck.PalindromeCheck_1( stringToCheck );

            Console.WriteLine( "\n" );
        }
    }
}
