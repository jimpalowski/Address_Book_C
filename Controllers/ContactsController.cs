using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;
namespace AddressBook.Controllers
{
  public class ContactsController : Controller
  {
    [HttpGet("/addresses/{addressId}/contacts/new")]
    public ActionResult CreateForm(int addressId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Address address = Address.Find(addressId);
      return View(address);
    }
    [HttpGet("/addresses/{addressId}/contacts/{contactId}")]
    public ActionResult Details(int addressId, int contactId)
    {
      Contact contact = Contact.Find(contactId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      Address address = Address.Find(addressId);
      model.Add("contact", contact);
      model.Add("address", address);
      return View(contact);
    }
  }
}
