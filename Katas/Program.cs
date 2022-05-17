using System;
using System.Linq;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseStringMethods();
        }

        private static void ReverseStringMethods()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine( "====================== Reverse a string" );
            Console.ForegroundColor = ConsoleColor.White;

            StringReverse.ReverseString_1( "Hello" );
            StringReverse.ReverseString_2( "Hello" );
            StringReverse.ReverseString_3( "Hello" );
            StringReverse.ReverseString_4( "Hello" );

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine( "#5 Solution (Extension Method)" );
            Console.ForegroundColor = ConsoleColor.White;
            var stringToReverse = "Hello";
            var result5 = stringToReverse.ReverseString_5();
            Console.WriteLine( $"Original string -> {stringToReverse}" );
            Console.WriteLine( "Reversed string -> " + result5 );
            Console.WriteLine( "---------------------------------------\n" );
            Console.WriteLine( "\n" );
        }
    }
}
