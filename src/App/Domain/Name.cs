namespace App.Domain
{
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() =>
            string.Join(' ', FirstName, LastName);
    }
}
