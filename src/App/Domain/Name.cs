namespace App.Domain
{
    public class Name
    {
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }

        public override string ToString() =>
            string.Join(' ', Name1, Name2, Name3);
    }
}
