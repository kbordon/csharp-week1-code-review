using AddressBook.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult ContactForm()
        {
            return View();
        }

        [HttpPost("/contacts/new")]
        public ActionResult ContactFormResult()
        {
            Contact newContact = new Contact(Request.Form["contact-name"], Request.Form["contact-phone"], Request.Form["contact-address"]);
            return View("ContactDetail", newContact);
        }

        [HttpGet("/contacts/{id}")]
        public ActionResult ContactDetail(int id)
        {
            Contact selectedContact = Contact.Find(id);
            selectedContact.ChangeNewStatus();
            return View(selectedContact);
        }

        [HttpPost("/contacts/clear")]
        public ActionResult ContactListClear()
        {
            Contact.ClearAll();
            return View();
        }
    }
}
