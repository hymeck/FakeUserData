using App.Extensions;
using static System.Console;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2 ||
                !int.TryParse(args[0], out var count) || 
                count < 1 ||
                !Utils.IsLocaleSupported(args[1]))
                PrintUsage();

            else
                PerformGeneration(args[1], count);
        }

        private static void PerformGeneration(string locale, int count)
        {
            var correctedLocale = Utils.GetCorrectedLocale(locale);
            var faker = UserFakerBuilder.Create(correctedLocale);
            var g = new UserGenerator(faker);
            foreach (var u in g.Generate(count)) 
                WriteLine(u.ToCsvString());
        }

        private static void PrintUsage()
        {
            WriteLine("usage: count locale");
            WriteLine("\tcount - a number of user data to generate; must be greater than zero");
            WriteLine("\tlocale - locale of user data; it must be en_US or ru_RU or uk_UA");
        }
    }
}
