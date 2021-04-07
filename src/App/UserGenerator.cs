using System.Collections.Generic;
using App.Domain;
using Bogus;

namespace App
{
    public class UserGenerator
    {
        private Faker<User> faker;

        public UserGenerator(Faker<User> faker) => 
            this.faker = faker;

        public IEnumerable<User> Generate(int count = 1)
        {
            for (var i = 0; i < count; i++)
            {
                var user = faker.Generate();
                yield return user;
            }
        }
    }
}
