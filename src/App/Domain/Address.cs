namespace App.Domain
{
    public class Address
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        public override string ToString() =>
            string.Join(", ", Country, Region, City, Street, ZipCode);
    }
}