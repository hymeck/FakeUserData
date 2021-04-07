namespace App.Domain
{
    public class PhoneNumber
    {
        public string CountryCode { get; set; }
        public string LocalCode { get; set; }
        public string Number { get; set; }

        public override string ToString() =>
            string.Join(' ', CountryCode, LocalCode, Number);
    }
}
