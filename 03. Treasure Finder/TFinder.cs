namespace _03._Treasure_Finder
{
    using System;
    using System.Linq;

    public class TFinder
    {
        public static void Main()
        {
            int[] keys = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "find")
            {
                var decrypted = "";
                var counterKeys = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (counterKeys == keys.Length)
                    {
                        counterKeys = 0;
                    }
                    decrypted += (char)(input[i] - keys[counterKeys]);
                    counterKeys++;
                }

                var nameFinder = decrypted.Split('&').ToArray();
                var name = nameFinder[1];

                var startCoordinate = decrypted.IndexOf('<');
                var endCoordinate = decrypted.IndexOf('>');

                var coordinate = decrypted.Substring(startCoordinate + 1,
                    endCoordinate - startCoordinate - 1);

                Console.WriteLine($"Found {name} at {coordinate}");
            }
        }
    }
}
