using App.Domain;
using ServiceStack;

namespace App.Extensions
{
    public static class UserExtensions
    {
        public static string ToCsvString(this User user) => 
            user.ToCsv();
    }
}
