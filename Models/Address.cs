using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Address
  {
    private static List<Address> _instances = new List<Address> {};
    private string _name;
    private int _id;
    private List<Contact> _contacts;

    public Address(string addressName)
    {
      _name = addressName;
      _instances.Add(this);
      _id = _instances.Count;
      _contacts = new List<Contact>{};
    }
    public string GetName()
    {
      return _name;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Address> GetAll()
    {
      return _instances;
    }
    public static void Clear()
    {
      _instances.Clear();
    }
    public static Address Find(int searchId)
    {
      return _instances[searchId-1];
    }
    public List<Contact> GetContacts()
    {
      return _contacts;
    }
    public void AddContact(Contact contact)
    {
      _contacts.Add(contact);
    }
  }
}
