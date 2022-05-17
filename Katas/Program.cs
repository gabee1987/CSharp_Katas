using System;
using System.Linq;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter a word or sentence" );
            string stringToManipulate = Console.ReadLine().ToLower();

            ReverseStringMethods( stringToManipulate );
            VowelCountMethods( stringToManipulate );
        }

        private static void ReverseStringMethods( string stringToManipulate )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "====================== Reverse a string" );
            Console.ForegroundColor = ConsoleColor.White;

            StringReverse.ReverseString_1( stringToManipulate );
            StringReverse.ReverseString_2( stringToManipulate );
            StringReverse.ReverseString_3( stringToManipulate );
            StringReverse.ReverseString_4( stringToManipulate );

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine( "#5 Solution (Extension Method)" );
            Console.ForegroundColor = ConsoleColor.White;
            var result5 = stringToManipulate.ReverseString_5();
            Console.WriteLine( $"Original string -> {stringToManipulate}" );
            Console.Write( "Reversed string -> " );
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write( result5 + "\n" );
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine( "---------------------------------------\n" );
            Console.WriteLine( "\n" );
        }

        private static void VowelCountMethods( string stringToManipulate )
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "====================== Count the vowels in a string" );
            Console.ForegroundColor = ConsoleColor.White;

            VowelsCount.VowelCounter_1( stringToManipulate );
            VowelsCount.VowelCounter_2( stringToManipulate );
            VowelsCount.VowelCounter_3( stringToManipulate );

            Console.WriteLine( "\n" );
        }
    }
}
