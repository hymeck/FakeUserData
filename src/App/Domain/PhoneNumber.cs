namespace App.Domain
{
    public class PhoneNumber
    {
        public string Number { get; set; }

        public override string ToString() => 
            Number;
    }
}
