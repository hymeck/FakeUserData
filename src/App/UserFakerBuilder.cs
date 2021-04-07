using App.Domain;
using Bogus;

namespace App
{
    public class UserFakerBuilder
    {
        public static Faker<User> Create(string locale)
        {
            var f = new Faker<User>(locale);
            
            // todo: setup
            
            return f;
        }
    }
}