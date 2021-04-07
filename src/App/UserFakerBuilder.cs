using System.Globalization;
using App.Domain;
using Bogus;

namespace App
{
    public class UserFakerBuilder
    {
        private static Faker<Name> GetConfiguredNameFaker(string locale)
        {
            return new Faker<Name>(locale)
                .RuleFor(x => x.FirstName, f => f.Name.FirstName())
                .RuleFor(x => x.LastName, f => f.Name.LastName());
        }

        private static Faker<Address> GetConfiguredAddressFaker(string locale)
        {
            return new Faker<Address>(locale)
                .RuleFor(x => x.Country, f => f.Address.Country())
                .RuleFor(x => x.Region, f => f.Address.State())
                .RuleFor(x => x.City, f => f.Address.City())
                .RuleFor(x => x.Street, f => f.Address.StreetName())
                .RuleFor(x => x.ZipCode, f => f.Address.ZipCode());
        }

        private static Faker<PhoneNumber> GetConfiguredPhoneNumberFaker(string locale)
        {
            return new Faker<PhoneNumber>(locale)
                .RuleFor(x => x.Number, f => f.Phone.PhoneNumber());
        }

        private static Faker<User> GetConfiguredUserFaker(
            string locale,
            Faker<Name> nameFaker,
            Faker<Address> addressFaker,
            Faker<PhoneNumber> numberFaker)
        {
            // return new Faker<User>(locale)
            //     .RuleFor(x => x.Name, nameFaker)
            //     .RuleFor(x => x.Address, addressFaker)
            //     .RuleFor(x => x.PhoneNumber, numberFaker);
            var ri = new RegionInfo(locale);
            string[] names = {ri.NativeName, ri.ThreeLetterISORegionName};
            return new Faker<User>(locale)
                .RuleFor(x => x.FullName, f => f.Name.FullName())
                .RuleFor(x => x.Country, f => f.PickRandom(names))
                .RuleFor(x => x.Region, f => f.Address.State())
                .RuleFor(x => x.City, f => f.Address.City())
                .RuleFor(x => x.StreetAddress, f => f.Address.StreetAddress())
                .RuleFor(x => x.ZipCode, f => f.Address.ZipCode())
                .RuleFor(x => x.Number, f => f.Phone.PhoneNumber());
        }

        public static Faker<User> Create(string locale)
        {
            var n = GetConfiguredNameFaker(locale);
            var a = GetConfiguredAddressFaker(locale);
            var num = GetConfiguredPhoneNumberFaker(locale);

            return GetConfiguredUserFaker(locale, n, a, num);
        }
    }
}
