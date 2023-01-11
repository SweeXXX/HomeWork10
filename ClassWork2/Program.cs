using System;

namespace ClassWork2
{
    static class Programm
    {
        static void Main()
        {
            var originalString = "ABCDEFG";

            var ACoder = new ACoder(originalString);

            Console.WriteLine($"Было:{originalString}");
            Console.WriteLine($"ACoder.E:{ACoder.Encode()}");
            Console.WriteLine($"ACoder.D: {ACoder.Decode()}");

            var BCoder = new BCoder(originalString);

            Console.WriteLine($"Было:{originalString}");
            Console.WriteLine($"BCoder.E: {BCoder.Encode()}");
            Console.WriteLine($"BCoder.D: {BCoder.Decode()}");
        }
    }
}


