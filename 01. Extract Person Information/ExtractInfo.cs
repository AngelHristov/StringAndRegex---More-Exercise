namespace _01._Extract_Person_Information
{
    using System;
    using System.Collections.Generic;

    public class ExtractInfo
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            var nameAndAges = new Dictionary<string, int>();

            for (int i = 0; i < lines; i++)
            {
                string text = Console.ReadLine();

                int nameStartPosition = text.IndexOf('@');
                int nameEndPosition = text.IndexOf('|');

                string name = text.Substring(nameStartPosition + 1,
                    nameEndPosition - nameStartPosition - 1);

                int ageStartPosition = text.IndexOf('#');
                int ageEndPosition = text.IndexOf('*');

                int age = int.Parse(text.Substring(ageStartPosition + 1,
                    ageEndPosition - ageStartPosition - 1));

                nameAndAges.Add(name, age);
            }

            foreach (var kvp in nameAndAges)
            {
                Console.WriteLine($"{ kvp.Key} is { kvp.Value} years old.");
            }
        }
    }
}
