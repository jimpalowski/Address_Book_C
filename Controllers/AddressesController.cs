using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class AddressesController : Controller
  {
    [HttpGet("/addresses")]
    public ActionResult Index()
    {
      List<Address> allAddresses = Address.GetAll();
      return View(allAddresses);
    }

    [HttpGet("/addresses/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/addresses")]
    public ActionResult Create()
    {
      Address newAddress = new Address(Request.Form["new-address"]);
      List<Address> allAddresses = Address.GetAll();
      return View("Index", allAddresses);
    }

    [HttpGet("/addresses/{id}")]
    public ActionResult Details(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Address selectedAddress = Address.Find(id);
      List<Contact> addressContacts = selectedAddress.GetContacts();
      model.Add("address", selectedAddress);
      model.Add("contacts", addressContacts);
      return View(model);
    }

    [HttpPost("/contacts")]
    public ActionResult CreateContact()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Address foundAddress = Address.Find(Int32.Parse(Request.Form["address-id"]));
      Contact contactName = new Contact(Request.Form["contact-name"], int.Parse(Request.Form["contact-phone"]), Request.Form["contact-place"]);
      foundAddress.AddContact(contactName);
      List<Contact> addressContacts = foundAddress.GetContacts();
      model.Add("contacts", addressContacts);
      model.Add("address", foundAddress);
      return View("Details", model);
    }
    [HttpPost("/contacts/new")]
    public ActionResult Return()
    {
      return View("Index");
    }

  }
}
