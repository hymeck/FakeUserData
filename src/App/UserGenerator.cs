using System.Collections.Generic;
using App.Domain;
using Bogus;

namespace App
{
    public class UserGenerator
    {
        private readonly Faker<User> faker;

        public UserGenerator(Faker<User> faker) => 
            this.faker = faker;

        public IEnumerable<User> Generate(int count)
        {
            var i = 0;
            foreach (var u in faker.GenerateForever())
            {
                // todo: clutch
                if (++i > count)
                    yield break;
                
                yield return u;
            }
        }
    }
}
