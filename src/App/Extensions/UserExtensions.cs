using App.Domain;

namespace App.Extensions
{
    public static class UserExtensions
    {
        public static string ToCsvString(this User user)
        {
            var a = string.Join(", ", user.Country, user.Region, user.StreetAddress, user.ZipCode);
            return string.Join("; ", user.FullName, a, user.Number);
        }
    }
}
