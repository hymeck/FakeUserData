using System;

namespace App.Domain
{
    public class User
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public PhoneNumber PhoneNumber { get; set; }

        // public override string ToString() =>
        //     string.Join(' ', Name?.ToString(), Address?.ToString(), PhoneNumber?.ToString());
    }
}
