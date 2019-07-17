namespace _02._Ascii_Sumator
{
    using System;

    public class AsciiSum
    {
        public static void Main()
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            string randomText = Console.ReadLine();

            if (endChar < startChar)
            {
                var tempChar = startChar;
                startChar = endChar;
                endChar = tempChar;
            }

            var sum = 0;

            for (int i = 0; i < randomText.Length; i++)
            {

                if (startChar < randomText[i] && randomText[i] < endChar)
                {
                    sum += randomText[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
