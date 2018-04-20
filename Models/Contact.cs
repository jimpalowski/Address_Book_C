using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _contactname;
    private int _number;
    private string _place;
    private int _id;
    private static List<Contact> _instances = new List<Contact>{};

    public Contact(string contactName, int phoneNumber, string contactPlace)
    {
      _contactname = contactName;
      _number = phoneNumber;
      _place = contactPlace;
      _instances.Add(this);
      _id = _instances.Count;
    }
    public string GetContactName()
    {
      return _contactname;
    }

    public void SetContactName(string newName)
    {
      _contactname = newName;
    }
    public int GetNumber()
    {
      return _number;
    }

    public void SetNumber(int newNumber)
    {
      _number = newNumber;
    }

    public string GetPlace()
    {
      return _place;
    }
    public void SetPlace(string newPlace)
    {
      _place = newPlace;
    }
    public int GetId()
    {
      return _id;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Contact Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
