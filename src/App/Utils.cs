namespace App
{
    public class Utils
    {
        public static bool IsLocaleSupported(string locale) =>
            locale switch
            {
                "en_US" or "ru_RU" or "uk_UA" => true,
                _ => false
            };

        public static string GetCorrectedLocale(string locale) =>
            locale switch
            {
                "en_US" => "en_US",
                "ru_RU" => "ru",
                "uk_UA" => "uk",
                _ => locale
            };
    }
}
