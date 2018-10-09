namespace AddressBook
{
    public class Contact
    {
        public Contact ()
        {
            FullName = $"{FirstName} {LastName}";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}