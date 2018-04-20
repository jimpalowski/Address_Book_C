using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Address> allAddresses = Address.GetAll();
      return View(allAddresses);
    }
  }
}
