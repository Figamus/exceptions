using System;
using System.Collections.Generic;

namespace AddressBook {
    public class AddressBook {
        // Properties
        public Dictionary<string, Contact> ContactList = new Dictionary<string, Contact>();

        // Methods
        public Contact GetByEmail (string email)
        {
            return ContactList[email];
        }
        public void AddContact (Contact contact) {
            ContactList.Add(contact.Email, contact);
        }
    }
}