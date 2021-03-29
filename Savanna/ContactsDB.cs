using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Savanna
{
    [Serializable]
    public class ContactsDB
    {
        public string SearchText { get; set; }
        public int SearchType { get; set; }
        List<Contact> AllContacts = new List<Contact>();
        int autoincrementIdContact = 1;
        string fileName = "db.bin";
        public void Save()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fstream = File.Create(fileName))
            {
                byte[] array = BitConverter.GetBytes(autoincrementIdContact);
                fstream.Write(array, 4, array.Length);
                binaryFormatter.Serialize(fstream, AllContacts);
            }

        }
            public ContactsDB()
            {
                if (File.Exists(fileName))
             {
                BinaryFormatter binaryformatter = new BinaryFormatter();
                using (FileStream fstream = File.OpenRead(fileName))
                {
                    var bf = new BinaryFormatter();
                    autoincrementIdContact = (int)bf.Deserialize(fstream);
                    AllContacts = (List<Contact>)bf.Deserialize(fstream);
                }
             }
                else { return; }
            }
            public Contact CreateContact()
            {
                Contact contact = new Contact();
                contact.ID = autoincrementIdContact;
                autoincrementIdContact++;
                AllContacts.Add(contact);
                return contact;
            }

             public void RemoveContact(Contact contact)
             {
                AllContacts.Remove(contact);
                Save();
             }
        public  enum SearchTypes
        {
           ПоискПоИмени,
           ПоискПоТелефону,
           ПоискПоНику
        }
        public List<Contact> Search()
        {
            List<Contact> contacts = new List<Contact>();
            if (SearchType == (int)SearchTypes.ПоискПоИмени)
            {
                foreach (Contact c in AllContacts)
                    if (c.Name.ToLower().Contains(SearchText.ToLower()))
                        contacts.Add(c);
            }
            if (SearchType == (int)SearchTypes.ПоискПоТелефону)
            {
                foreach (Contact c in AllContacts)
                   // if (c.Phones.
                        contacts.Add(c);
                    
                        
            }
            if (SearchType == (int)SearchTypes.ПоискПоНику)
            {
                foreach (Contact c in AllContacts)
                    if (c.NickNames.ListNicks.Contains(c.NickNames.ListNicks.FirstOrDefault(p => p.nick.ToLower().Contains(SearchText.ToLower()))))
                        contacts.Add(c);
            }
            return contacts;
        }
    }
}
