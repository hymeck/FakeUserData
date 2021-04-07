namespace App.Domain
{
    // todo: yes, it is a superclass. but otherwise it Generator actually generates one unique value
    public class User
    {
        public string FullName { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }

        public string Number { get; set; }
        // public Name Name { get; set; }
        // public Address Address { get; set; }
        // public PhoneNumber PhoneNumber { get; set; }

        // public override string ToString() =>
        //     string.Join(' ', Name?.ToString(), Address?.ToString(), PhoneNumber?.ToString());
    }
}
